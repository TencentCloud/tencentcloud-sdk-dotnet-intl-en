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

    public class DescribeBillDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Offset
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Quantity, maximum is 300
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// The period type. byUsedTime: By usage period; byPayTime: By payment period. Must be the same as the period of the current monthly bill of the Billing Center. You can check your bill statistics period type at the top of the [Bill Overview](https://console.cloud.tencent.com/expense/bill/overview) page. 
        /// </summary>
        [JsonProperty("PeriodType")]
        [System.Obsolete]
        public string PeriodType{ get; set; }

        /// <summary>
        /// Month; format: yyyy-mm. You only have to enter either Month or BeginTime and EndTime. When you enter values for BeginTime and EndTime, Month becomes invalid. This value must be no earlier than the month when Bill 2.0 is activated; last 24 months data are available.
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// The start time of the query range, which should be in the format Y-m-d H:i:s . The query range must be in the last 18 months and cannot be earlier than May 2018 (when Bill 2.0 was introduced). The start time and end time must be in the same month.
        /// 
        /// Example: tccli billing DescribeBillDetail --cli-unfold-argument --Offset 1 --Limit 100 --BeginTime '2023-04-01 12:05:15' --EndTime '2023-04-18 12:00:10' --ProjectId 1000000731  --version "2018-07-09"
        /// 
        /// Alternatively, you can use Month to query the billing details of a month.
        /// Example:
        /// ccli billing DescribeBillDetail --cli-unfold-argument --Offset 1 --Limit 100 --Month 2023-04  --version "2018-07-09" --ResourceId "disk-oj9okstm"
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// The end time of the query range, which should be in the format `Y-m-d H:i:s `. The query range must be in the last 18 months and cannot be earlier than May 2018 (when Bill 2.0 was introduced). The start time and end time must be in the same month.
        /// 
        /// Example: tccli billing DescribeBillDetail --cli-unfold-argument --Offset 1 --Limit 100 --BeginTime '2023-04-01 12:05:15' --EndTime '2023-04-18 12:00:10' --ProjectId 1000000731  --version "2018-07-09"
        /// 
        /// Alternatively, you can use `Month` to query the billing details of a month. 
        /// Example:
        /// ccli billing DescribeBillDetail --cli-unfold-argument --Offset 1 --Limit 100 --Month 2023-04  --version "2018-07-09" --ResourceId "disk-oj9okstm"
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Indicates whether or not the total number of records of accessing the list is required, used for frontend pages.
        /// 1 = yes, 0 = no
        /// </summary>
        [JsonProperty("NeedRecordNum")]
        public long? NeedRecordNum{ get; set; }

        /// <summary>
        /// Queries information on a specified product
        /// </summary>
        [JsonProperty("ProductCode")]
        [System.Obsolete]
        public string ProductCode{ get; set; }

        /// <summary>
        /// Billing mode: prePay/postPay
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Queries information on a specified resource
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Hourly settlement
        /// Daily settlement
        /// Monthly settlement
        /// Spot
        /// New monthly subscription
        /// Monthly subscription renewal
        /// Monthly subscription specification adjustment
        /// Monthly subscription refund
        /// Adjustment - deduction
        /// Adjustment - refund
        /// Hourly RI fee
        /// One-off RI Fee
        /// Hourly Savings Plan fee
        /// Offline project deduction
        /// Offline product deduction
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// Project ID: ID of the project to which the resource belongs
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Product code
        /// Note: To query the product codes used in the current month, call <a href="https://intl.cloud.tencent.com/document/product/555/35761?from_cn_redirect=1">DescribeBillSummaryByProduct</a>.
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Context information returned by the last request. You can set `Month` to `2023-05` or later to accelerate queries. We recommend users whose data volume is over 100 thousand entries use the paginated query feature, which can help greatly speed up your queries.
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

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
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NeedRecordNum", this.NeedRecordNum);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
        }
    }
}

