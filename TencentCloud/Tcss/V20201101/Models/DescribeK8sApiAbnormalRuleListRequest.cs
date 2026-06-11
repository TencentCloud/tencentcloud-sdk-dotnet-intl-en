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

    public class DescribeK8sApiAbnormalRuleListRequest : AbstractModel
    {
        
        /// <summary>
        /// Sorting field.
        /// <li>`UpdateTime` - String - Optional - Last updated</li>
        /// <li>`EffectClusterCount` - String - Optional - Number of clusters affected</li>
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>RuleType - string - required: no - rule type</li>
        /// <li>Status - string - required: no - status</li>
        /// <li>RuleName - string - required: no - rule name (fuzzy query)</li>
        /// <li>ClusterName - string - Required: No - Cluster name. Fuzzy search for rules bound to the cluster (including full cluster rules).</li>
        /// <li>ClusterID - string - Required: No - Cluster ID. Fuzzy search for rules bound to the cluster (including cluster rules).</li>
        /// <li>RuleAction - string - Required: No - Execution action filter. Value: RULE_MODE_ALERT (alert), RULE_MODE_HOLDUP (intercept)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// The number of results returned. Default value: 10. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sort order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

