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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCDNStatDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// Query indicators, the values u200bu200bare:
        /// <li>Traffic: traffic, unit is Byte. </li>
        /// <li>Bandwidth: Bandwidth, unit is Bps. </li>
        /// <li>Requests: Number of requests. </li>
        /// <li>QUICRequests: Number of QUIC requests. </li>
        /// <li>IpVisit: Number of IP visits. </li>
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Start time in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?lang=en&pg=).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?lang=en&pg=).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// List of domain names. The usage data of up to 20 domain names can be queried at a time. The usage data of all domain names is returned by default.
        /// </summary>
        [JsonProperty("DomainNames")]
        public string[] DomainNames{ get; set; }

        /// <summary>
        /// Service region. Valid values:
        /// <li>Chinese Mainland</li>
        /// <li>Asia Pacific Region 1: Hong Kong (China), Macao (China), Singapore, Vietnam, and Thailand</li>
        /// <li>Asia Pacific Region 2: Taiwan (China), Japan, Malaysia, Indonesia, and South Korea</li>
        /// <li>Asia Pacific Region 3: Philippines, India, Australia, and other Asia Pacific countries and regions</li>
        /// <li>Middle East</li>
        /// <li>Europe</li>
        /// <li>North America</li>
        /// <li>South America</li>
        /// <li>Africa</li>
        /// Default value: Chinese Mainland
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// District where users are located. When `Area` is `Chinese Mainland`, valid values for `Districts` are as follows. Otherwise, `Districts` can be ignored.
        /// <li>Beijing</li>
        /// <li>Inner Mongolia</li>
        /// <li>Shanxi</li>
        /// <li>Hebei</li>
        /// <li>Tianjin</li>
        /// <li>Ningxia</li>
        /// <li>Shaanxi</li>
        /// <li>Gansu</li>
        /// <li>Qinghai</li>
        /// <li>Xinjiang</li>
        /// <li>Heilongjiang</li>
        /// <li>Jilin</li>
        /// <li>Liaoning</li>
        /// <li>Fujian</li>
        /// <li>Jiangsu</li>
        /// <li>Anhui</li>
        /// <li>Shandong</li>
        /// <li>Shanghai</li>
        /// <li>Zhejiang</li>
        /// <li>Henan</li>
        /// <li>Hubei</li>
        /// <li>Jiangxi</li>
        /// <li>Hunan</li>
        /// <li>Guizhou</li>
        /// <li>Yunnan</li>
        /// <li>Chongqing</li>
        /// <li>Sichuan</li>
        /// <li>Xizang</li>
        /// <li>Guangdong</li>
        /// <li>Guangxi</li>
        /// <li>Hainan</li>
        /// <li>Hong Kong, Macao and Taiwan</li>
        /// <li>Outside Chinese Mainland</li>
        /// <li>Other</li>
        /// </summary>
        [JsonProperty("Districts")]
        public string[] Districts{ get; set; }

        /// <summary>
        /// ISP of users. When `Area` is `Chinese Mainland`, valid values for `Isps` are as follows. Otherwise, `Isps` can be ignored.
        /// <li>China Telecom</li>
        /// <li>China Unicom</li>
        /// <li>CERNET</li>
        /// <li>Great Wall Broadband Network</li>
        /// <li>China Mobile</li>
        /// <li>China Mobile Tietong</li>
        /// <li>ISPs outside Chinese Mainland</li>
        /// <li>Other ISPs</li>
        /// </summary>
        [JsonProperty("Isps")]
        public string[] Isps{ get; set; }

        /// <summary>
        /// Time granularity of every piece of data in minutes. Valid values:
        /// <li>5: 5-minute granularity. The data at 5-minute granularity in the query period will be returned.</li>
        /// <li>1440: 1-day granularity. The data at 1-day granularity in the query period will be returned. If the query period is larger than 24 hours, only data at 1-day granularity can be queried.</li>
        /// If the difference between `StartTime` and `EndTime` is larger than 24 hours, the default value of `DataInterval` is 1440.
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

