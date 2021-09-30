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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficPackage : AbstractModel
    {
        
        /// <summary>
        /// Traffic package ID.
        /// </summary>
        [JsonProperty("TrafficPackageId")]
        public string TrafficPackageId{ get; set; }

        /// <summary>
        /// Used traffic in bytes during traffic package validity period.
        /// </summary>
        [JsonProperty("TrafficUsed")]
        public long? TrafficUsed{ get; set; }

        /// <summary>
        /// Total traffic in bytes during traffic package validity period.
        /// </summary>
        [JsonProperty("TrafficPackageTotal")]
        public long? TrafficPackageTotal{ get; set; }

        /// <summary>
        /// Remaining traffic in bytes during traffic package validity period.
        /// </summary>
        [JsonProperty("TrafficPackageRemaining")]
        public long? TrafficPackageRemaining{ get; set; }

        /// <summary>
        /// Traffic exceeding package amount in bytes during traffic package validity period.
        /// </summary>
        [JsonProperty("TrafficOverflow")]
        public long? TrafficOverflow{ get; set; }

        /// <summary>
        /// Start time of traffic package validity period according to ISO 8601 standard. UTC time is used. 
        /// Format: YYYY-MM-DDThh:mm:ssZ.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of traffic package validity period according to ISO 8601 standard. UTC time is used. 
        /// Format: YYYY-MM-DDThh:mm:ssZ.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Traffic package expiration time according to ISO 8601 standard. UTC time is used. 
        /// Format: YYYY-MM-DDThh:mm:ssZ.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// Traffic package status:
        /// <li>NETWORK_NORMAL: normal</li>
        /// <li>OVERDUE_NETWORK_DISABLED: the network is disconnected due to overdue payments</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficPackageId", this.TrafficPackageId);
            this.SetParamSimple(map, prefix + "TrafficUsed", this.TrafficUsed);
            this.SetParamSimple(map, prefix + "TrafficPackageTotal", this.TrafficPackageTotal);
            this.SetParamSimple(map, prefix + "TrafficPackageRemaining", this.TrafficPackageRemaining);
            this.SetParamSimple(map, prefix + "TrafficOverflow", this.TrafficOverflow);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

