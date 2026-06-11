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

    public class K8sApiAbnormalEventInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Hit rule name.</p>
        /// </summary>
        [JsonProperty("MatchRuleName")]
        public string MatchRuleName{ get; set; }

        /// <summary>
        /// <p>Hit rule type.</p>
        /// </summary>
        [JsonProperty("MatchRuleType")]
        public string MatchRuleType{ get; set; }

        /// <summary>
        /// <p>Alarm level.</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Cluster running status: CSR_RUNNING, CSR_EXCEPTION, and CSR_CREATING</p>
        /// </summary>
        [JsonProperty("ClusterRunningStatus")]
        public string ClusterRunningStatus{ get; set; }

        /// <summary>
        /// <p>Initial generation time.</p>
        /// </summary>
        [JsonProperty("FirstCreateTime")]
        public string FirstCreateTime{ get; set; }

        /// <summary>
        /// <p>Last generation time.</p>
        /// </summary>
        [JsonProperty("LastCreateTime")]
        public string LastCreateTime{ get; set; }

        /// <summary>
        /// <p>Number of alarms.</p>
        /// </summary>
        [JsonProperty("AlarmCount")]
        public ulong? AlarmCount{ get; set; }

        /// <summary>
        /// <p>Status.<br>&quot;EVENT_UNDEAL&quot;: unhandled<br>&quot;EVENT_DEALED&quot;: handled<br>&quot;EVENT_IGNORE&quot;: ignored<br>&quot;EVENT_DEL&quot;: deleted<br>&quot;EVENT_ADD_WHITE&quot;: allowlisted</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Cluster master IP address.</p>
        /// </summary>
        [JsonProperty("ClusterMasterIP")]
        public string ClusterMasterIP{ get; set; }

        /// <summary>
        /// <p>K8s version.</p>
        /// </summary>
        [JsonProperty("K8sVersion")]
        public string K8sVersion{ get; set; }

        /// <summary>
        /// <p>Runtime component.</p>
        /// </summary>
        [JsonProperty("RunningComponent")]
        public string[] RunningComponent{ get; set; }

        /// <summary>
        /// <p>Description.</p>
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// <p>Suggestion.</p>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// <p>Request information.</p>
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }

        /// <summary>
        /// <p>Rule ID.</p>
        /// </summary>
        [JsonProperty("MatchRuleID")]
        public string MatchRuleID{ get; set; }

        /// <summary>
        /// <p>Array of highlighted fields.</p>
        /// </summary>
        [JsonProperty("HighLightFields")]
        public string[] HighLightFields{ get; set; }

        /// <summary>
        /// <p>Hit rule.</p>
        /// </summary>
        [JsonProperty("MatchRule")]
        public K8sApiAbnormalRuleScopeInfo MatchRule{ get; set; }

        /// <summary>
        /// <p>Hit rule content corresponding to highlighted fields (JSON string, such as {&quot;field1&quot;:&quot;value1&quot;,&quot;field2&quot;:&quot;value2&quot;})</p><p>Parameter format: {&quot;field1&quot;:&quot;value1&quot;,&quot;field2&quot;:&quot;value2&quot;}</p>
        /// </summary>
        [JsonProperty("HighLightFieldsVal")]
        public string HighLightFieldsVal{ get; set; }

        /// <summary>
        /// <p>Rule type.</p>
        /// </summary>
        [JsonProperty("RuleTypeZH")]
        public string RuleTypeZH{ get; set; }


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
            this.SetParamSimple(map, prefix + "HighLightFieldsVal", this.HighLightFieldsVal);
            this.SetParamSimple(map, prefix + "RuleTypeZH", this.RuleTypeZH);
        }
    }
}

