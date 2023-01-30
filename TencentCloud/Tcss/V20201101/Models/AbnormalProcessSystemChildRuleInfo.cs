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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AbnormalProcessSystemChildRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// Sub-policy ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Sub-policy status. Valid values: `true` (enabled); `false` (disabled).
        /// </summary>
        [JsonProperty("IsEnable")]
        public bool? IsEnable{ get; set; }

        /// <summary>
        /// Policy mode. `RULE_MODE_RELEASE`: Allow.
        ///    `RULE_MODE_ALERT`: Alert.
        ///    `RULE_MODE_HOLDUP`: Block.
        /// </summary>
        [JsonProperty("RuleMode")]
        public string RuleMode{ get; set; }

        /// <summary>
        /// Behavior type detected by the sub-policy
        /// `PROXY_TOOL`: Proxy.
        /// `TRANSFER_CONTROL`: Lateral movement.
        /// `ATTACK_CMD`: Malicious command.
        /// `REVERSE_SHELL`: Reverse shell.
        /// `FILELESS`: Fileless execution.
        /// `RISK_CMD`: High-risk command.
        /// `ABNORMAL_CHILD_PROC`: Unusual start found in the child process of the sensitive service.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Severity. Valid values: `HIGH` (high); `MIDDLE` (medium); `LOW` (low).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleLevel")]
        public string RuleLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "IsEnable", this.IsEnable);
            this.SetParamSimple(map, prefix + "RuleMode", this.RuleMode);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "RuleLevel", this.RuleLevel);
        }
    }
}

