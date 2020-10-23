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

    public class PayModeSummaryOverviewItem : AbstractModel
    {
        
        /// <summary>
        /// Billing mode
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Billing mode name
        /// </summary>
        [JsonProperty("PayModeName")]
        public string PayModeName{ get; set; }

        /// <summary>
        /// Actual cost
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public string RealTotalCost{ get; set; }

        /// <summary>
        /// Cost ratio, to two decimal points
        /// </summary>
        [JsonProperty("RealTotalCostRatio")]
        public string RealTotalCostRatio{ get; set; }

        /// <summary>
        /// Detailed summary of purchases by transaction type
        /// </summary>
        [JsonProperty("Detail")]
        public ActionSummaryOverviewItem[] Detail{ get; set; }

        /// <summary>
        /// Cash amount
        /// </summary>
        [JsonProperty("CashPayAmount")]
        public string CashPayAmount{ get; set; }

        /// <summary>
        /// Trial credit amount
        /// </summary>
        [JsonProperty("IncentivePayAmount")]
        public string IncentivePayAmount{ get; set; }

        /// <summary>
        /// Voucher amount
        /// </summary>
        [JsonProperty("VoucherPayAmount")]
        public string VoucherPayAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayModeName", this.PayModeName);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
            this.SetParamSimple(map, prefix + "RealTotalCostRatio", this.RealTotalCostRatio);
            this.SetParamArrayObj(map, prefix + "Detail.", this.Detail);
            this.SetParamSimple(map, prefix + "CashPayAmount", this.CashPayAmount);
            this.SetParamSimple(map, prefix + "IncentivePayAmount", this.IncentivePayAmount);
            this.SetParamSimple(map, prefix + "VoucherPayAmount", this.VoucherPayAmount);
        }
    }
}

