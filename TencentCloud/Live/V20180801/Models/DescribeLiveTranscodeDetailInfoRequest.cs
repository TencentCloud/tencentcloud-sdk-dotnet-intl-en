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

    public class DescribeLiveTranscodeDetailInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Push domain name.
        /// </summary>
        [JsonProperty("PushDomain")]
        public string PushDomain{ get; set; }

        /// <summary>
        /// Stream name.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// Start time (Beijing time).
        /// In the format of `yyyymmdd`.
        /// Note: details for a specified day in the last month can be queried.
        /// </summary>
        [JsonProperty("DayTime")]
        public string DayTime{ get; set; }

        /// <summary>
        /// Number of pages. Default value: 1.
        /// Up to 100 pages.
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// Number of entries per page. Default value: 20,
        /// Value range: [10,1000].
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Start day time (Beijing time),
        /// In the format of `yyyymmdd`.
        /// Note: details for the last month can be queried.
        /// </summary>
        [JsonProperty("StartDayTime")]
        public string StartDayTime{ get; set; }

        /// <summary>
        /// End day time (Beijing time),
        /// In the format of `yyyymmdd`.
        /// Note: detailed data for the last month can be queried. Either `DayTime` or `(StartDayTime,EndDayTime)` must be passed in. If both are passed in, `DayTime` shall prevail.
        /// </summary>
        [JsonProperty("EndDayTime")]
        public string EndDayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PushDomain", this.PushDomain);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "DayTime", this.DayTime);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "StartDayTime", this.StartDayTime);
            this.SetParamSimple(map, prefix + "EndDayTime", this.EndDayTime);
        }
    }
}

