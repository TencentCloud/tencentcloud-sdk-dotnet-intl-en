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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSAttackEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>Event ID.</p>
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// <p>Attack type.</p>
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// <p>Attack status.</p><p>Enumeration values:</p><ul><li>0: Observing</li><li>1: Attacking</li><li>2: Attack ended</li></ul>
        /// </summary>
        [JsonProperty("AttackStatus")]
        public long? AttackStatus{ get; set; }

        /// <summary>
        /// <p>Maximum attack bandwidth, in bps.</p>
        /// </summary>
        [JsonProperty("AttackMaxBandWidth")]
        public long? AttackMaxBandWidth{ get; set; }

        /// <summary>
        /// <p>Peak attack packet rate, unit: pps.</p>
        /// </summary>
        [JsonProperty("AttackPacketMaxRate")]
        public long? AttackPacketMaxRate{ get; set; }

        /// <summary>
        /// <p>Attack start timestamp.</p><p>Unit: second</p>
        /// </summary>
        [JsonProperty("AttackStartTime")]
        public long? AttackStartTime{ get; set; }

        /// <summary>
        /// <p>Attack end timestamp.</p><p>Unit: second</p>
        /// </summary>
        [JsonProperty("AttackEndTime")]
        public long? AttackEndTime{ get; set; }

        /// <summary>
        /// <p>DDoS policy group ID.</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// <p>Zone ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Region of the attack event.</p><p>Enumeration values:</p><ul><li>overseas: global (excluding the Chinese mainland) data;</li><li>mainland: Chinese mainland data.</li></ul>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>Block and unblock info.</p>
        /// </summary>
        [JsonProperty("DDoSBlockData")]
        public DDoSBlockData[] DDoSBlockData{ get; set; }

        /// <summary>
        /// <p>List of target IPs under DDoS attack.</p>
        /// </summary>
        [JsonProperty("DDoSAttackDips")]
        public string[] DDoSAttackDips{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "AttackStatus", this.AttackStatus);
            this.SetParamSimple(map, prefix + "AttackMaxBandWidth", this.AttackMaxBandWidth);
            this.SetParamSimple(map, prefix + "AttackPacketMaxRate", this.AttackPacketMaxRate);
            this.SetParamSimple(map, prefix + "AttackStartTime", this.AttackStartTime);
            this.SetParamSimple(map, prefix + "AttackEndTime", this.AttackEndTime);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArrayObj(map, prefix + "DDoSBlockData.", this.DDoSBlockData);
            this.SetParamArraySimple(map, prefix + "DDoSAttackDips.", this.DDoSAttackDips);
        }
    }
}

