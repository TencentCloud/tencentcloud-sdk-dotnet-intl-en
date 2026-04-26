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

    public class TagSummaryOverviewItem : AbstractModel
    {
        
        /// <summary>
        /// Tag value
        /// </summary>
        [JsonProperty("TagValue")]
        public string TagValue{ get; set; }

        /// <summary>
        /// Percentage of the fee, with 2 decimal places.
        /// </summary>
        [JsonProperty("RealTotalCostRatio")]
        public string RealTotalCostRatio{ get; set; }

        /// <summary>
        /// discounted total price
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

        /// <summary>
        /// Cash account expenditure: The amount paid through the cash account
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// Gift account expenditure: The amount paid using free credits
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// Coupon expenditure: The amount paid using various vouchers (such as vouchers and cash vouchers)
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// Royalty account expenditure: The amount paid through the royalty account
        /// </summary>
        [JsonProperty("TransferPayAmount")]
        public string TransferPayAmount{ get; set; }

        /// <summary>
        /// Original price in CNY. The TotalCost field comes into effect after bill 3.0 (May 2021) and returns "-" before bill 3.0. In the current situation of contract price, the TotalCost field returns "-" if a price difference exists with the official website price.
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TagValue", this.TagValue);
            this.SetParamSimple(map, prefix + "RealTotalCostRatio", this.RealTotalCostRatio);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
        }
    }
}

