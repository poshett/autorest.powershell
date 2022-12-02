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
    /// Defines headers for RotateServiceAccountSigningKeys operation.
    /// </summary>
    public partial class ManagedClustersRotateServiceAccountSigningKeysHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClustersRotateServiceAccountSigningKeysHeaders class.
        /// </summary>
        public ManagedClustersRotateServiceAccountSigningKeysHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClustersRotateServiceAccountSigningKeysHeaders class.
        /// </summary>
        public ManagedClustersRotateServiceAccountSigningKeysHeaders(string location = default(string))
        {
            this.Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
