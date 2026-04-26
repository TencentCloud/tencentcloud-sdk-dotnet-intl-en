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

    public class AllocationOverviewDetail : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of a cost allocation unit
        /// </summary>
        [JsonProperty("TreeNodeUniqKey")]
        public string TreeNodeUniqKey{ get; set; }

        /// <summary>
        /// Name of a cost allocation unit
        /// </summary>
        [JsonProperty("TreeNodeUniqKeyName")]
        public string TreeNodeUniqKeyName{ get; set; }

        /// <summary>
        /// Date: Settlement date
        /// </summary>
        [JsonProperty("BillDate")]
        public string BillDate{ get; set; }

        /// <summary>
        /// Collected fees (cash): Cash directly collected to the cost allocation unit based on the collection rules
        /// </summary>
        [JsonProperty("GatherCashPayAmount")]
        public string GatherCashPayAmount{ get; set; }

        /// <summary>
        /// Collected fees (voucher): Resource vouchers directly collected to the cost allocation unit based on the collection rules
        /// </summary>
        [JsonProperty("GatherVoucherPayAmount")]
        public string GatherVoucherPayAmount{ get; set; }

        /// <summary>
        /// Collected fees (free credit): Resource free credit directly collected to the cost allocation unit based on the collection rules
        /// </summary>
        [JsonProperty("GatherIncentivePayAmount")]
        public string GatherIncentivePayAmount{ get; set; }

        /// <summary>
        /// Collected fees (royalty amount): Resource royalty amount directly collected to the cost allocation unit based on the collection rules
        /// </summary>
        [JsonProperty("GatherTransferPayAmount")]
        public string GatherTransferPayAmount{ get; set; }

        /// <summary>
        /// Allocated fees (cash): Resource cash allocated to the cost allocation unit based on the allocation rules
        /// </summary>
        [JsonProperty("AllocateCashPayAmount")]
        public string AllocateCashPayAmount{ get; set; }

        /// <summary>
        /// Allocated fees (voucher): Resource vouchers allocated to the cost allocation unit based on the allocation rules
        /// </summary>
        [JsonProperty("AllocateVoucherPayAmount")]
        public string AllocateVoucherPayAmount{ get; set; }

        /// <summary>
        /// Allocated fees (free credit): Resource free credit allocated to the cost allocation unit based on the allocation rules
        /// </summary>
        [JsonProperty("AllocateIncentivePayAmount")]
        public string AllocateIncentivePayAmount{ get; set; }

        /// <summary>
        /// Allocated fees (royalty amount): Resource royalty amount allocated to the cost allocation unit based on the allocation rules
        /// </summary>
        [JsonProperty("AllocateTransferPayAmount")]
        public string AllocateTransferPayAmount{ get; set; }

        /// <summary>
        /// Total fees (cash): Total fees of the cost allocation unit, Collected Fees (Cash) + Allocated Fees (Cash)
        /// </summary>
        [JsonProperty("TotalCashPayAmount")]
        public string TotalCashPayAmount{ get; set; }

        /// <summary>
        /// Total fees (voucher): Total fees of the cost allocation unit, Collected Fees (Voucher) + Allocated Fees (Voucher)
        /// </summary>
        [JsonProperty("TotalVoucherPayAmount")]
        public string TotalVoucherPayAmount{ get; set; }

        /// <summary>
        /// Total fees (free credit): Total fees of the cost allocation unit, Collected Fees (Free Credit) + Allocated Fees (Free Credit)
        /// </summary>
        [JsonProperty("TotalIncentivePayAmount")]
        public string TotalIncentivePayAmount{ get; set; }

        /// <summary>
        /// Total fees (royalty amount): Total fees of the cost allocation unit, Collected Fees (Royalty Amount) + Allocated Fees (Royalty Amount)
        /// </summary>
        [JsonProperty("TotalTransferPayAmount")]
        public string TotalTransferPayAmount{ get; set; }

        /// <summary>
        /// Collected fees (discounted total): Total resource amount after discount directly collected to the cost allocation unit based on the collection rules
        /// </summary>
        [JsonProperty("GatherRealCost")]
        public string GatherRealCost{ get; set; }

        /// <summary>
        /// Allocated fees (discounted total): Total resource amount after discount directly allocated to the cost allocation unit based on the allocation rules
        /// </summary>
        [JsonProperty("AllocateRealCost")]
        public string AllocateRealCost{ get; set; }

        /// <summary>
        /// Total fees (discounted total): Total fees of the cost allocation unit, Collected Fees (discounted total) + Allocated Fees (discounted total)
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

        /// <summary>
        /// Proportion (discounted total): Total fees (discounted total) of the Cost Allocation Unit/Total Fees (discounted total) * 100%
        /// </summary>
        [JsonProperty("Ratio")]
        public string Ratio{ get; set; }

        /// <summary>
        /// Month-on-month ratio (discounted total): [Total fees (discounted total) of the cost allocation unit in this month - Total fees (discounted total) of the cost allocation unit in the previous month]/Total fees (discounted total) of the cost allocation unit in the previous month * 100%
        /// </summary>
        [JsonProperty("Trend")]
        public string Trend{ get; set; }

        /// <summary>
        /// Sequential Comparison Arrow
        /// upward - Upward
        /// downward - Downward
        /// none - Stable
        /// </summary>
        [JsonProperty("TrendType")]
        public string TrendType{ get; set; }

        /// <summary>
        /// GatherCostBeforeTax
        /// </summary>
        [JsonProperty("GatherCostBeforeTax")]
        public string GatherCostBeforeTax{ get; set; }

        /// <summary>
        /// AllocateCostBeforeTax
        /// </summary>
        [JsonProperty("AllocateCostBeforeTax")]
        public string AllocateCostBeforeTax{ get; set; }

        /// <summary>
        /// TotalCostBeforeTax
        /// </summary>
        [JsonProperty("TotalCostBeforeTax")]
        public string TotalCostBeforeTax{ get; set; }

        /// <summary>
        /// GatherTax
        /// </summary>
        [JsonProperty("GatherTax")]
        public string GatherTax{ get; set; }

        /// <summary>
        /// AllocateTax
        /// </summary>
        [JsonProperty("AllocateTax")]
        public string AllocateTax{ get; set; }

        /// <summary>
        /// TotalTax
        /// </summary>
        [JsonProperty("TotalTax")]
        public string TotalTax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TreeNodeUniqKey", this.TreeNodeUniqKey);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKeyName", this.TreeNodeUniqKeyName);
            this.SetParamSimple(map, prefix + "BillDate", this.BillDate);
            this.SetParamSimple(map, prefix + "GatherCashPayAmount", this.GatherCashPayAmount);
            this.SetParamSimple(map, prefix + "GatherVoucherPayAmount", this.GatherVoucherPayAmount);
            this.SetParamSimple(map, prefix + "GatherIncentivePayAmount", this.GatherIncentivePayAmount);
            this.SetParamSimple(map, prefix + "GatherTransferPayAmount", this.GatherTransferPayAmount);
            this.SetParamSimple(map, prefix + "AllocateCashPayAmount", this.AllocateCashPayAmount);
            this.SetParamSimple(map, prefix + "AllocateVoucherPayAmount", this.AllocateVoucherPayAmount);
            this.SetParamSimple(map, prefix + "AllocateIncentivePayAmount", this.AllocateIncentivePayAmount);
            this.SetParamSimple(map, prefix + "AllocateTransferPayAmount", this.AllocateTransferPayAmount);
            this.SetParamSimple(map, prefix + "TotalCashPayAmount", this.TotalCashPayAmount);
            this.SetParamSimple(map, prefix + "TotalVoucherPayAmount", this.TotalVoucherPayAmount);
            this.SetParamSimple(map, prefix + "TotalIncentivePayAmount", this.TotalIncentivePayAmount);
            this.SetParamSimple(map, prefix + "TotalTransferPayAmount", this.TotalTransferPayAmount);
            this.SetParamSimple(map, prefix + "GatherRealCost", this.GatherRealCost);
            this.SetParamSimple(map, prefix + "AllocateRealCost", this.AllocateRealCost);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "Trend", this.Trend);
            this.SetParamSimple(map, prefix + "TrendType", this.TrendType);
            this.SetParamSimple(map, prefix + "GatherCostBeforeTax", this.GatherCostBeforeTax);
            this.SetParamSimple(map, prefix + "AllocateCostBeforeTax", this.AllocateCostBeforeTax);
            this.SetParamSimple(map, prefix + "TotalCostBeforeTax", this.TotalCostBeforeTax);
            this.SetParamSimple(map, prefix + "GatherTax", this.GatherTax);
            this.SetParamSimple(map, prefix + "AllocateTax", this.AllocateTax);
            this.SetParamSimple(map, prefix + "TotalTax", this.TotalTax);
        }
    }
}

