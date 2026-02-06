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
        /// The start time.
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
        /// <li> l7Flow_outFlux_country: specifies the l7 EdgeOne response traffic metric counted by the country/region dimension.</li>
        /// <li> l7Flow_outFlux_province: specifies the l7 EdgeOne response traffic metric counted by the dimension of provinces in chinese mainland.</li>
        /// <li> l7Flow_outFlux_statusCode: specifies the l7 EdgeOne response traffic metric by status code dimension.</li>
        /// <li> l7Flow_outFlux_domain: specifies the l7 EdgeOne response traffic metric counted by domain name dimension.</li>
        /// <li>l7Flow_outFlux_url: specifies the l7 EdgeOne response traffic metric counted by url Path dimension.</li>
        /// <li> l7Flow_outFlux_resourceType: specifies the l7 EdgeOne response traffic metric counted by resource type dimension.</li>
        /// <li> l7Flow_outFlux_sip: specifies the l7 EdgeOne response traffic metric counted by the client IP dimension.</li>
        /// <li>l7Flow_outFlux_referers: specifies the l7 EdgeOne response traffic statistics by Referer dimension.</li>
        /// <li> l7Flow_outFlux_ua_device: specifies the l7 EdgeOne response traffic metric counted by device type dimension.</li>
        /// <li> l7Flow_outFlux_ua_browser: specifies the l7 EdgeOne response traffic metric by browser type dimension.</li>
        /// <li> l7Flow_outFlux_ua_os: specifies the l7 EdgeOne response traffic metric counted by the operating system type dimension.</li>
        /// <li> l7Flow_outFlux_ua: specifies the l7 EdgeOne response traffic metric by User-Agent dimension statistics.</li>
        /// <li> l7Flow_request_country: specifies the l7 access request count metric by country/region dimension.</li>
        /// <li> l7Flow_request_province: specifies the l7 access request count metric by province in the chinese mainland.</li>
        /// <li> l7Flow_request_statusCode: specifies the l7 access request count metric by status code dimension.</li>
        /// <li> l7Flow_request_domain: specifies the l7 access request count metric counted by the domain name dimension.</li>
        /// <li> l7Flow_request_url: specifies the l7 access request count metric counted by url Path dimension. </li>
        /// <li> l7Flow_request_resourceType: specifies the l7 access request count metric counted by the resource type dimension.</li>
        /// <li> l7Flow_request_sip: specifies the l7 access request count metric counted by the client IP dimension.</li>
        /// <li>l7Flow_request_referers: specifies l7 access request count metrics by referer dimension.</li>
        /// <li> l7Flow_request_ua_device: specifies the l7 access request count metric by device type dimension.</li>
        /// <li> l7Flow_request_ua_browser: specifies the l7 access request count metric by browser type dimension.</li>
        /// <li> l7Flow_request_ua_os: specifies the l7 access request count metric counted by the operating system type dimension.</li>
        /// <li> l7Flow_request_ua: l7 access request count metric counted by the User-Agent dimension.</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Site ID set. this parameter will change from option to required after may 30, 2024. for details, see the notice: [tencent cloud EdgeOne API change notification](https://www.tencentcloud.com/document/product/1552/104902?from_cn_redirect=1). a maximum of 100 site ids can be imported. use `*` to query all site data under the tencent cloud root account. querying account-level data requires all resource permissions for all sites in this interface.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Indicates the top N data to be queried. The maximum value is 1000. If this parameter is not input, the default value is 10, indicating querying the top 10 data.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter criteria used when filtering data. valid values refer to the available filter options for L7 access traffic, bandwidth, and request count in the [metric analysis filtering condition description](https://www.tencentcloud.com/document/product/1145/56985).
        /// If needed, limit the site or content identifier by importing the corresponding value in the `ZoneIds.N` parameter.
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// Query time granularity. this parameter is invalid. to be deprecated.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Data ownership region. this parameter is deprecated. please filter data by client region in `Filters.country`.
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

