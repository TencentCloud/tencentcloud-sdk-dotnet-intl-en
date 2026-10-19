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

    public class ListConfigRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of entries per page.
        /// Valid values: 1-200
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Offset.
        /// Value range: minimum value is 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Sorting type (rule name).
        /// - desc: descending order.
        /// asc: ascending order.
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// Risk level.
        /// 1: High-risk
        /// 2: Medium-risk,
        /// 3: Low risk.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong?[] RiskLevel{ get; set; }

        /// <summary>
        /// Rule Status.
        /// ACTIVE: enable
        /// UN_ACTIVE: Disabled
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Assessment result.
        /// COMPLIANT: compliant
        /// NON_COMPLIANT: non-compliance
        /// </summary>
        [JsonProperty("ComplianceResult")]
        public string[] ComplianceResult{ get; set; }

        /// <summary>
        /// Rule Name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamArraySimple(map, prefix + "RiskLevel.", this.RiskLevel);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArraySimple(map, prefix + "ComplianceResult.", this.ComplianceResult);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
        }
    }
}

