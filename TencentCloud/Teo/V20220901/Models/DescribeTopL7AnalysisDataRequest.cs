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

    public class DescribeTopL7AnalysisDataRequest : AbstractModel
    {
        
        /// <summary>
        /// The start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The end time. The query time range (`EndTime` - `StartTime`) must be less than or equal to 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Queried metric. Valid values:
        /// <li> l7Flow_outFlux_country: L7 EdgeOne response traffic aggregated by the country/region dimension;</li>
        /// <li> l7Flow_outFlux_province: L7 EdgeOne response traffic aggregated by the dimension of provinces in chinese mainland;</li>
        /// <li> l7Flow_outFlux_statusCode: L7 EdgeOne response traffic aggregated by the status code dimension;</li>
        /// <li> l7Flow_outFlux_domain: L7 EdgeOne response traffic aggregated by the domain name dimension;</li>
        /// <li>l7Flow_outFlux_url: L7 EdgeOne response traffic aggregated by url path dimension.</li>
        /// <li> l7Flow_outFlux_resourceType: L7 EdgeOne response traffic aggregated by the resource type dimension;</li>
        /// <li> l7Flow_outFlux_sip: L7 EdgeOne response traffic aggregated by the client IP dimension;</li>
        /// <li>l7Flow_outFlux_referers: L7 EdgeOne response traffic aggregated by referer dimension.</li>
        /// <li> l7Flow_outFlux_ua_device: L7 EdgeOne response traffic aggregated by the device type dimension;</li>
        /// <li> l7Flow_outFlux_ua_browser: L7 EdgeOne response traffic aggregated by the browser type dimension;</li>
        /// <li> l7Flow_outFlux_ua_os: L7 EdgeOne response traffic aggregated by the operating system type dimension;</li>
        /// <li> l7Flow_outFlux_ua: L7 EdgeOne response traffic aggregated by the User-Agent dimension;</li>
        /// <li> l7Flow_request_country: L7 request count aggregated by the country/region dimension;</li>
        /// <li> l7Flow_request_province: L7 request count aggregated by the dimension of provinces in the chinese mainland;</li>
        /// <li> l7Flow_request_statusCode: L7 request count aggregated by the status code dimension;</li>
        /// <li> l7Flow_request_domain: L7 request count aggregated by the domain name dimension;</li>
        /// <li>l7Flow_request_url: L7 request count aggregated by url Path dimension.</li>
        /// <li> l7Flow_request_resourceType: L7 request count aggregated by resource type dimension;</li>
        /// <li> l7Flow_request_sip: L7 request count aggregated by the client IP dimension;</li>
        /// <li>l7Flow_request_referer: L7 request count aggregated by referer dimension.</li>
        /// <li> l7Flow_request_ua_device: L7 request count aggregated by the device type dimension;</li>
        /// <li> l7Flow_request_ua_browser: L7 request count aggregated by the browser type dimension;</li>
        /// <li> l7Flow_request_ua_os: L7 request count aggregated by the operating system type dimension.</li>
        /// <li> l7Flow_request_ua: L7 request count aggregated by the User-Agent dimension.</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Zone ID set. This parameter is required. A maximum of 100 zone IDs can be passed in. If you need to query data for all zones under the Tencent Cloud main account, please use "*" instead. To query account-level data, you need to have full resource permissions for all zones of this interface.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Indicates the top N data to be queried. The maximum value is 1000. If this parameter is not input, the default value is 10, indicating querying the top 10 data.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter criteria. The detailed key values of filter criteria are as follows:
        /// <li>country: filter by country/region. The country/region follows the <a href="https://baike.baidu.com/item/ISO%203166-1/5269555">ISO 3166-1 alpha-2</a> standard. Example value: CN.</li>
        /// <li>province: filter by province. This parameter is supported only when the service area is the chinese mainland. refer to the <a href="https://intl.cloud.tencent.com/document/product/228/6316?from_cn_redirect=1#.E5.8C.BA.E5.9F.9F-.2F-.E8.BF.90.E8.90.a5.E5.95.86.E6.98.a0.E5.B0.84.E8.a1.a8">mapping table of provinces within the chinese mainland</a> for province codes. Example value: 22.</li>
        /// <li>isp: filter by isp. This parameter only supports the service area of chinese mainland. The corresponding value options are as follows:<br> 2: china telecom;<br> 26: china unicom;<br> 1046: cmcc;<br> 3947: china tietong;<br> 38: china education network;<br> 43: great wall broadband;<br> 0: other isp.</li>
        /// <Li>domain: filter by subdomain. Example value: www.example.com.</li>
        /// <li>url: filter by url Path. Example value: /content or /content/test.jpg. If you fill in url parameters, you can query the data of the last 30 days at most.</li>
        /// <Li>referer: filter by referer request header. Example value: http://www.example.com/. If the referer parameter is provided, up to 30 days of data can be queried.</li>
        /// <li>resourceType: filter by resource type. The resource type is generally a file suffix. Example value: .jpg. If the resourceType parameter is provided, data from the last 30 days can be queried at most;</li>
        /// <li>protocol: filter by HTTP protocol version. The corresponding value options are as follows:<br> HTTP/1.0;<br> HTTP/1.1;<br> HTTP/2.0;<br> HTTP/3;<br> WebSocket.</li>
        /// <li>socket: filter by HTTP protocol type. The corresponding value options are as follows:<br>HTTP: hypertext transfer protocol;<br>HTTPS: HTTPS protocol;<br>QUIC: QUIC protocol.</li>
        /// <li>statusCode: filter by edge status code. If the statusCode parameter is filled in, data from the last 30 days can be queried at most. The corresponding value options are as follows:<br> 1XX: 1XX type status codes;<br> 2XX: 2XX type status codes;<br> 3XX: 3XX type status codes;<br> 4XX: 4XX type status codes;<br> 5XX: 5XX type status codes;<br> integers within the range [0,600).</li>
        /// <li>browserType: filter by browser type. If the browserType parameter is filled in, data from the last 30 days can be queried at most. The options for The corresponding value are as follows:<br> Firefox: Firefox browser;<br> Chrome: Chrome browser;<br> Safari: Safari browser;<br> Other: Other browser types;<br> Empty: browser type is Empty;<br> Bot: search engine crawler;<br> MicrosoftEdge: microsoft edge browser;<br> IE: IE browser;<br> Opera: Opera browser;<br> QQBrowser: QQ browser;<br> LBBrowser: LB browser;<br> MaxthonBrowser: Maxthon browser;<br> SouGouBrowser: sogou browser;<br> BIDUBrowser: BIDUBrowser;<br> TaoBrowser: TaoBrowser;<br> UBrowser: UC browser.</li>
        /// <li>deviceType: filter by device type. If the deviceType parameter is filled in, data from the last 30 days can be queried at most. The options for The corresponding value are as follows:<br> TV: TV device;<br> Tablet: Tablet device;<br> Mobile: Mobile device;<br> Desktop: Desktop device;<br> Other: Other device type;<br> Empty: device type Empty.</li>
        /// <li>operatingSystemType: filter by operating system type. If the operatingSystemType parameter is filled in, data from the last 30 days can be queried at most. The options for The corresponding value are as follows:<br> Linux: Linux operating system;<br> MacOS: MacOS operating system;<br> Android: Android operating system;<br> IOS: IOS operating system;<br> Windows: Windows operating system;<br> NetBSD: NetBSD;<br> ChromiumOS: ChromiumOS;<br> Bot: Bot: search engine crawler;<br> Other: Other types of operating systems;<br> Empty: operating system is Empty.</li>
        /// <li>tlsVersion: filter by TLS version. If the tlsVersion parameter is input, data from the last 30 days can be queried at most. The options for The corresponding value are as follows:<br> TLS1.0;<br> TLS1.1;<br> TLS1.2;<br> TLS1.3.</li>
        /// <li>ipVersion: filter by IP version. The options for the corresponding value are as follows:<br> 4: IPv4;<br> 6: IPv6.</li>
        /// <li>cacheType: filter by cache status. The options for The corresponding value are as follows:<br>hit: request hits EdgeOne node cache, and resources are provided by node cache. partial cache hit for resources is also recorded as hit.<br>miss: request does not hit EdgeOne node cache, and resources are provided by the origin server.<br>dynamic: requested resources cannot be cached/unconfigured to be cached by node cache, and resources are provided by the origin server.<br>other: unrecognizable cache status. requests responded to by edge functions are recorded as other.</li>
        /// <li>clientIp: filter by client IP. If the clientIp parameter is filled in, data from the last 30 days can be queried at most.</li>
        /// <li>userAgent: filter by User-Agent request header. If the userAgent parameter is filled in, data from the last 30 days can be queried at most.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

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
        /// Data ownership region. this parameter is deprecated. Please filter data by client region in Filters.country.
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

