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
    /// This property enables and defines account-level immutability. Enabling
    /// the feature auto-enables Blob Versioning.
    /// </summary>
    public partial class ImmutableStorageAccount
    {
        /// <summary>
        /// Initializes a new instance of the ImmutableStorageAccount class.
        /// </summary>
        public ImmutableStorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImmutableStorageAccount class.
        /// </summary>
        /// <param name="enabled">A boolean flag which enables account-level
        /// immutability. All the containers under such an account have
        /// object-level immutability enabled by default.</param>
        /// <param name="immutabilityPolicy">Specifies the default
        /// account-level immutability policy which is inherited and applied to
        /// objects that do not possess an explicit immutability policy at the
        /// object level. The object-level immutability policy has higher
        /// precedence than the container-level immutability policy, which has
        /// a higher precedence than the account-level immutability
        /// policy.</param>
        public ImmutableStorageAccount(bool? enabled = default(bool?), AccountImmutabilityPolicyProperties immutabilityPolicy = default(AccountImmutabilityPolicyProperties))
        {
            this.Enabled = enabled;
            this.ImmutabilityPolicy = immutabilityPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a boolean flag which enables account-level
        /// immutability. All the containers under such an account have
        /// object-level immutability enabled by default.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets specifies the default account-level immutability
        /// policy which is inherited and applied to objects that do not
        /// possess an explicit immutability policy at the object level. The
        /// object-level immutability policy has higher precedence than the
        /// container-level immutability policy, which has a higher precedence
        /// than the account-level immutability policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "immutabilityPolicy")]
        public AccountImmutabilityPolicyProperties ImmutabilityPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ImmutabilityPolicy != null)
            {
                this.ImmutabilityPolicy.Validate();
            }
        }
    }
}
