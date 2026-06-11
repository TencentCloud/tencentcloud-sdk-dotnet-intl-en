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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class K8sApiAbnormalRuleListItem : AbstractModel
    {
        
        /// <summary>
        /// Whether take effect on all clusters. true indicates all clusters take effect. false indicates only specified clusters take effect.
        /// </summary>
        [JsonProperty("EffectAllCluster")]
        public bool? EffectAllCluster{ get; set; }

        /// <summary>
        /// Total number of affected clusters
        /// </summary>
        [JsonProperty("EffectClusterCount")]
        public ulong? EffectClusterCount{ get; set; }

        /// <summary>
        /// Edit account
        /// </summary>
        [JsonProperty("OprUin")]
        public string OprUin{ get; set; }

        /// <summary>
        /// Deduplicated list of ALL execution actions in the rule group. The present blocklist contains only RULE_MODE_ALERT (Alert).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleActions")]
        public string[] RuleActions{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// Subrule content list, deserialized from rule_details JSON
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleInfoList")]
        public K8sApiAbnormalRuleScopeInfo[] RuleInfoList{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule type
        /// RT_SYSTEM System rules
        /// RT_USER User defined
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EffectAllCluster", this.EffectAllCluster);
            this.SetParamSimple(map, prefix + "EffectClusterCount", this.EffectClusterCount);
            this.SetParamSimple(map, prefix + "OprUin", this.OprUin);
            this.SetParamArraySimple(map, prefix + "RuleActions.", this.RuleActions);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArrayObj(map, prefix + "RuleInfoList.", this.RuleInfoList);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

