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
        /// `flux`: Bill by traffic
        /// `bandwidth`: Bill by bandwidth
        /// `request`: Bill by the number of requests
        /// `flux_sep`: Disused field
        /// `bandwidth_sep`: Disused field
        /// When you change a daily billing mode to another, and there is network usage on the day of change, this field shows the new billing mode, which takes effect from the next day. If there is no network usage on the day of change, this field shows the new billing mode directly.
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// Billing cycle:
        /// `day`: Daily
        /// `month`: Monthly 
        /// `hour`: Hourly 
        /// </summary>
        [JsonProperty("BillingCycle")]
        public string BillingCycle{ get; set; }

        /// <summary>
        /// `monthMax`: Billed by the monthly average of daily peak traffic (monthly settlement)
        /// `day95`: Billed by the daily 95th percentile bandwidth (monthly settlement)
        /// `month95`: Billed by the monthly 95th percentile bandwidth (monthly settlement)
        /// `sum`: Billed by the total traffic/total requests (daily or monthly settlement)
        /// `max`: Billed by the peak bandwidth (daily settlement)
        /// </summary>
        [JsonProperty("StatType")]
        public string StatType{ get; set; }

        /// <summary>
        /// Billing method for regions outside the Chinese mainland:
        /// `all`: Unified billing for all regions
        /// `multiple`: Region-specific billing
        /// </summary>
        [JsonProperty("RegionType")]
        public string RegionType{ get; set; }

        /// <summary>
        /// The current billing mode in effect:
        /// `flux`: Billed by traffic
        /// `bandwidth`: Billed by bandwidth
        /// `request`: Billed by the number of requests
        /// `flux_sep`: Disused field
        /// `bandwidth_sep`: Disused field
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

