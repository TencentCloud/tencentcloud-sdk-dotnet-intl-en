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

    public class DescribeOriginDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time of the query, e.g., 2018-09-04 10:40:00.
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
        /// Specifies the metric to query, which can be:
        /// `flux`: Origin-pull traffic (in bytes)
        /// `bandwidth`: Origin-pull bandwidth (in bps)
        /// `request`: Number of origin-pull requests
        /// `failRequest`: Number of failed origin-pull requests
        /// `failRate`: Origin-pull failure rate (in %)
        /// `statusCode`: Origin-pull status code. The aggregate data for 2xx, 3xx, 4xx, and 5xx origin-pull status codes will be returned (in entries)
        /// `2xx`: Returns the aggregate list of 2xx origin-pull status codes and the data for origin-pull status codes starting with 2 (in entries)
        /// `3xx`: Returns the aggregate list of 3xx origin-pull status codes and the data for origin-pull status codes starting with 3 (in entries)
        /// `4xx`: Returns the aggregate list of 4xx origin-pull status codes and the data for origin-pull status codes starting with 4 (in entries)
        /// `5xx`: Returns the aggregate list of 5xx origin-pull status codes and the data for origin-pull status codes starting with 5 (in entries)
        /// It is supported to specify a status code for query. The return will be empty if the status code has never been generated.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Specifies the list of domain names to query. You can query up to 30 domain names at a time.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// Specifies the project ID to be queried. [Check project ID in the console](https://console.cloud.tencent.com/project)
        /// If the domain name is not specified, the specified project will be queried. Up to 30 acceleration domain names can be queried at a time.
        /// If the domain name information is specified, this parameter can be ignored.
        /// </summary>
        [JsonProperty("Project")]
        public long? Project{ get; set; }

        /// <summary>
        /// Time granularity, which can be:
        /// `min`: Return data with 1-minute granularity. It’s available when the query period is  within 24 hours and `Area` is `mainland`.
        /// `5min`: Return data with 5-minute granularity. It’s available when the query period is within 31 days.
        /// `hour`: Return data with 1-hour granularity. It’s available when the query period is within 31 days.
        /// `day`: Return data with 1-day granularity. It’s available when the query period is longer than 31 days.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// The aggregate data for multiple domain names is returned by default (false) when multiple `Domains` are passed in.
        /// You can set it to true to return the details for each Domain (the statusCode metric is currently not supported)
        /// </summary>
        [JsonProperty("Detail")]
        public bool? Detail{ get; set; }

        /// <summary>
        /// Specifies the service region. If this value is left blank, it means to query CDN data within the Chinese mainland.
        /// `mainland`: Query CDN data in the Chinese mainland.
        /// `overseas`: Query CDN data outside the Chinese mainland.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Specifies a time zone to query. The default time zone is UTC+08:00.
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
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

