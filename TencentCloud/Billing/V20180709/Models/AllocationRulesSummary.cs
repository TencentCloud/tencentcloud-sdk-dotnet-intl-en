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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocationRulesSummary : AbstractModel
    {
        
        /// <summary>
        /// Add new sharing rule name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Specifies the sharing rule policy type. the enumeration values are as follows:.
        /// 1 - custom sharing proportion. 
        /// 2 - proportional allocation.
        /// 3 - allocation by proportion.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Sharing rule expression.
        /// </summary>
        [JsonProperty("RuleDetail")]
        public AllocationRuleExpression RuleDetail{ get; set; }

        /// <summary>
        /// Sharing proportion expression, allocation by proportion not passed.
        /// </summary>
        [JsonProperty("RatioDetail")]
        public AllocationRationExpression[] RatioDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "RuleDetail.", this.RuleDetail);
            this.SetParamArrayObj(map, prefix + "RatioDetail.", this.RatioDetail);
        }
    }
}

