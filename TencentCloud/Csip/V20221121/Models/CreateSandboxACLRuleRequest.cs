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

    public class CreateSandboxACLRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Rule name
        /// Input parameter limit: length 1-128
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule level
        /// Enumeration values:
        /// INFO: Notification.
        /// LOW: low-risk
        /// MEDIUM: Medium risk
        /// HIGH: HIGH risk
        /// CRITICAL: Critical
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Asset type to which it belongs
        /// Enumeration values:
        /// HOST: HOST
        /// CONTAINER: Container
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// Effective scope
        /// Input limitation: if EffectScope.EffectType is INCLUDE, EffectAssets must be non-empty.
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// Initial status
        /// Enumeration values:
        /// ON: enable
        /// OFF: disabled.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Rule action
        /// Enumeration values:
        /// PASS: allowlist
        /// BLOCK: Block and alarm
        /// MONITOR: Alarm
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// List of referenced system rule IDs
        /// Input limit: up to 100; provide at least one of this parameter and UserRuleContent
        /// </summary>
        [JsonProperty("SystemRuleIDList")]
        public long?[] SystemRuleIDList{ get; set; }

        /// <summary>
        /// Content of user-defined rules
        /// Input parameter limit: up to 100 sub-rules; provide at least one of this parameter or SystemRuleIDList.
        /// </summary>
        [JsonProperty("UserRuleContent")]
        public TrafficSandboxACLRuleContentItem[] UserRuleContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamArraySimple(map, prefix + "SystemRuleIDList.", this.SystemRuleIDList);
            this.SetParamArrayObj(map, prefix + "UserRuleContent.", this.UserRuleContent);
        }
    }
}

