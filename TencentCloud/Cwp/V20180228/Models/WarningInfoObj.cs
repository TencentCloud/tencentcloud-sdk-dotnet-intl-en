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

    public class WarningInfoObj : AbstractModel
    {
        
        /// <summary>
        /// Event alarm type. 1: offline; 2: Trojan; 3: abnormal log-in; 4: brute force cracking; 5: vulnerability (including types of values 9, 10, 11, and 12); 6: high-risk command; 7: reverse shell; 8: local privilege escalation; 9: application vulnerability; 10: web CMS vulnerability; 11: emergency vulnerability; 12: security baseline; 13: tampering prevention; 14: malicious request; 15: network attack; 16: Windows system vulnerability; 17: Linux software vulnerability; 18: core file monitoring; 19: client uninstallation; 20: client offline.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 1: disable alarm; 0: enable alarm
        /// </summary>
        [JsonProperty("DisablePhoneWarning")]
        public ulong? DisablePhoneWarning{ get; set; }

        /// <summary>
        /// Start time. Format: HH:mm.
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// End time. Format: HH:mm.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Time zone information
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// Vulnerability level control bit (corresponding to the decimal storage in the database)
        /// </summary>
        [JsonProperty("ControlBit")]
        public ulong? ControlBit{ get; set; }

        /// <summary>
        /// Vulnerability level control bits in binary. Each bit indicates the enabling status of the corresponding vulnerability level on the page: low, medium, and high (0: disabled; 1: enabled). For example, 101 indicates that both low and high levels are enabled.
        /// </summary>
        [JsonProperty("ControlBits")]
        public string ControlBits{ get; set; }

        /// <summary>
        /// Alarm Host Range Type. 0: All Hosts; 1: By Project; 2: By Tencent Cloud Tag; 3: By Host Security Tag; 4: Custom Hosts
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostRange")]
        public long? HostRange{ get; set; }

        /// <summary>
        /// Configured Number of Hosts in the Range of Alarm, used by the frontend to decide when to display prompt information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DisablePhoneWarning", this.DisablePhoneWarning);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "ControlBit", this.ControlBit);
            this.SetParamSimple(map, prefix + "ControlBits", this.ControlBits);
            this.SetParamSimple(map, prefix + "HostRange", this.HostRange);
            this.SetParamSimple(map, prefix + "Count", this.Count);
        }
    }
}

