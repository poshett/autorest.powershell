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

    public partial class ManagedClusterPodIdentityProvisioningInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterPodIdentityProvisioningInfo class.
        /// </summary>
        public ManagedClusterPodIdentityProvisioningInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterPodIdentityProvisioningInfo class.
        /// </summary>
        /// <param name="error">Pod identity assignment error (if any).</param>
        public ManagedClusterPodIdentityProvisioningInfo(ManagedClusterPodIdentityProvisioningError error = default(ManagedClusterPodIdentityProvisioningError))
        {
            this.Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets pod identity assignment error (if any).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public ManagedClusterPodIdentityProvisioningError Error { get; set; }

    }
}
