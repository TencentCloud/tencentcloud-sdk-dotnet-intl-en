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

    public class DescribeBillResourceSummaryRequest : AbstractModel
    {
        
        /// <summary>
        /// Pagination offset. If `Offset` is `0`, it indicates the first page. If `Limit` is `100`, "`Offset` = `100`" indicates the second page, then "`Offset` = `200`" indicates the third page, and so on.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Quantity, maximum is 1000
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Bill month in the format of "yyyy-mm". This value must be no earlier than March 2019, when Bill 2.0 was launched.
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// The period type. byUsedTime: By usage period; byPayTime: by payment period. Must be the same as the period of the current monthly bill of the Billing Center. You can check your bill statistics period type at the top of the [Bill Overview](https://console.cloud.tencent.com/expense/bill/overview) page.
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// Indicates whether or not the total number of records of accessing the list is required, used for frontend pages.
        /// 1 = yes, 0 = no
        /// </summary>
        [JsonProperty("NeedRecordNum")]
        public long? NeedRecordNum{ get; set; }

        /// <summary>
        /// Action type to query. Valid values:
        /// Purchase
        /// Renewal
        /// Modify
        /// Refund
        /// Deduction
        /// Hourly settlement
        /// Daily settlement
        /// Monthly settlement
        /// Offline project deduction
        /// Offline deduction
        /// adjust-CR
        /// adjust-DR
        /// One-off RI Fee
        /// Spot
        /// Hourly RI fee
        /// New monthly subscription
        /// Monthly subscription renewal
        /// Monthly subscription specification adjustment
        /// Monthly subscription refund
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// ID of the instance to be queried
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Billing mode. Valid values: `prePay` (prepaid), `postPay` (postpaid)
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Product code
        /// Note: To query the product codes used in the current month, call <a href="https://intl.cloud.tencent.com/document/product/555/35761?from_cn_redirect=1">DescribeBillSummaryByProduct</a>.
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// The account ID of the payer, which is the unique identifier of a Tencent Cloud user. This account is allowed to query its own bills by default. If an organization admin account needs to query the self-pay bills of members, this field should be specified as the member account ID.
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamSimple(map, prefix + "NeedRecordNum", this.NeedRecordNum);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
        }
    }
}

