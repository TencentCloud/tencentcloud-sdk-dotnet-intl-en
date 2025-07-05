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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEcdnStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// Query start time, such as 2019-12-13 00:00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Query end time, such as 2019-12-13 23:59:59
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Specifies the query metric, which can be:
        /// flux: traffic (in bytes)
        /// bandwidth: bandwidth (in bps)
        /// request: number of requests
        /// 2xx: returns the number of 2xx status codes or details of status codes starting with 2
        /// 3xx: returns the number of 3xx status codes or details of status codes starting with 3
        /// 4xx: returns the number of 4xx status codes or details of status codes starting with 4
        /// 5xx: returns the number of 5xx status codes or details of status codes starting with 5
        /// </summary>
        [JsonProperty("Metrics")]
        public string[] Metrics{ get; set; }

        /// <summary>
        /// Sampling interval in minutes. The available options vary for different query period. See below: 
        /// 1 day: `1`, `5`, `15`, `30`, `60`, `120`, `240`, `1440` 
        /// 2 to 3 days: `15`, `30`, `60`, `120`, `240`, `1440`
        /// 4 to 7 days: `30`, `60`, `120`, `240`, `1440`
        /// 8 to 31 days: `60`, `120`, `240`, `1440`
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// Specifies the list of domain names to be queried
        /// 
        /// Up to 30 acceleration domain names can be queried at a time.
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
        /// Statistical areas:
        /// mainland: Chinese mainland
        /// oversea: outside the Chinese mainland
        /// global: global
        /// Default value: global
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "Projects.", this.Projects);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

