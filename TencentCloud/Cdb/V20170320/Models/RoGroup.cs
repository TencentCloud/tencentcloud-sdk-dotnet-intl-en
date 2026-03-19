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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>Read-only group mode. Available values are: alone-automatic allocation by the system; allinone-create a read-only group; join-use an existing read-only group.</p>
        /// </summary>
        [JsonProperty("RoGroupMode")]
        public string RoGroupMode{ get; set; }

        /// <summary>
        /// <p>Read-only group ID.<br>Note: If the data structure is used during instance purchase, this item is required only when the read-only group mode is set to join.</p>
        /// </summary>
        [JsonProperty("RoGroupId")]
        public string RoGroupId{ get; set; }

        /// <summary>
        /// <p>Read-only group name.</p>
        /// </summary>
        [JsonProperty("RoGroupName")]
        public string RoGroupName{ get; set; }

        /// <summary>
        /// <p>Whether to enable the feature to isolate an instance that exceeds the latency threshold. After enabling this feature, if the delay between a read-only instance and the primary instance exceeds the delay threshold, the read-only instance will be isolated. Available values: 1-enable; 0-disable.</p>
        /// </summary>
        [JsonProperty("RoOfflineDelay")]
        public long? RoOfflineDelay{ get; set; }

        /// <summary>
        /// <p>Delay threshold, in seconds. Value range: 1–10000. The value is an integer.</p>
        /// </summary>
        [JsonProperty("RoMaxDelayTime")]
        public long? RoMaxDelayTime{ get; set; }

        /// <summary>
        /// <p>Minimum number of instances to retain. If the number of read-only instances purchased is less than the set number, removal will not occur.</p>
        /// </summary>
        [JsonProperty("MinRoInGroup")]
        public long? MinRoInGroup{ get; set; }

        /// <summary>
        /// <p>Read-write weight allocation mode. Available values: system-automatic allocation by the system; custom-customization.</p>
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// <p>This field is deprecated and meaningless. To view the weight of a read-only instance, check the Weight value in the RoInstances field.</p>
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// <p>Details of read-only instances in the read-only group.</p>
        /// </summary>
        [JsonProperty("RoInstances")]
        public RoInstanceInfo[] RoInstances{ get; set; }

        /// <summary>
        /// <p>Private IP address of the read-only group.</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>Private network port number of the read-only group.</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>VPC ID.</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID.</p>
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// <p>Region of the read-only group.</p>
        /// </summary>
        [JsonProperty("RoGroupRegion")]
        public string RoGroupRegion{ get; set; }

        /// <summary>
        /// <p>AZ of the read-only group.</p>
        /// </summary>
        [JsonProperty("RoGroupZone")]
        public string RoGroupZone{ get; set; }

        /// <summary>
        /// <p>Replication delay time, in seconds. Value range: 1–259200. The value is an integer.</p>
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

