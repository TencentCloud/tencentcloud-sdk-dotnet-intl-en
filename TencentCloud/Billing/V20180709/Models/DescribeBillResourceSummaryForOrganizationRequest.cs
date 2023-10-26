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

    public class DescribeBillResourceSummaryForOrganizationRequest : AbstractModel
    {
        
        /// <summary>
        /// Pagination offset. If `Offset` is `0`, it indicates the first page. When `Limit` is `100`, if `Offset` is `100`, it indicates the second page; if `Offset` is `200`, it indicates the third page, and so on.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The number of entries returned at a time. The maximum value is `1000`.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Bill month in the format of "yyyy-mm". This value must be no earlier than the month when Bill 2.0 is activated.
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// Cycle type, which can be `byUsedTime` (by billing cycle) or `byPayTime` (by deduction time). This value must be the same as the billing period type in Billing Center for that particular month. You can check your billing cycle at the top of the [Bill Overview](https://console.cloud.tencent.com/expense/bill/overview) page.
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// Indicates whether the total number of records is required, used for pagination.
        /// Valid values: `1` (required), `0` (not required).
        /// </summary>
        [JsonProperty("NeedRecordNum")]
        public long? NeedRecordNum{ get; set; }

        /// <summary>
        /// Transaction type. This parameter needs to be input using the `ActionTypeName` value. Valid values:
        /// Monthly subscription purchase
        /// Monthly subscription renewal
        /// Monthly subscription upgrade/downgrade
        /// Monthly subscription refund 
        /// Pay-as-you-go deduction 
        /// Offline project deduction 
        /// Offline product deduction 
        /// Adjustment deduction 
        /// Adjustment compensation 
        /// Hourly pay-as-you-go 
        /// Daily pay-as-you-go 
        /// Monthly pay-as-you-go 
        /// Hourly spot instance 
        /// Offline project adjustment compensation 
        /// Offline product adjustment compensation 
        /// Offer deduction 
        /// Offer compensation 
        /// Pay-as-you-go resource migration in 
        /// Pay-as-you-go resource migration out 
        /// Monthly subscription resource migration in 
        /// Monthly subscription resource migration out 
        /// Prepaid 
        /// Hourly 
        /// RI refund 
        /// Pay-as-you-go reversal 
        /// Monthly subscription to pay-as-you-go 
        /// Minimum spend deduction 
        /// Hourly savings plan fee
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// ID of the instance to be queried.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Billing mode. Valid values: `prePay`, `postPay`.
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Product code
        /// Note: To query the product codes (`BusinessCode`) used in the current month, call <a href="https://intl.cloud.tencent.com/document/product/555/35761?from_cn_redirect=1">DescribeBillSummaryByProduct</a>.
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// Cost allocation tag key, which can be customized. This parameter can be used for querying bills after January 2021.
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }

        /// <summary>
        /// Resource tag value. If it is left empty, there are no records with tag values set under this tag key.
        /// This parameter can be used for querying bills after January 2021.
        /// </summary>
        [JsonProperty("TagValue")]
        public string TagValue{ get; set; }


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
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
            this.SetParamSimple(map, prefix + "TagValue", this.TagValue);
        }
    }
}

