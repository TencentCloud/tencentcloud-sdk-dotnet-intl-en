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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePlayErrorCodeSumInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// The start time of the request, supports data query for the last one day, the gap between the start time and the end time cannot exceed one day. Interface request supports two time formats:
        /// 1) YYYY-MM-DDThh:mm:ssZ: ISO time format, for details, see [ISO Date Format Description](https://cloud.tencent.com/document/product/267/38543#:~:text=I- ,ISO,-%E6%97%A5%E6%9C%9F%E6%A0%BC%E5%BC%8F)
        /// 2) YYYY-MM-DD hh:mm:ss: When using this format, it represents Beijing time by default.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The end time of the request, supports data query for the last one day, the gap between the start time and the end time cannot exceed one day. Interface request supports two time formats:
        /// 1) YYYY-MM-DDThh:mm:ssZ: ISO time format,for details,see [ISO Date Format Description](https://cloud.tencent.com/document/product/267/38543#:~:text=I- ,ISO,-%E6%97%A5%E6%9C%9F%E6%A0%BC%E5%BC%8F)
        /// 2) YYYY-MM-DD hh:mm:ss: When using this format, it represents Beijing time by default.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Playback domain name list. If this parameter is left empty, full data will be queried.
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }

        /// <summary>
        /// Number of pages. Value range: [1,1000]. Default value: 1.
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// Number of entries per page. Value range: [1,1000]. Default value: 20.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Region. Valid values: Mainland (data for Mainland China), Oversea (data for regions outside Mainland China), China (data for China, including Hong Kong, Macao, and Taiwan), Foreign (data for regions outside China, excluding Hong Kong, Macao, and Taiwan), Global (default). If this parameter is left empty, data for all regions will be queried.
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }

        /// <summary>
        /// Grouping parameter. Valid values: CountryProIsp (default value), Country (country/region). Grouping is made by country/region + district + ISP by default. Currently, districts and ISPs outside Mainland China cannot be recognized.
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// Language used in the output field. Valid values: Chinese (default), English. Currently, country/region, district, and ISP parameters support multiple languages.
        /// </summary>
        [JsonProperty("OutLanguage")]
        public string OutLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "PlayDomains.", this.PlayDomains);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "OutLanguage", this.OutLanguage);
        }
    }
}

