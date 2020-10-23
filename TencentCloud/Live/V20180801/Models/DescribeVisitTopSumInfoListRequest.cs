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

    public class DescribeVisitTopSumInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// Start point in time in the format of `yyyy-mm-dd HH:MM:SS`.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End point in time in the format of `yyyy-mm-dd HH:MM:SS`
        /// The time span is (0,4 hours]. Data for the last day can be queried.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Bandwidth metric. Valid values: "Domain", "StreamId".
        /// </summary>
        [JsonProperty("TopIndex")]
        public string TopIndex{ get; set; }

        /// <summary>
        /// Playback domain name. If this parameter is left empty, full data will be queried by default.
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }

        /// <summary>
        /// Page number,
        /// Value range: [1,1000],
        /// Default value: 1.
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// Number of entries per page. Value range: [1,1000].
        /// Default value: 20.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Sorting metric. Valid values: "AvgFluxPerSecond", "TotalRequest" (default), "TotalFlux".
        /// </summary>
        [JsonProperty("OrderParam")]
        public string OrderParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TopIndex", this.TopIndex);
            this.SetParamArraySimple(map, prefix + "PlayDomains.", this.PlayDomains);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "OrderParam", this.OrderParam);
        }
    }
}

