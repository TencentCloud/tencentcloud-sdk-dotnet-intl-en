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

    public class AnalyseConditions : AbstractModel
    {
        
        /// <summary>
        /// Product name code
        /// </summary>
        [JsonProperty("BusinessCodes")]
        public string BusinessCodes{ get; set; }

        /// <summary>
        /// Subproduct name code
        /// </summary>
        [JsonProperty("ProductCodes")]
        public string ProductCodes{ get; set; }

        /// <summary>
        /// Component type code
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// Availability zone ID: The availability zone ID where the resource is located.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string ZoneIds{ get; set; }

        /// <summary>
        /// Region ID: Resource region ID
        /// </summary>
        [JsonProperty("RegionIds")]
        public string RegionIds{ get; set; }

        /// <summary>
        /// Project ID: Project ID of the resource
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string ProjectIds{ get; set; }

        /// <summary>
        /// Billing mode prePay (monthly subscription)/postPay (pay-as-you-go billing)
        /// </summary>
        [JsonProperty("PayModes")]
        public string PayModes{ get; set; }

        /// <summary>
        /// Transaction type. Query transaction type (please use transaction type code as input parameter).
        /// </summary>
        [JsonProperty("ActionTypes")]
        public string ActionTypes{ get; set; }

        /// <summary>
        /// Cost allocation tag key
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// Fee type. Query fee type (please use fee type code input parameter). The input parameter enumeration is as follows:
        /// cashPayAmount: Cash 
        /// incentivePayAmount: Bonus 
        /// voucherPayAmount: Coupon 
        /// tax: tax. 
        /// costBeforeTax: pre-tax price
        /// </summary>
        [JsonProperty("FeeType")]
        public string FeeType{ get; set; }

        /// <summary>
        /// User UIN for querying cost analysis data
        /// </summary>
        [JsonProperty("PayerUins")]
        public string PayerUins{ get; set; }

        /// <summary>
        /// User UIN for using resources
        /// </summary>
        [JsonProperty("OwnerUins")]
        public string OwnerUins{ get; set; }

        /// <summary>
        /// Consumption type. Query consumption type (please use consumption type code input parameter).
        /// </summary>
        [JsonProperty("ConsumptionTypes")]
        public string ConsumptionTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessCodes", this.BusinessCodes);
            this.SetParamSimple(map, prefix + "ProductCodes", this.ProductCodes);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ZoneIds", this.ZoneIds);
            this.SetParamSimple(map, prefix + "RegionIds", this.RegionIds);
            this.SetParamSimple(map, prefix + "ProjectIds", this.ProjectIds);
            this.SetParamSimple(map, prefix + "PayModes", this.PayModes);
            this.SetParamSimple(map, prefix + "ActionTypes", this.ActionTypes);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamSimple(map, prefix + "PayerUins", this.PayerUins);
            this.SetParamSimple(map, prefix + "OwnerUins", this.OwnerUins);
            this.SetParamSimple(map, prefix + "ConsumptionTypes", this.ConsumptionTypes);
        }
    }
}

