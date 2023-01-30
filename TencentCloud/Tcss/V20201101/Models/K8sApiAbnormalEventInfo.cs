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

    public class K8sApiAbnormalEventInfo : AbstractModel
    {
        
        /// <summary>
        /// Hit rule name
        /// </summary>
        [JsonProperty("MatchRuleName")]
        public string MatchRuleName{ get; set; }

        /// <summary>
        /// Hit rule type
        /// </summary>
        [JsonProperty("MatchRuleType")]
        public string MatchRuleType{ get; set; }

        /// <summary>
        /// Alarm level
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
        /// `EVENT_UNDEAL`: Unhandled
        /// `EVENT_DEALED`: Handled
        /// `EVENT_IGNORE`: Ignored
        /// `EVENT_DEL`: Deleted
        /// `EVENT_ADD_WHITE`: Added to an allowlist
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The master IP of a cluster
        /// </summary>
        [JsonProperty("ClusterMasterIP")]
        public string ClusterMasterIP{ get; set; }

        /// <summary>
        /// K8s version
        /// </summary>
        [JsonProperty("K8sVersion")]
        public string K8sVersion{ get; set; }

        /// <summary>
        /// Runtime component
        /// </summary>
        [JsonProperty("RunningComponent")]
        public string[] RunningComponent{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Suggestion
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Request information
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("MatchRuleID")]
        public string MatchRuleID{ get; set; }

        /// <summary>
        /// An array of highlighted fields
        /// </summary>
        [JsonProperty("HighLightFields")]
        public string[] HighLightFields{ get; set; }

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
            this.SetParamSimple(map, prefix + "MatchRuleName", this.MatchRuleName);
            this.SetParamSimple(map, prefix + "MatchRuleType", this.MatchRuleType);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterRunningStatus", this.ClusterRunningStatus);
            this.SetParamSimple(map, prefix + "FirstCreateTime", this.FirstCreateTime);
            this.SetParamSimple(map, prefix + "LastCreateTime", this.LastCreateTime);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterMasterIP", this.ClusterMasterIP);
            this.SetParamSimple(map, prefix + "K8sVersion", this.K8sVersion);
            this.SetParamArraySimple(map, prefix + "RunningComponent.", this.RunningComponent);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Info", this.Info);
            this.SetParamSimple(map, prefix + "MatchRuleID", this.MatchRuleID);
            this.SetParamArraySimple(map, prefix + "HighLightFields.", this.HighLightFields);
            this.SetParamObj(map, prefix + "MatchRule.", this.MatchRule);
        }
    }
}

