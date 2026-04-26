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

    public class AllocationSummaryByBusiness : AbstractModel
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
        /// Total fees (cash): Total fees of the cost allocation unit, Collected Fees (Cash) + Allocated fees (Cash)
        /// </summary>
        [JsonProperty("TotalCashPayAmount")]
        public string TotalCashPayAmount{ get; set; }

        /// <summary>
        /// Total fees (voucher): Total fees of the cost allocation unit, Collected Fees (Vouchers) + Allocated fees (Vouchers)
        /// </summary>
        [JsonProperty("TotalVoucherPayAmount")]
        public string TotalVoucherPayAmount{ get; set; }

        /// <summary>
        /// Total fees (free credit): Total fees of the cost allocation unit, Collected Fees (Free Credit) + Allocated fees (Free Credit)
        /// </summary>
        [JsonProperty("TotalIncentivePayAmount")]
        public string TotalIncentivePayAmount{ get; set; }

        /// <summary>
        /// Total fees (royalty amount): Total fees of the cost allocation unit, Collected Fees (Royalty Amount) + Allocated fees (Royalty Amount)
        /// </summary>
        [JsonProperty("TotalTransferPayAmount")]
        public string TotalTransferPayAmount{ get; set; }

        /// <summary>
        /// Collected fees (discounted total): Total resource amount after discount directly collected to the cost allocation unit based on the collection rules
        /// </summary>
        [JsonProperty("GatherRealCost")]
        public string GatherRealCost{ get; set; }

        /// <summary>
        /// Allocated fees (discounted total): Total resource amount after discount allocated to the cost allocation unit based on the allocation rules
        /// </summary>
        [JsonProperty("AllocateRealCost")]
        public string AllocateRealCost{ get; set; }

        /// <summary>
        /// Total fees (discounted total): Total fees of the cost allocation unit, Collected Fees (discounted total) + Allocated fees (discounted total)
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
        /// Product code
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Product name: Various cloud products purchased by users
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// Original price of a component: Original Price = Component List Price * Component Usage * Duration of Use (not displayed if the customer enjoys a fixed price/contract price, and not displayed by default in refund scenarios), specified price mode
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// Original price deducted by a reserved instance: The original price of a component deducted by reserved instances for this product or service
        /// </summary>
        [JsonProperty("RICost")]
        public string RICost{ get; set; }

        /// <summary>
        /// Savings plan deduction from original price: Savings Plan Deduction from Original Price = Monetary Value of Savings Plan Deduction/ Savings Plan Deduction Rate
        /// </summary>
        [JsonProperty("SPCost")]
        public string SPCost{ get; set; }

        /// <summary>
        /// Cash account expenditure (CNY): The amount paid through the cash account
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// Promo voucher expenditure (CNY): The amount paid using various vouchers (such as promo vouchers and cash vouchers)
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// Gift account expenditure (CNY): The amount paid using free credits
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// Royalty account expenditure (CNY): The amount paid through the royalty account
        /// </summary>
        [JsonProperty("TransferPayAmount")]
        public string TransferPayAmount{ get; set; }

        /// <summary>
        /// Discounted total: discounted total = (Original Price - Original Price Deducted by a Reserved Instance - Savings Plan Deduction from Original Price) * Discount Rate
        /// </summary>
        [JsonProperty("AllocationRealTotalCost")]
        public string AllocationRealTotalCost{ get; set; }

        /// <summary>
        /// Collected fees (tax): Tax directly collected to the cost allocation unit based on the collection rules
        /// </summary>
        [JsonProperty("GatherTax")]
        public string GatherTax{ get; set; }

        /// <summary>
        /// Allocated fees (tax): Resource tax allocated to the cost allocation unit based on the allocation rules
        /// </summary>
        [JsonProperty("AllocateTax")]
        public string AllocateTax{ get; set; }

        /// <summary>
        /// Total fees (tax): Total fees of the cost allocation unit, Collected Fees (Tax) + Allocated fees (Tax)
        /// </summary>
        [JsonProperty("TotalTax")]
        public string TotalTax{ get; set; }

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
        /// Tax
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// CostBeforeTax
        /// </summary>
        [JsonProperty("CostBeforeTax")]
        public string CostBeforeTax{ get; set; }


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
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "RICost", this.RICost);
            this.SetParamSimple(map, prefix + "SPCost", this.SPCost);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "AllocationRealTotalCost", this.AllocationRealTotalCost);
            this.SetParamSimple(map, prefix + "GatherTax", this.GatherTax);
            this.SetParamSimple(map, prefix + "AllocateTax", this.AllocateTax);
            this.SetParamSimple(map, prefix + "TotalTax", this.TotalTax);
            this.SetParamSimple(map, prefix + "GatherCostBeforeTax", this.GatherCostBeforeTax);
            this.SetParamSimple(map, prefix + "AllocateCostBeforeTax", this.AllocateCostBeforeTax);
            this.SetParamSimple(map, prefix + "TotalCostBeforeTax", this.TotalCostBeforeTax);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "CostBeforeTax", this.CostBeforeTax);
        }
    }
}

