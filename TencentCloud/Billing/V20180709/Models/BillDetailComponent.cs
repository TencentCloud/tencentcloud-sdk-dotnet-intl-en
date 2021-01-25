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
        /// Component type: type of a resource component, e.g. memory, disk, etc.
        /// </summary>
        [JsonProperty("ComponentCodeName")]
        public string ComponentCodeName{ get; set; }

        /// <summary>
        /// Component name: name of a resource component, e.g. TencentDB for MySQL-memory
        /// </summary>
        [JsonProperty("ItemCodeName")]
        public string ItemCodeName{ get; set; }

        /// <summary>
        /// Component published price: original price of a resource component with the original granularity
        /// </summary>
        [JsonProperty("SinglePrice")]
        public string SinglePrice{ get; set; }

        /// <summary>
        /// Specified price of the component
        /// </summary>
        [JsonProperty("SpecifiedPrice")]
        public string SpecifiedPrice{ get; set; }

        /// <summary>
        /// Price unit
        /// </summary>
        [JsonProperty("PriceUnit")]
        public string PriceUnit{ get; set; }

        /// <summary>
        /// Component usage
        /// </summary>
        [JsonProperty("UsedAmount")]
        public string UsedAmount{ get; set; }

        /// <summary>
        /// Component usage unit
        /// </summary>
        [JsonProperty("UsedAmountUnit")]
        public string UsedAmountUnit{ get; set; }

        /// <summary>
        /// Usage period
        /// </summary>
        [JsonProperty("TimeSpan")]
        public string TimeSpan{ get; set; }

        /// <summary>
        /// Time unit
        /// </summary>
        [JsonProperty("TimeUnitName")]
        public string TimeUnitName{ get; set; }

        /// <summary>
        /// Original price of the component
        /// </summary>
        [JsonProperty("Cost")]
        public string Cost{ get; set; }

        /// <summary>
        /// Discount rate
        /// </summary>
        [JsonProperty("Discount")]
        public string Discount{ get; set; }

        /// <summary>
        /// Offer type
        /// </summary>
        [JsonProperty("ReduceType")]
        public string ReduceType{ get; set; }

        /// <summary>
        /// Total discounted price
        /// </summary>
        [JsonProperty("RealCost")]
        public string RealCost{ get; set; }

        /// <summary>
        /// Amount paid in voucher
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// Amount paid in cash
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// Amount paid in trial credit
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// Component type code
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ItemCode")]
        public string ItemCode{ get; set; }

        /// <summary>
        /// Component code
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// Contract price
        /// </summary>
        [JsonProperty("ContractPrice")]
        public string ContractPrice{ get; set; }


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
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnitName", this.TimeUnitName);
            this.SetParamSimple(map, prefix + "Cost", this.Cost);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "ReduceType", this.ReduceType);
            this.SetParamSimple(map, prefix + "RealCost", this.RealCost);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "ItemCode", this.ItemCode);
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ContractPrice", this.ContractPrice);
        }
    }
}

