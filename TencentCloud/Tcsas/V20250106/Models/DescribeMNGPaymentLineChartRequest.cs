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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMNGPaymentLineChartRequest : AbstractModel
    {
        
        /// <summary>
        /// Tenant ID
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// Fixed value: payment_data_analysis
        /// </summary>
        [JsonProperty("ReportId")]
        public string ReportId{ get; set; }

        /// <summary>
        /// Valid values:
        /// mng_paid_amount: Virtual payment amount,
        /// paid_user_num: Number of paying users,
        /// new_paid_user_num: Number of new paying users,
        /// new_paid_user_amount: Revenue from new paying users,
        /// new_paid_user_ratio: Percentage of new users who made payments,
        /// arppu: Average revenue per paying user (ARPPU),
        /// mng_refund_num: Number of refund orders
        /// mng_refund_amount: Refund amount
        /// </summary>
        [JsonProperty("IndexId")]
        public string IndexId{ get; set; }

        /// <summary>
        /// Input parameter base64 string: {"Platform":0,"MnpId":"mgcp5xc2yzw8aixv","BeginDate":20251028,"EndDate":20251126,"DataType":"1","PaymentType":2}
        /// </summary>
        [JsonProperty("QueryData")]
        public string QueryData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "ReportId", this.ReportId);
            this.SetParamSimple(map, prefix + "IndexId", this.IndexId);
            this.SetParamSimple(map, prefix + "QueryData", this.QueryData);
        }
    }
}

