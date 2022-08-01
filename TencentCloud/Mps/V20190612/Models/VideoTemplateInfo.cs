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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// The video codec. Valid values:
        /// <li>`libx264`: H.264</li>
        /// <li>`libx265`: H.265</li>
        /// <li>`av1`: AOMedia Video 1</li>
        /// Note: You must specify a resolution (not higher than 640 x 480) if the H.265 codec is used.
        /// Note: You can only use the AOMedia Video 1 codec for MP4 files.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// The video frame rate (Hz). Value range: [0, 100].
        /// If the value is 0, the frame rate will be the same as that of the source video.
        /// Note: For adaptive bitrate streaming, the value range of this parameter is [0, 60].
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// The video bitrate (Kbps). Value range: 0 and [128, 35000].
        /// If the value is 0, the bitrate of the video will be the same as that of the source video.
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// Resolution adaption. Valid values:
        /// <li>open: Enabled. When resolution adaption is enabled, `Width` indicates the long side of a video, while `Height` indicates the short side.</li>
        /// <li>close: Disabled. When resolution adaption is disabled, `Width` indicates the width of a video, while `Height` indicates the height.</li>
        /// Default value: open.
        /// Note: When resolution adaption is enabled, `Width` cannot be smaller than `Height`.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Maximum value of the width (or long side) of a video stream in px. Value range: 0 and [128, 4,096].
        /// <li>If both `Width` and `Height` are 0, the resolution will be the same as that of the source video;</li>
        /// <li>If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled;</li>
        /// <li>If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled;</li>
        /// <li>If both `Width` and `Height` are not 0, the custom resolution will be used.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum value of the height (or short side) of a video stream in px. Value range: 0 and [128, 4,096].
        /// <li>If both `Width` and `Height` are 0, the resolution will be the same as that of the source video;</li>
        /// <li>If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled;</li>
        /// <li>If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled;</li>
        /// <li>If both `Width` and `Height` are not 0, the custom resolution will be used.</li>
        /// Default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Frame interval between I keyframes. Value range: 0 and [1,100000].
        /// If this parameter is 0 or left empty, the system will automatically set the GOP length.
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// The fill mode, which indicates how a video is resized when the video’s original aspect ratio is different from the target aspect ratio. Valid values:
        /// <li>stretch: Stretch the image frame by frame to fill the entire screen. The video image may become "squashed" or "stretched" after transcoding.</li>
        /// <li>black: Keep the image's original aspect ratio and fill the blank space with black bars.</li>
        /// <li>white: Keep the image’s original aspect ratio and fill the blank space with white bars.</li>
        /// <li>gauss: Keep the image’s original aspect ratio and apply Gaussian blur to the blank space.</li>
        /// Default value: black.
        /// Note: Only `stretch` and `black` are supported for adaptive bitrate streaming.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// The control factor of video constant bitrate. Value range: [1, 51]
        /// If this parameter is specified, CRF (a bitrate control method) will be used for transcoding. (Video bitrate will no longer take effect.)
        /// It is not recommended to specify this parameter if there are no special requirements.
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }


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
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Vcrf", this.Vcrf);
        }
    }
}

