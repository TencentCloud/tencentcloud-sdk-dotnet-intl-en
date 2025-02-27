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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BillDetailData : AbstractModel
    {
        
        /// <summary>
        /// reseller account.
        /// </summary>
        [JsonProperty("PayerAccountId")]
        public long? PayerAccountId{ get; set; }

        /// <summary>
        /// Subaccount.
        /// </summary>
        [JsonProperty("OwnerAccountId")]
        public long? OwnerAccountId{ get; set; }

        /// <summary>
        /// Operator account.
        /// </summary>
        [JsonProperty("OperatorAccountId")]
        public long? OperatorAccountId{ get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Billing mode
        /// .
        /// Monthly subscription (annual and monthly).
        /// Pay-As-You-Go resources.
        /// Standard ri reserved instance.
        /// </summary>
        [JsonProperty("BillingMode")]
        public string BillingMode{ get; set; }

        /// <summary>
        /// Project name.
        /// .
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Resource region.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Resource available zone.
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public string AvailabilityZone{ get; set; }

        /// <summary>
        /// Instance id.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Sub-Product name
        /// .
        /// </summary>
        [JsonProperty("SubProductName")]
        public string SubProductName{ get; set; }

        /// <summary>
        /// Settlement type.
        /// </summary>
        [JsonProperty("TransactionType")]
        public string TransactionType{ get; set; }

        /// <summary>
        /// <Transaction id>.
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// Settlement time.
        /// </summary>
        [JsonProperty("TransactionTime")]
        public string TransactionTime{ get; set; }

        /// <summary>
        /// <Resource start time>.
        /// </summary>
        [JsonProperty("UsageStartTime")]
        public string UsageStartTime{ get; set; }

        /// <summary>
        /// <Resource end usage time>.
        /// </summary>
        [JsonProperty("UsageEndTime")]
        public string UsageEndTime{ get; set; }

        /// <summary>
        /// Component.
        /// </summary>
        [JsonProperty("ComponentType")]
        public string ComponentType{ get; set; }

        /// <summary>
        /// Component name.
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// Component list price.
        /// </summary>
        [JsonProperty("ComponentListPrice")]
        public string ComponentListPrice{ get; set; }

        /// <summary>
        /// Price unit.
        /// </summary>
        [JsonProperty("ComponentPriceMeasurementUnit")]
        public string ComponentPriceMeasurementUnit{ get; set; }

        /// <summary>
        /// Component usage.
        /// </summary>
        [JsonProperty("ComponentUsage")]
        public string ComponentUsage{ get; set; }

        /// <summary>
        /// Component usage unit.
        /// </summary>
        [JsonProperty("ComponentUsageUnit")]
        public string ComponentUsageUnit{ get; set; }

        /// <summary>
        /// Resource usage duration.
        /// </summary>
        [JsonProperty("UsageDuration")]
        public string UsageDuration{ get; set; }

        /// <summary>
        /// duration unit.
        /// </summary>
        [JsonProperty("DurationUnit")]
        public string DurationUnit{ get; set; }

        /// <summary>
        /// Total original price.
        /// Original cost = component list price * component usage * usage duration.
        /// </summary>
        [JsonProperty("OriginalCost")]
        public string OriginalCost{ get; set; }

        /// <summary>
        /// Discount (default is 1).
        /// </summary>
        [JsonProperty("DiscountRate")]
        public string DiscountRate{ get; set; }

        /// <summary>
        /// Currency.
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// Total cost after discount.
        /// </summary>
        [JsonProperty("TotalAmountAfterDiscount")]
        public string TotalAmountAfterDiscount{ get; set; }

        /// <summary>
        /// Voucher deduction amount.
        /// </summary>
        [JsonProperty("VoucherDeduction")]
        public string VoucherDeduction{ get; set; }

        /// <summary>
        /// = Total Amount After Discount - Voucher Deduction
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// Identifier (id).
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


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
        }
    }
}

