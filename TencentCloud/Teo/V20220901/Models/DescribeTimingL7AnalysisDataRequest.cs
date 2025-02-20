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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTimingL7AnalysisDataRequest : AbstractModel
    {
        
        /// <summary>
        /// The start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The end time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Metric list. valid values:.
        /// <Li>L7Flow_outFlux: l7 edgeone response traffic, unit: byte;</li>.
        /// <Li>L7Flow_inFlux: l7 client request traffic, unit: byte;</li>.
        /// <Li>L7Flow_flux: l7 total access traffic (including the edgeone response traffic and client request traffic), unit: byte;</li>.
        /// <Li>L7Flow_outBandwidth: l7 edgeone response bandwidth, unit: bps;</li>.
        /// <Li>L7Flow_inBandwidth: l7 client request bandwidth, unit: bps;</li>.
        /// <Li>L7Flow_bandwidth: l7 total access bandwidth (including the edgeone response bandwidth and client request bandwidth), unit: bps;</li>.
        /// <Li>L7Flow_request: l7 access request count, unit: times;</li>.
        /// <Li> l7flow_avgresponsetime: l7 average response time, unit: ms (milliseconds);</li>.
        /// <Li> l7flow_avgfirstbyteresponsetime: l7 average first byte response time for access, unit: ms.</li>.
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// Zone ID set. This parameter is required.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Query period granularity. Valid values:
        /// <li>min: 1 minute;</li>
        /// <li>5min: 5 minutes;</li>
        /// <li>hour: 1 hour;</li>
        /// <li>day: 1 day.</li>If this parameter is not filled in, the granularity will be automatically calculated based on the interval between the start time and end time. Specifically, data will be queried with a granularity of min, 5min, hour, and day respectively when the period is no more than 2 hours, no more than 2 days, no more than 7 days, and over 7 days.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filter criteria. The detailed key values are as follows:
        /// <li>country: Filter by country/region. The country/region follows the <a href="https://baike.baidu.com/item/ISO%203166-1/5269555">ISO 3166-1 alpha-2</a> standard. Example value: CN.</li>
        /// <li>province: Filter by province. This parameter is supported only when the service area is the Chinese mainland. For province codes, refer to the <a href="https://intl.cloud.tencent.com/document/product/228/6316?from_cn_redirect=1#.E5.8C.BA.E5.9F.9F-.2F-.E8.BF.90.E8.90.A5.E5.95.86.E6.98.A0.E5.B0.84.E8.A1.A8">Mapping Table of Provinces Within the Chinese Mainland</a>. Example value: 22.</li>
        /// <li>isp: Filter by ISP. This parameter is supported only when the service area is the Chinese mainland. Valid values are as follows:<br> 2: China Telecom;<br> 26: China Unicom;<br> 1046: China Mobile;<br> 3947: China Tietong;<br> 38: CERNET;<br> 43: Great Wall Broadband;<br> 0: other ISPs.</li>
        /// <li>domain: Filter by subdomain name. Example value: www.example.com.</li>
        /// <li>url: Filter by URL path. Example value: /content or /content/test.jpg. If the url parameter is input, up to 30 days of data can be queried.</li>
        /// <li>referer: Filter by Referer request header. Example value: http://www.example.com/. If the referer parameter is input, up to 30 days of data can be queried.</li>
        /// <li>resourceType: Filter by resource type, which is generally the file suffix. Example value: .jpg. If the resourceType parameter is input, up to 30 days of data can be queried;</li>
        /// <li>protocol: Filter by HTTP protocol version. Valid values are as follows:<br> HTTP/1.0;<br> HTTP/1.1;<br> HTTP/2.0;<br> HTTP/3;<br> WebSocket.</li><li>socket: Filter by HTTP protocol type. Valid values are as follows:<br> HTTP: HTTP protocol;<br> HTTPS: HTTPS protocol;<br> QUIC: QUIC protocol.</li>
        /// <li>statusCode: Filter by edge status code. If the statusCode parameter is input, up to 30 days of data can be queried. Valid values are as follows:<br> 1XX: 1xx status code;<br> 2XX: 2xx status code;<br> 3XX: 3xx status code;<br> 4XX: 4xx status code;<br> 5XX: 5xx status code;<br> An integer within the range [0,600).</li>
        /// <li>browserType: Filter by browser type. If the browserType parameter is input, up to 30 days of data can be queried. Valid values are as follows:<br> Firefox: Firefox browser;<br> Chrome: Chrome browser;<br> Safari: Safari browser;<br> Other: other browser types;<br> Empty: The browser type is empty;<br> Bot: search engine crawler;<br> MicrosoftEdge: Microsoft Edge browser;<br> IE: IE browser;<br> Opera: Opera browser;<br> QQBrowser: QQ browser;<br> LBBrowser: LB browser;<br> MaxthonBrowser: Maxthon browser;<br> SouGouBrowser: Sogou browser;<br> BIDUBrowser: Baidu browser;<br> TaoBrowser: Tao browser;<br> UBrowser: UC browser.</li>
        /// <li>deviceType: Filter by device type. If the deviceType parameter is input, up to 30 days of data can be queried. Valid values are as follows:<br> TV: TV device;<br> Tablet: tablet device;<br> Mobile: mobile device;<br> Desktop: desktop device;<br> Other: other device types;<br> Empty: The device type is empty.</li>
        /// <li>operatingSystemType: Filter by operating system type. If the operatingSystemType parameter is input, up to 30 days of data can be queried. Valid values are as follows:<br> Linux: Linux operating system;<br> MacOS: MacOS operating system;<br> Android: Android operating system;<br> IOS: iOS operating system;<br> Windows: Windows operating system;<br> NetBSD: NetBSD;<br> ChromiumOS: ChromiumOS;<br> Bot: search engine crawler;<br> Other: other types of operating systems;<br> Empty: The operating system is empty.</li>
        /// <li>tlsVersion: Filter by TLS version. If the tlsVersion parameter is input, up to 30 days of data can be queried. Valid values are as follows:<br> TLS1.0;<br> TLS1.1;<br> TLS1.2;<br> TLS1.3.</li>
        /// <li>ipVersion: Filter by IP version. Valid values are as follows:<br> 4: IPv4;<br> 6: IPv6.</li>
        /// <li>cacheType: Filter by cache status. Valid values are as follows:<br> hit: The request hits the EdgeOne node cache and the resources are provided by the node cache. A partial cache hit for resources is also recorded as hit.<br> miss: The request does not hit the EdgeOne node cache and the resources are provided by the origin server.<br> dynamic: The requested resources cannot be cached or are not configured with node cache and are provided by the origin server.<br> other: unrecognizable cache status. Requests responded to by edge functions are recorded as other.</li>
        /// <li>clientIp: Filter by client IP.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// Data region. Valid values:
        /// <li>overseas: global (excluding the Chinese mainland) data;</li>
        /// <li>mainland: Chinese mainland data;</li>
        /// <li>global: global data.</li>
        /// If this parameter is not filled in, the default value is global.
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
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

