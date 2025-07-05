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

    public class WatermarkCycleConfigForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Playback time point in seconds when a watermark appears in a video for the first time.
        /// </summary>
        [JsonProperty("StartTime")]
        public float? StartTime{ get; set; }

        /// <summary>
        /// Display duration of a watermark in a watermark cycle in seconds.
        /// </summary>
        [JsonProperty("DisplayDuration")]
        public float? DisplayDuration{ get; set; }

        /// <summary>
        /// Duration of a watermark cycle in seconds.
        /// If 0 is entered, a watermark will last for only one cycle (i.e., visible for `DisplayDuration` seconds throughout the video).
        /// </summary>
        [JsonProperty("CycleDuration")]
        public float? CycleDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "DisplayDuration", this.DisplayDuration);
            this.SetParamSimple(map, prefix + "CycleDuration", this.CycleDuration);
        }
    }
}

