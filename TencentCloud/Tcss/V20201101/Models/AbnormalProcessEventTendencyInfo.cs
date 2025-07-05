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

    public class AbnormalProcessEventTendencyInfo : AbstractModel
    {
        
        /// <summary>
        /// Date
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// Number of pending proxy events
        /// </summary>
        [JsonProperty("ProxyToolEventCount")]
        public long? ProxyToolEventCount{ get; set; }

        /// <summary>
        /// Number of pending lateral movement events
        /// </summary>
        [JsonProperty("TransferControlEventCount")]
        public long? TransferControlEventCount{ get; set; }

        /// <summary>
        /// Number of pending malicious command events
        /// </summary>
        [JsonProperty("AttackCmdEventCount")]
        public long? AttackCmdEventCount{ get; set; }

        /// <summary>
        /// Number of pending reverse shell events
        /// </summary>
        [JsonProperty("ReverseShellEventCount")]
        public long? ReverseShellEventCount{ get; set; }

        /// <summary>
        /// Number of pending fileless execution events
        /// </summary>
        [JsonProperty("FilelessEventCount")]
        public long? FilelessEventCount{ get; set; }

        /// <summary>
        /// Number of pending high-risk command events
        /// </summary>
        [JsonProperty("RiskCmdEventCount")]
        public long? RiskCmdEventCount{ get; set; }

        /// <summary>
        /// Number of pending events of unusual startups found in the child process of the sensitive service
        /// </summary>
        [JsonProperty("AbnormalChildProcessEventCount")]
        public long? AbnormalChildProcessEventCount{ get; set; }

        /// <summary>
        /// Number of pending custom rule events
        /// </summary>
        [JsonProperty("UserDefinedRuleEventCount")]
        public long? UserDefinedRuleEventCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "ProxyToolEventCount", this.ProxyToolEventCount);
            this.SetParamSimple(map, prefix + "TransferControlEventCount", this.TransferControlEventCount);
            this.SetParamSimple(map, prefix + "AttackCmdEventCount", this.AttackCmdEventCount);
            this.SetParamSimple(map, prefix + "ReverseShellEventCount", this.ReverseShellEventCount);
            this.SetParamSimple(map, prefix + "FilelessEventCount", this.FilelessEventCount);
            this.SetParamSimple(map, prefix + "RiskCmdEventCount", this.RiskCmdEventCount);
            this.SetParamSimple(map, prefix + "AbnormalChildProcessEventCount", this.AbnormalChildProcessEventCount);
            this.SetParamSimple(map, prefix + "UserDefinedRuleEventCount", this.UserDefinedRuleEventCount);
        }
    }
}

