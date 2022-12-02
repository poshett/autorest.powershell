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
    /// An environment is a set of time-series data available for query, and is
    /// the top level Azure Time Series Insights resource. Standard
    /// environments have data retention limits.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Standard")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class StandardEnvironmentResource : EnvironmentResource
    {
        /// <summary>
        /// Initializes a new instance of the StandardEnvironmentResource
        /// class.
        /// </summary>
        public StandardEnvironmentResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StandardEnvironmentResource
        /// class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="sku">The sku determines the type of environment,
        /// either standard (S1 or S2) or long-term (L1). For standard
        /// environments the sku determines the capacity of the environment,
        /// the ingress rate, and the billing rate.</param>
        /// <param name="dataRetentionTime">ISO8601 timespan specifying the
        /// minimum number of days the environment's events will be available
        /// for query.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="storageLimitExceededBehavior">The behavior the Time
        /// Series Insights service should take when the environment's capacity
        /// has been exceeded. If "PauseIngress" is specified, new events will
        /// not be read from the event source. If "PurgeOldData" is specified,
        /// new events will continue to be read and old events will be deleted
        /// from the environment. The default behavior is PurgeOldData.
        /// Possible values include: 'PurgeOldData', 'PauseIngress'</param>
        /// <param name="partitionKeyProperties">The list of event properties
        /// which will be used to partition data in the environment.</param>
        /// <param name="dataAccessId">An id used to access the environment
        /// data, e.g. to query the environment's events or upload reference
        /// data for the environment.</param>
        /// <param name="dataAccessFqdn">The fully qualified domain name used
        /// to access the environment data, e.g. to query the environment's
        /// events or upload reference data for the environment.</param>
        /// <param name="status">An object that represents the status of the
        /// environment, and its internal state in the Time Series Insights
        /// service.</param>
        public StandardEnvironmentResource(string location, Sku sku, string dataRetentionTime, string id = default(string), string name = default(string), string type = default(string), string tags = default(string), StorageLimitExceededBehavior? storageLimitExceededBehavior = default(StorageLimitExceededBehavior?), System.Collections.Generic.IList<TimeSeriesIdProperty> partitionKeyProperties = default(System.Collections.Generic.IList<TimeSeriesIdProperty>), string dataAccessId = default(string), string dataAccessFqdn = default(string), EnvironmentStatus status = default(EnvironmentStatus))
            : base(location, sku, id, name, type, tags)
        {
            this.DataRetentionTime = dataRetentionTime;
            this.StorageLimitExceededBehavior = storageLimitExceededBehavior;
            this.PartitionKeyProperties = partitionKeyProperties;
            this.DataAccessId = dataAccessId;
            this.DataAccessFqdn = dataAccessFqdn;
            this.Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ISO8601 timespan specifying the minimum number of days
        /// the environment's events will be available for query.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dataRetentionTime")]
        public string DataRetentionTime { get; set; }

        /// <summary>
        /// Gets or sets the behavior the Time Series Insights service should
        /// take when the environment's capacity has been exceeded. If
        /// "PauseIngress" is specified, new events will not be read from the
        /// event source. If "PurgeOldData" is specified, new events will
        /// continue to be read and old events will be deleted from the
        /// environment. The default behavior is PurgeOldData. Possible values
        /// include: 'PurgeOldData', 'PauseIngress'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageLimitExceededBehavior")]
        public StorageLimitExceededBehavior? StorageLimitExceededBehavior { get; set; }

        /// <summary>
        /// Gets or sets the list of event properties which will be used to
        /// partition data in the environment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.partitionKeyProperties")]
        public System.Collections.Generic.IList<TimeSeriesIdProperty> PartitionKeyProperties { get; set; }

        /// <summary>
        /// Gets an id used to access the environment data, e.g. to query the
        /// environment's events or upload reference data for the environment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dataAccessId")]
        public string DataAccessId { get; private set; }

        /// <summary>
        /// Gets the fully qualified domain name used to access the environment
        /// data, e.g. to query the environment's events or upload reference
        /// data for the environment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dataAccessFqdn")]
        public string DataAccessFqdn { get; private set; }

        /// <summary>
        /// Gets or sets an object that represents the status of the
        /// environment, and its internal state in the Time Series Insights
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.status")]
        public EnvironmentStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.DataRetentionTime == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DataRetentionTime");
            }
            if (this.Status != null)
            {
                this.Status.Validate();
            }
        }
    }
}
