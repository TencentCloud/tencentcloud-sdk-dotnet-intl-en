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

    public class UsageRecords : AbstractModel
    {
        
        /// <summary>
        /// The amount used. The value of this parameter is the amount used (USD, rounded to 8 decimal places) multiplied by 100,000,000.
        /// </summary>
        [JsonProperty("UsedAmount")]
        public long? UsedAmount{ get; set; }

        /// <summary>
        /// The time when the voucher was used.
        /// </summary>
        [JsonProperty("UsedTime")]
        public string UsedTime{ get; set; }

        /// <summary>
        /// Usage record details
        /// </summary>
        [JsonProperty("UsageDetails")]
        public UsageDetails[] UsageDetails{ get; set; }

        /// <summary>
        /// Payment mode
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Queried coupon id
        /// </summary>
        [JsonProperty("VoucherId")]
        public string VoucherId{ get; set; }

        /// <summary>
        /// Transaction scene: (adjust: adjust accounts, common: normal transaction scene)
        /// </summary>
        [JsonProperty("PayScene")]
        public string PayScene{ get; set; }

        /// <summary>
        /// Unique ID, corresponding to transaction: prepaid dealName, bill adjustment/postpaid outTradeNo
        /// </summary>
        [JsonProperty("SeqId")]
        public string SeqId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UsedAmount", this.UsedAmount);
            this.SetParamSimple(map, prefix + "UsedTime", this.UsedTime);
            this.SetParamArrayObj(map, prefix + "UsageDetails.", this.UsageDetails);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "VoucherId", this.VoucherId);
            this.SetParamSimple(map, prefix + "PayScene", this.PayScene);
            this.SetParamSimple(map, prefix + "SeqId", this.SeqId);
        }
    }
}

