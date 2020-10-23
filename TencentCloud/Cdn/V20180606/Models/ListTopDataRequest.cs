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

    public class ListTopDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Query start time in the format of `yyyy-MM-dd HH:mm:ss`
        /// Only supports data query at daily granularity. The date in the input parameter is used as the start date.
        /// Data generated after or at 00:00:00 on the start date will be returned
        /// Only data for the last 90 days can be queried
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Query end time in the format of `yyyy-MM-dd HH:mm:ss`
        /// Only supports data query at daily granularity. The date in the input parameter is used as the end date.
        /// Data generated before or at 23:59:59 on the end date will be returned
        /// `EndTime` must be later than or equal to `StartTime`
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Object representing the sort criteria. The following objects are supported:
        /// url: sorts by access URL (including the query string). Supported filters are `flux` and `request`
        /// path: sorts by access URL (excluding the query string). Supported filters are `flux` and `request` (allowlist-based feature)
        /// district: sorts by district. Supported filters are `flux` and `request`
        /// isp: sorts by ISP. Supported filters are `flux` and `request`
        /// host: sorts by domain name access data. Supported filters are `flux`, `request`, `bandwidth`, `fluxHitRate`, 2XX, 3XX, 4XX, 5XX, and `statusCode`
        /// originHost: sorts by domain name origin-pull data. Supported filters are `flux`, `request`, `bandwidth`, `origin_2XX`, `origin_3XX`, `origin_4XX`, `origin_5XX`, and `OriginStatusCode`
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Metric name used for sorting:
        /// flux: If Metric is `host`, it indicates the access traffic; if Metric is `originHost`, it indicates the origin-pull traffic.
        /// bandwidth: If Metric is `host`, it indicates the access bandwidth; if Metric is `originHost`, it indicates the origin-pull bandwidth.
        /// request: If Metric is `host`, it indicates the number of access requests; if Metric is `originHost`, it indicates the number of origin-pull requests.
        /// fluxHitRate: Average traffic hit rate
        /// 2XX: access 2XX status code
        /// 3XX: access 3XX status code
        /// 4XX: access 4XX status code
        /// 5XX: access 5XX status code
        /// origin_2XX: origin-pull 2XX status code
        /// origin_3XX: origin-pull 3XX status code
        /// origin_4XX: origin-pull 4XX status code
        /// origin_5XX: origin-pull 5XX status code
        /// statusCode: statistics of a specific access status code which is specified in the `Code` parameter.
        /// OriginStatusCode: statistics of a specific origin-pull status code which is specified in the `Code` parameter.
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// Specifies the list of domain names to be queried; up to 30 domain names can be queried at a time.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// Specifies the project ID to be queried, which can be viewed [here](https://console.cloud.tencent.com/project)
        /// Please note that if domain names are specified, this parameter will be ignored.
        /// </summary>
        [JsonProperty("Project")]
        public long? Project{ get; set; }

        /// <summary>
        /// Default is `false` for multi-domain name queries, which returns sorted results of all domain names. 
        /// If `Metric` is `url`, `path`, `district`, or `isp` and `Filter` is `flux` or `request`, it can be set to `true` to return the sorted results of each domain.
        /// </summary>
        [JsonProperty("Detail")]
        public bool? Detail{ get; set; }

        /// <summary>
        /// When Filter is `statusCode` or `OriginStatusCode`, enter a code to query and sort results.
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// Specifies a service region for the query. If it is left blank, CDN data within Mainland China will be queried.
        /// `mainland`: specifies to query CDN data within Mainland China;
        /// `overseas`: specifies to query CDN data outside Mainland China. Supported metrics are `url`, `district`, `host`, and `originHost`. If `Metric` is `originHost`, supported filters are `flux`, `request`, and `bandwidth`.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// The region type can be specified only when you query CDN data outside Mainland China and `Metric` is `district` or `host`; if you leave it empty, data of the service region will be queried (only applicable when `Area` is `overseas` and `Metric` is `district` or `host`)
        /// server: specifies to query data of service region (where a CDN node is located)
        /// client: specifies to query data of the client region (where a user request device is located). If `Metric` is `host`, `Filter` can only be `flux`, `request`, or `bandwidth`
        /// </summary>
        [JsonProperty("AreaType")]
        public string AreaType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "AreaType", this.AreaType);
        }
    }
}

