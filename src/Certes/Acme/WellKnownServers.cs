using System;

namespace Certes.Acme
{
    /// <summary>
    /// The well known ACME servers.
    /// </summary>
    public class WellKnownServers
    {
        /// <summary>
        /// Gets the URI for Google ACME v2 production server.
        /// </summary>
        /// <value>
        /// The URI for Google ACME v2 production server.
        /// </value>
        public static Uri GoogleV2 { get; } = new Uri("https://dv.acme-v02.api.pki.goog/directory");

        /// <summary>
        /// Gets the URI for Google V2 staging server.
        /// </summary>
        /// <value>
        /// The URI for Google V2 staging server.
        /// </value>
        public static Uri GoogleStagingV2 { get; } = new Uri("https://dv.acme-v02.test-api.pki.goog/directory");

        /// <summary>
        /// Gets the URI for Let's Encrypt ACME v2 production server.
        /// </summary>
        /// <value>
        /// The URI for Let's Encrypt ACME v2 production server.
        /// </value>
        public static Uri LetsEncryptV2 { get; } = new Uri("https://acme-v02.api.letsencrypt.org/directory");

        /// <summary>
        /// Gets the URI for Let's Encrypt V2 staging server.
        /// </summary>
        /// <value>
        /// The URI for Let's Encrypt V2 staging server.
        /// </value>
        public static Uri LetsEncryptStagingV2 { get; } = new Uri("https://acme-staging-v02.api.letsencrypt.org/directory");

        /// <summary>
        /// Gets the URI for ZeroSSL ACME v2 production server.
        /// </summary>
        /// <value>
        /// The URI for ZeroSSL ACME v2 production server.
        /// </value>
        public static Uri ZeroSslV2 { get; } = new Uri("https://acme.zerossl.com/v2/DV90");
    }
}
