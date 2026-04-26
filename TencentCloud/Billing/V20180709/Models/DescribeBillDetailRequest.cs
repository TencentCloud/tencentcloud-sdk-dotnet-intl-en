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
        /// Pagination offset. Offset=0 indicates the first page. If Limit=100, Offset=100 indicates the second page, Offset=200 indicates the third page, and so on.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The number of entries returned at a time. The maximum value is `300`.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Period type, byUsedTime by billing period/byPayTime by fee deduction cycle. It should be consistent with the billing cycle for the month in the expense center. You can go to the top of the [bill overview](https://console.cloud.tencent.com/expense/bill/overview) page to view and confirm your billing cycle type.
        /// </summary>
        [JsonProperty("PeriodType")]
        [System.Obsolete]
        public string PeriodType{ get; set; }

        /// <summary>
        /// The month is in the format of yyyy-mm. Either Month or BeginTime&EndTime must be specified. If BeginTime&EndTime is specified, the Month field is invalid. Data within the last 18 months can be pulled at most.
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// The start time of the period in the format of yyyy-mm-dd hh:ii:ss. Either Month or BeginTime&EndTime must be specified. If BeginTime&EndTime is specified, the Month field is invalid. BeginTime and EndTime must be specified together and must be in the same month. Cross-month queries are not supported and the query results are data for the entire month. Data within the last 18 months can be pulled at most.
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// The end time of the period in the format of yyyy-mm-dd hh:ii:ss. Either Month or BeginTime&EndTime must be specified. If BeginTime&EndTime is specified, the Month field is invalid. BeginTime and EndTime must be specified together and must be in the same month. Cross-month queries are not supported and the query results are data for the entire month. Data within the last 18 months can be pulled at most.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Total number of records for access list needed for frontend pagination
        /// 1: needed, 0: not needed
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
        /// Yearly/monthly subscription
        /// Spot
        /// New yearly/monthly subscription
        /// Yearly/monthly subscription renewal
        /// Yearly/monthly subscription specification adjustment
        /// Yearly/monthly subscription refund
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
        /// Project ID: Project ID of the resource
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Product name code
        /// Remark: If needed to obtain BusinessCode used in current month, invoke API: <a href="https://www.tencentcloud.com/document/product/555/35761?from_cn_redirect=1">Get fee distribution by product</a>
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Context information returned from the last request. Paginated query of data for months with Month>=2023-05 can speed up query speed. Recommended for users with data volume at tens of thousands level. Query speed can be improved by 2-10x.
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// Account ID of the payer (Account ID is the unique account identifier for the user in Tencent Cloud). By default, the query returns the account statement of the current account. If the group management account needs to query the self-pay bills of member accounts, enter the member account UIN in this field.
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

