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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WarningRule : AbstractModel
    {
        
        /// <summary>
        /// Alert event type:
        /// Image repository security - Trojan: `IMG_REG_VIRUS`.
        /// Image repository security - Vulnerability: `IMG_REG_VUL`.
        /// Image repository security - Sensitive data: `IMG_REG_RISK`.
        /// Image security - Trojan: `IMG_VIRUS`.
        /// Image security - Vulnerability: `IMG_VUL`.
        /// Image security - Sensitive data: `IMG_RISK`.
        /// Image security - Image blocking: `IMG_INTERCEPT`.
        /// Runtime security - Container escape: `RUNTIME_ESCAPE`.
        /// Runtime security - Abnormal process: `RUNTIME_FILE`.
        /// Runtime security - Abnormal file access: `RUNTIME_PROCESS`.
        /// Runtime security - High-risk syscall: `RUNTIME_SYSCALL`.
        /// Runtime security - Reverse shell: `RUNTIME_REVERSE_SHELL`.
        /// Runtime security - Trojan: `RUNTIME_VIRUS`.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Switch status:
        /// `ON`: On.
        /// `OFF`: Off.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Alert start time in the format of "HH:mm"
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// Alert end time in the format of "HH:mm"
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Alert level policy control. Each binary bit represents a meaning, and the value is passed as a string.
        /// The control switch can be high, medium, or low, corresponding to the third, second, and first binary bit, respectively. Valid values: `0` (off); `1` (on).
        /// For example, if the high and medium levels indicate to enable the alert and the low level indicates to disable it, the binary value is `110`.
        /// If level control does not take effect for the alert type, pass in `1`.
        /// </summary>
        [JsonProperty("ControlBits")]
        public string ControlBits{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ControlBits", this.ControlBits);
        }
    }
}

