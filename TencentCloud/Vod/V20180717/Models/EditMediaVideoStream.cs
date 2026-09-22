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

    public class EditMediaVideoStream : AbstractModel
    {
        
        /// <summary>
        /// Encoding format for video streams. Optional values:
        /// <li>libx264: H.264 encoding;</li>
        /// <li>libx265: H.265 encoding;</li>
        /// <li>av1: AOMedia Video 1 encoding;</li>
        /// <li>H.266: H.266 encoding.</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Bitrate of video stream. Value range: 0 and [128, 100000]. Unit: kbps.
        /// When the value is 0 or not specified, VOD automatically sets the bitrate.
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// Resolution adaptation. Available values:
        /// <li>open: enabled. At this point, Width represents the long side of the video, and Height represents the short side of the video;</li>
        /// <li>close: closed. At this point, Width represents the video width, and Height indicates the video height.</li>
        /// Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Maximum value of the video stream width (or long edge) in px. Value range: 0 and [128, 4096].
        /// <li>If both Width and Height are 0, the base resolution is used.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be scaled based on the benchmark resolution ratio.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be scaled based on the benchmark resolution ratio.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum height (or short side) of the video stream. Value range: 0 and [128, 4096]. Unit: px.
        /// <li>If both Width and Height are 0, the base resolution is used.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be scaled based on the benchmark resolution ratio.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be scaled based on the benchmark resolution ratio.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Video frame rate. Value range: [0, 100]. Unit: Hz.
        /// When the value is 0, the frame rate is automatically set for the video.
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
        }
    }
}

