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

    public class DescribeCustomerBillDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Sub-account UIN.
        /// </summary>
        [JsonProperty("CustomerUin")]
        public ulong? CustomerUin{ get; set; }

        /// <summary>
        /// Inquiry month, in the format of YYYY-MM, such as 2023-01.
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// Page parameter: number of entries per page. Value range: [1, 200]
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Page parameter: current page number. The minimum value is 1.
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// Billing mode. Valid values:
        /// prePay (Monthly subscription)
        /// postPay (Pay-As-You-Go resources)
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Transaction type. Valid values:
        /// prepay_purchase (Purchase)
        /// prepay_renew (Renewal)
        /// prepay_modify (Upgrade/Downgrade)
        /// prepay_return ( Monthly subscription refund)
        /// postpay_deduct (Pay-as-you-go)
        /// postpay_deduct_h (Hourly settlement)
        /// postpay_deduct_d (Daily settlement)
        /// postpay_deduct_m (Monthly settlement)
        /// offline_deduct (Offline project deduction)
        /// online_deduct (Offline product deduction)
        /// recon_deduct (Adjustment - deduction)
        /// recon_increase (Adjustment - compensation)
        /// ripay_purchase (One-off RI Fee)
        /// postpay_deduct_s (Spot)
        /// ri_hour_pay (Hourly RI fee)
        /// prePurchase (New monthly subscription)
        /// preRenew (Monthly subscription renewal)
        /// preUpgrade (Upgrade/Downgrade)
        /// preDowngrade (Upgrade/Downgrade)
        /// svp_hour_pay (Hourly Savings Plan fee)
        /// recon_guarantee (Minimum spend deduction)
        /// pre_purchase (New monthly subscription)
        /// pre_renew (Monthly subscription renewal)
        /// pre_upgrade (Upgrade/Downgrade)
        /// pre_downgrade (Upgrade/Downgrade)
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// Payment status
        /// 0: not distinguished
        /// 1: paid
        /// 2: unpaid
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
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "IsConfirmed", this.IsConfirmed);
        }
    }
}

