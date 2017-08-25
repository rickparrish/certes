﻿using Certes.Acme;
using Certes.Acme.Resource;
using Certes.Json;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Certes
{
    /// <summary>
    /// Presents the context for ACME operations.
    /// </summary>
    /// <seealso cref="Certes.IAcmeContext" />
    public class AcmeContext : IAcmeContext
    {
        private const string MimeJoseJson = "application/jose+json";
        private const string MimeJson = "application/json";
        private readonly static Lazy<HttpClient> SharedHttp = new Lazy<HttpClient>(() => new HttpClient());

        /// <summary>
        /// The directory URI.
        /// </summary>
        private readonly Uri directoryUri;

        private Directory directory;
        private string nonce = null;
        private readonly HttpClient http;

        private JsonSerializerSettings jsonSettings = JsonUtil.CreateSettings();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcmeContext"/> class.
        /// </summary>
        public AcmeContext() : this(WellKnownServers.LetsEncrypt)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcmeContext"/> class.
        /// </summary>
        /// <param name="directoryUri">The directory URI.</param>
        public AcmeContext(Uri directoryUri)
        {
            this.directoryUri = directoryUri;
        }

        internal AcmeContext(Uri directoryUrl, HttpClient http)
        {
            this.http = http ?? SharedHttp.Value;
        }

        /// <summary>
        /// Gets the URI for terms of service.
        /// </summary>
        /// <returns>
        /// The terms of service URI.
        /// </returns>
        public async Task<Uri> TermsOfService()
        {
            var dir = await this.GetDirectory();
            return dir.Meta?.TermsOfService;
        }

        internal async Task<Uri> GetResourceEndpoint(ResourceType type)
        {
            var dir = await this.GetDirectory();
            switch (type)
            {
                case ResourceType.NewNonce:
                    return dir.NewNonce;
                case ResourceType.NewAccount:
                    return dir.NewAccount;
                case ResourceType.NewOrder:
                    return dir.NewOrder;
                case ResourceType.NewAuthz:
                    return dir.NewAuthz;
                case ResourceType.RevokeCert:
                    return dir.RevokeCert;
                case ResourceType.KeyChange:
                    return dir.KeyChange;
            }

            throw new ArgumentOutOfRangeException(nameof(type));
        }

        internal async Task<string> ConsumeNonce()
        {
            var nonce = Interlocked.Exchange(ref this.nonce, null);
            while (nonce == null)
            {
                await this.FetchNonce();
                nonce = Interlocked.Exchange(ref this.nonce, null);
            }

            return nonce;
        }

        internal async Task<(Uri Location, T Resource, ILookup<string, Uri> Links)> Get<T>(Uri uri)
        {
            var response = await http.GetAsync(uri);
            return await ProcessResponse<T>(response);
        }

        internal async Task<(Uri Location, T Resource, ILookup<string, Uri> Links)> Post<T>(Uri uri, object payload)
        {
            var payloadJson = JsonConvert.SerializeObject(payload, Formatting.None, jsonSettings);
            var content = new StringContent(payloadJson, Encoding.UTF8, MimeJoseJson);
            var response = await http.PostAsync(uri, content);
            return await ProcessResponse<T>(response);
        }

        private async Task<(Uri Location, T Resource, ILookup<string, Uri> Links)> ProcessResponse<T>(HttpResponseMessage response)
        {
            var data =
                (
                    Location: response.Headers.Location,
                    Resource: default(T),
                    Links: default(ILookup<string, Uri>)
                );

            if (response.Headers.Contains("Replay-Nonce"))
            {
                this.nonce = response.Headers.GetValues("Replay-Nonce").Single();
            }

            if (response.Headers.Contains("Link"))
            {
                data.Links = response.Headers.GetValues("Link")?
                    .Select(h =>
                    {
                        var segments = h.Split(';');
                        var url = segments[0].Substring(1, segments[0].Length - 2);
                        var rel = segments.Skip(1)
                            .Select(s => s.Trim())
                            .Where(s => s.StartsWith("rel=", StringComparison.OrdinalIgnoreCase))
                            .Select(r =>
                            {
                                var relType = r.Split('=')[1];
                                return relType.Substring(1, relType.Length - 2);
                            })
                            .First();

                        return (
                            Rel: rel,
                            Uri: new Uri(url)
                        );
                    })
                    .ToLookup(l => l.Rel, l => l.Uri);
            }

            if (IsJsonMedia(response.Content?.Headers.ContentType.MediaType))
            {
                var json = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    data.Resource = JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    var error = JsonConvert.DeserializeObject<AcmeError>(json);
                    throw new Exception(error.Detail);
                }
            }

            return data;
        }

        private async Task<Directory> GetDirectory()
        {
            if (this.directory == null)
            {
                await this.FetchDirectory();
            }

            return directory;
        }

        private async Task FetchDirectory()
        {
            var response = await http.GetAsync(this.directoryUri);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception();
            }

            var dirJson = await response.Content.ReadAsStringAsync();
            this.directory = JsonConvert.DeserializeObject<Directory>(dirJson);
            this.nonce = response.Headers.GetValues("Replay-Nonce").FirstOrDefault();
        }

        private async Task FetchNonce()
        {
            var dir = await GetDirectory();
            if (dir.NewNonce == null)
            {
                throw new InvalidOperationException();
            }

            var response = await http.SendAsync(new HttpRequestMessage
            {
                RequestUri = dir.NewNonce,
                Method = HttpMethod.Head,
            });

            this.nonce = response.Headers.GetValues("Replay-Nonce").FirstOrDefault();
            if (this.nonce == null)
            {
                throw new Exception();
            }
        }

        private static bool IsJsonMedia(string mediaType)
        {
            if (mediaType != null && mediaType.StartsWith("application/"))
            {
                return mediaType
                    .Substring("application/".Length)
                    .Split('+')
                    .Any(t => t == "json");
            }

            return false;
        }
    }
}
