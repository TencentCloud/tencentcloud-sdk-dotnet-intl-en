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

    public class BusinessSummaryInfo : AbstractModel
    {
        
        /// <summary>
        /// Product code
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Product name: The name of a Tencent Cloud product purchased by the user, such as CVM.
        /// </summary>
        [JsonProperty("BusinessCodeName")]
        public string BusinessCodeName{ get; set; }

        /// <summary>
        /// Original cost in USD. This parameter became valid when Bill 3.0 took effect in May 2021. Before that, `-` was returned for this parameter. If a customer has applied for a contract price different from the prices listed on the official website, `-` will also be returned for this parameter. 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// Total amount after discount
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

        /// <summary>
        /// Cash credit: The amount paid from the user’s cash account
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// Free credit: The amount paid with the user’s free credit
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// Voucher payment: The voucher deduction amount
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }

        /// <summary>
        /// Commission credit: The amount paid with the user’s commission credit. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransferPayAmount")]
        public string TransferPayAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "BusinessCodeName", this.BusinessCodeName);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
            this.SetParamSimple(map, prefix + "TransferPayAmount", this.TransferPayAmount);
        }
    }
}

