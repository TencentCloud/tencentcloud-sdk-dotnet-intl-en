/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoGroup : AbstractModel
    {
        
        /// <summary>
        /// Read-only group mode. Valid values: `alone` (the system assigns a read-only group automatically), `allinone` (a new read-only group will be created), `join` (an existing read-only group will be used).
        /// </summary>
        [JsonProperty("RoGroupMode")]
        public string RoGroupMode{ get; set; }

        /// <summary>
        /// Read-only group ID.
        /// </summary>
        [JsonProperty("RoGroupId")]
        public string RoGroupId{ get; set; }

        /// <summary>
        /// Read-only group name.
        /// </summary>
        [JsonProperty("RoGroupName")]
        public string RoGroupName{ get; set; }

        /// <summary>
        /// Whether to enable the function of isolating an instance that exceeds the latency threshold. If it is enabled, when the latency between the read-only instance and the primary instance exceeds the latency threshold, the read-only instance will be isolated. Valid values: 1 (enabled), 0 (not enabled)
        /// </summary>
        [JsonProperty("RoOfflineDelay")]
        public long? RoOfflineDelay{ get; set; }

        /// <summary>
        /// Latency threshold
        /// </summary>
        [JsonProperty("RoMaxDelayTime")]
        public long? RoMaxDelayTime{ get; set; }

        /// <summary>
        /// Minimum number of instances to be retained. If the number of the purchased read-only instances is smaller than the set value, they will not be removed.
        /// </summary>
        [JsonProperty("MinRoInGroup")]
        public long? MinRoInGroup{ get; set; }

        /// <summary>
        /// Read/write weight distribution mode. Valid values: `system` (weights are assigned by the system automatically), `custom` (weights are customized)
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// Weight value.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// Details of read-only instances in read-only group
        /// </summary>
        [JsonProperty("RoInstances")]
        public RoInstanceInfo[] RoInstances{ get; set; }

        /// <summary>
        /// Private IP of read-only group.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Private network port number of read-only group.
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// VPC ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Subnet ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Read-only group region.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoGroupRegion")]
        public string RoGroupRegion{ get; set; }

        /// <summary>
        /// Read-only group AZ.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoGroupZone")]
        public string RoGroupZone{ get; set; }

        /// <summary>
        /// Replication delay.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DelayReplicationTime")]
        public long? DelayReplicationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoGroupMode", this.RoGroupMode);
            this.SetParamSimple(map, prefix + "RoGroupId", this.RoGroupId);
            this.SetParamSimple(map, prefix + "RoGroupName", this.RoGroupName);
            this.SetParamSimple(map, prefix + "RoOfflineDelay", this.RoOfflineDelay);
            this.SetParamSimple(map, prefix + "RoMaxDelayTime", this.RoMaxDelayTime);
            this.SetParamSimple(map, prefix + "MinRoInGroup", this.MinRoInGroup);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamArrayObj(map, prefix + "RoInstances.", this.RoInstances);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "RoGroupRegion", this.RoGroupRegion);
            this.SetParamSimple(map, prefix + "RoGroupZone", this.RoGroupZone);
            this.SetParamSimple(map, prefix + "DelayReplicationTime", this.DelayReplicationTime);
        }
    }
}

