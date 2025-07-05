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

    public class AllocationRuleExpression : AbstractModel
    {
        
        /// <summary>
        /// RuleKey: cost allocation dimension.
        /// Enumeration value.
        /// ownerUin - user UIN.
        /// Operator UIN.
        /// businessCode - product-level code.
        /// productCode - 2-tier product code.
        /// itemCode - 4-tier product code.
        /// projectId - specifies the project ID.
        /// regionId.
        /// resourceId - specifies the resource ID.
        /// tag - tag key-value pair.
        /// payMode - billing mode.
        /// instanceType - instance type.
        /// actionType - transaction type.
        /// </summary>
        [JsonProperty("RuleKey")]
        public string RuleKey{ get; set; }

        /// <summary>
        /// Specifies the dimension rules for cost allocation.
        /// Enumeration value.
        /// in.
        /// not in.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Cost allocation dimension value. for example, when RuleKey is businessCode, ["p_cbs","p_sqlserver"] indicates the cost of products at the "p_cbs","p_sqlserver" level.
        /// </summary>
        [JsonProperty("RuleValue")]
        public string[] RuleValue{ get; set; }

        /// <summary>
        /// Logical connection for cost allocation, enumeration values are as follows:.
        /// Create and bind a policy query an instance reset the access password of an instance.
        /// Create and bind a policy query an instance reset the access password of an instance.
        /// </summary>
        [JsonProperty("Connectors")]
        public string Connectors{ get; set; }

        /// <summary>
        /// Nested rule.
        /// </summary>
        [JsonProperty("Children")]
        public AllocationRuleExpression[] Children{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleKey", this.RuleKey);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamArraySimple(map, prefix + "RuleValue.", this.RuleValue);
            this.SetParamSimple(map, prefix + "Connectors", this.Connectors);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
        }
    }
}

