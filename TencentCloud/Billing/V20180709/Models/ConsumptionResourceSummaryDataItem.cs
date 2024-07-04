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

    public class ConsumptionResourceSummaryDataItem : AbstractModel
    {
        
        /// <summary>
        /// Resource ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Resource name
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Discounted total price
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

        /// <summary>
        /// Cash expenditure
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// Region name
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// Payment mode
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Payment mode name
        /// </summary>
        [JsonProperty("PayModeName")]
        public string PayModeName{ get; set; }

        /// <summary>
        /// Product name code
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// Consumption type
        /// </summary>
        [JsonProperty("ConsumptionTypeName")]
        public string ConsumptionTypeName{ get; set; }

        /// <summary>
        /// Pre-discount priceNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealCost")]
        public string RealCost{ get; set; }

        /// <summary>
        /// Start time of feesNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FeeBeginTime")]
        public string FeeBeginTime{ get; set; }

        /// <summary>
        /// End time of feesNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FeeEndTime")]
        public string FeeEndTime{ get; set; }

        /// <summary>
        /// Days
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DayDiff")]
        public string DayDiff{ get; set; }

        /// <summary>
        /// Daily consumptionNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DailyTotalCost")]
        public string DailyTotalCost{ get; set; }

        /// <summary>
        /// Order numberNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// VoucherNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// Bonus
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// Share revenueNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransferPayAmount")]
        public string TransferPayAmount{ get; set; }

        /// <summary>
        /// Payer UIN: the account ID of the payer, which is the unique identifier of a Tencent Cloud userNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }

        /// <summary>
        /// User UIN: the account ID of the actual resource userNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Operator UIN: the account ID or role ID of the operator who places orders for prepaid resources or activates postpaid resourcesNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// Subproduct codeNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// Subproduct name: the subcategory of a product purchased by the user, such as CVM – Standard S1Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductCodeName")]
        public string ProductCodeName{ get; set; }

        /// <summary>
        /// Region typeNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionType")]
        public string RegionType{ get; set; }

        /// <summary>
        /// Region type nameNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionTypeName")]
        public string RegionTypeName{ get; set; }

        /// <summary>
        /// Extended field 1Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Extend1")]
        public string Extend1{ get; set; }

        /// <summary>
        /// Extended field 2Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Extend2")]
        public string Extend2{ get; set; }

        /// <summary>
        /// Extended field 3Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Extend3")]
        public string Extend3{ get; set; }

        /// <summary>
        /// Extended field 4Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Extend4")]
        public string Extend4{ get; set; }

        /// <summary>
        /// Extended field 5Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Extend5")]
        public string Extend5{ get; set; }

        /// <summary>
        /// Instance typeNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance type nameNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceTypeName")]
        public string InstanceTypeName{ get; set; }

        /// <summary>
        /// Deduction time: the time at which a payment is deductedNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayTime")]
        public string PayTime{ get; set; }

        /// <summary>
        /// Availability zone: availability zone of a resource, e.g. Guangzhou Zone 3Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Configuration descriptionNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentConfig")]
        public string ComponentConfig{ get; set; }

        /// <summary>
        /// Tag information.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayModeName", this.PayModeName);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "ConsumptionTypeName", this.ConsumptionTypeName);
            this.SetParamSimple(map, prefix + "RealCost", this.RealCost);
            this.SetParamSimple(map, prefix + "FeeBeginTime", this.FeeBeginTime);
            this.SetParamSimple(map, prefix + "FeeEndTime", this.FeeEndTime);
            this.SetParamSimple(map, prefix + "DayDiff", this.DayDiff);
            this.SetParamSimple(map, prefix + "DailyTotalCost", this.DailyTotalCost);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "ProductCodeName", this.ProductCodeName);
            this.SetParamSimple(map, prefix + "RegionType", this.RegionType);
            this.SetParamSimple(map, prefix + "RegionTypeName", this.RegionTypeName);
            this.SetParamSimple(map, prefix + "Extend1", this.Extend1);
            this.SetParamSimple(map, prefix + "Extend2", this.Extend2);
            this.SetParamSimple(map, prefix + "Extend3", this.Extend3);
            this.SetParamSimple(map, prefix + "Extend4", this.Extend4);
            this.SetParamSimple(map, prefix + "Extend5", this.Extend5);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceTypeName", this.InstanceTypeName);
            this.SetParamSimple(map, prefix + "PayTime", this.PayTime);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ComponentConfig", this.ComponentConfig);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
        }
    }
}

