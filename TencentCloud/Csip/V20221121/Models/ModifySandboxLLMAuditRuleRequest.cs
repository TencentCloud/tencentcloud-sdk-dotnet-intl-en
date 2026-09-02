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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySandboxLLMAuditRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Rule name
        /// Input parameter limit: length 1-128
        /// Default value: no modification if not passed
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule level
        /// Enumeration values:
        /// INFO: Notification
        /// LOW: low-risk
        /// MEDIUM: medium-risk
        /// HIGH: high risk
        /// CRITICAL: Critical
        /// Default value: no modification if not passed
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Referenced LLM audit system rule ID list (string)
        /// Input parameter limit: if not passed, it means no modification; if passed, it overwrites all values, length 1-1000; each element length 1-128.
        /// </summary>
        [JsonProperty("SystemRuleIDList")]
        public string[] SystemRuleIDList{ get; set; }

        /// <summary>
        /// Effective scope
        /// Default value: no modification if not passed
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// Rule action
        /// Enumeration values:
        /// PASS: allowlist
        /// BLOCK: Block and alarm
        /// MONITOR: Alarm
        /// Default value: no modification if not passed
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// Target Status
        /// Enumeration values:
        /// ON: enable
        /// OFF: disabled.
        /// Default value: no modification if not passed
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArraySimple(map, prefix + "SystemRuleIDList.", this.SystemRuleIDList);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

