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

    public class DescribeBillingDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Query start time, e.g., 2018-09-04 10:40:00. The returned result will be later than or equal to the specified time
        /// The time will be rounded forward based on the granularity parameter `Interval`. For example, if the query start time is 2018-09-04 10:40:00 and the query time granularity is 1-hour, the time for the first returned entry will be 2018-09-04 10:00:00
        /// The range between the start time and end time should be less than or equal to 90 days
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Query end time, e.g. 2018-09-04 10:40:00. The returned result will be earlier than or equal to the specified time
        /// The time will be rounded forward based on the granularity parameter `Interval`. For example, if the query end time is 2018-09-04 10:40:00 and the query time granularity is 1-hour, the time for the last returned entry will be 2018-09-04 10:00:00
        /// The range between the start time and end time should be less than or equal to 90 days
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
        /// Querying 1-minute granularity data is not supported if the `Area` field is `overseas`.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Domain name whose billing data is to be queried
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Project ID, which can be viewed [here](https://console.cloud.tencent.com/project)
        /// If the `Domain` parameter is populated with specific domain name information, then the billing data of this domain name instead of the specified project will be returned
        /// </summary>
        [JsonProperty("Project")]
        public long? Project{ get; set; }

        /// <summary>
        /// Acceleration region whose billing data is to be queried:
        /// mainland: in the mainland of China
        /// overseas: outside the mainland of China
        /// If this parameter is left empty, `mainland` will be used by default
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Country/region to be queried if `Area` is `overseas`
        /// For district or country/region codes, please see [District Code Mappings](https://intl.cloud.tencent.com/document/product/228/6316?from_cn_redirect=1#.E7.9C.81.E4.BB.BD.E6.98.A0.E5.B0.84)
        /// If this parameter is left empty, all countries/regions will be queried
        /// </summary>
        [JsonProperty("District")]
        public long? District{ get; set; }

        /// <summary>
        /// Billing statistics type
        /// flux: bill-by-traffic
        /// bandwidth: bill-by-bandwidth
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
        }
    }
}

