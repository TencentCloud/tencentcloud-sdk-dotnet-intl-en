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

    public class DescribeBillAdjustInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Format: yyyy-MM<br>Bill month. Either month or timeFrom&amp;timeTo must be specified. If timeFrom&amp;timeTo is specified, the month field is invalid.</p>
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// <p>Format: yyyy-MM-dd<br>Start time. Either month or timeFrom&amp;timeTo must be specified. If timeFrom&amp;timeTo is specified, the month field is invalid. timeFrom and timeTo must be specified together and must be in the same month. Cross-month queries are not supported and the query results are data for the entire month.</p>
        /// </summary>
        [JsonProperty("TimeFrom")]
        public string TimeFrom{ get; set; }

        /// <summary>
        /// <p>Format: yyyy-MM-dd<br>End time. Either month or timeFrom&amp;timeTo must be specified. If this field is specified, the month field is invalid. timeFrom and timeTo must be passed together and be in the same month. Cross-month queries are not supported. The query result is data of the entire month.</p>
        /// </summary>
        [JsonProperty("TimeTo")]
        public string TimeTo{ get; set; }

        /// <summary>
        /// <p>Account ID of the payer (Account ID is the unique account identifier for the user in Tencent Cloud). By default, the query returns the account statement of the current account. If the group management account needs to query the self-pay bills of member accounts, enter the member account UIN in this field.</p>
        /// </summary>
        [JsonProperty("PayerUin")]
        public string PayerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "TimeFrom", this.TimeFrom);
            this.SetParamSimple(map, prefix + "TimeTo", this.TimeTo);
            this.SetParamSimple(map, prefix + "PayerUin", this.PayerUin);
        }
    }
}

