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
        /// If the specified start date is greater than 00:00:00, it will be rounded down to 00:00:00 on the date. For example, if `StartTime` is 2018-09-04 10:40:00, it will be rounded down to 2018-09-04 00:00:00.
        /// Only data from the last 90 days will be queried.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Query end time in the format of `yyyy-MM-dd HH:mm:ss`
        /// Only supports data query at daily granularity. The date in the input parameter is used as the end date.
        /// If the specified end date is smaller than 23:59:59, it will be rounded up to 23:59:59 on the date. For example, if `EndTime` is 2018-09-05 22:40:00, it will be rounded up to 2018-09-05 23:59:59.
        /// `EndTime` must be later than or equal to `StartTime`
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Objects to be sorted. Valid values:
        /// `url`: Sort by access URL (URLs carrying no parameters). Supported filters are `flux` and `request`.
        /// `district`: sorts provinces or countries/regions. Supported filters are `flux` and `request`.
        /// `isp`: sorts ISPs. Supported filters are `flux` and `request`.
        /// `host`: Sort by domain name access data. Supported filters are `flux`, `request`, `bandwidth`, `fluxHitRate`, and `statusCode` (2XX, 3XX, 4XX, 5XX).
        /// `originHost`: Sort by domain name origin-pull data. Supported filters are `flux`, `request`, `bandwidth`, and `OriginStatusCode` (origin_2XX, origin_3XX, origin_4XX, origin_5XX).
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
        /// The sorted results of all domain names are returned by default (false) during a multi-domain-name query
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
        /// Specifies the service region. If this value is left blank, it means to query CDN data within the Chinese mainland.
        /// `mainland`: Query CDN data in the Chinese mainland.
        /// `overseas`: Query CDN data outside the Chinese mainland. Supported metrics are `url`, `district`, `host`, and `originHost`. If `Metric` is `originHost`, supported filters are `flux`, `request`, and `bandwidth`.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Specifies a region type for the query. If it is left blank, data of the service region will be queried. This parameter is only valid when `Area` is `overseas` and `Metric` is `district` or `host`.
        /// `server`: Query by the location of server (Tencent Cloud CDN nodes).
        /// `client`: Query data of the client region where the request devices are located; if `Metric` is `host`, supported filters are `flux`, `request`, and `bandwidth`.
        /// </summary>
        [JsonProperty("AreaType")]
        public string AreaType{ get; set; }

        /// <summary>
        /// Specifies the product to query, either `cdn` (default) or `ecdn`.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Returns the first N data entries. The default value is 100 if this parameter is not specified, whereas 1000 if `Metric` is `url`.
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
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "AreaType", this.AreaType);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

