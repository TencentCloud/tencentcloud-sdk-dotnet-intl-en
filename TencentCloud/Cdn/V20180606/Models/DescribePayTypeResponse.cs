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
        /// Billing type
        /// `flux`: Bill by traffic
        /// `bandwidth`: Bill by bandwidth
        /// `request`: Bill by the number of requests
        /// `flux_sep`: Bill by dynamic and static traffic separately 
        /// `bandwidth_sep`: Bill by dynamic and static bandwidth separately
        /// If you incur any usage when switching the billing mode, the new mode will take effect the next day. If no usage is incurred, the new mode takes effect immediately.
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// Billing cycle
        /// `day`: Daily
        /// `month`: Monthly
        /// `hour`: Hourly
        /// </summary>
        [JsonProperty("BillingCycle")]
        public string BillingCycle{ get; set; }

        /// <summary>
        /// Statistic data
        /// `monthMax`: Billed monthly based on the monthly average daily peak traffic
        /// `day95`: Billed monthly based on the daily 95th percentile bandwidth
        /// `month95`: Billed monthly based on the monthly 95th percentile bandwidth
        /// `sum`: Billed daily/monthly based on the total traffic or requests
        /// `max`: Billed daily based on the peak bandwidth
        /// </summary>
        [JsonProperty("StatType")]
        public string StatType{ get; set; }

        /// <summary>
        /// Regionl billing
        /// `all`: Unified billing for all regions
        /// `multiple`: Region-specific billing
        /// </summary>
        [JsonProperty("RegionType")]
        public string RegionType{ get; set; }

        /// <summary>
        /// Current billing mode
        /// `flux`: Bill by traffic
        /// `bandwidth`: Bill by bandwidth
        /// `request`: Bill by the number of requests
        /// `flux_sep`: Bill by dynamic and static traffic separately 
        /// `bandwidth_sep`: Bill by dynamic and static bandwidth separately
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

