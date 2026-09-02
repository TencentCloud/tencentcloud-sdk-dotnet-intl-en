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

    public class ModifySandboxDLPRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Rule ID.</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>Rule name<br>Input limit: length 1-128<br>Default value: no modification if not passed</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Rule level<br>Enumeration values:<br>INFO: notification<br>LOW: low risk<br>MEDIUM: medium risk<br>HIGH: high risk<br>CRITICAL: critical<br>Default value: no modification if not passed in</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>Rule action<br>Enumeration values:<br>PASS: blocklist<br>BLOCK: block and alarm<br>MONITOR: alarm<br>Default value: no modification if not passed in</p>
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// <p>Referenced system rule ID list<br>Input parameter limit: up to 1000; when passed, overwrites the original collection entirely; if not passed, means no modification</p>
        /// </summary>
        [JsonProperty("SystemRuleIDList")]
        public long?[] SystemRuleIDList{ get; set; }

        /// <summary>
        /// <p>User-defined rule content<br>Input parameter limits: when passed in, the entire collection is overwritten (passing an empty array is allowed to clear it); if not passed, no modification is made</p>
        /// </summary>
        [JsonProperty("UserRuleContent")]
        public TrafficSandboxDLPRuleContentItem[] UserRuleContent{ get; set; }

        /// <summary>
        /// <p>Structured input parameters support 5 detection dimensions (file name/file size/file format/outbound domain name/outbound content). Each dimension is selectable, and at least one must be hit. When passed in, it overwrites the original collection as a whole; if not passed, no modification is made. It will override when passed in at the same time as UserRuleContent</p>
        /// </summary>
        [JsonProperty("UserRuleInfo")]
        public TrafficSandboxDLPUserRuleInfo UserRuleInfo{ get; set; }

        /// <summary>
        /// <p>Effective scope<br>Default value: no modification if not passed</p>
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// <p>Target status<br>Enumeration values: <br>ON: Enablement<br>OFF: Disablement<br>Default value: No modification if not passed in</p>
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
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamArraySimple(map, prefix + "SystemRuleIDList.", this.SystemRuleIDList);
            this.SetParamArrayObj(map, prefix + "UserRuleContent.", this.UserRuleContent);
            this.SetParamObj(map, prefix + "UserRuleInfo.", this.UserRuleInfo);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

