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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BillDetailData : AbstractModel
    {
        
        /// <summary>
        /// <p> Distributor account</p>
        /// </summary>
        [JsonProperty("PayerAccountId")]
        public long? PayerAccountId{ get; set; }

        /// <summary>
        /// <p>Sub-Customer account</p>
        /// </summary>
        [JsonProperty("OwnerAccountId")]
        public long? OwnerAccountId{ get; set; }

        /// <summary>
        /// <p>Operator account</p>
        /// </summary>
        [JsonProperty("OperatorAccountId")]
        public long? OperatorAccountId{ get; set; }

        /// <summary>
        /// <p>Product name.</p>
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>Billing mode</p><p>Enumeration values:</p><ul><li>yearly/monthly subscription</li><li>Pay-As-You-Go resources</li></ul>
        /// </summary>
        [JsonProperty("BillingMode")]
        public string BillingMode{ get; set; }

        /// <summary>
        /// <p>Project name.</p>
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// <p>Associated region of the resource</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Availability zone of resource</p>
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public string AvailabilityZone{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Instance name.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Sub-product name</p>
        /// </summary>
        [JsonProperty("SubProductName")]
        public string SubProductName{ get; set; }

        /// <summary>
        /// <p>Settlement type</p>
        /// </summary>
        [JsonProperty("TransactionType")]
        public string TransactionType{ get; set; }

        /// <summary>
        /// <p>Transaction log ID</p>
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// <p>Time of settlement</p>
        /// </summary>
        [JsonProperty("TransactionTime")]
        public string TransactionTime{ get; set; }

        /// <summary>
        /// <p>Resource usage start time</p>
        /// </summary>
        [JsonProperty("UsageStartTime")]
        public string UsageStartTime{ get; set; }

        /// <summary>
        /// <p>Resource usage end time</p>
        /// </summary>
        [JsonProperty("UsageEndTime")]
        public string UsageEndTime{ get; set; }

        /// <summary>
        /// <p>Component</p>
        /// </summary>
        [JsonProperty("ComponentType")]
        public string ComponentType{ get; set; }

        /// <summary>
        /// <p>Component name</p>
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// <p>Component list price</p>
        /// </summary>
        [JsonProperty("ComponentListPrice")]
        public string ComponentListPrice{ get; set; }

        /// <summary>
        /// <p>Price unit</p>
        /// </summary>
        [JsonProperty("ComponentPriceMeasurementUnit")]
        public string ComponentPriceMeasurementUnit{ get; set; }

        /// <summary>
        /// <p>Component usage</p>
        /// </summary>
        [JsonProperty("ComponentUsage")]
        public string ComponentUsage{ get; set; }

        /// <summary>
        /// <p>Component usage unit</p>
        /// </summary>
        [JsonProperty("ComponentUsageUnit")]
        public string ComponentUsageUnit{ get; set; }

        /// <summary>
        /// <p>Resource usage duration</p>
        /// </summary>
        [JsonProperty("UsageDuration")]
        public string UsageDuration{ get; set; }

        /// <summary>
        /// <p>Duration unit</p>
        /// </summary>
        [JsonProperty("DurationUnit")]
        public string DurationUnit{ get; set; }

        /// <summary>
        /// <p>Original total price<br>Original Cost = Component List Price * Component Usage * Usage Duration</p>
        /// </summary>
        [JsonProperty("OriginalCost")]
        public string OriginalCost{ get; set; }

        /// <summary>
        /// <p>Discount (default: 1) - abandoned</p>
        /// </summary>
        [JsonProperty("DiscountRate")]
        public string DiscountRate{ get; set; }

        /// <summary>
        /// <p>Currency.</p>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// <p>Total cost after discount</p>
        /// </summary>
        [JsonProperty("TotalAmountAfterDiscount")]
        public string TotalAmountAfterDiscount{ get; set; }

        /// <summary>
        /// <p>Voucher deducted amount</p>
        /// </summary>
        [JsonProperty("VoucherDeduction")]
        public string VoucherDeduction{ get; set; }

        /// <summary>
        /// <p>= Total Amount After Discount - Voucher Deduction</p>
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// <p>id</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>customer discount rate. The discount rate for customers of resellers, set by the reseller. The default value is 1.</p>
        /// </summary>
        [JsonProperty("CustomerDiscountRate")]
        public string CustomerDiscountRate{ get; set; }

        /// <summary>
        /// <p>Product code</p>
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// <p>Sub-product code</p>
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// <p>Component type code</p>
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// <p>Component code</p>
        /// </summary>
        [JsonProperty("ItemCode")]
        public string ItemCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerAccountId", this.PayerAccountId);
            this.SetParamSimple(map, prefix + "OwnerAccountId", this.OwnerAccountId);
            this.SetParamSimple(map, prefix + "OperatorAccountId", this.OperatorAccountId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AvailabilityZone", this.AvailabilityZone);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "SubProductName", this.SubProductName);
            this.SetParamSimple(map, prefix + "TransactionType", this.TransactionType);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "TransactionTime", this.TransactionTime);
            this.SetParamSimple(map, prefix + "UsageStartTime", this.UsageStartTime);
            this.SetParamSimple(map, prefix + "UsageEndTime", this.UsageEndTime);
            this.SetParamSimple(map, prefix + "ComponentType", this.ComponentType);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "ComponentListPrice", this.ComponentListPrice);
            this.SetParamSimple(map, prefix + "ComponentPriceMeasurementUnit", this.ComponentPriceMeasurementUnit);
            this.SetParamSimple(map, prefix + "ComponentUsage", this.ComponentUsage);
            this.SetParamSimple(map, prefix + "ComponentUsageUnit", this.ComponentUsageUnit);
            this.SetParamSimple(map, prefix + "UsageDuration", this.UsageDuration);
            this.SetParamSimple(map, prefix + "DurationUnit", this.DurationUnit);
            this.SetParamSimple(map, prefix + "OriginalCost", this.OriginalCost);
            this.SetParamSimple(map, prefix + "DiscountRate", this.DiscountRate);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "TotalAmountAfterDiscount", this.TotalAmountAfterDiscount);
            this.SetParamSimple(map, prefix + "VoucherDeduction", this.VoucherDeduction);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "CustomerDiscountRate", this.CustomerDiscountRate);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
        }
    }
}

