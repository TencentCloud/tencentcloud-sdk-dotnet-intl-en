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
        /// The list of metrics. Values:
        /// <li>`l7Flow_outFlux`: Access traffic;</li>
        /// <li>`l7Flow_request`: Access requests;</li>
        /// <li>`l7Flow_outBandwidth`: Access bandwidth.</li>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// List of sites
        /// Enter the IDs of sites to query. The maximum query period is determined by the <a href="https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1#edgeone-.E5.A5.97.E9.A4.90">max data query period</a> of the bound plan. If it's not specified, all sites are selected by default, and the query period must be within the last 30 days. 
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// The query granularity. Values:
        /// <li>`min`: 1 minute;</li>
        /// <li>`5min`: 5 minutes;</li>
        /// <li>`hour`: 1 hour;</li>
        /// <li>`day`: 1 day.</li>If this field is not specified, the granularity will be determined based on the query period. <br>Period <= 1 hour: `min`; <br>1 hour < Period <= 2 days: `5min`; <br>2 days < period <= 7 days: `hour`; <br>Period > 7 days: `day`.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Filters
        /// <li>`country`:<br>   Filter by the specified <strong>country code</strong>. <a href="https://en.wikipedia.org/wiki/ISO_3166-1">ISO 3166</a> country codes are used.</li>
        /// <li>`province`<br>   Filter by the specified <strong>province name</strong>. It's only available when `Area` is `mainland`. </li>
        /// <li>`isp`<br>   Filter by the specified <strong>ISP</strong>. It's only available when `Area` is `mainland`.<br>   Values: <br>   `2`: CTCC; <br>   `26`: CUCC;<br>   `1046`: CMCC;<br>   `3947`: CTT; <br>   `38`: CERNET; <br>   `43`: GWBN;<br>   `0`: Others</li>
        /// <li>`domain`<br>   Filter by the specified <strong>sub-domain name</strong>, such as `test.example.com`</li>
        /// <li>`url`<br>   Filter by the specified <strong>URL Path</strong> (such as `/content` or `content/test.jpg`.<br>   When this parameter is specified, the query period must be within the last 30 days. <br>   In this case, the supported <a href="https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1#edgeone-.E5.A5.97.E9.A4.90">max data query period</a> stated when `Zonelds` is specified become invalid.</li>
        /// <li>`referer`<br>   Filter by the specified <strong>Referer header</strong>, such as `example.com`.<br>   When this parameter is specified, the query period must be within the last 30 days. <br>   In this case, the supported <a href="https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1#edgeone-.E5.A5.97.E9.A4.90">max data query period</a> stated when `Zonelds` is specified become invalid.</li>
        /// <li>`resourceType`<br>   Filter by the specified <strong>resource file type</strong>, such as `jpg`, `css`. <br>   When this parameter is specified, the query period must be within the last 30 days. <br>   In this case, the supported <a href="https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1#edgeone-.E5.A5.97.E9.A4.90">max data query period</a> stated when `Zonelds` is specified become invalid.</li>
        /// <li>`protocol`:<br>   Filter by the specified <strong>HTTP protocol</strong><br>   Values:<br>   `HTTP/1.0`: HTTP 1.0<br>   `HTTP/1.1`: HTTP 1.1<br>   `HTTP/2.0`: HTTP 2.0<br>   `HTTP/3.0`: HTTP 3.0<br>   `WebSocket`: WebSocket</li>
        /// <li>`statusCode`<br>   Filter by the specified <strong> status code</strong>. <br>   When this parameter is specified, the query period must be within the last 30 days. <br>   In this case, the supported <a href="https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1#edgeone-.E5.A5.97.E9.A4.90">max data query period</a> stated when `Zonelds` is specified become invalid.<br>   Values: <br>   `1XX`: All 1xx status codes;<br>   `100`: 100 status code;<br>   `101`: 101 status code;<br>   `102`: 102 status code;<br>   `2XX`: All 2xx status codes;<br>   `200`: 200 status code;<br>   `201`: 201 status code;<br>   `202`: 202 status code;<br>   `203`: 203 status code;<br>   `204`: 204 status code;<br>   `205`: 205 status code;<br>   `206`: 206 status code;<br>   `207`: 207 status code;<br>  `3XX`: All 3xx status codes;<br>   `300`: 300 status code;<br>   `301`: 301 status code;<br>   `302`: 302 status code;<br>   `303`: 303 status code;<br>   `304`: 304 status code;<br>   `305`: 305 status code;<br>   `307`: 307 status code;<br>   `4XX`: All 4xx status codes;<br>   `400`: 400 status code;<br>   `401`: 401 status code;<br>   `402`: 402 status code;<br>   `403`: 403 status code;<br>   `404`: 404 status code;<br>   `405`: 405 status code;<br>   `406`: 406 status code;<br>   `407`: 407 status code;<br>   `408`: 408 status code;<br>   `409`: 409 status code;<br>   `410`: 410 status code;<br>   `411`: 411 status code;<br>   `412`: 412 status code;<br>   `412`: 413 status code;<br>   `414`: 414 status code;<br>   `415`: 415 status code;<br>   `416`: 416 status code;<br>   `417`: 417 status code;<br>  `422`: 422 status code;<br>   `423`: 423 status code;<br>   `424`: 424 status code;<br>   `426`: 426 status code;<br>   `451`: 451 status code;<br>   `5XX`: All 5xx status codes;<br>   `500`: 500 status code;<br>   `501`: 501 status code;<br>   `502`: 502 status code;<br>   `503`: 503 status code;<br>   `504`: 504 status code;<br>   `505`: 505 status code;<br>   `506`: 506 status code;<br>   `507`: 507 status code;<br>   `510`: 510 status code;<br>   `514`: 514 status code;<br>   `544`: 544 status code.</li>
        /// <li>`browserType`<br>   Filter by the specified <strong>browser type</strong>. <br>   When this parameter is specified, the query period must be within the last 30 days. <br>   In this case, the supported <a href="https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1#edgeone-.E5.A5.97.E9.A4.90">max data query period</a> stated when `Zonelds` is specified become invalid.<br>   Values: <br>  `Firefox`: Firefox browser;<br>   `Chrome`: Chrome browser;<br>   `Safari`: Safari browser;<br>   `MicrosoftEdge`: Microsoft Edge browser;<br>   `IE`: IE browser;<br>   `Opera`: Opera browser;<br>   `QQBrowser`: QQ browser;<br>   `LBBrowser`: LB browser;<br>   `MaxthonBrowser`: Maxthon browser;<br>   `SouGouBrowser`: Sogou browser;<br>  `BIDUBrowser`: Baidu browser;<br>   `TaoBrowser`: Tao browser;<br>   `UBrowser`: UC browser;<br>   `Other`: Other browsers; <br>   `Empty`: The browser type is not specified; <br>   `Bot`: Web crawler.</li>
        /// <li>`deviceType`<br>   Filter by the <strong>device type</strong>. <br>   When this parameter is specified, the query period must be within the last 30 days. <br>   In this case, the supported <a href="https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1#edgeone-.E5.A5.97.E9.A4.90">max data query period</a> stated when `Zonelds` is specified become invalid.<br>   Values: <br>   `TV`: TV; <br>   `Tablet`: Tablet;<br>   `Mobile`: Mobile phone;<br>   `Desktop`: Desktop device; <br>   `Other`: Other device;<br>   `Empty`: Device type not specified.</li>
        /// <li>`operatingSystemType`<br>   Filter by the <strong>operating system</strong>. <br>   When this parameter is specified, the query period must be within the last 30 days. <br>   In this case, the supported <a href="https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1#edgeone-.E5.A5.97.E9.A4.90">max data query period</a> stated when `Zonelds` is specified become invalid.<br>   Values: <br>   `Linux`: Linux OS;<br>   `MacOS`: Mac OS;<br>   `Android`: Android OS;<br>   `IOS`: iOS OS;<br>   `Windows`: Windows OS;<br>   `NetBSD`: NetBSD OS;<br>   `ChromiumOS`: Chromium OS;<br>   `Bot`: Web crawler: <br>   `Other`: Other OS;<br>   `Empty`: The OS is not specified.</li>
        /// <li>`tlsVersion`<br>   Filter by the <strong>TLS version</strong>. <br>   When this parameter is specified, the query period must be within the last 30 days. <br>   In this case, the supported <a href="https://intl.cloud.tencent.com/document/product/1552/77380?from_cn_redirect=1#edgeone-.E5.A5.97.E9.A4.90">max data query period</a> stated when `Zonelds` is specified become invalid.<br>   Values:<br>   `TLS1.0`: TLS 1.0; <br>   `TLS1.1`: TLS 1.1;<br>   `TLS1.2`: TLS 1.2;<br>   `TLS1.3`: TLS 1.3.</li>
        /// <li>`ipVersion`<br>   Filter by the specified <strong>IP version</strong>.<br>   Values:<br>   `4`: IPv4;<br>   `6`: IPv6.</li>
        /// <li>tagKey<br>   Filter by the specified <strong>tag key</strong></li>
        /// <li>tagValue<br>   Filter by the specified <strong>tag value</strong></li>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }

        /// <summary>
        /// Geolocation scope. Values:
        /// <li>`overseas`: Regions outside the Chinese mainland</li>
        /// <li>`mainland`: Chinese mainland</li>
        /// <li>`global`: Global</li>If this field is not specified, the default value `global` is used.
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

