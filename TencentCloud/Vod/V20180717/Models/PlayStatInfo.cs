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

    public class PlayStatInfo : AbstractModel
    {
        
        /// <summary>
        /// Start time of the time interval where the data resides, in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I). For example, when the time granularity is day, 2018-12-01T00:00:00+08:00 means the interval from December 1, 2018 (inclusive) to December 2, 2018 (exclusive).
        /// <li>For hour-level data, 2019-08-22T00:00:00+08:00 refers to the stats from 0:00 to 1:00 on August 22, 2019.</li>
        /// <li>When representing day-level data, 2019-08-22T00:00:00+08:00 refers to the stats for 2019-08-22.</li>
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Media file ID.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Number of plays.
        /// </summary>
        [JsonProperty("PlayTimes")]
        public ulong? PlayTimes{ get; set; }

        /// <summary>
        /// Playback traffic volume. Measurement unit: byte.
        /// </summary>
        [JsonProperty("Traffic")]
        public ulong? Traffic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "PlayTimes", this.PlayTimes);
            this.SetParamSimple(map, prefix + "Traffic", this.Traffic);
        }
    }
}

