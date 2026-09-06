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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StandbyDBInstanceRelation : AbstractModel
    {
        
        /// <summary>
        /// Primary instance ID
        /// </summary>
        [JsonProperty("PrimaryInstanceId")]
        public string PrimaryInstanceId{ get; set; }

        /// <summary>
        /// Primary instance name
        /// </summary>
        [JsonProperty("PrimaryInstanceName")]
        public string PrimaryInstanceName{ get; set; }

        /// <summary>
        /// Region of the primary instance
        /// </summary>
        [JsonProperty("PrimaryRegion")]
        public string PrimaryRegion{ get; set; }

        /// <summary>
        /// Subnet IP of the primary instance
        /// </summary>
        [JsonProperty("PrimaryVip")]
        public string PrimaryVip{ get; set; }

        /// <summary>
        /// Port of the primary instance subnet
        /// </summary>
        [JsonProperty("PrimaryVport")]
        public long? PrimaryVport{ get; set; }

        /// <summary>
        /// Primary instance AZ
        /// </summary>
        [JsonProperty("PrimaryZones")]
        public string[] PrimaryZones{ get; set; }

        /// <summary>
        /// Primary instance running status
        /// </summary>
        [JsonProperty("PrimaryStatus")]
        public string PrimaryStatus{ get; set; }

        /// <summary>
        /// Disaster Recovery instance ID
        /// </summary>
        [JsonProperty("SecondaryInstanceId")]
        public string SecondaryInstanceId{ get; set; }

        /// <summary>
        /// Disaster Recovery instance name
        /// </summary>
        [JsonProperty("SecondaryInstanceName")]
        public string SecondaryInstanceName{ get; set; }

        /// <summary>
        /// Region of the standby instance
        /// </summary>
        [JsonProperty("SecondaryRegion")]
        public string SecondaryRegion{ get; set; }

        /// <summary>
        /// Subnet IP of the Disaster Recovery instance
        /// </summary>
        [JsonProperty("SecondaryVip")]
        public string SecondaryVip{ get; set; }

        /// <summary>
        /// Port of the Disaster Recovery instance subnet
        /// </summary>
        [JsonProperty("SecondaryVport")]
        public long? SecondaryVport{ get; set; }

        /// <summary>
        /// Disaster Recovery instance availability zone
        /// </summary>
        [JsonProperty("SecondaryZones")]
        public string[] SecondaryZones{ get; set; }

        /// <summary>
        /// Disaster Recovery instance running status
        /// </summary>
        [JsonProperty("SecondaryStatus")]
        public string SecondaryStatus{ get; set; }

        /// <summary>
        /// Connection type. Valid values: `log_service`, `raft`.
        /// </summary>
        [JsonProperty("ConnType")]
        public string ConnType{ get; set; }

        /// <summary>
        /// Synchronization type. Valid values: `sync` and `async`.
        /// </summary>
        [JsonProperty("SyncMode")]
        public string SyncMode{ get; set; }

        /// <summary>
        /// Synchronization status. 1: synchronizing; 2: sync exception
        /// </summary>
        [JsonProperty("SyncStatus")]
        public long? SyncStatus{ get; set; }

        /// <summary>
        /// Synchronization status description. Error information when the synchronization status is abnormal.
        /// </summary>
        [JsonProperty("SyncStatusDesc")]
        public string SyncStatusDesc{ get; set; }

        /// <summary>
        /// Disaster recovery status description. Valid values: "creating", "running", "modifying". Empty if no disaster recovery relationship exists.
        /// </summary>
        [JsonProperty("StandbyStatus")]
        public string StandbyStatus{ get; set; }

        /// <summary>
        /// Primary instance version
        /// </summary>
        [JsonProperty("PrimaryCreateVersion")]
        public string PrimaryCreateVersion{ get; set; }

        /// <summary>
        /// Disaster Recovery instance version
        /// </summary>
        [JsonProperty("SecondaryCreateVersion")]
        public string SecondaryCreateVersion{ get; set; }

        /// <summary>
        /// Latency in seconds
        /// </summary>
        [JsonProperty("SyncDelay")]
        public long? SyncDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrimaryInstanceId", this.PrimaryInstanceId);
            this.SetParamSimple(map, prefix + "PrimaryInstanceName", this.PrimaryInstanceName);
            this.SetParamSimple(map, prefix + "PrimaryRegion", this.PrimaryRegion);
            this.SetParamSimple(map, prefix + "PrimaryVip", this.PrimaryVip);
            this.SetParamSimple(map, prefix + "PrimaryVport", this.PrimaryVport);
            this.SetParamArraySimple(map, prefix + "PrimaryZones.", this.PrimaryZones);
            this.SetParamSimple(map, prefix + "PrimaryStatus", this.PrimaryStatus);
            this.SetParamSimple(map, prefix + "SecondaryInstanceId", this.SecondaryInstanceId);
            this.SetParamSimple(map, prefix + "SecondaryInstanceName", this.SecondaryInstanceName);
            this.SetParamSimple(map, prefix + "SecondaryRegion", this.SecondaryRegion);
            this.SetParamSimple(map, prefix + "SecondaryVip", this.SecondaryVip);
            this.SetParamSimple(map, prefix + "SecondaryVport", this.SecondaryVport);
            this.SetParamArraySimple(map, prefix + "SecondaryZones.", this.SecondaryZones);
            this.SetParamSimple(map, prefix + "SecondaryStatus", this.SecondaryStatus);
            this.SetParamSimple(map, prefix + "ConnType", this.ConnType);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "SyncStatusDesc", this.SyncStatusDesc);
            this.SetParamSimple(map, prefix + "StandbyStatus", this.StandbyStatus);
            this.SetParamSimple(map, prefix + "PrimaryCreateVersion", this.PrimaryCreateVersion);
            this.SetParamSimple(map, prefix + "SecondaryCreateVersion", this.SecondaryCreateVersion);
            this.SetParamSimple(map, prefix + "SyncDelay", this.SyncDelay);
        }
    }
}

