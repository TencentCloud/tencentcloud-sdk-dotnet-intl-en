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
        /// The event ID.
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// The attack type.
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// The attack status.
        /// </summary>
        [JsonProperty("AttackStatus")]
        public long? AttackStatus{ get; set; }

        /// <summary>
        /// The maximum attack bandwidth.
        /// </summary>
        [JsonProperty("AttackMaxBandWidth")]
        public long? AttackMaxBandWidth{ get; set; }

        /// <summary>
        /// The peak attack packet rate.
        /// </summary>
        [JsonProperty("AttackPacketMaxRate")]
        public long? AttackPacketMaxRate{ get; set; }

        /// <summary>
        /// The attack start time recorded in seconds.
        /// </summary>
        [JsonProperty("AttackStartTime")]
        public long? AttackStartTime{ get; set; }

        /// <summary>
        /// The attack end time recorded in seconds.
        /// </summary>
        [JsonProperty("AttackEndTime")]
        public long? AttackEndTime{ get; set; }

        /// <summary>
        /// The DDoS policy ID. 
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// The site ID. 
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Geolocation scope. Values: 
        /// <li>`overseas`: Regions outside the Chinese mainland</li>
        /// <li>`mainland`: Chinese mainland</li>
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// The blocking time of a DDoS attack. 
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DDoSBlockData")]
        public DDoSBlockData[] DDoSBlockData{ get; set; }


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
        }
    }
}

