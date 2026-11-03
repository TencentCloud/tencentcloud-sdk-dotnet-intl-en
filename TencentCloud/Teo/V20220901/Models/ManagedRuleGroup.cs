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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagedRuleGroup : AbstractModel
    {
        
        /// <summary>
        /// Group name of the managed rule. If no rule group is specified, the default configuration is used. For the specific value of GroupId, refer to the product documentation.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Protection level of the managed rule group. Valid values: <li>loose: Loose. It only contains ultra-high risk rules. At this point, Action is required and RuleActions is invalid.</li><li>normal: Normal. It contains ultra-high risk and high-risk rules. At this point, Action is required and RuleActions is invalid.</li><li>strict: Strict. It contains ultra-high risk, high-risk, and medium-risk rules. At this point, Action is required and RuleActions is invalid.</li><li>extreme: Ultra-strict. It contains ultra-high risk, high-risk, medium-risk, and low-risk rules. At this point, Action is required and RuleActions is invalid.</li><li>custom: Custom. Refined strategy. Configure the disposal method for each individual rule. At this point, the Action field is invalid. Use RuleActions to configure the refined strategy for individual rules.</li>	
        /// </summary>
        [JsonProperty("SensitivityLevel")]
        public string SensitivityLevel{ get; set; }

        /// <summary>
        /// Handling action of the managed rule group. Supported values for SecurityAction Name: <li>Deny: Block. Respond with an interception page;</li><li>Monitor: Observe. Do not process requests, log security events in logs;</li><li>Disabled: Not activated. Do not scan requests, skip this rule.</li>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// Specific configuration of rule items in the managed rule group. This configuration is effective only when SensitivityLevel is custom.
        /// </summary>
        [JsonProperty("RuleActions")]
        public ManagedRuleAction[] RuleActions{ get; set; }

        /// <summary>
        /// Managed rule group information. This is an output-only parameter.	
        /// </summary>
        [JsonProperty("MetaData")]
        public ManagedRuleGroupMeta MetaData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "SensitivityLevel", this.SensitivityLevel);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamArrayObj(map, prefix + "RuleActions.", this.RuleActions);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
        }
    }
}

