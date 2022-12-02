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
    /// Lease Container response schema.
    /// </summary>
    public partial class LeaseContainerResponse
    {
        /// <summary>
        /// Initializes a new instance of the LeaseContainerResponse class.
        /// </summary>
        public LeaseContainerResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LeaseContainerResponse class.
        /// </summary>
        /// <param name="leaseId">Returned unique lease ID that must be
        /// included with any request to delete the container, or to renew,
        /// change, or release the lease.</param>
        /// <param name="leaseTimeSeconds">Approximate time remaining in the
        /// lease period, in seconds.</param>
        public LeaseContainerResponse(string leaseId = default(string), string leaseTimeSeconds = default(string))
        {
            this.LeaseId = leaseId;
            this.LeaseTimeSeconds = leaseTimeSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets returned unique lease ID that must be included with
        /// any request to delete the container, or to renew, change, or
        /// release the lease.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "leaseId")]
        public string LeaseId { get; set; }

        /// <summary>
        /// Gets or sets approximate time remaining in the lease period, in
        /// seconds.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "leaseTimeSeconds")]
        public string LeaseTimeSeconds { get; set; }

    }
}
