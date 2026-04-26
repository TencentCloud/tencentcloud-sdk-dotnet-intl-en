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

    public class AllocationSummaryByItem : AbstractModel
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
        /// Payer UIN: Account ID of the payer, which is the unique account identifier for the user in Tencent Cloud.
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// User UIN: Account ID of the actual resource user
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Operator account ID (the resource account ID or role ID opened by prepaid resource ordering or postpaid operation)
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// Billing mode code
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Billing mode: Resource billing mode, which can be monthly subscription or pay-as-you-go.
        /// </summary>
        [JsonProperty("PayModeName")]
        public string PayModeName{ get; set; }

        /// <summary>
        /// Transaction type code
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// Transaction type: Detailed transaction type
        /// </summary>
        [JsonProperty("ActionTypeName")]
        public string ActionTypeName{ get; set; }

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
        /// Subproduct code
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// Subproduct name: Product subdivision type purchased by the user
        /// </summary>
        [JsonProperty("ProductCodeName")]
        public string ProductCodeName{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// Region name: The region where the resource is located
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// AZ ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// Availability zone: The availability zone where the resource is located.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Instance type code
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance type: The type of an instance corresponding to the product service purchased, including resource packages, RI, SP, and spot instances. It is displayed as "-" by default for regular instances.
        /// </summary>
        [JsonProperty("InstanceTypeName")]
        public string InstanceTypeName{ get; set; }

        /// <summary>
        /// Resource ID: Resources vary by product, and the content is not identical. For example, Cloud Virtual Machine (CVM) corresponds to the instance ID. If the product is split, it shows the split item ID, such as COS bucket ID and CDN domain name.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Instance name: The name set by the user for the resource in the console, which is empty by default if not set. If the product is split, it shows the split resource alias.
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Allocation tag: The resource-bound tag
        /// </summary>
        [JsonProperty("Tag")]
        public BillTag[] Tag{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Project name: The Project to which a resource belongs, which is independently allocated by the user for the resource in the console. If a resource has not been allocated to an Project, it will be a default Project.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Cost collection type: The source types of fees, including allocated, collection and unallocated.
        /// 0 - Allocation
        /// 1 - Collection
        /// -1 - Unallocated
        /// </summary>
        [JsonProperty("AllocationType")]
        public long? AllocationType{ get; set; }

        /// <summary>
        /// Original price of a component: Original Price = Component List Price * Component Usage * Duration of Use (not displayed if the customer enjoys a fixed price/contract price, and not displayed by default in refund scenarios), specified price mode
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// Reserved instance deduction duration: The duration of use deducted by reserved instances for this product or service.
        /// </summary>
        [JsonProperty("RiTimeSpan")]
        public string RiTimeSpan{ get; set; }

        /// <summary>
        /// Original price deducted by a reserved instance: The original price of a component deducted by reserved instances for this product or service
        /// </summary>
        [JsonProperty("RiCost")]
        public string RiCost{ get; set; }

        /// <summary>
        /// Discounted total: discounted total = (Original Price - Original Price Deducted by a Reserved Instance - Savings Plan Deduction from Original Price) * Discount Rate
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

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
        /// Component name code
        /// </summary>
        [JsonProperty("ItemCode")]
        public string ItemCode{ get; set; }

        /// <summary>
        /// Component name: The specific component of a product or service purchased by the user
        /// </summary>
        [JsonProperty("ItemCodeName")]
        public string ItemCodeName{ get; set; }

        /// <summary>
        /// Component type code
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// Component type: The major component category corresponding to the product or service purchased by the user
        /// </summary>
        [JsonProperty("ComponentCodeName")]
        public string ComponentCodeName{ get; set; }

        /// <summary>
        /// Split item ID: The ID of the split item involved in the split product, such as COS bucket ID and CDN domain name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SplitItemId")]
        [System.Obsolete]
        public string SplitItemId{ get; set; }

        /// <summary>
        /// Split item name: The split item involved in the split product
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SplitItemName")]
        [System.Obsolete]
        public string SplitItemName{ get; set; }

        /// <summary>
        /// Usage start time: Usage start time
        /// </summary>
        [JsonProperty("FeeBeginTime")]
        public string FeeBeginTime{ get; set; }

        /// <summary>
        /// Usage end time: Product or service usage end time
        /// </summary>
        [JsonProperty("FeeEndTime")]
        public string FeeEndTime{ get; set; }

        /// <summary>
        /// Savings plan deduction from original price: Savings Plan Deduction from Original Price = Monetary Value of Savings Plan Deduction/ Savings Plan Deduction Rate
        /// </summary>
        [JsonProperty("SPCost")]
        public string SPCost{ get; set; }

        /// <summary>
        /// Domestic and international codes
        /// </summary>
        [JsonProperty("RegionType")]
        public string RegionType{ get; set; }

        /// <summary>
        /// Domestic and international: Resource region type (domestic, international)
        /// </summary>
        [JsonProperty("RegionTypeName")]
        public string RegionTypeName{ get; set; }

        /// <summary>
        /// Component list price: The original unit price of the component on the portal (not displayed if the customer enjoys a fixed price/contract price)
        /// </summary>
        [JsonProperty("SinglePrice")]
        public string SinglePrice{ get; set; }

        /// <summary>
        /// Component unit price: Discounted unit price of the component. Component unit price = list price * discount.
        /// </summary>
        [JsonProperty("ContractPrice")]
        public string ContractPrice{ get; set; }

        /// <summary>
        /// Component Price Unit: Unit of component price, Unit Composition: CNY/usage unit/duration unit
        /// </summary>
        [JsonProperty("SinglePriceUnit")]
        public string SinglePriceUnit{ get; set; }

        /// <summary>
        /// Component usage: The actual settlement usage of the component, Component Usage = Original Component Usage - Deducted Usage (including resource packages)
        /// </summary>
        [JsonProperty("UsedAmount")]
        public string UsedAmount{ get; set; }

        /// <summary>
        /// Component usage unit: Unit of measurement corresponding to component usage.
        /// </summary>
        [JsonProperty("UsedAmountUnit")]
        public string UsedAmountUnit{ get; set; }

        /// <summary>
        /// Usage duration: The duration of resource usage, Component Usage = Original Component Usage Duration - Deducted Duration (including resource packages)
        /// </summary>
        [JsonProperty("TimeSpan")]
        public string TimeSpan{ get; set; }

        /// <summary>
        /// Duration unit: Unit of resource usage duration.
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Remark attribute (instance configuration): Additional remark information, such as reserved instance type and transaction type for reserved instances, regional information of both ends for CCN products.
        /// </summary>
        [JsonProperty("ReserveDetail")]
        public string ReserveDetail{ get; set; }

        /// <summary>
        /// Original usage/duration: The original usage of the component before deduction by resource packages.
        /// (Currently only TRTC, TEM, Cloud Call Center, and CDZ products support this information display. Other products are being integrated.)
        /// </summary>
        [JsonProperty("RealTotalMeasure")]
        public string RealTotalMeasure{ get; set; }

        /// <summary>
        /// Deduction of usage/duration (including resource packages): The amount of usage deducted by resource packages
        /// (Currently only TRTC, TEM, Cloud Call Center, and CDZ products support this information display. Other products are being integrated.)
        /// </summary>
        [JsonProperty("DeductedMeasure")]
        public string DeductedMeasure{ get; set; }

        /// <summary>
        /// Discount rate: The discount rate enjoyed by this resource (it is not shown by default if the customer enjoys a fixed/contract price, and it is also not shown by default in the refund scenario)
        /// </summary>
        [JsonProperty("Discount")]
        public string Discount{ get; set; }

        /// <summary>
        /// Mixed discount rate: The final discount rate after integrating various discount deductions. Mixed Discount Rate = Discounted total price/Original Price.
        /// </summary>
        [JsonProperty("BlendedDiscount")]
        public string BlendedDiscount{ get; set; }

        /// <summary>
        /// Price attribute: Other attributes of the component that affect discount pricing besides unit price and duration
        /// </summary>
        [JsonProperty("PriceInfo")]
        public string[] PriceInfo{ get; set; }

        /// <summary>
        /// Calculation rule explanation: A detailed explanation to calculations of billing settlement for special transaction types, such as refund and configuration changes.
        /// </summary>
        [JsonProperty("Formula")]
        public string Formula{ get; set; }

        /// <summary>
        /// Billing Rules: The detailed billing rules for each product shown in the portal explanation link
        /// </summary>
        [JsonProperty("FormulaUrl")]
        public string FormulaUrl{ get; set; }

        /// <summary>
        /// Configuration description: Information on specification of resource configuration
        /// </summary>
        [JsonProperty("ComponentConfig")]
        public string ComponentConfig{ get; set; }

        /// <summary>
        /// SPDeduction
        /// </summary>
        [JsonProperty("SPDeduction")]
        public string SPDeduction{ get; set; }

        /// <summary>
        /// Savings plan deduction rate: The discount rate for this component within the available balance limit of the savings plan
        /// </summary>
        [JsonProperty("SPDeductionRate")]
        public string SPDeductionRate{ get; set; }

        /// <summary>
        /// Currency.
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// Tax
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// tax rate
        /// </summary>
        [JsonProperty("TaxRate")]
        public string TaxRate{ get; set; }

        /// <summary>
        /// CostBeforeTax
        /// </summary>
        [JsonProperty("CostBeforeTax")]
        public string CostBeforeTax{ get; set; }

        /// <summary>
        /// AmountBeforeTax
        /// </summary>
        [JsonProperty("AmountBeforeTax")]
        public string AmountBeforeTax{ get; set; }

        /// <summary>
        /// AssociatedOrder
        /// </summary>
        [JsonProperty("AssociatedOrder")]
        public string AssociatedOrder{ get; set; }

        /// <summary>
        /// Discount object of the current consumption item, such as official website discount, user discount and activity discount.
        /// </summary>
        [JsonProperty("DiscountObject")]
        public string DiscountObject{ get; set; }

        /// <summary>
        /// Discount type of the current consumption item, such as discount and contract price.
        /// </summary>
        [JsonProperty("DiscountType")]
        public string DiscountType{ get; set; }

        /// <summary>
        /// Supplementary description of the offer type, for example: business discount 20% off, the offer type is "discount" and the discount content is "0.8".
        /// </summary>
        [JsonProperty("DiscountContent")]
        public string DiscountContent{ get; set; }

        /// <summary>
        /// Billing month
        /// </summary>
        [JsonProperty("BillMonth")]
        public string BillMonth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TreeNodeUniqKey", this.TreeNodeUniqKey);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKeyName", this.TreeNodeUniqKeyName);
            this.SetParamSimple(map, prefix + "BillDate", this.BillDate);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayModeName", this.PayModeName);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ActionTypeName", this.ActionTypeName);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ProductCodeName", this.ProductCodeName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceTypeName", this.InstanceTypeName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "AllocationType", this.AllocationType);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "RiTimeSpan", this.RiTimeSpan);
            this.SetParamSimple(map, prefix + "RiCost", this.RiCost);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
            this.SetParamSimple(map, prefix + "ItemCodeName", this.ItemCodeName);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ComponentCodeName", this.ComponentCodeName);
            this.SetParamSimple(map, prefix + "SplitItemId", this.SplitItemId);
            this.SetParamSimple(map, prefix + "SplitItemName", this.SplitItemName);
            this.SetParamSimple(map, prefix + "FeeBeginTime", this.FeeBeginTime);
            this.SetParamSimple(map, prefix + "FeeEndTime", this.FeeEndTime);
            this.SetParamSimple(map, prefix + "SPCost", this.SPCost);
            this.SetParamSimple(map, prefix + "RegionType", this.RegionType);
            this.SetParamSimple(map, prefix + "RegionTypeName", this.RegionTypeName);
            this.SetParamSimple(map, prefix + "SinglePrice", this.SinglePrice);
            this.SetParamSimple(map, prefix + "ContractPrice", this.ContractPrice);
            this.SetParamSimple(map, prefix + "SinglePriceUnit", this.SinglePriceUnit);
            this.SetParamSimple(map, prefix + "UsedAmount", this.UsedAmount);
            this.SetParamSimple(map, prefix + "UsedAmountUnit", this.UsedAmountUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "ReserveDetail", this.ReserveDetail);
            this.SetParamSimple(map, prefix + "RealTotalMeasure", this.RealTotalMeasure);
            this.SetParamSimple(map, prefix + "DeductedMeasure", this.DeductedMeasure);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "BlendedDiscount", this.BlendedDiscount);
            this.SetParamArraySimple(map, prefix + "PriceInfo.", this.PriceInfo);
            this.SetParamSimple(map, prefix + "Formula", this.Formula);
            this.SetParamSimple(map, prefix + "FormulaUrl", this.FormulaUrl);
            this.SetParamSimple(map, prefix + "ComponentConfig", this.ComponentConfig);
            this.SetParamSimple(map, prefix + "SPDeduction", this.SPDeduction);
            this.SetParamSimple(map, prefix + "SPDeductionRate", this.SPDeductionRate);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "TaxRate", this.TaxRate);
            this.SetParamSimple(map, prefix + "CostBeforeTax", this.CostBeforeTax);
            this.SetParamSimple(map, prefix + "AmountBeforeTax", this.AmountBeforeTax);
            this.SetParamSimple(map, prefix + "AssociatedOrder", this.AssociatedOrder);
            this.SetParamSimple(map, prefix + "DiscountObject", this.DiscountObject);
            this.SetParamSimple(map, prefix + "DiscountType", this.DiscountType);
            this.SetParamSimple(map, prefix + "DiscountContent", this.DiscountContent);
            this.SetParamSimple(map, prefix + "BillMonth", this.BillMonth);
        }
    }
}

