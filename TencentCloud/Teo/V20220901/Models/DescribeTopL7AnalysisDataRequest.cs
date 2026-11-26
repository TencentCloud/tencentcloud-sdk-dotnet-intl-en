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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopL7AnalysisDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time. The query time range (`EndTime` - `StartTime`) must be less than or equal to 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Queried metric. Valid values:
        /// <li> l7Flow_outFlux_country: L7 EdgeOne response traffic metric counted by the country/region dimension;</li>
        /// <li> l7Flow_outFlux_province: L7 EdgeOne response traffic metric counted by the dimension of provinces in Chinese mainland;</li>
        /// <li> l7Flow_outFlux_statusCode: L7 EdgeOne response traffic metric counted by the status code dimension;</li>
        /// <li> l7Flow_outFlux_domain: L7 EdgeOne response traffic metric counted by the domain name dimension;</li>
        /// <li> l7Flow_outFlux_url: l7 EdgeOne response traffic metric counted by url Path dimension; </li>
        /// <li> l7Flow_outFlux_resourceType: L7 EdgeOne response traffic metric counted by the resource type dimension;</li>
        /// <li> l7Flow_outFlux_sip: L7 EdgeOne response traffic metric counted by the client IP dimension;</li>
        /// <li> l7Flow_outFlux_referers: statistics of L7 EdgeOne response traffic by Referer dimension;</li>
        /// <li> l7Flow_outFlux_ua_device: L7 EdgeOne response traffic metric counted by the device type dimension;</li>
        /// <li> l7Flow_outFlux_ua_browser: L7 EdgeOne response traffic metric counted by the browser type dimension;</li>
        /// <li> l7Flow_outFlux_ua_os: L7 EdgeOne response traffic metric counted by the operating system type dimension;</li>
        /// <li> l7Flow_outFlux_ua: L7 EdgeOne response traffic metric by User-Agent dimension;</li>
        /// <li> l7Flow_request_country: L7 access request count metric counted by the country/region dimension;</li>
        /// <li> l7Flow_request_province: L7 access request count metric counted by the dimension of provinces in the Chinese mainland;</li>
        /// <li> l7Flow_request_statusCode: L7 access request count metric counted by the status code dimension;</li>
        /// <li> l7Flow_request_domain: L7 access request count metric counted by the domain name dimension;</li>
        /// <li> l7Flow_request_url: l7 access request count metrics counted by url Path dimension; </li>
        /// <li> l7Flow_request_resourceType: L7 access request count metric counted by the resource type dimension;</li>
        /// <li> l7Flow_request_sip: L7 access request count metric counted by the client IP dimension;</li>
        /// <li> l7Flow_request_referers: L7 access request count metric by Referer dimension;</li>
        /// <li> l7Flow_request_ua_device: L7 access request count metric counted by the device type dimension;</li>
        /// <li> l7Flow_request_ua_browser: L7 access request count metric counted by the browser type dimension;</li>
        /// <li> l7Flow_request_ua_os: L7 access request count metric counted by the operating system type dimension;</li>
        /// <li> l7Flow_request_ua: L7 access request count metric counted by the User-Agent dimension.</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Site ID set. This parameter will change from optional to required after May 30, 2024. For details, see the announcement: [Tencent Cloud EdgeOne Cloud API Change Notification](https://www.tencentcloud.com/document/product/1552/104902?from_cn_redirect=1). You can import up to 100 site IDs. To query data of all sites under the Tencent Cloud root account, use `*` instead. To query account-level data, you must have permission for all site resources of this interface.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Indicates the top N data to be queried. The maximum value is 1000. If this parameter is not input, the default value is 10, indicating querying the top 10 data.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter criteria used when filtering data. For values, see the available filter options for L7 access traffic, bandwidth, and request count in [Metric Analysis Filter Criteria](https://www.tencentcloud.com/document/product/1552/98219?from_cn_redirect=1#1aaf1150-55a4-4b4d-b103-3a8317ac7945).
        /// If you need to limit the site or content identifier, enter the corresponding value in the `ZoneIds.N` parameter.
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// Query time granularity. This parameter is invalid and to be deprecated.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Data ownership region. This parameter is deprecated. Please filter data by client region in `Filters.country`.
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
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

