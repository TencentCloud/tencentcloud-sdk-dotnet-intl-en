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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSEventRecord : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgpip`: Anti-DDoS Advanced; `bgp`: Anti-DDoS Pro (Single IP); `bgp-multip`: Anti-DDoS Pro (Multi-IP); `net`: Anti-DDoS Ultimate; `basic`: Anti-DDoS Basic
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Anti-DDoS instance ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Resource IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Attack start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Attack end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Maximum attack bandwidth
        /// </summary>
        [JsonProperty("Mbps")]
        public ulong? Mbps{ get; set; }

        /// <summary>
        /// Maximum attack packet rate
        /// </summary>
        [JsonProperty("Pps")]
        public ulong? Pps{ get; set; }

        /// <summary>
        /// Attack type
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// Whether the IP is blocked. Valid values: [1 (yes), 0 (no), 2 (invalid value)]
        /// </summary>
        [JsonProperty("BlockFlag")]
        public ulong? BlockFlag{ get; set; }

        /// <summary>
        /// Whether the elastic protection bandwidth is exceeded. Valid values: [yes (yes), no (no), empty string (unknown value)]
        /// </summary>
        [JsonProperty("OverLoad")]
        public string OverLoad{ get; set; }

        /// <summary>
        /// Attack status. Valid values: [0 (ongoing), 1 (ended)]
        /// </summary>
        [JsonProperty("AttackStatus")]
        public ulong? AttackStatus{ get; set; }

        /// <summary>
        /// Resource name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Attack event ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Mbps", this.Mbps);
            this.SetParamSimple(map, prefix + "Pps", this.Pps);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "BlockFlag", this.BlockFlag);
            this.SetParamSimple(map, prefix + "OverLoad", this.OverLoad);
            this.SetParamSimple(map, prefix + "AttackStatus", this.AttackStatus);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
        }
    }
}

