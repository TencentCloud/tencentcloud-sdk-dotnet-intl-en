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

    public class CreateSandboxDLPRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Rule name<br>Input parameter limit: length 1-128</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Rule level<br>Enumeration values:<br>INFO: notification<br>LOW: low risk<br>MEDIUM: medium risk<br>HIGH: high risk<br>CRITICAL: critical</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>Rule action<br>Enumeration value:<br>PASS: allowlist<br>BLOCK: block and alarm<br>MONITOR: alarm</p>
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// <p>Affiliated asset type<br>Enumeration values:<br>HOST: Host<br>CONTAINER: Container</p>
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// <p>Effective scope</p>
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// <p>Initial status<br>Enumeration values:<br>ON: Enable<br>OFF: Disable</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Referenced system rule ID list<br>Input limit: up to 1000; at least one of this or UserRuleContent must be provided</p>
        /// </summary>
        [JsonProperty("SystemRuleIDList")]
        public long?[] SystemRuleIDList{ get; set; }

        /// <summary>
        /// <p>User-defined rule content<br>Input limits: up to 100 sub-rules; import either this or UserRuleInfo. If both are imported at the same time, UserRuleInfo takes precedence</p>
        /// </summary>
        [JsonProperty("UserRuleContent")]
        public TrafficSandboxDLPRuleContentItem[] UserRuleContent{ get; set; }

        /// <summary>
        /// <p>Newly-added selectable structured input parameters support 5 detection dimensions (file name/file size/file format/outbound domain name/outbound content). Each dimension is selectable and at least one must be hit. It will override when passed at the same time as UserRuleContent.</p>
        /// </summary>
        [JsonProperty("UserRuleInfo")]
        public TrafficSandboxDLPUserRuleInfo UserRuleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SystemRuleIDList.", this.SystemRuleIDList);
            this.SetParamArrayObj(map, prefix + "UserRuleContent.", this.UserRuleContent);
            this.SetParamObj(map, prefix + "UserRuleInfo.", this.UserRuleInfo);
        }
    }
}

