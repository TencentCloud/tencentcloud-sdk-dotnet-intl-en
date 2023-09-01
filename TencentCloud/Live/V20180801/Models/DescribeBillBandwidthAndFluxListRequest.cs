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

    public class DescribeBillBandwidthAndFluxListRequest : AbstractModel
    {
        
        /// <summary>
        /// The start time of the request, supports data query for the last three years, the gap between the start time and the end time cannot exceed one month. Interface request supports two time formats:
        /// 1) YYYY-MM-DDThh:mm:ssZ: ISO time format, for details, see [ISO Date Format Description](https://cloud.tencent.com/document/product/267/38543#:~:text=I- ,ISO,-%E6%97%A5%E6%9C%9F%E6%A0%BC%E5%BC%8F)
        /// 2) YYYY-MM-DD hh:mm:ss: When using this format, it represents Beijing time by default.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The end time of the request, supports data query for the last three years, the gap between the start time and the end time cannot exceed one month. Interface request supports two time formats:
        /// 1) YYYY-MM-DDThh:mm:ssZ: ISO time format,for details,see [ISO Date Format Description](https://cloud.tencent.com/document/product/267/38543#:~:text=I- ,ISO,-%E6%97%A5%E6%9C%9F%E6%A0%BC%E5%BC%8F)
        /// 2) YYYY-MM-DD hh:mm:ss: When using this format, it represents Beijing time by default.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// LVB playback domain name. If this parameter is left empty, full data will be queried.
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }

        /// <summary>
        /// Valid values:
        /// Mainland: query data for Mainland China,
        /// Oversea: query data for regions outside Mainland China,
        /// Default: query data for all regions.
        /// Note: LEB only supports querying data for all regions.
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }

        /// <summary>
        /// Data granularity. Valid values:
        /// 5: 5-minute granularity (the query time span should be within 1 day),
        /// 60: 1-hour granularity (the query time span should be within one month),
        /// 1440: 1-day granularity (the query time span should be within one month).
        /// Default value: 5.
        /// </summary>
        [JsonProperty("Granularity")]
        public ulong? Granularity{ get; set; }

        /// <summary>
        /// Service name. Valid values: LVB, LEB. The sum of LVB and LEB usage will be returned if this parameter is left empty.
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Region. Valid values:
        /// China Mainland
        /// Asia Pacific I
        /// Asia Pacific II
        /// Asia Pacific III
        /// Europe
        /// North America
        /// South America
        /// Middle East
        /// Africa
        /// </summary>
        [JsonProperty("RegionNames")]
        public string[] RegionNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "PlayDomains.", this.PlayDomains);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamArraySimple(map, prefix + "RegionNames.", this.RegionNames);
        }
    }
}

