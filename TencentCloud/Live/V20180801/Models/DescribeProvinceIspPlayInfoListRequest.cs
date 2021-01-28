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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProvinceIspPlayInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// Start point in time (Beijing time).
        /// Example: 2019-02-21 10:00:00.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End point in time (Beijing time).
        /// Example: 2019-02-21 12:00:00.
        /// Note: `EndTime` and `StartTime` only support querying data for the last day.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Supported granularities:
        /// 1: 1-minute granularity (the query interval should be within 1 day)
        /// </summary>
        [JsonProperty("Granularity")]
        public ulong? Granularity{ get; set; }

        /// <summary>
        /// Statistical metric type:
        /// "Bandwidth": bandwidth
        /// "FluxPerSecond": average traffic
        /// "Flux": traffic
        /// "Request": number of requests
        /// "Online": number of concurrent connections
        /// </summary>
        [JsonProperty("StatType")]
        public string StatType{ get; set; }

        /// <summary>
        /// Playback domain name list.
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }

        /// <summary>
        /// List of the districts to be queried, such as Beijing.
        /// </summary>
        [JsonProperty("ProvinceNames")]
        public string[] ProvinceNames{ get; set; }

        /// <summary>
        /// List of the ISPs to be queried, such as China Mobile. If this parameter is left empty, the data of all ISPs will be queried.
        /// </summary>
        [JsonProperty("IspNames")]
        public string[] IspNames{ get; set; }

        /// <summary>
        /// Region. Valid values: Mainland (data for Mainland China), Oversea (data for regions outside Mainland China), China (data for China, including Hong Kong, Macao, and Taiwan), Foreign (data for regions outside China, excluding Hong Kong, Macao, and Taiwan), Global (default). If this parameter is left empty, data for all regions will be queried.
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }

        /// <summary>
        /// IP type:
        /// "Ipv6": IPv6 data
        /// Data of all IPs will be returned if this parameter is left empty.
        /// </summary>
        [JsonProperty("IpType")]
        public string IpType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "StatType", this.StatType);
            this.SetParamArraySimple(map, prefix + "PlayDomains.", this.PlayDomains);
            this.SetParamArraySimple(map, prefix + "ProvinceNames.", this.ProvinceNames);
            this.SetParamArraySimple(map, prefix + "IspNames.", this.IspNames);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "IpType", this.IpType);
        }
    }
}

