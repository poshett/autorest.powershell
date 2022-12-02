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
    /// The parameters used to regenerate the storage account key.
    /// </summary>
    public partial class StorageAccountRegenerateKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StorageAccountRegenerateKeyParameters class.
        /// </summary>
        public StorageAccountRegenerateKeyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StorageAccountRegenerateKeyParameters class.
        /// </summary>
        /// <param name="keyName">The name of storage keys that want to be
        /// regenerated, possible values are key1, key2, kerb1, kerb2.</param>
        public StorageAccountRegenerateKeyParameters(string keyName)
        {
            this.KeyName = keyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of storage keys that want to be regenerated,
        /// possible values are key1, key2, kerb1, kerb2.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyName")]
        public string KeyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.KeyName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "KeyName");
            }
        }
    }
}
