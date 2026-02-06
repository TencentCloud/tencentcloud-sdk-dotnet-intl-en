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

    public class DescribePaymentDataLineChartRequest : AbstractModel
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
        /// IndexId (optional):
        /// order_user_num: Number of users placing orders
        /// order_num: Total orders
        /// total_amount: Total amount
        /// order_unpaid_num: Total unpaid orders
        /// unpaid_amount: Unpaid amount
        /// order_paid_num: Total paid orders
        /// paid_amount: Amount paid
        /// order_refund_num: Total refunded orders
        /// refund_amount: Total amount refunded
        /// </summary>
        [JsonProperty("IndexId")]
        public string IndexId{ get; set; }

        /// <summary>
        /// Input parameter base64 string: {"Platform":0,"MnpIds":["mp9e7qluz4i3z3km"],"BeginDate":20251031,"EndDate":20251129,"DataType":"1","PaymentType":1}
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

