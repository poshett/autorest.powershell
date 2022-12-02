// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Azure Key Vault key management service settings for the security
    /// profile.
    /// </summary>
    public partial class AzureKeyVaultKms
    {
        /// <summary>
        /// Initializes a new instance of the AzureKeyVaultKms class.
        /// </summary>
        public AzureKeyVaultKms()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureKeyVaultKms class.
        /// </summary>
        /// <param name="enabled">Whether to enable Azure Key Vault key
        /// management service. The default is false.</param>
        /// <param name="keyId">Identifier of Azure Key Vault key. See [key
        /// identifier
        /// format](https://docs.microsoft.com/en-us/azure/key-vault/general/about-keys-secrets-certificates#vault-name-and-object-name)
        /// for more details. When Azure Key Vault key management service is
        /// enabled, this field is required and must be a valid key identifier.
        /// When Azure Key Vault key management service is disabled, leave the
        /// field empty.</param>
        /// <param name="keyVaultNetworkAccess">Network access of the key
        /// vault</param>
        /// <param name="keyVaultResourceId">Resource ID of key vault. When
        /// keyVaultNetworkAccess is `Private`, this field is required and must
        /// be a valid resource ID. When keyVaultNetworkAccess is `Public`,
        /// leave the field empty.</param>
        public AzureKeyVaultKms(bool? enabled = default(bool?), string keyId = default(string), string keyVaultNetworkAccess = default(string), string keyVaultResourceId = default(string))
        {
            this.Enabled = enabled;
            this.KeyId = keyId;
            this.KeyVaultNetworkAccess = keyVaultNetworkAccess;
            this.KeyVaultResourceId = keyVaultResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether to enable Azure Key Vault key management
        /// service. The default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets identifier of Azure Key Vault key. See [key identifier
        /// format](https://docs.microsoft.com/en-us/azure/key-vault/general/about-keys-secrets-certificates#vault-name-and-object-name)
        /// for more details. When Azure Key Vault key management service is
        /// enabled, this field is required and must be a valid key identifier.
        /// When Azure Key Vault key management service is disabled, leave the
        /// field empty.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// Gets or sets network access of the key vault
        /// </summary>
        /// <remarks>
        /// Network access of key vault. The possible values are `Public` and
        /// `Private`. `Public` means the key vault allows public access from
        /// all networks. `Private` means the key vault disables public access
        /// and enables private link. The default value is `Public`. Possible
        /// values include: 'Public', 'Private'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultNetworkAccess")]
        public string KeyVaultNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets resource ID of key vault. When keyVaultNetworkAccess
        /// is `Private`, this field is required and must be a valid resource
        /// ID. When keyVaultNetworkAccess is `Public`, leave the field empty.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultResourceId")]
        public string KeyVaultResourceId { get; set; }

    }
}
