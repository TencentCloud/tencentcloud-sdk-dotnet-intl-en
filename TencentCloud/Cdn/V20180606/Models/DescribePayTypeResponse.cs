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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePayTypeResponse : AbstractModel
    {
        
        /// <summary>
        /// Billing modes:
        /// `flux`: bill-by-traffic
        /// `bandwidth`: bill-by-bandwidth
        /// `request`: bill-by-request
        /// In case the billing mode is changed in the day, if there is bandwidth consumption occurred in the current day, the billing mode returned is the new billing mode for the next day. If no bandwidth consumption occurs, it indicates the current billing mode.
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// Billing cycle:
        /// day: daily settlement
        /// month: monthly settlement
        /// </summary>
        [JsonProperty("BillingCycle")]
        public string BillingCycle{ get; set; }

        /// <summary>
        /// `monthMax`: billed by the monthly average of daily peak traffic (monthly settlement)
        /// `day95`: billed by the daily 95th percentile bandwidth (monthly settlement)
        /// `month95`: billed by the monthly 95th percentile bandwidth (monthly settlement)
        /// `sum`: billed by the total traffic/total requests (daily or monthly settlement)
        /// `max`: billed by the peak bandwidth (daily settlement)
        /// </summary>
        [JsonProperty("StatType")]
        public string StatType{ get; set; }

        /// <summary>
        /// Billing method outside Mainland China:
        /// `all`: unified billing for all regions
        /// `multiple`: separate billing for different regions
        /// </summary>
        [JsonProperty("RegionType")]
        public string RegionType{ get; set; }

        /// <summary>
        /// The current billing mode in effect:
        /// `flux`: bill-by-traffic
        /// `bandwidth`: bill-by-bandwidth
        /// `request`: bill-by-request
        /// </summary>
        [JsonProperty("CurrentPayType")]
        public string CurrentPayType{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "BillingCycle", this.BillingCycle);
            this.SetParamSimple(map, prefix + "StatType", this.StatType);
            this.SetParamSimple(map, prefix + "RegionType", this.RegionType);
            this.SetParamSimple(map, prefix + "CurrentPayType", this.CurrentPayType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

