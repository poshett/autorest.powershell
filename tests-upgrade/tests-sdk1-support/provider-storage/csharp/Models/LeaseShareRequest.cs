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
    /// Lease Share request schema.
    /// </summary>
    public partial class LeaseShareRequest
    {
        /// <summary>
        /// Initializes a new instance of the LeaseShareRequest class.
        /// </summary>
        public LeaseShareRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LeaseShareRequest class.
        /// </summary>
        /// <param name="action">Specifies the lease action. Can be one of the
        /// available actions. Possible values include: 'Acquire', 'Renew',
        /// 'Change', 'Release', 'Break'</param>
        /// <param name="leaseId">Identifies the lease. Can be specified in any
        /// valid GUID string format.</param>
        /// <param name="breakPeriod">Optional. For a break action, proposed
        /// duration the lease should continue before it is broken, in seconds,
        /// between 0 and 60.</param>
        /// <param name="leaseDuration">Required for acquire. Specifies the
        /// duration of the lease, in seconds, or negative one (-1) for a lease
        /// that never expires.</param>
        /// <param name="proposedLeaseId">Optional for acquire, required for
        /// change. Proposed lease ID, in a GUID string format.</param>
        public LeaseShareRequest(string action, string leaseId = default(string), int? breakPeriod = default(int?), int? leaseDuration = default(int?), string proposedLeaseId = default(string))
        {
            this.Action = action;
            this.LeaseId = leaseId;
            this.BreakPeriod = breakPeriod;
            this.LeaseDuration = leaseDuration;
            this.ProposedLeaseId = proposedLeaseId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the lease action. Can be one of the
        /// available actions. Possible values include: 'Acquire', 'Renew',
        /// 'Change', 'Release', 'Break'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets identifies the lease. Can be specified in any valid
        /// GUID string format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "leaseId")]
        public string LeaseId { get; set; }

        /// <summary>
        /// Gets or sets optional. For a break action, proposed duration the
        /// lease should continue before it is broken, in seconds, between 0
        /// and 60.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "breakPeriod")]
        public int? BreakPeriod { get; set; }

        /// <summary>
        /// Gets or sets required for acquire. Specifies the duration of the
        /// lease, in seconds, or negative one (-1) for a lease that never
        /// expires.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "leaseDuration")]
        public int? LeaseDuration { get; set; }

        /// <summary>
        /// Gets or sets optional for acquire, required for change. Proposed
        /// lease ID, in a GUID string format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "proposedLeaseId")]
        public string ProposedLeaseId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Action == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Action");
            }
        }
    }
}
