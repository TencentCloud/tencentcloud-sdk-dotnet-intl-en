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

    public class K8sApiAbnormalRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// Rule information list
        /// </summary>
        [JsonProperty("RuleInfoList")]
        public K8sApiAbnormalRuleScopeInfo[] RuleInfoList{ get; set; }

        /// <summary>
        /// Effective cluster IDSet
        /// </summary>
        [JsonProperty("EffectClusterIDSet")]
        public string[] EffectClusterIDSet{ get; set; }

        /// <summary>
        /// Rule type
        /// RT_SYSTEM: System rules
        /// RT_USER: User-defined rules
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Whether all clusters are effective
        /// </summary>
        [JsonProperty("EffectAllCluster")]
        public bool? EffectAllCluster{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "RuleInfoList.", this.RuleInfoList);
            this.SetParamArraySimple(map, prefix + "EffectClusterIDSet.", this.EffectClusterIDSet);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "EffectAllCluster", this.EffectAllCluster);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
        }
    }
}

