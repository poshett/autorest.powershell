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
    /// The blob service properties for change feed events.
    /// </summary>
    public partial class ChangeFeed
    {
        /// <summary>
        /// Initializes a new instance of the ChangeFeed class.
        /// </summary>
        public ChangeFeed()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ChangeFeed class.
        /// </summary>
        /// <param name="enabled">Indicates whether change feed event logging
        /// is enabled for the Blob service.</param>
        /// <param name="retentionInDays">Indicates the duration of changeFeed
        /// retention in days. Minimum value is 1 day and maximum value is
        /// 146000 days (400 years). A null value indicates an infinite
        /// retention of the change feed.</param>
        public ChangeFeed(bool? enabled = default(bool?), int? retentionInDays = default(int?))
        {
            this.Enabled = enabled;
            this.RetentionInDays = retentionInDays;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether change feed event logging is enabled
        /// for the Blob service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets indicates the duration of changeFeed retention in
        /// days. Minimum value is 1 day and maximum value is 146000 days (400
        /// years). A null value indicates an infinite retention of the change
        /// feed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retentionInDays")]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.RetentionInDays != null)
            {
                if (this.RetentionInDays > 146000)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "RetentionInDays", 146000);
                }
                if (this.RetentionInDays < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "RetentionInDays", 1);
                }
            }
        }
    }
}
