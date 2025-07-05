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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCdnDataRequest : AbstractModel
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
        /// `flux`: Traffic (in bytes)
        /// `fluxIn`: Upstream traffic (in bytes), only used for the `ecdn` product
        /// `fluxOut`: Downstream traffic (in bytes), only used for the `ecdn` product
        /// `bandwidth`: Bandwidth (in bps)
        /// `bandwidthIn`: Upstream bandwidth (in bps), only used for the `ecdn` product
        /// `bandwidthOut`: Downstream bandwidth (in bps), only used for the `ecdn` product
        /// `request`: Number of requests
        /// `hitRequest`: Number of hit requests
        /// `requestHitRate`: Request hit rate (in % with two decimal digits)
        /// `hitFlux`: Hit traffic (in bytes)
        /// `fluxHitRate`: Traffic hit rate (in % with two decimal digits)
        /// `statusCode`: Status code. The aggregate data for 2xx, 3xx, 4xx, and 5xx status codes will be returned (in entries)
        /// `2xx`: Returns the aggregate list of 2xx status codes and the data for status codes starting with 2 (in entries)
        /// `3xx`: Returns the aggregate list of 3xx status codes and the data for status codes starting with 3 (in entries)
        /// `4xx`: Returns the aggregate list of 4xx status codes and the data for status codes starting with 4 (in entries)
        /// `5xx`: Returns the aggregate list of 5xx status codes and the data for status codes starting with 5 (in entries)
        /// Specifies the status code to query. The return will be empty if the status code has never been generated.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Specifies the list of domain names to be queried
        /// You can specify one or more domain names.
        /// Up to 30 domain names can be queried in one request.
        /// If this parameter is not specified, it means to query all domain names under the current account.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// Specifies the project ID to be queried. [Check project ID in the console](https://console.cloud.tencent.com/project)
        /// Note that `Project` will be ignored if `Domains` is specified.
        /// </summary>
        [JsonProperty("Project")]
        public long? Project{ get; set; }

        /// <summary>
        /// Sampling interval. The available options vary for different query period. See below: 
        /// `min`: Return data with 1-minute granularity. It’s available when the query period is  within 24 hours and `Area` is `mainland`.
        /// `5min`: Return data with 5-minute granularity. It’s available when the query period is within 31 days.
        /// `hour`: Return data with 1-hour granularity. It’s available when the query period is within 31 days.
        /// `day`: Return data with 1-day granularity. It’s available when the query period is longer than 31 days.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// The aggregate data for multiple domain names is returned by default (false) during a multi-domain-name query.
        /// You can set it to true to return the details for each Domain (the statusCode metric is currently not supported).
        /// </summary>
        [JsonProperty("Detail")]
        public bool? Detail{ get; set; }

        /// <summary>
        /// Specifies an ISP when you query the CDN data within the Chinese mainland. If this is left blank, all ISPs will be queried.
        /// To view ISP codes, see [ISP Code Mappings](https://intl.cloud.tencent.com/document/product/228/6316?from_cn_redirect=1#.E5.8C.BA.E5.9F.9F-.2F-.E8.BF.90.E8.90.A5.E5.95.86.E6.98.A0.E5.B0.84.E8.A1.A8)
        /// Note that only one of `District`, `Isp` and `IpProtocol` can be specified.
        /// </summary>
        [JsonProperty("Isp")]
        public long? Isp{ get; set; }

        /// <summary>
        /// Specifies a province when you query the CDN data within the Chinese mainland. If this is left blank, all provinces will be queried.
        /// Specifies a country/region when you query the CDN data outside the Chinese mainland. If this is left blank, all countries/regions will be queried.
        /// To view codes of provinces or countries/regions, see [Province Code Mappings](https://intl.cloud.tencent.com/document/product/228/6316?from_cn_redirect=1#.E5.8C.BA.E5.9F.9F-.2F-.E8.BF.90.E8.90.A5.E5.95.86.E6.98.A0.E5.B0.84.E8.A1.A8).
        /// When `Area` is `mainland`, you can query by the province. Note that only one of `District`, `Isp` and `IpProtocol` can be specified.
        /// </summary>
        [JsonProperty("District")]
        public long? District{ get; set; }

        /// <summary>
        /// Specifies the protocol to be queried; if you leave it blank, all protocols will be queried.
        /// `all`: All protocols
        /// `http`: Query HTTP data
        /// `https`: Query HTTPS data
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Specifies the data source to be queried. It’s only open to beta users now. 
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// Specifies the IP protocol to be queried. If it’s not specified, data of all IP protocols are returned.
        /// `all`: All protocols
        /// `ipv4`: Query IPv4 data
        /// `ipv6`: Query IPv6 data
        /// If `IpProtocol` is specified, `District` parameter can not be specified at the same time.
        /// Note: `ipv4` and `ipv6` are only available to beta users. 
        /// </summary>
        [JsonProperty("IpProtocol")]
        public string IpProtocol{ get; set; }

        /// <summary>
        /// Specifies the service area. If it’s not specified, CDN data of the Chinese mainland are returned.
        /// `mainland`: Query CDN data in the Chinese mainland.
        /// `overseas`: Query CDN data outside the Chinese mainland.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Specify whether to query by the region of the server or client. This parameter is valid only when `Area` is `overseas`.
        /// `server`: Query by the location of server (Tencent Cloud CDN nodes)
        /// `client`: Query by the location of the client (where the request devices are located)
        /// </summary>
        [JsonProperty("AreaType")]
        public string AreaType{ get; set; }

        /// <summary>
        /// Specifies the product to query, either `cdn` (default) or `ecdn`.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

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
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "IpProtocol", this.IpProtocol);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "AreaType", this.AreaType);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

