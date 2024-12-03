/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class BillDetailComponent : AbstractModel
    {
        
        /// <summary>
        /// Component type: The component type of a product or service purchased, such as CVM instance components including CPU and memory.
        /// </summary>
        [JsonProperty("ComponentCodeName")]
        public string ComponentCodeName{ get; set; }

        /// <summary>
        /// Component name: The specific component of a product or service purchased
        /// </summary>
        [JsonProperty("ItemCodeName")]
        public string ItemCodeName{ get; set; }

        /// <summary>
        /// Component list price: The listed unit price of a component. If a customer has applied for a fixed preferential price or contract price, this parameter will not be displayed by default.
        /// </summary>
        [JsonProperty("SinglePrice")]
        public string SinglePrice{ get; set; }

        /// <summary>
        /// Specified price of a component. This parameter has been deprecated.
        /// </summary>
        [JsonProperty("SpecifiedPrice")]
        [System.Obsolete]
        public string SpecifiedPrice{ get; set; }

        /// <summary>
        /// Component price measurement unit: The unit of measurement for a component price, which is composed of USD, usage unit, and duration unit.
        /// </summary>
        [JsonProperty("PriceUnit")]
        public string PriceUnit{ get; set; }

        /// <summary>
        /// Component usage: The actually settled usage of a component, which is "Raw usage - Deducted usage (including packages)".
        /// </summary>
        [JsonProperty("UsedAmount")]
        public string UsedAmount{ get; set; }

        /// <summary>
        /// Component usage unit: The unit of measurement for component usage
        /// </summary>
        [JsonProperty("UsedAmountUnit")]
        public string UsedAmountUnit{ get; set; }

        /// <summary>
        /// Raw usage/duration: The raw usage/duration of a component before deduction. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealTotalMeasure")]
        public string RealTotalMeasure{ get; set; }

        /// <summary>
        /// Deducted usage/duration (including packages): The usage/duration deducted with a package. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeductedMeasure")]
        public string DeductedMeasure{ get; set; }

        /// <summary>
        /// Usage duration: The resource usage duration
        /// </summary>
        [JsonProperty("TimeSpan")]
        public string TimeSpan{ get; set; }

        /// <summary>
        /// Duration unit: The unit of measurement for usage duration
        /// </summary>
        [JsonProperty("TimeUnitName")]
        public string TimeUnitName{ get; set; }

        /// <summary>
        /// Original cost: The original cost of a resource, which is "List price x Usage x Usage duration". If a customer has applied for a fixed preferential price or contract price or is in a refund scenario, this parameter will not be displayed by default.
        /// </summary>
        [JsonProperty("Cost")]
        public string Cost{ get; set; }

        /// <summary>
        /// Discount multiplier: The discount multiplier applied to the cost of the resource. If a customer has applied for a fixed preferential price or contract price or is in a refund scenario, this parameter will not be displayed by default.
        /// </summary>
        [JsonProperty("Discount")]
        public string Discount{ get; set; }

        /// <summary>
        /// Offer type
        /// </summary>
        [JsonProperty("ReduceType")]
        public string ReduceType{ get; set; }

        /// <summary>
        /// Total amount after discount: Total amount after discount = (Original cost - RI deduction (cost) - SP deduction (cost)) x Discount multiplier
        /// </summary>
        [JsonProperty("RealCost")]
        public string RealCost{ get; set; }

        /// <summary>
        /// Voucher payment: The voucher deduction amount
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// Cash credit: The amount paid from the user's cash account
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// Free credit: The amount paid with the user's free credit
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// Commission credit: The amount paid with the user's commission credit. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransferPayAmount")]
        public string TransferPayAmount{ get; set; }

        /// <summary>
        /// Component type code. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ItemCode")]
        public string ItemCode{ get; set; }

        /// <summary>
        /// Component name code. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// Component contracted price: The contracted unit price of a component, which is "List price x Discount". Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContractPrice")]
        public string ContractPrice{ get; set; }

        /// <summary>
        /// Instance type: The instance type of a product or service purchased, which can be resource package, RI, SP, or spot instance. Other instance types are not displayed by default. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// RI deduction (duration): The usage duration deducted by RI. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiTimeSpan")]
        public string RiTimeSpan{ get; set; }

        /// <summary>
        /// RI deduction (cost): The amount deducted from the original cost by RI. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginalCostWithRI")]
        public string OriginalCostWithRI{ get; set; }

        /// <summary>
        /// Savings plan deduction rate: The discount multiplier that applies to the component based on the remaining commitment of the savings plan. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SPDeductionRate")]
        public string SPDeductionRate{ get; set; }

        /// <summary>
        /// Cost deduction by SP. This parameter has been deprecated. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SPDeduction")]
        [System.Obsolete]
        public string SPDeduction{ get; set; }

        /// <summary>
        /// SP deduction (cost): SP deduction (cost) = Cost deduction by SP / SP deduction rate. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginalCostWithSP")]
        public string OriginalCostWithSP{ get; set; }

        /// <summary>
        /// Blended discount multiplier: The final discount multiplier that is applied after combining multiple discount types, which is "Total amount after discount / Original cost". Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BlendedDiscount")]
        public string BlendedDiscount{ get; set; }

        /// <summary>
        /// Configuration description: The specification configuration of an instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentConfig")]
        public BillDetailComponentConfig[] ComponentConfig{ get; set; }

        /// <summary>
        /// The tax rate.
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// The tax amount.
        /// </summary>
        [JsonProperty("TaxAmount")]
        public string TaxAmount{ get; set; }

        /// <summary>
        /// The currency used for the settlement of a component.
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentCodeName", this.ComponentCodeName);
            this.SetParamSimple(map, prefix + "ItemCodeName", this.ItemCodeName);
            this.SetParamSimple(map, prefix + "SinglePrice", this.SinglePrice);
            this.SetParamSimple(map, prefix + "SpecifiedPrice", this.SpecifiedPrice);
            this.SetParamSimple(map, prefix + "PriceUnit", this.PriceUnit);
            this.SetParamSimple(map, prefix + "UsedAmount", this.UsedAmount);
            this.SetParamSimple(map, prefix + "UsedAmountUnit", this.UsedAmountUnit);
            this.SetParamSimple(map, prefix + "RealTotalMeasure", this.RealTotalMeasure);
            this.SetParamSimple(map, prefix + "DeductedMeasure", this.DeductedMeasure);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnitName", this.TimeUnitName);
            this.SetParamSimple(map, prefix + "Cost", this.Cost);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "ReduceType", this.ReduceType);
            this.SetParamSimple(map, prefix + "RealCost", this.RealCost);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ContractPrice", this.ContractPrice);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "RiTimeSpan", this.RiTimeSpan);
            this.SetParamSimple(map, prefix + "OriginalCostWithRI", this.OriginalCostWithRI);
            this.SetParamSimple(map, prefix + "SPDeductionRate", this.SPDeductionRate);
            this.SetParamSimple(map, prefix + "SPDeduction", this.SPDeduction);
            this.SetParamSimple(map, prefix + "OriginalCostWithSP", this.OriginalCostWithSP);
            this.SetParamSimple(map, prefix + "BlendedDiscount", this.BlendedDiscount);
            this.SetParamArrayObj(map, prefix + "ComponentConfig.", this.ComponentConfig);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "TaxAmount", this.TaxAmount);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
        }
    }
}

