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

    public class PlayStatFileInfo : AbstractModel
    {
        
        /// <summary>
        /// Date of playback statistics in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?lang=en&pg=).
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// URL of a playback statistics file, including the following contents:
        /// <li> date: playback date</li>
        /// <li> file_id: video file ID</li>
        /// <li> ip_count: number of client IPs after deduplication</li>
        /// <li> flux: playback traffic in bytes</li>
        /// <li> play_times: total playback times</li>
        /// <li> pc_play_times: playback times on PC clients</li>
        /// <li> mobile_play_times: playback times on mobile clients</li>
        /// <li> iphone_play_times: playback times on iPhone</li>
        /// <li> android_play_times: playback times on Android</li>
        /// <li> host_name: domain name</li>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

