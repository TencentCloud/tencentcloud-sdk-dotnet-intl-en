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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCDNStatDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// Query metric. Valid values:
        /// <li>Traffic: Total Traffic in bytes.</li>
        /// <li>Bandwidth: bandwidth, in Bps.</li>
        /// <li>Requests: Request count.</li>
        /// <li>QUICRequests: Number of QUIC requests.</li>
        /// <li>IpVisit: Number of IP visits.</li>
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Start time. Use the [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time. Use the [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Domain name list. Up to 20 domain names can be queried for data. Default returns the overlaid usage data of all domains.
        /// </summary>
        [JsonProperty("DomainNames")]
        public string[] DomainNames{ get; set; }

        /// <summary>
        /// Service area. Valid values:
        /// <li>Chinese Mainland: Chinese mainland.</li>
        /// <li>Asia Pacific Region 1: Asia Pacific zone 1, including Hong Kong (China), Macao (China), Singapore, Vietnam, and Thailand.</li>
        /// <li>Asia Pacific Region 2: Asia Pacific zone 2, including Taiwan, Japan, Malaysia, Indonesia, Korea.</li>
        /// <li>Asia Pacific Region 3: Asia Pacific zone 3, including Philippines, India, Australia and other countries and regions in Asia Pacific.</li>
        /// <li>Middle East: Middle East.</li>
        /// <li>Europe: Europe.</li>
        /// <li>North America: North America.</li>
        /// <li>South America: South America.</li>
        /// <li>Africa: Africa.</li>
        /// Default is Chinese mainland.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// When the user's located region is Chinese Mainland, value is the following region information. When Area has other values, ignore the Districts parameter.
        /// <li>Beijing: Beijing.</li>
        /// <li>Inner Mongolia: Inner Mongolia.</li>
        /// <li>Shanxi: Shanxi.</li>
        /// <li>Hebei: Hebei.</li>
        /// <li>Tianjin: Tianjin.</li>
        /// <li>Ningxia: Ningxia.</li>
        /// <li>Shaanxi: Shaanxi.</li>
        /// <li>Gansu: Gansu.</li>
        /// <li>Qinghai: Qinghai.</li>
        /// <li>Xinjiang: Xinjiang.</li>
        /// <li>Heilongjiang: Heilongjiang.</li>
        /// <li>Jilin: Jilin.</li>
        /// <li>Liaoning: Liaoning.</li>
        /// <li>Fujian: Fujian.</li>
        /// <li>Jiangsu: Jiangsu.</li>
        /// <li>Anhui: Anhui.</li>
        /// <li>Shandong: Shandong.</li>
        /// <li>Shanghai: Shanghai.</li>
        /// <li>Zhejiang: Zhejiang.</li>
        /// <li>Henan: Henan.</li>
        /// <li>Hubei: Hubei.</li>
        /// <li>Jiangxi: Jiangxi.</li>
        /// <li>Hunan: Hu’nan.</li>
        /// <li>Guizhou: Guizhou.</li>
        /// <li>Yunnan: Yunnan.</li>
        /// <li>Chongqing: Chongqing.</li>
        /// <li>Sichuan: Sichuan.</li>
        /// <li>Xizang: Tibet.</li>
        /// <li>Guangdong: Guangdong.</li>
        /// <li>Guangxi: Guangxi.</li>
        /// <li>Hainan: Hainan.</li>
        /// <li>Hong Kong, Macao and Taiwan: Hong Kong (China), Macao (China) and Taiwan (China).</li>
        /// <li>Outside Chinese Mainland: overseas.</li>
        /// <li>Other: other.</li>
        /// </summary>
        [JsonProperty("Districts")]
        public string[] Districts{ get; set; }

        /// <summary>
        /// User's Operator Information. When Area is Chinese Mainland, value is the following carrier information. When Area is other values, ignore the Isps parameter.
        /// <li>China Telecom: CTCC. </li>
        /// <li>China Unicom: CUCC. </li>
        /// <li>CERNET: China Education Network.</li>
        /// <li>Great Wall Broadband Network: Great Wall Broadband.</li>
        /// <li>China Mobile: CMCC.</li>
        /// <li>China Mobile Tietong: China Tietong.</li>
        /// <li>ISPs outside Chinese Mainland: Overseas carriers.</li>
        /// <li>Other ISPs: Other ISPs.</li>
        /// </summary>
        [JsonProperty("Isps")]
        public string[] Isps{ get; set; }

        /// <summary>
        /// Time granularity of each data entry. Unit: minute. Valid values:
        /// <li>5: 5 minutes, return detailed data at a minute granularity for the specified query time.</li>
        /// <li>1440: Day granularity. Returns the data of day granularity within the specified query time. The duration between start time and end time is more than 24 hours. Supports only day granularity data.</li>
        /// When the duration between StartTime and EndTime is more than 24 hours, DataInterval defaults to 1440.
        /// </summary>
        [JsonProperty("DataInterval")]
        public ulong? DataInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "DomainNames.", this.DomainNames);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArraySimple(map, prefix + "Districts.", this.Districts);
            this.SetParamArraySimple(map, prefix + "Isps.", this.Isps);
            this.SetParamSimple(map, prefix + "DataInterval", this.DataInterval);
        }
    }
}

