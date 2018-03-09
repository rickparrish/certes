﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Certes.Cli {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Certes.Cli.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Challenge with type &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string ErrorChallengeNotAvailable {
            get {
                return ResourceManager.GetString("ErrorChallengeNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DNS zone for &apos;{0}&apos; not found..
        /// </summary>
        internal static string ErrorDnsZoneNotFound {
            get {
                return ResourceManager.GetString("ErrorDnsZoneNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not export certificate for order with &apos;{0}&apos; status..
        /// </summary>
        internal static string ErrorExportInvalidOrder {
            get {
                return ResourceManager.GetString("ErrorExportInvalidOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Identifier &apos;{0}&apos; not found in the certificate order..
        /// </summary>
        internal static string ErrorIdentifierNotAvailable {
            get {
                return ResourceManager.GetString("ErrorIdentifierNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Challenge type &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string ErrorInvalidChallengeType {
            get {
                return ResourceManager.GetString("ErrorInvalidChallengeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No account available for ACME server &apos;{0}&apos;..
        /// </summary>
        internal static string ErrorNoAccountKey {
            get {
                return ResourceManager.GetString("ErrorNoAccountKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option &apos;--{0}&apos; is required..
        /// </summary>
        internal static string ErrorOptionMissing {
            get {
                return ResourceManager.GetString("ErrorOptionMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not down certificate for order &apos;{0}&apos;..
        /// </summary>
        internal static string ErrorOrderIncompleted {
            get {
                return ResourceManager.GetString("ErrorOrderIncompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; is required..
        /// </summary>
        internal static string ErrorParameterMissing {
            get {
                return ResourceManager.GetString("ErrorParameterMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Auzre app service name..
        /// </summary>
        internal static string HelpAppName {
            get {
                return ResourceManager.GetString("HelpAppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client ID of the Azure service principal..
        /// </summary>
        internal static string HelpAzureClientId {
            get {
                return ResourceManager.GetString("HelpAzureClientId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The resource group..
        /// </summary>
        internal static string HelpAzureResourceGroup {
            get {
                return ResourceManager.GetString("HelpAzureResourceGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client secret of the Azure service principal..
        /// </summary>
        internal static string HelpAzureSecret {
            get {
                return ResourceManager.GetString("HelpAzureSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure subscription ID..
        /// </summary>
        internal static string HelpAzureSubscriptionId {
            get {
                return ResourceManager.GetString("HelpAzureSubscriptionId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure talent ID..
        /// </summary>
        internal static string HelpAzureTalentId {
            get {
                return ResourceManager.GetString("HelpAzureTalentId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to save the certificate..
        /// </summary>
        internal static string HelpCertificateOut {
            get {
                return ResourceManager.GetString("HelpCertificateOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The challenge type, http or dns..
        /// </summary>
        internal static string HelpChallengeType {
            get {
                return ResourceManager.GetString("HelpChallengeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage ACME accounts..
        /// </summary>
        internal static string HelpCommandAccount {
            get {
                return ResourceManager.GetString("HelpCommandAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new ACME account..
        /// </summary>
        internal static string HelpCommandAccountNew {
            get {
                return ResourceManager.GetString("HelpCommandAccountNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set the default ACME account..
        /// </summary>
        internal static string HelpCommandAccountSet {
            get {
                return ResourceManager.GetString("HelpCommandAccountSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get the ACME account..
        /// </summary>
        internal static string HelpCommandAccountShow {
            get {
                return ResourceManager.GetString("HelpCommandAccountShow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update ACME account..
        /// </summary>
        internal static string HelpCommandAccountUpdate {
            get {
                return ResourceManager.GetString("HelpCommandAccountUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deploy certificates to Microsoft Azure..
        /// </summary>
        internal static string HelpCommandAzure {
            get {
                return ResourceManager.GetString("HelpCommandAzure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deploy certificates to Azure app services..
        /// </summary>
        internal static string HelpCommandAzureApp {
            get {
                return ResourceManager.GetString("HelpCommandAzureApp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configure Azure DNS to respone to ACME DNS challenge..
        /// </summary>
        internal static string HelpCommandAzureDns {
            get {
                return ResourceManager.GetString("HelpCommandAzureDns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configure default credentials for Microsoft Azure..
        /// </summary>
        internal static string HelpCommandAzureSet {
            get {
                return ResourceManager.GetString("HelpCommandAzureSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export certificates..
        /// </summary>
        internal static string HelpCommandCertificate {
            get {
                return ResourceManager.GetString("HelpCommandCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export certificate to PEM for an order..
        /// </summary>
        internal static string HelpCommandCertificatePem {
            get {
                return ResourceManager.GetString("HelpCommandCertificatePem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export certificate to PFX for an order..
        /// </summary>
        internal static string HelpCommandCertificatePfx {
            get {
                return ResourceManager.GetString("HelpCommandCertificatePfx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage certificate orders..
        /// </summary>
        internal static string HelpCommandOrder {
            get {
                return ResourceManager.GetString("HelpCommandOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get the details of an authorization..
        /// </summary>
        internal static string HelpCommandOrderAuthz {
            get {
                return ResourceManager.GetString("HelpCommandOrderAuthz", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finalize an order..
        /// </summary>
        internal static string HelpCommandOrderFinalize {
            get {
                return ResourceManager.GetString("HelpCommandOrderFinalize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List all certificate orders..
        /// </summary>
        internal static string HelpCommandOrderList {
            get {
                return ResourceManager.GetString("HelpCommandOrderList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create new certificate order..
        /// </summary>
        internal static string HelpCommandOrderNew {
            get {
                return ResourceManager.GetString("HelpCommandOrderNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get the details of a certificate order..
        /// </summary>
        internal static string HelpCommandOrderShow {
            get {
                return ResourceManager.GetString("HelpCommandOrderShow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validate the authorization challenge..
        /// </summary>
        internal static string HelpCommandOrderValidate {
            get {
                return ResourceManager.GetString("HelpCommandOrderValidate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage ACME servers..
        /// </summary>
        internal static string HelpCommandServer {
            get {
                return ResourceManager.GetString("HelpCommandServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configure the default ACME server..
        /// </summary>
        internal static string HelpCommandServerSet {
            get {
                return ResourceManager.GetString("HelpCommandServerSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get the details of a ACME server..
        /// </summary>
        internal static string HelpCommandServerShow {
            get {
                return ResourceManager.GetString("HelpCommandServerShow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The distinguished name for the certificate request..
        /// </summary>
        internal static string HelpDn {
            get {
                return ResourceManager.GetString("HelpDn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The domain..
        /// </summary>
        internal static string HelpDomain {
            get {
                return ResourceManager.GetString("HelpDomain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The domains for the certificate order..
        /// </summary>
        internal static string HelpDomains {
            get {
                return ResourceManager.GetString("HelpDomains", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The E-mail for ACME account..
        /// </summary>
        internal static string HelpEmail {
            get {
                return ResourceManager.GetString("HelpEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to the ACME account key..
        /// </summary>
        internal static string HelpKey {
            get {
                return ResourceManager.GetString("HelpKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path to save the generated key..
        /// </summary>
        internal static string HelpKeyOut {
            get {
                return ResourceManager.GetString("HelpKeyOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URI of the certificate order..
        /// </summary>
        internal static string HelpOrderId {
            get {
                return ResourceManager.GetString("HelpOrderId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password for the PFX..
        /// </summary>
        internal static string HelpPfxPassword {
            get {
                return ResourceManager.GetString("HelpPfxPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The private key for the certificate..
        /// </summary>
        internal static string HelpPrivateKey {
            get {
                return ResourceManager.GetString("HelpPrivateKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dictionary URI to an ACME server..
        /// </summary>
        internal static string HelpServer {
            get {
                return ResourceManager.GetString("HelpServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure app service deployment slot..
        /// </summary>
        internal static string HelpSlot {
            get {
                return ResourceManager.GetString("HelpSlot", resourceCulture);
            }
        }
    }
}
