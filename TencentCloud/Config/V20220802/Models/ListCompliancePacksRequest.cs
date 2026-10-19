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

    public class ListCompliancePacksRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Quantity.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Offset.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Compliance package name.</p>
        /// </summary>
        [JsonProperty("CompliancePackName")]
        public string CompliancePackName{ get; set; }

        /// <summary>
        /// <p>Risk level. Valid values:<br>1: high-risk<br>2: medium-risk<br>3: low risk</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong?[] RiskLevel{ get; set; }

        /// <summary>
        /// <p>Compliance package status. Valid values: ACTIVE (active) and NO_ACTIVE (inactive).</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Evaluation status. Valid values: &#39;COMPLIANT&#39 (compliant)<br>&#39;NON_COMPLIANT&#39 (non-compliant)</p>
        /// </summary>
        [JsonProperty("ComplianceResult")]
        public string[] ComplianceResult{ get; set; }

        /// <summary>
        /// <p>Sorting type. Valid values: desc (descending) and asc (ascending).</p>
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// <p>Contains compliance pack rule statistical information</p><p>Enumeration values:</p><ul><li>1: Yes</li></ul>
        /// </summary>
        [JsonProperty("IncludeCompliancePackRuleResult")]
        public string IncludeCompliancePackRuleResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "CompliancePackName", this.CompliancePackName);
            this.SetParamArraySimple(map, prefix + "RiskLevel.", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "ComplianceResult.", this.ComplianceResult);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "IncludeCompliancePackRuleResult", this.IncludeCompliancePackRuleResult);
        }
    }
}

