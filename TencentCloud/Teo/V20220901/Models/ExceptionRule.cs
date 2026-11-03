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
        /// ID of the exception rule.<br>Different rule configuration operations can be performed by rule ID:<br> <li> <b>Add</b> a new rule: leave the ID empty or do not specify the ID parameter;</li><li> <b>Modify</b> an existing rule: specify the rule ID to be updated/modified;</li><li> <b>Delete</b> an existing rule: existing rules not included in the Rules list in the ExceptionRules parameter will be deleted.</li>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Name of the exception rule.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Specific content of the exception rule must comply with the expression grammar. For detailed specifications, please refer to the product document.
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Exception rule execution options. Valid values: <li>WebSecurityModules: assigns the security protection module for the exception rule. Use in conjunction with WebSecurityModulesForException.</li><li>WebSecuritySubmodules: assigns the security protection submodule for the exception rule. Use in conjunction with WebSecuritySubmodulesForException.</li><li>ManagedRules: assigns the specific managed rule for the exception rule. Use in conjunction with ManagedRulesForException.</li><li>ManagedRuleGroups: assigns the managed rule group for the exception rule. Use in conjunction with ManagedRuleGroupsForException.</li>
        /// </summary>
        [JsonProperty("SkipScope")]
        public string SkipScope{ get; set; }

        /// <summary>
        /// Skip the specific type of request. Valid values: <li>SkipOnAllRequestFields: skip all requests;</li><li>SkipOnSpecifiedRequestFields: skip specified request fields.</li>Valid only when SkipScope is ManagedRules or ManagedRuleGroups.
        /// </summary>
        [JsonProperty("SkipOption")]
        public string SkipOption{ get; set; }

        /// <summary>
        /// Security protection module for the exception rule. Valid only when SkipScope is WebSecurityModules. Valid values: <li>websec-mod-managed-rules: managed rule</li><li>websec-mod-rate-limiting: rate limit</li><li>websec-mod-custom-rules: custom rule</li><li>websec-mod-adaptive-control: adaptive frequency control, intelligent client filtering, slow attack protection, traffic theft protection</li><li>websec-mod-bot: bot management</li>
        /// </summary>
        [JsonProperty("WebSecurityModulesForException")]
        public string[] WebSecurityModulesForException{ get; set; }

        /// <summary>
        /// Specifies the security protection submodule for the exception rule. Valid only when SkipScope is WebSecuritySubmodules. Valid values: <ul><li>ManagedRules module features: <ul><li>websec-mod-managed-rules/managed-rule-groups: rule set;</li><li>websec-mod-managed-rules/frequent-scanning-protection: high frequency scan protection;</li></ul></li><li>RateLimitingRules module features: <ul><li>websec-mod-rate-limiting-rules: rate limiting rule;</li></ul></li><li>CustomRules module features: <ul><li>websec-mod-custom-rules: custom rule;</li></ul></li><li>HttpDDoSProtection module features: <ul><li>websec-mod-HTTP-DDoS-protection/adaptive-frequency-control: adaptive frequency control;</li><li>websec-mod-HTTP-DDoS-protection/client-filtering: intelligent client filtering;</li><li>websec-mod-HTTP-DDoS-protection/bandwidth-abuse-defense: traffic fraud protection;</li></ul></li><li>BotManagement module features: <ul><li>websec-mod-Bot-management/basic-feature: basic feature management;</li><li>websec-mod-Bot-management/ip-reputation: client profile analysis;</li><li>websec-mod-Bot-management/Bot-intelligence: intelligent Bot analysis;</li><li>websec-mod-Bot-management/custom-rules: custom rule;</li><li>websec-mod-Bot-management/browser-impersonation-detection: proactive feature recognition;</li><li>websec-mod-Bot-management/client-attestation-rules: client authentication;</li></ul></li><li>BotManagementLite module features: <ul><li>websec-mod-Bot-management-lite/ai-crawler-detection: ai crawler disposal;</li><li>websec-mod-Bot-management-lite/captcha-page-challenge: captcha page challenge.</li></ul></li></ul>
        /// </summary>
        [JsonProperty("WebSecuritySubmodulesForException")]
        public string[] WebSecuritySubmodulesForException{ get; set; }

        /// <summary>
        /// Specify the specific managed rule for the exception rule. This parameter is valid only when SkipScope is ManagedRules.
        /// </summary>
        [JsonProperty("ManagedRulesForException")]
        public string[] ManagedRulesForException{ get; set; }

        /// <summary>
        /// Managed rule group with specified exception rules. This parameter is valid only when SkipScope is ManagedRuleGroups.
        /// </summary>
        [JsonProperty("ManagedRuleGroupsForException")]
        public string[] ManagedRuleGroupsForException{ get; set; }

        /// <summary>
        /// Configuration for specifying exception rules to skip specified request fields. This is valid only when SkipScope is ManagedRules or ManagedRuleGroups and SkipOption is SkipOnSpecifiedRequestFields.
        /// </summary>
        [JsonProperty("RequestFieldsForException")]
        public RequestFieldsForException[] RequestFieldsForException{ get; set; }

        /// <summary>
        /// Whether the exception rule is enabled. Valid values: <li>on: enabled</li><li>off: disabled</li>
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
            this.SetParamArraySimple(map, prefix + "WebSecuritySubmodulesForException.", this.WebSecuritySubmodulesForException);
            this.SetParamArraySimple(map, prefix + "ManagedRulesForException.", this.ManagedRulesForException);
            this.SetParamArraySimple(map, prefix + "ManagedRuleGroupsForException.", this.ManagedRuleGroupsForException);
            this.SetParamArrayObj(map, prefix + "RequestFieldsForException.", this.RequestFieldsForException);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

