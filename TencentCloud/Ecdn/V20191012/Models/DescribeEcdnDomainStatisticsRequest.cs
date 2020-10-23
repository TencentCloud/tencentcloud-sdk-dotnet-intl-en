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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEcdnDomainStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// Query start time, such as 2019-12-13 00:00:00.
        /// The time span cannot exceed 90 days.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Query end time, such as 2019-12-13 23:59:59.
        /// The time span cannot exceed 90 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Statistical metric name. flux: traffic in bytes
        /// bandwidth: bandwidth in bps
        /// request: number of requests
        /// delay: response time in ms
        /// static_request: number of static requests
        /// static_flux: static traffic in bytes
        /// static_bandwidth: static bandwidth in bps
        /// dynamic_request: number of dynamic requests
        /// dynamic_flux: dynamic traffic in bytes
        /// dynamic_bandwidth: dynamic bandwidth in bps
        /// </summary>
        [JsonProperty("Metrics")]
        public string[] Metrics{ get; set; }

        /// <summary>
        /// Specifies the list of domain names to be queried
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// Specifies the project ID to be queried, which can be viewed [here](https://console.cloud.tencent.com/project)
        /// If no domain name is entered, the specified project will be queried; otherwise, the domain name will prevail
        /// </summary>
        [JsonProperty("Projects")]
        public long?[] Projects{ get; set; }

        /// <summary>
        /// Pagination offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of entries per page. Default value: 1000. Maximum value: 3,000.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Metrics.", this.Metrics);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "Projects.", this.Projects);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

