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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillingDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time of the query, e.g. 2018-09-04 10:40:00.
        /// The specified start time will be rounded down based on the granularity parameter `Interval`. For example, if you set the start time to 2018-09-04 10:40:00 with 1-hour granularity, the time will be rounded down to 2018-09-04 10:00:00.
        /// The period between the start time and end time can be up to 90 days.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the query, e.g. 2018-09-04 10:40:00.
        /// The specified end time will be rounded down based on the granularity parameter `Interval`. For example, if you set the end time to 2018-09-04 10:40:00 with 1-hour granularity, the time will be rounded down to 2018-09-04 10:00:00.
        /// The period between the start time and end time can be up to 90 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Time granularity, which can be:
        /// `min`: 1-minute granularity. The query period cannot exceed 24 hours.
        /// `5min`: 5-minute granularity. The query range cannot exceed 31 days.
        /// `hour`: 1-hour granularity. The query period cannot exceed 31 days.
        /// `day`: 1-day granularity. The query period cannot exceed 31 days.
        /// 
        /// `min` is not supported if the `Area` field is `overseas`.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Domain name whose billing data is to be queried
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Specifies the project ID to be queried. [Check project ID in the console](https://console.cloud.tencent.com/project)
        /// If the `Domain` parameter is passed in, the `Proejct` parameter is ignored. Only the billing data of the specified domain name is returned. 
        /// </summary>
        [JsonProperty("Project")]
        public long? Project{ get; set; }

        /// <summary>
        /// Acceleration region whose billing data is to be queried:
        /// `mainland`: Regions within the Chinese mainland
        /// `overseas`: Regions outside the Chinese mainland
        /// If this parameter is left empty, `mainland` will be used by default
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Country/region to be queried if `Area` is `overseas`
        /// To view codes of provinces or countries/regions, see [Province Code Mappings](https://intl.cloud.tencent.com/document/product/228/6316?from_cn_redirect=1#.E7.9C.81.E4.BB.BD.E6.98.A0.E5.B0.84)
        /// If this parameter is left empty, all countries/regions will be queried
        /// </summary>
        [JsonProperty("District")]
        public long? District{ get; set; }

        /// <summary>
        /// Billing statistics type
        /// `flux`: Bill by traffic
        /// `bandwidth`: Bill by bandwidth
        /// Default value: `bandwidth`
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Specifies the product to query, either `cdn` (default) or `ecdn`.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

