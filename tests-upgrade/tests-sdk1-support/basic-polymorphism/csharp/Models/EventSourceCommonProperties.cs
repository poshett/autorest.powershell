// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of the event source.
    /// </summary>
    public partial class EventSourceCommonProperties : ResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the EventSourceCommonProperties
        /// class.
        /// </summary>
        public EventSourceCommonProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventSourceCommonProperties
        /// class.
        /// </summary>
        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: 'Accepted', 'Creating', 'Updating',
        /// 'Succeeded', 'Failed', 'Deleting'</param>
        /// <param name="creationTime">The time the resource was
        /// created.</param>
        /// <param name="timestampPropertyName">The event property that will be
        /// used as the event source's timestamp. If a value isn't specified
        /// for timestampPropertyName, or if null or empty-string is specified,
        /// the event creation time will be used.</param>
        public EventSourceCommonProperties(ProvisioningState? provisioningState = default(ProvisioningState?), System.DateTime? creationTime = default(System.DateTime?), string timestampPropertyName = default(string))
            : base(provisioningState, creationTime)
        {
            this.TimestampPropertyName = timestampPropertyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the event property that will be used as the event
        /// source's timestamp. If a value isn't specified for
        /// timestampPropertyName, or if null or empty-string is specified, the
        /// event creation time will be used.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timestampPropertyName")]
        public string TimestampPropertyName { get; set; }

    }
}
