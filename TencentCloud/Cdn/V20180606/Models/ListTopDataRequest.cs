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
        /// Starting time of the queried period, such as `2018-09-09 00:00:00`. Currently, only 1-day granularity is supported, so only the date information will be used for the query.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the queried period, such as `2018-09-10 00:00:00`. Currently, only 1-day granularity is supported, so only the date information will be used for the query. For example, to query data on September 10, 2018, just enter `StartTime=2018-09-10 00:00:00` and `EndTime=2018-09-10 00:00:00`.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Objects to be sorted. Valid values:
        /// `url`: sorts access URLs with query string parameters included. Supported filters are `flux` and `request`.
        /// `path`: sorts access URLs with query string parameters excluded. Supported filters are `flux` and `request`. You need to be whitelisted before using this feature.
        /// `district`: sorts provinces or countries/regions. Supported filters are `flux` and `request`.
        /// `isp`: sorts ISPs. Supported filters are `flux` and `request`.
        /// `host`: sorts domain name access data. Supported filters are `flux`, `request`, `bandwidth`, `fluxHitRate`, `2XX`, `3XX`, `4XX`, `5XX` and `statusCode`.
        /// `originHost`: sorts by domain name origin-pull data. Supported filters are `flux`, `request`, `bandwidth`, `origin_2XX`, `origin_3XX`, `oringin_4XX`, `origin_5XX` and `OriginStatusCode`
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
        /// Default value: `false`, indicating that results for all domain names are returned together when you query multiple domain names.
        /// If `Metric` is `Url`, `Path`, `District`, or `Isp` and `Filter` is `flux` or `request`, you can set this parameter to `true`, indicating that results for each domain name are returned.
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
        /// Specifies a region type for the query. If it is left blank, data on the service region will be queried. This parameter is only valid when `Area` is `overseas` and `Metric` is `District` or `Host`.
        /// `server`: specifies to query data on the service region where Tencent Cloud CDN nodes are located;
        /// `client`: specifies to query data on the client region where the request devices are located; if `Metric` is `Host`, supported filters are `flux`, `request`, and `bandwidth`.
        /// </summary>
        [JsonProperty("AreaType")]
        public string AreaType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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

