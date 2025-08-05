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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Encoding format for video streams. valid values: <li>H.264: use H.264 encoding;</li><li>H.265: use H.265 encoding.</li>.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Video frame rate. value ranges from 0 to 30. measurement unit: Hz.
        /// If the value is 0, the frame rate will be the same as that of the source video, with a maximum not exceeding 30.
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Fps")]
        public float? Fps{ get; set; }

        /// <summary>
        /// Specifies the bitrate of video stream. valid values: 0 and [128, 10000]. measurement unit: kbps.
        /// Value is 0, means automatically select video bitrate based on video image and quality.
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// Resolution adaptation. available values: <li>open: enable. at this point, Width represents the long side of the video and Height represents the short side.</li><li>close: disable. at this point, Width represents the Width of the video and Height represents the Height.</li>default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// The maximum value of the video stream Width (or long side). valid values: 0 and [128, 1920]. unit: px. <li>when Width and Height are both 0, the resolution is from the same source;</li> <li>when Width is 0 and Height is non-0, Width is scaled proportionally;</li> <li>when Width is non-0 and Height is 0, Height is scaled proportionally;</li> <li>when both Width and Height are non-0, the resolution is specified by the user.</li> default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// The maximum value of the video stream Height (or short side). valid values: 0 and [128, 1080]. unit: px. <li>when Width and Height are both 0, the resolution is from the same source;</li> <li>when Width is 0 and Height is non-0, Width is scaled proportionally;</li> <li>when Width is non-0 and Height is 0, the Height is scaled proportionally;</li> <li>when both Width and Height are non-0, the resolution is specified by the user.</li> default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Filling method. specifies the processing method for transcoding when video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video. valid values: <li>stretch: stretch each frame to fill the entire screen, possibly causing the transcoded video to be squashed or stretched.</li><li>black: maintain video aspect ratio with edges filled with black.</li><li>white: maintain video aspect ratio with edges filled with white.</li><li>gauss: maintain video aspect ratio with gaussian blur filling for the rest of the edges.</li> default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
        }
    }
}

