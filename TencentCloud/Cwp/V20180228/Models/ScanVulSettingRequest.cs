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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanVulSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// Regular detection interval (days)
        /// </summary>
        [JsonProperty("TimerInterval")]
        public ulong? TimerInterval{ get; set; }

        /// <summary>
        /// Vulnerability type. 1: web CMS vulnerability; 2: application vulnerability; 4: Linux software vulnerability; 5: Windows system vulnerability. Pass in the values in array format. Example: [1,2]
        /// </summary>
        [JsonProperty("VulCategories")]
        public ulong?[] VulCategories{ get; set; }

        /// <summary>
        /// Severity level. 1: low-risk; 2: medium-risk; 3: high-risk; 4: critical. Pass in the values in array format. Example: [1,2,3]
        /// </summary>
        [JsonProperty("VulLevels")]
        public ulong?[] VulLevels{ get; set; }

        /// <summary>
        /// Periodic detection time. Example: 02:10:50
        /// </summary>
        [JsonProperty("TimerTime")]
        public string TimerTime{ get; set; }

        /// <summary>
        /// Whether the vulnerability is an emergency vulnerability. 0: no; 1: yes.
        /// </summary>
        [JsonProperty("VulEmergency")]
        public ulong? VulEmergency{ get; set; }

        /// <summary>
        /// Scan start time. Example: 00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Scan end time. Example: 08:00
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Whether to enable scanning. 1: enable; 0: disable.
        /// </summary>
        [JsonProperty("EnableScan")]
        public ulong? EnableScan{ get; set; }

        /// <summary>
        /// If empty, scan hosts with all Professional, Premium, and General Discount editions by default; if not empty, only scan the selected hosts.
        /// </summary>
        [JsonProperty("Uuids")]
        public string[] Uuids{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScanMethod")]
        public ulong? ScanMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimerInterval", this.TimerInterval);
            this.SetParamArraySimple(map, prefix + "VulCategories.", this.VulCategories);
            this.SetParamArraySimple(map, prefix + "VulLevels.", this.VulLevels);
            this.SetParamSimple(map, prefix + "TimerTime", this.TimerTime);
            this.SetParamSimple(map, prefix + "VulEmergency", this.VulEmergency);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "EnableScan", this.EnableScan);
            this.SetParamArraySimple(map, prefix + "Uuids.", this.Uuids);
            this.SetParamSimple(map, prefix + "ScanMethod", this.ScanMethod);
        }
    }
}

