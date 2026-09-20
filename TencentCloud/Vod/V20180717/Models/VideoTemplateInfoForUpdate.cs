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

    public class VideoTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// <p>Video stream encoding format. Available values:</p><li>libx264: H.264 encoding;</li><li>libx265: H.265 encoding;</li><li>av1: AOMedia Video 1 encoding;</li><li>H.266: H.266 encoding.</li><font color="red">Note:</font><li>av1 and H.266 encoding containers currently only support mp4;</li><li>H.266 currently only supports the fixed CRF bitrate control method.</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// <p>Video frame rate. Value range: [0, 100]. Unit: Hz.<br>When the value is 0, it means the frame rate is consistent with the original video.</p>
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// <p>Bitrate of video stream. Value range: 0 and [128, 100000]. Unit: kbps.<br>When the value is 0, it means VOD automatically sets the bitrate.</p>
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// <p>Resolution adaptation. Available values:</p><li>open: enable. At this point, Width represents the long side of the video, and Height represents the short side.</li><li>close: disable. At this point, Width represents the width of the video, and Height represents the height.</li>
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// <p>The maximum value of the video stream width (or long side). Valid values: 0 and [128, 8192]. Unit: px.</p><li>When Width and Height are both 0, the resolution is from the same source;</li><li>When Width is 0 and Height is non-0, Width is scaled proportionally;</li><li>When Width is non-0 and Height is 0, Height is scaled proportionally;</li><li>When both Width and Height are non-0, the resolution is specified by the user.</li>
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// <p>Maximum height (or short side) of the video stream. Value range: 0 and [128, 8192]. Unit: px.</p>
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// <p>Filling method. When the video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video, the processing method for transcoding is "filling". Available filling modes:</p><li>stretch: Stretch each frame to fill the entire screen, which may cause the transcoded video to be "squashed" or "stretched".</li><li>black: Keep the video aspect ratio unchanged and fill the rest of the edges with black.</li><li>white: Keep the video aspect ratio unchanged and fill the rest of the edges with white.</li><li>gauss: Gaussian blur. Keep the video aspect ratio unchanged and use Gaussian blur filling for the rest of the edges.</li>
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// <p>Control factor for constant video bitrate. Value range: [1, 51]. 0 indicates that it is disabled.</p><p><font color="red">Note:</font></p><li>If you specify this parameter, the bitrate control mode for CRF will be used to transcode (video bitrate will no longer take effect);</li><li>When the encoding format of the specified video stream is H.266, this field is required. Recommended value: 28;</li><li>If there are no special requirements, it is not recommended to specify this parameter.</li>
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }

        /// <summary>
        /// <p>Interval between I-frames, in frames. Value range: 0 and [1, 100000].<br>When it is set to 0 or not set, the system will automatically set the gop length.</p>
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// <p>When the original video is HDR (High Dynamic Range), whether the transcoding output remains HDR. Value range:</p><li>ON: If the original file is HDR, the transcoding output remains HDR; otherwise, the transcoding output is SDR (Standard Dynamic Range).</li><li>OFF: Regardless of whether the original file is HDR or SDR, the transcoding output is SDR.</li>
        /// </summary>
        [JsonProperty("PreserveHDRSwitch")]
        public string PreserveHDRSwitch{ get; set; }

        /// <summary>
        /// <p>Encoding tag. It is valid only when the video stream encoding format is H.265. Available values:</p><li>hvc1 refers to the hvc1 tag;</li><li>hev1 refers to the hev1 tag. </li>Default value: hvc1.
        /// </summary>
        [JsonProperty("CodecTag")]
        public string CodecTag{ get; set; }

        /// <summary>
        /// <p>Gop value unit.</p><p>Enumeration values:</p><ul><li>frame: number of frames.</li><li>second: seconds.</li></ul><p>Default value: frame</p>
        /// </summary>
        [JsonProperty("GopUnit")]
        public string GopUnit{ get; set; }

        /// <summary>
        /// <p>Bitrate control mode.</p><p>Enumeration values:</p><ul><li>VBR: Variable Bit Rate. The output bitrate is adjusted based on the complexity of the video image to ensure higher image quality. It is suitable for storage scenarios and applications with high image quality requirements.</li><li>ABR: Average Bit Rate. It minimizes overall bitrate while maintaining a stable average bitrate of the output video, allowing short-term bitrate fluctuation. It is suitable for scenarios where maintaining a certain quality while minimizing overall bitrate is desired.</li><li>CBR: Constant Bit Rate. The output bitrate remains constant during video encoding, regardless of image complexity. It is suitable for scenarios with strict network bandwidth requirements, such as live streaming.</li><li>VCRF: Constant Rate Factor. A quality factor is set to control video quality and achieve constant quality encoding of videos. The bitrate is automatically adjusted based on content complexity. It is suitable for scenarios where maintaining a certain image quality is desired.</li></ul><p>Default value: VBR</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>Maximum number of consecutive B-frames. Set to auto by default, and -1 means change to automatic.</p><p>Value range: [-1, 16]</p>
        /// </summary>
        [JsonProperty("Bframes")]
        public long? Bframes{ get; set; }

        /// <summary>
        /// <p>Average duration of slices. 0 or left empty means automatic, and an appropriate segment duration will be automatically chosen based on video features such as GOP.</p><p>Value range: [0, 10]</p><p>Unit: seconds</p><p>Supports only transcoding templates, not adaptive bitrate stream templates.</p>
        /// </summary>
        [JsonProperty("HlsTime")]
        public long? HlsTime{ get; set; }

        /// <summary>
        /// <p>A predefined group of encoding tools or features allowed by the video encoding standard, suitable for different scenarios.</p><p>Enumeration values:</p><ul><li>baseline: Supports only I/p frames and non-interlaced scenarios, suitable for video calls, mobile video, and other scenarios.</li><li>main: Mainstream Profile, provides I-frames, p-frames, and B-frames, and supports both interlaced and non-interlaced modes. Mainly used in mainstream audio and video consumption products such as video players and streaming media transmission devices.</li><li>high: Highest encoding level, adds 8X8 prediction on top of the main Profile and supports custom quantification. Widely used in Blu-ray storage, HDTV, and other scenarios.</li><li>default: Automatic filling along with the original video.  </li></ul><p>default value: default</p><p>This configuration item is valid only when Codec is libx264.</p>
        /// </summary>
        [JsonProperty("VideoProfile")]
        public string VideoProfile{ get; set; }


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
            this.SetParamSimple(map, prefix + "CodecTag", this.CodecTag);
            this.SetParamSimple(map, prefix + "GopUnit", this.GopUnit);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Bframes", this.Bframes);
            this.SetParamSimple(map, prefix + "HlsTime", this.HlsTime);
            this.SetParamSimple(map, prefix + "VideoProfile", this.VideoProfile);
        }
    }
}

