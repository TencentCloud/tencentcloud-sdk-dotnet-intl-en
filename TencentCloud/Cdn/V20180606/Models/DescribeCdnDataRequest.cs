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

    public class DescribeCdnDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Queries start time, such as 2018-09-04 10:40:00; the returned result is later than or equal to the specified time.
        /// According to the specified time granularity, forward rounding is applied; for example, if the query end time is 2018-09-04 10:40:00 and the query time granularity is 1 hour, the time for the first returned entry will be 2018-09-04 10:00:00.
        /// The gap between the start time and end time should be less than or equal to 90 days.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Queries end time, such as 2018-09-04 10:40:00; the returned result is earlier than or equal to the specified time.
        /// According to the specified time granularity, forward rounding is applied; for example, if the query start time is 2018-09-04 10:40:00 and the query time granularity is 1 hour, the time for the last returned entry will be 2018-09-04 10:00:00.
        /// The gap between the start time and end time should be less than or equal to 90 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Specifies the metric to query, which can be:
        /// `flux`: traffic (in bytes)
        /// `fluxIn`: upstream traffic (in bytes), only used for the `ecdn` product
        /// `fluxOut`: downstream traffic (in bytes), only used for the `ecdn` product
        /// `bandwidth`: bandwidth (in bps)
        /// `bandwidthIn`: upstream bandwidth (in bps), only used for the `ecdn` product
        /// `bandwidthOut`: downstream bandwidth (in bps), only used for the `ecdn` product
        /// `request`: number of requests
        /// `hitRequest`: number of hit requests
        /// `requestHitRate`: request hit rate (in % with two decimal digits)
        /// `hitFlux`: hit traffic (in bytes)
        /// `fluxHitRate`: traffic hit rate (in % with two decimal digits)
        /// `statusCode`: status code. Number of 2xx, 3xx, 4xx, and 5xx status codes returned during the queried period.
        /// `2xx`: lists the number of all status codes starting with **2** returned during the queried period based on the specified interval (if any)
        /// `3xx`: lists the number of all status codes starting with **3** returned during the queried period based on the specified interval (if any)
        /// `4xx`: lists the number of all status codes starting with **4** returned during the queried period based on the specified interval (if any)
        /// `5xx`: lists the number of all status codes starting with **5** returned during the queried period based on the specified interval (if any)
        /// Specifies the status code to query. The return will be empty if the status code has never been generated.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Queries the information of specified domain names
        /// Specifies a domain name to query
        /// Specifies multiple domain names to query (30 at most at a time)
        /// Queries all Specifies an account to query all domain names
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
        /// Time granularity; valid values:
        /// `min`: data with 1-minute granularity is returned when the queried period is no longer than 24 hours. This value is not supported if the service region you want to query is outside Mainland China;
        /// `5min`: data with 5-minute granularity is returned when the queried period is no longer than 31 days;
        /// `hour`: data with 1-hour granularity is returned when the queried period is no longer than 31 days;
        /// `day`: data with 1-day granularity is returned when the queried period is longer than 31 days.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// The aggregate data for multiple domain names is returned by default (false) during a multi-domain-name query.
        /// You can set it to true to return the details for each Domain (the statusCode metric is currently not supported)
        /// </summary>
        [JsonProperty("Detail")]
        public bool? Detail{ get; set; }

        /// <summary>
        /// Specifies an ISP when you query the CDN data within Mainland China. If this is left blank, all ISPs will be queried.
        /// To view ISP codes, see [ISP Code Mappings](https://intl.cloud.tencent.com/document/product/228/6316?from_cn_redirect=1#.E5.8C.BA.E5.9F.9F-.2F-.E8.BF.90.E8.90.A5.E5.95.86.E6.98.A0.E5.B0.84.E8.A1.A8)
        /// If you have specified an ISP, you cannot specify a province or an IP protocol for the same query.
        /// </summary>
        [JsonProperty("Isp")]
        public long? Isp{ get; set; }

        /// <summary>
        /// Specifies a province when you query the CDN data within Mainland China. If this is left blank, all provinces will be queried.
        /// Specifies a country/region when you query the CDN data outside Mainland China. If this is left blank, all countries/regions will be queried.
        /// To view codes of provinces or countries/regions, see [Province Code Mappings](https://intl.cloud.tencent.com/document/product/228/6316?from_cn_redirect=1#.E5.8C.BA.E5.9F.9F-.2F-.E8.BF.90.E8.90.A5.E5.95.86.E6.98.A0.E5.B0.84.E8.A1.A8)
        /// If you have specified a province for your query on CDN data within mainland China, you cannot specify an ISP or an IP protocol for the same query.
        /// </summary>
        [JsonProperty("District")]
        public long? District{ get; set; }

        /// <summary>
        /// Specifies the protocol to be queried; if you leave it blank, all protocols will be queried.
        /// all: All protocols
        /// http: specifies the HTTP metric to be queried
        /// https: specifies the HTTPS metric to be queried
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Specifies the data source to be queried, which can be seen as the allowlist function.
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// Specified IP protocol to be queried. If this parameter is left empty, all protocols will be queried
        /// all: all protocols
        /// ipv4: specifies to query IPv4 metrics
        /// ipv6: specifies to query IPv6 metrics
        /// If the IP protocol to be queried is specified, the district and ISP cannot be specified at the same time
        /// Note: non-IPv6 allowlisted users cannot specify `ipv4` and `ipv6` for query
        /// </summary>
        [JsonProperty("IpProtocol")]
        public string IpProtocol{ get; set; }

        /// <summary>
        /// Specifies a service region. If this value is left blank, CDN data within Mainland China will be queried.
        /// `mainland`: specifies to query CDN data within Mainland China;
        /// `overseas`: specifies to query CDN data outside Mainland China.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Specifies a region type for your query on CDN data outside Mainland China. If this parameter is left blank, data on the service region will be queried. This parameter is valid only when `Area` is `overseas`.
        /// `server`: specifies to query data on the service region where Tencent Cloud CDN nodes are located;
        /// `client`: specifies to query data on the client region where the request devices are located.
        /// </summary>
        [JsonProperty("AreaType")]
        public string AreaType{ get; set; }

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
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "IpProtocol", this.IpProtocol);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "AreaType", this.AreaType);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

