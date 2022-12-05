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
    /// An object that represents a set of mutable event source resource
    /// properties.
    /// </summary>
    public partial class EventSourceMutableProperties
    {
        /// <summary>
        /// Initializes a new instance of the EventSourceMutableProperties
        /// class.
        /// </summary>
        public EventSourceMutableProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventSourceMutableProperties
        /// class.
        /// </summary>
        /// <param name="timestampPropertyName">The event property that will be
        /// used as the event source's timestamp. If a value isn't specified
        /// for timestampPropertyName, or if null or empty-string is specified,
        /// the event creation time will be used.</param>
        /// <param name="localTimestamp">An object that represents the local
        /// timestamp property. It contains the format of local timestamp that
        /// needs to be used and the corresponding timezone offset information.
        /// If a value isn't specified for localTimestamp, or if null, then the
        /// local timestamp will not be ingressed with the events.</param>
        public EventSourceMutableProperties(string timestampPropertyName = default(string), LocalTimestamp localTimestamp = default(LocalTimestamp))
        {
            this.TimestampPropertyName = timestampPropertyName;
            this.LocalTimestamp = localTimestamp;
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

        /// <summary>
        /// Gets or sets an object that represents the local timestamp
        /// property. It contains the format of local timestamp that needs to
        /// be used and the corresponding timezone offset information. If a
        /// value isn't specified for localTimestamp, or if null, then the
        /// local timestamp will not be ingressed with the events.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "localTimestamp")]
        public LocalTimestamp LocalTimestamp { get; set; }

    }
}