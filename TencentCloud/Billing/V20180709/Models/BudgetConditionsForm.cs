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

    public class BudgetConditionsForm : AbstractModel
    {
        
        /// <summary>
        /// <p>Product.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Business")]
        public string[] Business{ get; set; }

        /// <summary>
        /// <p>Billing mode</p><p>Enumeration value:</p><ul><li>prePay: Monthly Subscription</li><li>postPay: Pay-As-You-Go</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayMode")]
        public string[] PayMode{ get; set; }

        /// <summary>
        /// <p>Subproduct</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductCodes")]
        public string[] ProductCodes{ get; set; }

        /// <summary>
        /// <p>Component code</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentCodes")]
        public string[] ComponentCodes{ get; set; }

        /// <summary>
        /// <p>Region.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>AZ.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionIds")]
        public string[] RegionIds{ get; set; }

        /// <summary>
        /// <p>Project</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string[] ProjectIds{ get; set; }

        /// <summary>
        /// <p>Transaction type</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionTypes")]
        public string[] ActionTypes{ get; set; }

        /// <summary>
        /// <p>Consumption type</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumptionTypes")]
        public string[] ConsumptionTypes{ get; set; }

        /// <summary>
        /// <p>Tag.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public TagsForm[] Tags{ get; set; }

        /// <summary>
        /// <p>Leaf-level cost allocation unit</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayerUins")]
        public string[] PayerUins{ get; set; }

        /// <summary>
        /// <p>Primary user Uin</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OwnerUins")]
        public string[] OwnerUins{ get; set; }

        /// <summary>
        /// <p>Unique key of the leaf-level cost allocation unit</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TreeNodeUniqKeys")]
        public string[] TreeNodeUniqKeys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Business.", this.Business);
            this.SetParamArraySimple(map, prefix + "PayMode.", this.PayMode);
            this.SetParamArraySimple(map, prefix + "ProductCodes.", this.ProductCodes);
            this.SetParamArraySimple(map, prefix + "ComponentCodes.", this.ComponentCodes);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "RegionIds.", this.RegionIds);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "ActionTypes.", this.ActionTypes);
            this.SetParamArraySimple(map, prefix + "ConsumptionTypes.", this.ConsumptionTypes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "PayerUins.", this.PayerUins);
            this.SetParamArraySimple(map, prefix + "OwnerUins.", this.OwnerUins);
            this.SetParamArraySimple(map, prefix + "TreeNodeUniqKeys.", this.TreeNodeUniqKeys);
        }
    }
}

