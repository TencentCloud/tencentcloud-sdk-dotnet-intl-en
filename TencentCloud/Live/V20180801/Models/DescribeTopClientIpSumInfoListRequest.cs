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

    public class DescribeTopClientIpSumInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// Start point in time in the format of `yyyy-mm-dd HH:MM:SS`.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End point in time in the format of `yyyy-mm-dd HH:MM:SS`
        /// The time span is [0,4 hours]. Data for the last day can be queried.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Playback domain name. If this parameter is left empty, full data will be queried by default.
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }

        /// <summary>
        /// Page number. Value range: [1,1000]. Default value: 1.
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// Number of entries per page. Value range: [1,1000]. Default value: 20.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Sorting metric. Valid values: TotalRequest (default value), FailedRequest, TotalFlux.
        /// </summary>
        [JsonProperty("OrderParam")]
        public string OrderParam{ get; set; }

        /// <summary>
        /// Region. Valid values: Mainland (data for Mainland China), Oversea (data for regions outside Mainland China), China (data for China, including Hong Kong, Macao, and Taiwan), Foreign (data for regions outside China, excluding Hong Kong, Macao, and Taiwan), Global (default). If this parameter is left empty, data for all regions will be queried.
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }

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
            this.SetParamSimple(map, prefix + "OrderParam", this.OrderParam);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "OutLanguage", this.OutLanguage);
        }
    }
}

