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

    public class BillDetail : AbstractModel
    {
        
        /// <summary>
        /// Product name: The name of a Tencent Cloud product purchased by the user, such as CVM.
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// Subproduct name: The subcategory of a Tencent Cloud product purchased by the user, such as CVM Standard S1.
        /// </summary>
        [JsonProperty("ProductCodeName")]
        public string ProductCodeName{ get; set; }

        /// <summary>
        /// Billing mode, which can be monthly subscription or pay-as-you-go.
        /// </summary>
        [JsonProperty("PayModeName")]
        public string PayModeName{ get; set; }

        /// <summary>
        /// Project name: The project to which a resource belongs, which is user-designated. If a resource has not been assigned to a project, it will automatically belong to the default project.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Region: The region to which a resource belongs, such as South China (Guangzhou).
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// Availability zone: availability zone of a resource, e.g. Guangzhou Zone 3
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Instance ID: The object ID of a billed resource, such as a CVM instance ID. This object ID may vary due to various forms and contents of resources in different products.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Instance name: The resource name set by the user in the console. If it is not set, it will be empty by default.
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Transaction type, which can be monthly subscription purchase, monthly subscription renewal, or pay-as-you-go deduction.
        /// </summary>
        [JsonProperty("ActionTypeName")]
        public string ActionTypeName{ get; set; }

        /// <summary>
        /// Order ID: The sub-order number corresponding to the monthly subscription mode. In the postpaid billing model, the bill amount does not exist as an order concept, and this parameter can be ignored.
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// Transaction ID: The bill number for a deducted payment
        /// </summary>
        [JsonProperty("BillId")]
        public string BillId{ get; set; }

        /// <summary>
        /// Transaction time: The time at which a payment was deducted
        /// </summary>
        [JsonProperty("PayTime")]
        public string PayTime{ get; set; }

        /// <summary>
        /// Usage start time: The time at which product or service usage starts
        /// </summary>
        [JsonProperty("FeeBeginTime")]
        public string FeeBeginTime{ get; set; }

        /// <summary>
        /// Usage end time: The time at which product or service usage ends
        /// </summary>
        [JsonProperty("FeeEndTime")]
        public string FeeEndTime{ get; set; }

        /// <summary>
        /// Component list
        /// </summary>
        [JsonProperty("ComponentSet")]
        public BillDetailComponent[] ComponentSet{ get; set; }

        /// <summary>
        /// Payer account ID: The account ID of the payer, which is the unique identifier of a Tencent Cloud user.
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// Owner account ID: The account ID of the actual resource user
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Operator account ID: The account or role ID of the operator who purchases or activates a resource
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// Tag information.
        /// </summary>
        [JsonProperty("Tags")]
        public BillTagInfo[] Tags{ get; set; }

        /// <summary>
        /// Product code
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Subproduct code
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// Transaction type code
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Price attribute: Other attributes of the component that affect discount pricing besides unit price and duration
        /// </summary>
        [JsonProperty("PriceInfo")]
        public string[] PriceInfo{ get; set; }

        /// <summary>
        /// Associated transaction document ID: Document ID associated with this transaction, such as a write-off order, the original order, a resettlement order, or the original purchase order number recorded in a refund order.
        /// </summary>
        [JsonProperty("AssociatedOrder")]
        public BillDetailAssociatedOrder AssociatedOrder{ get; set; }

        /// <summary>
        /// Calculation explanation: A detailed explanation to calculations of billing settlement for special transaction types, such as refund and configuration changes.
        /// </summary>
        [JsonProperty("Formula")]
        public string Formula{ get; set; }

        /// <summary>
        /// Billing Rules: The detailed billing rules for each product shown in the portal explanation link
        /// </summary>
        [JsonProperty("FormulaUrl")]
        public string FormulaUrl{ get; set; }

        /// <summary>
        /// Billing day
        /// </summary>
        [JsonProperty("BillDay")]
        public string BillDay{ get; set; }

        /// <summary>
        /// Billing month
        /// </summary>
        [JsonProperty("BillMonth")]
        public string BillMonth{ get; set; }

        /// <summary>
        /// Billing record ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

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
        /// Remark attribute (instance configuration): Additional remark information, such as reserved instance type and transaction type for reserved instances, regional information of both ends for CCN products.
        /// </summary>
        [JsonProperty("ReserveDetail")]
        public string ReserveDetail{ get; set; }

        /// <summary>
        /// discount object
        /// </summary>
        [JsonProperty("DiscountObject")]
        public string DiscountObject{ get; set; }

        /// <summary>
        /// Offer type
        /// </summary>
        [JsonProperty("DiscountType")]
        public string DiscountType{ get; set; }

        /// <summary>
        /// discount content
        /// </summary>
        [JsonProperty("DiscountContent")]
        public string DiscountContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "ProductCodeName", this.ProductCodeName);
            this.SetParamSimple(map, prefix + "PayModeName", this.PayModeName);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ActionTypeName", this.ActionTypeName);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "BillId", this.BillId);
            this.SetParamSimple(map, prefix + "PayTime", this.PayTime);
            this.SetParamSimple(map, prefix + "FeeBeginTime", this.FeeBeginTime);
            this.SetParamSimple(map, prefix + "FeeEndTime", this.FeeEndTime);
            this.SetParamArrayObj(map, prefix + "ComponentSet.", this.ComponentSet);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "PriceInfo.", this.PriceInfo);
            this.SetParamObj(map, prefix + "AssociatedOrder.", this.AssociatedOrder);
            this.SetParamSimple(map, prefix + "Formula", this.Formula);
            this.SetParamSimple(map, prefix + "FormulaUrl", this.FormulaUrl);
            this.SetParamSimple(map, prefix + "BillDay", this.BillDay);
            this.SetParamSimple(map, prefix + "BillMonth", this.BillMonth);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RegionType", this.RegionType);
            this.SetParamSimple(map, prefix + "RegionTypeName", this.RegionTypeName);
            this.SetParamSimple(map, prefix + "ReserveDetail", this.ReserveDetail);
            this.SetParamSimple(map, prefix + "DiscountObject", this.DiscountObject);
            this.SetParamSimple(map, prefix + "DiscountType", this.DiscountType);
            this.SetParamSimple(map, prefix + "DiscountContent", this.DiscountContent);
        }
    }
}

