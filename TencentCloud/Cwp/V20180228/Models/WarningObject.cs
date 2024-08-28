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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WarningObject : AbstractModel
    {
        
        /// <summary>
        /// Event Alarm Type. 1: Offline; 2: Trojan; 3: Exceptional login; 4: Brute force; 5: Vulnerability (split into four types ranging from 9 to 12); 6: High-risk command; 7: Reverse sell; 8: Local privilege escalation;, 9: System component vulnerabilities; 10: Web application vulnerabilities; 11: Emergency vulnerabilities; 12: Security baseline; 14: Malicious request; 15: Network attack; 16: Windows system vulnerabilities; 17: Linux software vulnerabilities
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 1: disable alarm; 0: enable alarm.
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
        /// 1. Vulnerability level control bits in binary. Each bit corresponds to the vulnerability level enabling status on the corresponding page. Level: low, medium, high (0: disabled; 1: enabled). Example: 101, indicating both the low and high levels are enabled. 2. Brute force cracking control bits in binary. 01: notify upon successful brute force cracking; 10: notify upon brute force cracking failure.
        /// </summary>
        [JsonProperty("ControlBits")]
        public string ControlBits{ get; set; }

        /// <summary>
        /// Alarm Host Range Type. 0: All Hosts; 1: By Project; 2: By Tencent Cloud Tag; 3: By Host Security Tag; 4: Custom Hosts
        /// </summary>
        [JsonProperty("HostRange")]
        public long? HostRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DisablePhoneWarning", this.DisablePhoneWarning);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ControlBits", this.ControlBits);
            this.SetParamSimple(map, prefix + "HostRange", this.HostRange);
        }
    }
}

