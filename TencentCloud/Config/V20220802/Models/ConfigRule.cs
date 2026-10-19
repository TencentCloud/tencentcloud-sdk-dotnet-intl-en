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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigRule : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// Rule Name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule parameters
        /// </summary>
        [JsonProperty("InputParameter")]
        public InputParameter[] InputParameter{ get; set; }

        /// <summary>
        /// Rule trigger condition.
        /// </summary>
        [JsonProperty("SourceCondition")]
        public SourceConditionForManage[] SourceCondition{ get; set; }

        /// <summary>
        /// Resource types supported by the rule. The rule applies only to resources of the specified resource types.
        /// </summary>
        [JsonProperty("ResourceType")]
        public string[] ResourceType{ get; set; }

        /// <summary>
        /// Rule tags.
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }

        /// <summary>
        /// Rule risk level.
        /// 1: Low risk
        /// 2: Medium-risk
        /// 3: High-risk
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// Function corresponding to the rule.
        /// </summary>
        [JsonProperty("ServiceFunction")]
        public string ServiceFunction{ get; set; }

        /// <summary>
        /// Creation time.
        /// Format: YYYY-MM-DD h:i:s
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// ACTIVE: enable
        /// NO_ACTIVE: Disabled
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Compliant: 'COMPLIANT'
        /// Non-compliance: 'NON_COMPLIANT'
        /// Unable to apply rule: 'NOT_APPLICABLE'
        /// </summary>
        [JsonProperty("ComplianceResult")]
        public string ComplianceResult{ get; set; }

        /// <summary>
        /// ["",""]
        /// </summary>
        [JsonProperty("Annotation")]
        public Annotation Annotation{ get; set; }

        /// <summary>
        /// Rule evaluation time
        /// Format: YYYY-MM-DD h:i:s
        /// </summary>
        [JsonProperty("ConfigRuleInvokedTime")]
        public string ConfigRuleInvokedTime{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("ConfigRuleId")]
        public string ConfigRuleId{ get; set; }

        /// <summary>
        /// CUSTOMIZE: custom rule
        /// SYSTEM: managed rule
        /// </summary>
        [JsonProperty("IdentifierType")]
        public string IdentifierType{ get; set; }

        /// <summary>
        /// Compliance package ID.
        /// </summary>
        [JsonProperty("CompliancePackId")]
        public string CompliancePackId{ get; set; }

        /// <summary>
        /// Trigger Type
        /// ScheduledNotification: periodic trigger.
        /// ConfigurationItemChangeNotification: Triggered by a change
        /// </summary>
        [JsonProperty("TriggerType")]
        public TriggerType[] TriggerType{ get; set; }

        /// <summary>
        /// Parameter details
        /// </summary>
        [JsonProperty("ManageInputParameter")]
        public InputParameterForManage[] ManageInputParameter{ get; set; }

        /// <summary>
        /// Compliance package name
        /// </summary>
        [JsonProperty("CompliancePackName")]
        public string CompliancePackName{ get; set; }

        /// <summary>
        /// Associated regions.
        /// </summary>
        [JsonProperty("RegionsScope")]
        public string[] RegionsScope{ get; set; }

        /// <summary>
        /// Associated tag
        /// </summary>
        [JsonProperty("TagsScope")]
        public Tag[] TagsScope{ get; set; }

        /// <summary>
        ///  The rule is invalid for the specified resource ID, meaning that evaluation will not be performed on this resource.
        /// </summary>
        [JsonProperty("ExcludeResourceIdsScope")]
        public string[] ExcludeResourceIdsScope{ get; set; }

        /// <summary>
        /// Account group ID.
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public string AccountGroupId{ get; set; }

        /// <summary>
        /// Account group name.
        /// </summary>
        [JsonProperty("AccountGroupName")]
        public string AccountGroupName{ get; set; }

        /// <summary>
        /// Rule owner user ID.
        /// </summary>
        [JsonProperty("RuleOwnerId")]
        public ulong? RuleOwnerId{ get; set; }

        /// <summary>
        /// Trigger methods supported by preset rules.
        /// ScheduledNotification: periodic trigger
        /// ConfigurationItemChangeNotification: Triggered by a change
        /// </summary>
        [JsonProperty("ManageTriggerType")]
        public string[] ManageTriggerType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "InputParameter.", this.InputParameter);
            this.SetParamArrayObj(map, prefix + "SourceCondition.", this.SourceCondition);
            this.SetParamArraySimple(map, prefix + "ResourceType.", this.ResourceType);
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "ServiceFunction", this.ServiceFunction);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ComplianceResult", this.ComplianceResult);
            this.SetParamObj(map, prefix + "Annotation.", this.Annotation);
            this.SetParamSimple(map, prefix + "ConfigRuleInvokedTime", this.ConfigRuleInvokedTime);
            this.SetParamSimple(map, prefix + "ConfigRuleId", this.ConfigRuleId);
            this.SetParamSimple(map, prefix + "IdentifierType", this.IdentifierType);
            this.SetParamSimple(map, prefix + "CompliancePackId", this.CompliancePackId);
            this.SetParamArrayObj(map, prefix + "TriggerType.", this.TriggerType);
            this.SetParamArrayObj(map, prefix + "ManageInputParameter.", this.ManageInputParameter);
            this.SetParamSimple(map, prefix + "CompliancePackName", this.CompliancePackName);
            this.SetParamArraySimple(map, prefix + "RegionsScope.", this.RegionsScope);
            this.SetParamArrayObj(map, prefix + "TagsScope.", this.TagsScope);
            this.SetParamArraySimple(map, prefix + "ExcludeResourceIdsScope.", this.ExcludeResourceIdsScope);
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamSimple(map, prefix + "AccountGroupName", this.AccountGroupName);
            this.SetParamSimple(map, prefix + "RuleOwnerId", this.RuleOwnerId);
            this.SetParamArraySimple(map, prefix + "ManageTriggerType.", this.ManageTriggerType);
        }
    }
}

