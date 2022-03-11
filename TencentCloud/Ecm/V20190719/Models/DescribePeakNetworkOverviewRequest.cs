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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePeakNetworkOverviewRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time (xxxx-xx-xx), such as `2019-08-14`. It is 7 days ago by default and should not be more than 30 days ago.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time (xxxx-xx-xx), such as `2019-08-14`. It is yesterday by default and should not be more than 30 days ago. When the time period between the start time and end time is within 1 day, data at the 1-minute granularity will be returned; when the time period is within 7 days, data at the 5-minute granularity will be returned; otherwise, data at the 1-hour granularity will be returned.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Filter.
        /// 
        /// region    String      Required: no     (Filter) Filter by region. Fuzzy match is not supported. Note: you need to enter the ECM region to be queried before data can be returned.
        /// area       String      Required: no     (Filter) Filter by region. Fuzzy match is not supported. Regions include `china-central`, `china-east`, etc. You can call `DescribeNode` to get the information of all regions. You can also use `ALL_REGION` to indicate all regions.
        /// isp         String      Required: no     (Filter) Filter region traffic by ISP. ISPs include CTCC, CUCC, and CMCC. This parameter must be used together with `area`, and you can specify only one ISP at a time.
        /// 
        /// You can specify either `region` or `area`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Statistical period in seconds. Valid values: 60, 300.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Period", this.Period);
        }
    }
}

