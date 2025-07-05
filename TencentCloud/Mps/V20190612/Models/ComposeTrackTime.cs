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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComposeTrackTime : AbstractModel
    {
        
        /// <summary>
        /// The time when the element starts on the track.
        /// <li>The value of this parameter ends with `s`, which means seconds. For example, `3.5s` indicates the time when 3.5 seconds of the video elapses.</li>
        /// Note: If this parameter is not specified, the start time will be the end time of the previous element. Therefore, you can also use the placeholder parameter `ComposeEmptyItem` to configure the start time.
        /// </summary>
        [JsonProperty("Start")]
        public string Start{ get; set; }

        /// <summary>
        /// The element duration.
        /// <li>The value of this parameter ends with `s`, which means seconds. For example, `3.5s` means 3.5 seconds.</li>
        /// The default value is the material duration, which is determined by `EndTime` and `StartTime` of `ComposeSourceMedia`. If `ComposeSourceMedia` is not specified, the duration will be 1 second.
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
        }
    }
}

