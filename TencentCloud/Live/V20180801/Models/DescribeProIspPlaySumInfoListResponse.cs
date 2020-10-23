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

    public class DescribeProIspPlaySumInfoListResponse : AbstractModel
    {
        
        /// <summary>
        /// Total traffic.
        /// </summary>
        [JsonProperty("TotalFlux")]
        public float? TotalFlux{ get; set; }

        /// <summary>
        /// Total number of requests.
        /// </summary>
        [JsonProperty("TotalRequest")]
        public ulong? TotalRequest{ get; set; }

        /// <summary>
        /// Statistics type.
        /// </summary>
        [JsonProperty("StatType")]
        public string StatType{ get; set; }

        /// <summary>
        /// Number of results per page.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Page number.
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// Total number of results.
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        [JsonProperty("TotalPage")]
        public ulong? TotalPage{ get; set; }

        /// <summary>
        /// Aggregated data list by district, ISP, or country/region.
        /// </summary>
        [JsonProperty("DataInfoList")]
        public ProIspPlaySumInfo[] DataInfoList{ get; set; }

        /// <summary>
        /// Download speed in MB/s. Calculation method: total traffic/total duration.
        /// </summary>
        [JsonProperty("AvgFluxPerSecond")]
        public float? AvgFluxPerSecond{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalFlux", this.TotalFlux);
            this.SetParamSimple(map, prefix + "TotalRequest", this.TotalRequest);
            this.SetParamSimple(map, prefix + "StatType", this.StatType);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "TotalPage", this.TotalPage);
            this.SetParamArrayObj(map, prefix + "DataInfoList.", this.DataInfoList);
            this.SetParamSimple(map, prefix + "AvgFluxPerSecond", this.AvgFluxPerSecond);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

