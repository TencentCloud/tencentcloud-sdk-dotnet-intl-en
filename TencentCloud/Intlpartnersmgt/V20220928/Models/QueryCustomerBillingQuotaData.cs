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

    public class QueryCustomerBillingQuotaData : AbstractModel
    {
        
        /// <summary>
        /// Total credit limit (unit: usd), accurate down to two decimal places.
        /// </summary>
        [JsonProperty("TotalCredit")]
        public float? TotalCredit{ get; set; }

        /// <summary>
        /// Remaining credit limit (unit: usd), accurate down to two decimal places.
        /// </summary>
        [JsonProperty("RemainingCredit")]
        public float? RemainingCredit{ get; set; }

        /// <summary>
        /// Remaining total voucher amount (unit: usd), accurate down to two decimal places.
        /// </summary>
        [JsonProperty("RemainingVoucher")]
        public float? RemainingVoucher{ get; set; }

        /// <summary>
        /// Forced status.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Force")]
        public long? Force{ get; set; }

        /// <summary>
        /// Prepaid frozen amount.
        /// </summary>
        [JsonProperty("PrepayFrozen")]
        public float? PrepayFrozen{ get; set; }

        /// <summary>
        /// Postpaid frozen amount.
        /// </summary>
        [JsonProperty("PostpayFrozen")]
        public float? PostpayFrozen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCredit", this.TotalCredit);
            this.SetParamSimple(map, prefix + "RemainingCredit", this.RemainingCredit);
            this.SetParamSimple(map, prefix + "RemainingVoucher", this.RemainingVoucher);
            this.SetParamSimple(map, prefix + "Force", this.Force);
            this.SetParamSimple(map, prefix + "PrepayFrozen", this.PrepayFrozen);
            this.SetParamSimple(map, prefix + "PostpayFrozen", this.PostpayFrozen);
        }
    }
}

