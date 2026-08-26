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

    public class DescribeCustomerBillSummaryRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Sub-customer uin</p>
        /// </summary>
        [JsonProperty("CustomerUin")]
        public ulong? CustomerUin{ get; set; }

        /// <summary>
        /// <p>Inquiry month, in the format of YYYY-MM, such as 2023-01</p>
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// <p>Billing mode</p><p>Enumeration values:</p><ul><li>prePay: yearly/monthly subscription</li><li>postPay: Pay-As-You-Go resources</li></ul>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>Transaction type</p><p>Enumeration values:</p><ul><li>prepay_purchase: Purchase</li><li>prepay_renew: Renewal</li><li>prepay_modify: Upgrade/Downgrade</li><li>prepay_return: yearly/monthly subscription refund</li><li>postpay_deduct: Pay-as-you-go</li><li>postpay_deduct_h: Hourly settlement</li><li>postpay_deduct_d: Daily settlement</li><li>postpay_deduct_m: Monthly settlement</li><li>offline_deduct: Offline project deduction</li><li>online_deduct: Offline product deduction</li><li>recon_deduct: Adjustment - deduction</li><li>ripay_purchase: One-off RI Fee</li><li>postpay_deduct_s: Spot</li><li>ri_hour_pay: Hourly RI fee</li><li>prePurchase: New yearly/monthly subscription</li><li>preRenew: yearly/monthly subscription renewal</li><li>preUpgrade: Upgrade/Downgrade</li></ul>
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// <p>Payment Status<br>0: case-insensitive<br>1: paid<br>2: unpaid</p>
        /// </summary>
        [JsonProperty("IsConfirmed")]
        public string IsConfirmed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerUin", this.CustomerUin);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "IsConfirmed", this.IsConfirmed);
        }
    }
}

