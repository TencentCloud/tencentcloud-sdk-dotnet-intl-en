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

    public class GatherResourceSummary : AbstractModel
    {
        
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
        /// Allocation rule ID hit by the resource
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// Allocation rule name hit by the resource
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

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
        /// Allocation tag: The resource-bound tag
        /// </summary>
        [JsonProperty("Tag")]
        public BillTag[] Tag{ get; set; }

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
        /// Cost collection type: The source types of fees, including allocated, collection and unallocated.
        /// 0 - Allocation
        /// 1 - Collection
        /// -1 - Unallocated
        /// </summary>
        [JsonProperty("AllocationType")]
        public long? AllocationType{ get; set; }

        /// <summary>
        /// Information of the current allocation unit
        /// </summary>
        [JsonProperty("BelongTreeNodeUniqKey")]
        public AllocationTreeNode BelongTreeNodeUniqKey{ get; set; }

        /// <summary>
        /// Information on allocation rules hit by the current resource
        /// </summary>
        [JsonProperty("BelongRule")]
        public AllocationRule BelongRule{ get; set; }

        /// <summary>
        /// Information on other allocation units
        /// </summary>
        [JsonProperty("OtherTreeNodeUniqKeys")]
        public AllocationTreeNode[] OtherTreeNodeUniqKeys{ get; set; }

        /// <summary>
        /// Information on other hit rules
        /// </summary>
        [JsonProperty("OtherRules")]
        public AllocationRule[] OtherRules{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceTypeName", this.InstanceTypeName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKey", this.TreeNodeUniqKey);
            this.SetParamSimple(map, prefix + "TreeNodeUniqKeyName", this.TreeNodeUniqKeyName);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
            this.SetParamSimple(map, prefix + "ItemCodeName", this.ItemCodeName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "AllocationType", this.AllocationType);
            this.SetParamObj(map, prefix + "BelongTreeNodeUniqKey.", this.BelongTreeNodeUniqKey);
            this.SetParamObj(map, prefix + "BelongRule.", this.BelongRule);
            this.SetParamArrayObj(map, prefix + "OtherTreeNodeUniqKeys.", this.OtherTreeNodeUniqKeys);
            this.SetParamArrayObj(map, prefix + "OtherRules.", this.OtherRules);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ProductCodeName", this.ProductCodeName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayModeName", this.PayModeName);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ActionTypeName", this.ActionTypeName);
            this.SetParamSimple(map, prefix + "SplitItemId", this.SplitItemId);
            this.SetParamSimple(map, prefix + "SplitItemName", this.SplitItemName);
        }
    }
}

