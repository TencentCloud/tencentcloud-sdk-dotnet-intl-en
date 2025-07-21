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

    public class ExceptionRule : AbstractModel
    {
        
        /// <summary>
        /// The ID of the exception rule. different rule configuration operations are supported by rule ID: <li> <b>add</b> a new rule: leave the ID empty or do not specify the ID parameter.</li> <li> <b>modify</b> an existing rule: specify the rule ID that needs to be updated/modified.</li> <li> <b>delete</b> an existing rule: existing Rules not included in the Rules list under the ExceptionRules parameter will be deleted.</li>.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// The name of the exception rule.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Describes the specific content of the exception rule, which must comply with the expression grammar. for details, please refer to the product document.
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Exception rule execution options, valid values: <li>WebSecurityModules: designate the security protection module for the exception rule.</li> <li>ManagedRules: designate the managed rule.</li>.
        /// </summary>
        [JsonProperty("SkipScope")]
        public string SkipScope{ get; set; }

        /// <summary>
        /// Skip the specific type of request. valid values: <li>SkipOnAllRequestFields: skip all requests;</li> <li>SkipOnSpecifiedRequestFields: skip specified request fields.</li> valid only when SkipScope is ManagedRules.
        /// </summary>
        [JsonProperty("SkipOption")]
        public string SkipOption{ get; set; }

        /// <summary>
        /// Specifies the security protection module for exception rules. valid only when SkipScope is WebSecurityModules. valid values: <li>websec-mod-managed-rules: managed rule.</li><li>websec-mod-rate-limiting: rate limit.</li><li>websec-mod-custom-rules: custom rule.</li><li>websec-mod-adaptive-control: adaptive frequency control, intelligent client filtering, slow attack protection, traffic theft protection.</li><li>websec-mod-bot: bot management.</li>.
        /// </summary>
        [JsonProperty("WebSecurityModulesForException")]
        public string[] WebSecurityModulesForException{ get; set; }

        /// <summary>
        /// Specifies the managed rule for the exception rule. valid only when SkipScope is ManagedRules. cannot specify ManagedRuleGroupsForException at this time.
        /// </summary>
        [JsonProperty("ManagedRulesForException")]
        public string[] ManagedRulesForException{ get; set; }

        /// <summary>
        /// A managed rule group with designated exception rules is valid only when SkipScope is ManagedRules, and at this point you cannot specify ManagedRulesForException.
        /// </summary>
        [JsonProperty("ManagedRuleGroupsForException")]
        public string[] ManagedRuleGroupsForException{ get; set; }

        /// <summary>
        /// Specify exception rules to skip request fields. valid only when SkipScope is ManagedRules and SkipOption is SkipOnSpecifiedRequestFields.
        /// </summary>
        [JsonProperty("RequestFieldsForException")]
        public RequestFieldsForException[] RequestFieldsForException{ get; set; }

        /// <summary>
        /// Whether the exception rule is enabled. valid values: <li>`on`: enable</li> <li>`off`: disable</li>.
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "SkipScope", this.SkipScope);
            this.SetParamSimple(map, prefix + "SkipOption", this.SkipOption);
            this.SetParamArraySimple(map, prefix + "WebSecurityModulesForException.", this.WebSecurityModulesForException);
            this.SetParamArraySimple(map, prefix + "ManagedRulesForException.", this.ManagedRulesForException);
            this.SetParamArraySimple(map, prefix + "ManagedRuleGroupsForException.", this.ManagedRuleGroupsForException);
            this.SetParamArrayObj(map, prefix + "RequestFieldsForException.", this.RequestFieldsForException);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

