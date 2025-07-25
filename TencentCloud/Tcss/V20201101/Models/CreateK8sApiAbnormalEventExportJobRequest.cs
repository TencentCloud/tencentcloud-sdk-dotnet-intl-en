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

    public class CreateK8sApiAbnormalEventExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Filters.
        /// <li>TimeRange - String - Optional - Time range. Example: ["2022-03-31 16:55:00", "2022-03-31 17:00:00"]</li>
        /// <li>`MatchRules` - String - Optional - Hit rule</li>
        /// <li>`RiskLevel` - String - Optional - Threat level</li>
        /// <li>`Status` - String - Optional - Event status</li>
        /// <li>`MatchRuleType` - String - Optional - Hit rule type</li>
        /// <li>`ClusterRunningStatus` - String - Optional - Cluster running status</li>
        /// <li>`ClusterName` - String - Optional - Cluster name</li>
        /// <li>`ClusterID` - String - Optional - Cluster ID</li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// Sort order
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// Export field
        /// </summary>
        [JsonProperty("ExportField")]
        public string[] ExportField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamArraySimple(map, prefix + "ExportField.", this.ExportField);
        }
    }
}

