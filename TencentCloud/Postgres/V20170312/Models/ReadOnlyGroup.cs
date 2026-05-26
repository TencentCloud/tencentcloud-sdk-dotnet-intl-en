/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReadOnlyGroup : AbstractModel
    {
        
        /// <summary>
        /// RO group identifier.
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }

        /// <summary>
        /// Specifies the read-only group name.
        /// </summary>
        [JsonProperty("ReadOnlyGroupName")]
        public string ReadOnlyGroupName{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Primary instance id.
        /// </summary>
        [JsonProperty("MasterDBInstanceId")]
        public string MasterDBInstanceId{ get; set; }

        /// <summary>
        /// Specifies the minimum number of instances to retain.
        /// </summary>
        [JsonProperty("MinDelayEliminateReserve")]
        public long? MinDelayEliminateReserve{ get; set; }

        /// <summary>
        /// Specifies the delay threshold for space size in MB.
        /// </summary>
        [JsonProperty("MaxReplayLatency")]
        public long? MaxReplayLatency{ get; set; }

        /// <summary>
        /// Specifies the delay size switch. valid values: 0 - turn off; 1 - turn on.
        /// </summary>
        [JsonProperty("ReplayLatencyEliminate")]
        public long? ReplayLatencyEliminate{ get; set; }

        /// <summary>
        /// Delay time size threshold, in seconds.
        /// </summary>
        [JsonProperty("MaxReplayLag")]
        public float? MaxReplayLag{ get; set; }

        /// <summary>
        /// Delay time switch. 0 - turn off. 1 - turn on.
        /// </summary>
        [JsonProperty("ReplayLagEliminate")]
        public long? ReplayLagEliminate{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Availability zone ID
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Status. valid values: creating, ok, modifying, deleting, deleted.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Instance details
        /// </summary>
        [JsonProperty("ReadOnlyDBInstanceList")]
        public DBInstance[] ReadOnlyDBInstanceList{ get; set; }

        /// <summary>
        /// Whether to enable automatic load balancing
        /// </summary>
        [JsonProperty("Rebalance")]
        public long? Rebalance{ get; set; }

        /// <summary>
        /// Network information
        /// </summary>
        [JsonProperty("DBInstanceNetInfo")]
        public DBInstanceNetInfo[] DBInstanceNetInfo{ get; set; }

        /// <summary>
        /// Network access list of the RO group (this field has been deprecated)
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetworkAccessList")]
        public NetworkAccess[] NetworkAccessList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupName", this.ReadOnlyGroupName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "MasterDBInstanceId", this.MasterDBInstanceId);
            this.SetParamSimple(map, prefix + "MinDelayEliminateReserve", this.MinDelayEliminateReserve);
            this.SetParamSimple(map, prefix + "MaxReplayLatency", this.MaxReplayLatency);
            this.SetParamSimple(map, prefix + "ReplayLatencyEliminate", this.ReplayLatencyEliminate);
            this.SetParamSimple(map, prefix + "MaxReplayLag", this.MaxReplayLag);
            this.SetParamSimple(map, prefix + "ReplayLagEliminate", this.ReplayLagEliminate);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "ReadOnlyDBInstanceList.", this.ReadOnlyDBInstanceList);
            this.SetParamSimple(map, prefix + "Rebalance", this.Rebalance);
            this.SetParamArrayObj(map, prefix + "DBInstanceNetInfo.", this.DBInstanceNetInfo);
            this.SetParamArrayObj(map, prefix + "NetworkAccessList.", this.NetworkAccessList);
        }
    }
}

