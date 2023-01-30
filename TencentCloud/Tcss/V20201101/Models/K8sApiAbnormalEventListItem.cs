/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class K8sApiAbnormalEventListItem : AbstractModel
    {
        
        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// Hit rule type
        /// </summary>
        [JsonProperty("MatchRuleType")]
        public string MatchRuleType{ get; set; }

        /// <summary>
        /// Threat level
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Cluster running status
        /// </summary>
        [JsonProperty("ClusterRunningStatus")]
        public string ClusterRunningStatus{ get; set; }

        /// <summary>
        /// First creation time
        /// </summary>
        [JsonProperty("FirstCreateTime")]
        public string FirstCreateTime{ get; set; }

        /// <summary>
        /// Last creation time
        /// </summary>
        [JsonProperty("LastCreateTime")]
        public string LastCreateTime{ get; set; }

        /// <summary>
        /// Number of alarms
        /// </summary>
        [JsonProperty("AlarmCount")]
        public ulong? AlarmCount{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Rule type
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Solution
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Hit rule
        /// </summary>
        [JsonProperty("MatchRule")]
        public K8sApiAbnormalRuleScopeInfo MatchRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "MatchRuleType", this.MatchRuleType);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterRunningStatus", this.ClusterRunningStatus);
            this.SetParamSimple(map, prefix + "FirstCreateTime", this.FirstCreateTime);
            this.SetParamSimple(map, prefix + "LastCreateTime", this.LastCreateTime);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamObj(map, prefix + "MatchRule.", this.MatchRule);
        }
    }
}

