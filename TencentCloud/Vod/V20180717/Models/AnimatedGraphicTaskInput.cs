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

    public class AnimatedGraphicTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Video-to-GIF conversion template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Start time offset of the GIF in the video, in seconds.
        /// <li>If not set or set to 0, it starts from the starting position of the video.</li>
        /// <li>When the value is greater than 0 (assume it is n), it means starting from the nth second of the video;</li>
        /// <li>When the value is less than 0 (assuming -n), it means starting from the position n seconds before the video ends.</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of an animated image in the video, in seconds.
        /// <li>If not set or set to 0, it will last until the end of a video.</li>
        /// <li>When the value is greater than 0 (assuming n), it means it will last until the nth second of the video and then terminate;</li>
        /// <li>When the value is less than 0 (assuming -n), it means the video will terminate n seconds before the end.</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
        }
    }
}

