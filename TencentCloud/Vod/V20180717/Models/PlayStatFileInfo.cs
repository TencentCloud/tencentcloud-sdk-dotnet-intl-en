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
        /// Date of playback statistics in ISO date format (https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// URL address of the playback statistics file. The content of the playback statistics file is:
        /// <li> date: Playback date.</li>
        /// <li> file_id: Video file ID.</li>
        /// <li> ip_count: Number of client IPs after deduplication.</li>
        /// <li> flux: playback traffic volume, unit: byte.</li>
        /// <li> play_times: total number of plays.</li>
        /// <li> pc_play_times: Playback times on PC.</li>
        /// <li> mobile_play_times: Mobile playback count.</li>
        /// <li> iphone_play_times: Number of plays on iPhone.</li>
        /// <li> android_play_times: Number of plays on Android.</li>
        /// <li> host_name	Domain name.</li>
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

