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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLLMContentRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Priority.</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>Rule switch.</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>Detection scope. 1: Inbound. 2: Outbound. 3: Inbound and outbound.</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public ulong? CheckType{ get; set; }

        /// <summary>
        /// <p>Detection content matching.</p>
        /// </summary>
        [JsonProperty("RuleItem")]
        public RuleItem[] RuleItem{ get; set; }

        /// <summary>
        /// <p>Matching condition.</p>
        /// </summary>
        [JsonProperty("Options")]
        public LLMOptionsItem[] Options{ get; set; }

        /// <summary>
        /// <p>Domain name.</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Action. monitor: Observe. Intercept: Intercept.</p>
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// <p>Response prompt content.</p>
        /// </summary>
        [JsonProperty("ResponseText")]
        public string ResponseText{ get; set; }

        /// <summary>
        /// <p>Session ID for which the rule is to be enabled.</p>
        /// </summary>
        [JsonProperty("SessionApplied")]
        public string[] SessionApplied{ get; set; }

        /// <summary>
        /// <p>Rule ID. Enter 0 when adding a rule.</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>Interception page id.</p>
        /// </summary>
        [JsonProperty("PageId")]
        public ulong? PageId{ get; set; }

        /// <summary>
        /// <p>Detection content and/or expression. Defaults to and.</p>
        /// </summary>
        [JsonProperty("ContentLogicalOp")]
        public string ContentLogicalOp{ get; set; }

        /// <summary>
        /// <p>Instance id. Required.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Response type. 1: Built-in trusted model security response. 2: Custom response, which takes effect when ActionType=reply.</p><p>Valid values:</p><ul><li>1: Built-in trusted model security response</li><li>2: Custom response, which takes effect when ActionType=reply</li></ul>
        /// </summary>
        [JsonProperty("ReplyType")]
        public ulong? ReplyType{ get; set; }

        /// <summary>
        /// <p>Custom response template.</p>
        /// </summary>
        [JsonProperty("CustomReplyRuleId")]
        public string CustomReplyRuleId{ get; set; }

        /// <summary>
        /// <p>Modality type. 0: Text (default). 1: Image.</p><p>Valid values:</p><ul><li>0: Text</li><li>1: Image</li></ul>
        /// </summary>
        [JsonProperty("ModalType")]
        public ulong? ModalType{ get; set; }

        /// <summary>
        /// <p>Rule category. black: Regular rule (default). white: Allowlist rule. If this parameter is left empty, the black category is used. When this parameter is set to white, ActionType can only be set to pass, and RuleItem supports allowlist matching fields (Key: ip/geo/type/content/chat_id/user_id/tool_name/tool_args/keyword_whitelist; Op: belong/not_belong/equal/not_equal/contain/not_contain/prefix/suffix/wildcard).</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>Effective scope of the allowlist rule: a list of multiple serviceId/domain values (used when Category=white), indicating the domains/serviceIds to which the allowlist rule applies. This field is not used for blocklist rules.</p>
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// <p>List of module types for which the allowlist takes effect (used when Category=white), indicating the protection modules to which the allowlist rule applies (pass) after a match. Valid values: 2: Compute resource consumption rule; 3: Custom protection rule; 4: ToolCall protection; 5: Prompt attack protection; 6: Content compliance detection; 7: Sensitive data detection.</p>
        /// </summary>
        [JsonProperty("AppliedModules")]
        public ulong?[] AppliedModules{ get; set; }

        /// <summary>
        /// <p>Severity. critical: Critical. high: High. medium: Medium (default). low: Low. When this rule is matched, the risk level is displayed in attack logs based on this parameter. If this parameter is not passed or is left empty, the medium severity is used.</p><p>Valid values:</p><ul><li>critical: Critical</li><li>high: High</li><li>medium: Medium (default)</li><li>low: Low</li></ul>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamArrayObj(map, prefix + "RuleItem.", this.RuleItem);
            this.SetParamArrayObj(map, prefix + "Options.", this.Options);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ResponseText", this.ResponseText);
            this.SetParamArraySimple(map, prefix + "SessionApplied.", this.SessionApplied);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "ContentLogicalOp", this.ContentLogicalOp);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ReplyType", this.ReplyType);
            this.SetParamSimple(map, prefix + "CustomReplyRuleId", this.CustomReplyRuleId);
            this.SetParamSimple(map, prefix + "ModalType", this.ModalType);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "AppliedModules.", this.AppliedModules);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
        }
    }
}

