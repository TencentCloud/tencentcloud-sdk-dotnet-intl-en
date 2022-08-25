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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// The video codec. Valid values:
        /// <li>libx264: H.264</li>
        /// <li>libx265: H.265</li>
        /// <li>av1: AOMedia Video 1</li>
        /// <li>H.266: H.266</li>
        /// <font color=red>Notes:</font>
        /// <li>The AOMedia Video 1 and H.266 codecs can only be used for MP4 files.</li>
        /// <li> Only CRF is supported for H.266 currently.</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Video frame rate in Hz. Value range: [0,100].
        /// If the value is 0, the frame rate will be the same as that of the source video.
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// Bitrate of video stream in Kbps. Value range: 0 and [128, 35,000].
        /// If the value is 0, the bitrate of the video will be the same as that of the source video.
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// Resolution adaption. Valid values:
        /// <li>open: enabled. In this case, `Width` represents the long side of a video, while `Height` the short side;</li>
        /// <li>close: disabled. In this case, `Width` represents the width of a video, while `Height` the height.</li>
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// The maximum video width (or long side) in pixels. Value range: 0 and [128, 8192].
        /// <li>If both `Width` and `Height` are 0, the output resolution will be the same as that of the source video.</li>
        /// <li>If `Width` is 0 and `Height` is not, the video width will be proportionally scaled.</li>
        /// <li>If `Width` is not 0 and `Height` is, the video height will be proportionally scaled.</li>
        /// <li>If neither `Width` nor `Height` is 0, the specified width and height will be used.</li>
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// The maximum video height (or short side) in pixels. Value range: 0 and [128, 8192].
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Fill type. "Fill" refers to the way of processing a screenshot when its aspect ratio is different from that of the source video. Valid values:
        /// <li>stretch: stretches video image frame by frame to fill the screen. The video image may become "squashed" or "stretched" after transcoding.</li>
        /// <li>black: fills the uncovered area with black color, without changing the image's aspect ratio.</li>
        /// <li>white: fills the uncovered area with white color, without changing the image's aspect ratio.</li>
        /// <li>gauss: applies Gaussian blur to the uncovered area, without changing the image's aspect ratio.</li>
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// The video constant rate factor (CRF). Value range: 1-51. `0` means to disable this parameter.
        /// 
        /// <font color=red>Notes:</font>
        /// <li>If this parameter is specified, CRF encoding will be used and the bitrate parameter will be ignored.</li>
        /// <li>If `Codec` is `H.266`, this parameter is required (`28` is recommended).</li>
        /// <li>We don’t recommend using this parameter unless you have special requirements.</li>
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }

        /// <summary>
        /// I-frame interval in frames. Valid values: 0 and 1-100000.
        /// When this parameter is set to 0 or left empty, `Gop` will be automatically set.
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// Whether to output an HDR (high dynamic range) video if the source video is HDR. Valid values:
        /// <li>ON: If the source video is HDR, output an HDR video; if not, output an SDR (standard dynamic range) video.</li>
        /// <li>OFF: Output an SDR video regardless of whether the source video is HDR.</li>
        /// </summary>
        [JsonProperty("PreserveHDRSwitch")]
        public string PreserveHDRSwitch{ get; set; }


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
            this.SetParamSimple(map, prefix + "Vcrf", this.Vcrf);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "PreserveHDRSwitch", this.PreserveHDRSwitch);
        }
    }
}

