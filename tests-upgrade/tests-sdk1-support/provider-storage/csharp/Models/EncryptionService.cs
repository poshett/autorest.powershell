// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// A service that allows server-side encryption to be used.
    /// </summary>
    public partial class EncryptionService
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionService class.
        /// </summary>
        public EncryptionService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionService class.
        /// </summary>
        /// <param name="enabled">A boolean indicating whether or not the
        /// service encrypts the data as it is stored. Encryption at rest is
        /// enabled by default today and cannot be disabled.</param>
        /// <param name="lastEnabledTime">Gets a rough estimate of the
        /// date/time when the encryption was last enabled by the user. Data is
        /// encrypted at rest by default today and cannot be disabled.</param>
        /// <param name="keyType">Encryption key type to be used for the
        /// encryption service. 'Account' key type implies that an
        /// account-scoped encryption key will be used. 'Service' key type
        /// implies that a default service key is used. Possible values
        /// include: 'Service', 'Account'</param>
        public EncryptionService(bool? enabled = default(bool?), System.DateTime? lastEnabledTime = default(System.DateTime?), string keyType = default(string))
        {
            this.Enabled = enabled;
            this.LastEnabledTime = lastEnabledTime;
            this.KeyType = keyType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a boolean indicating whether or not the service
        /// encrypts the data as it is stored. Encryption at rest is enabled by
        /// default today and cannot be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets a rough estimate of the date/time when the encryption was last
        /// enabled by the user. Data is encrypted at rest by default today and
        /// cannot be disabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastEnabledTime")]
        public System.DateTime? LastEnabledTime { get; private set; }

        /// <summary>
        /// Gets or sets encryption key type to be used for the encryption
        /// service. 'Account' key type implies that an account-scoped
        /// encryption key will be used. 'Service' key type implies that a
        /// default service key is used. Possible values include: 'Service',
        /// 'Account'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyType")]
        public string KeyType { get; set; }

    }
}
