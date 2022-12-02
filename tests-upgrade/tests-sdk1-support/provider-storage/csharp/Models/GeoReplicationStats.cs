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
    /// Statistics related to replication for storage account's Blob, Table,
    /// Queue and File services. It is only available when geo-redundant
    /// replication is enabled for the storage account.
    /// </summary>
    public partial class GeoReplicationStats
    {
        /// <summary>
        /// Initializes a new instance of the GeoReplicationStats class.
        /// </summary>
        public GeoReplicationStats()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GeoReplicationStats class.
        /// </summary>
        /// <param name="status">The status of the secondary location. Possible
        /// values are: - Live: Indicates that the secondary location is active
        /// and operational. - Bootstrap: Indicates initial synchronization
        /// from the primary location to the secondary location is in
        /// progress.This typically occurs when replication is first enabled. -
        /// Unavailable: Indicates that the secondary location is temporarily
        /// unavailable. Possible values include: 'Live', 'Bootstrap',
        /// 'Unavailable'</param>
        /// <param name="lastSyncTime">All primary writes preceding this UTC
        /// date/time value are guaranteed to be available for read operations.
        /// Primary writes following this point in time may or may not be
        /// available for reads. Element may be default value if value of
        /// LastSyncTime is not available, this can happen if secondary is
        /// offline or we are in bootstrap.</param>
        /// <param name="canFailover">A boolean flag which indicates whether or
        /// not account failover is supported for the account.</param>
        public GeoReplicationStats(string status = default(string), System.DateTime? lastSyncTime = default(System.DateTime?), bool? canFailover = default(bool?))
        {
            this.Status = status;
            this.LastSyncTime = lastSyncTime;
            this.CanFailover = canFailover;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the status of the secondary location. Possible values are: -
        /// Live: Indicates that the secondary location is active and
        /// operational. - Bootstrap: Indicates initial synchronization from
        /// the primary location to the secondary location is in progress.This
        /// typically occurs when replication is first enabled. - Unavailable:
        /// Indicates that the secondary location is temporarily unavailable.
        /// Possible values include: 'Live', 'Bootstrap', 'Unavailable'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets all primary writes preceding this UTC date/time value are
        /// guaranteed to be available for read operations. Primary writes
        /// following this point in time may or may not be available for reads.
        /// Element may be default value if value of LastSyncTime is not
        /// available, this can happen if secondary is offline or we are in
        /// bootstrap.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastSyncTime")]
        public System.DateTime? LastSyncTime { get; private set; }

        /// <summary>
        /// Gets a boolean flag which indicates whether or not account failover
        /// is supported for the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "canFailover")]
        public bool? CanFailover { get; private set; }

    }
}
