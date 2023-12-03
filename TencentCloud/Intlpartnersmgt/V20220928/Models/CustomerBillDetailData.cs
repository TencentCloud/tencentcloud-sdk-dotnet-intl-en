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

    public class CustomerBillDetailData : AbstractModel
    {
        
        /// <summary>
        /// Reseller account
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayerAccountId")]
        public long? PayerAccountId{ get; set; }

        /// <summary>
        /// Customer account
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OwnerAccountId")]
        public long? OwnerAccountId{ get; set; }

        /// <summary>
        /// Operator account
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OperatorAccountId")]
        public long? OperatorAccountId{ get; set; }

        /// <summary>
        /// Product name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Billing mode
        /// `Monthly subscription` (Monthly subscription)
        /// `Pay-As-You-Go resources` (Pay-as-you-go)
        /// `Standard RI` (Reserved instance)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BillingMode")]
        public string BillingMode{ get; set; }

        /// <summary>
        /// Project name
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Resource region
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Resource AZ
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AvailabilityZone")]
        public string AvailabilityZone{ get; set; }

        /// <summary>
        /// Instance ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Subproduct name
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubProductName")]
        public string SubProductName{ get; set; }

        /// <summary>
        /// Settlement type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransactionType")]
        public string TransactionType{ get; set; }

        /// <summary>
        /// Transaction ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// Settlement time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransactionTime")]
        public string TransactionTime{ get; set; }

        /// <summary>
        /// Start time of resource use
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsageStartTime")]
        public string UsageStartTime{ get; set; }

        /// <summary>
        /// End time of resource use
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsageEndTime")]
        public string UsageEndTime{ get; set; }

        /// <summary>
        /// Component
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentType")]
        public string ComponentType{ get; set; }

        /// <summary>
        /// Component name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// Component list price
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentListPrice")]
        public string ComponentListPrice{ get; set; }

        /// <summary>
        /// Price unit
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentPriceMeasurementUnit")]
        public string ComponentPriceMeasurementUnit{ get; set; }

        /// <summary>
        /// Component usage
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentUsage")]
        public string ComponentUsage{ get; set; }

        /// <summary>
        /// Component usage unit
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentUsageUnit")]
        public string ComponentUsageUnit{ get; set; }

        /// <summary>
        /// Resource usage duration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsageDuration")]
        public string UsageDuration{ get; set; }

        /// <summary>
        /// Duration unit
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DurationUnit")]
        public string DurationUnit{ get; set; }

        /// <summary>
        /// Original cost
        /// Original cost = component list price * component usage * usage duration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginalCost")]
        public string OriginalCost{ get; set; }

        /// <summary>
        /// Currency
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// Total cost = discounted total - voucher deduction
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// ID
        /// Note: The return value may be null, indicating that no valid data can be obtained.
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
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

