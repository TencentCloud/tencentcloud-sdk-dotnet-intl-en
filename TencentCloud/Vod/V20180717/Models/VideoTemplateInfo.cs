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

    public class VideoTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Video stream encoding format. Available values:</p><li>libx264: H.264 code;</li><li>libx265: H.265 code;</li><li>av1: AOMedia Video 1 code;</li><li>H.266: H.266 code.</li><font color="red">Note:</font><li>av1 and H.266 encoding containers currently only support mp4;</li><li>H.266 currently only supports fixed CRF bitrate control method.</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// <p>Video frame rate. Value ranges from 0 to 100. Measurement unit: Hz.<br>When the value is 0, it means the frame rate is consistent with the original video.</p>
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// <p>Bitrate of video stream, value ranges from 0 to [128, 100000], unit: kbps.<br>When the value is 0, it means the bitrate is automatically set by VOD.</p>
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// <p>Resolution adaptation. Available values:</p><li>open: Enable. At this point, Width represents the long side of the video, and Height represents the short side of the video;</li><li>close: Disable. At this point, Width represents the width of the video, and Height represents the height of the video.</li>Default value: open.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// <p>The maximum value of the video stream width (or long side). Valid values: 0 and [128, 8192]. Unit: px.</p><li>When Width and Height are both 0, the resolution is from the same source;</li><li>When Width is 0 and Height is non-0, Width is scaled proportionally;</li><li>When Width is non-0 and Height is 0, the Height is scaled proportionally;</li><li>When both Width and Height are non-0, the resolution is specified by the user.</li>Default value: 0.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// <p>The maximum value of the video stream height (or short side). Valid values: 0 and [128, 8192]. Unit: px.</p><li>When Width and Height are both 0, the resolution is from the same source;</li><li>When Width is 0 and Height is non-0, Width is scaled proportionally;</li><li>When Width is non-0 and Height is 0, the Height is scaled proportionally;</li><li>When both Width and Height are non-0, the resolution is specified by the user.</li>Default value: 0.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// <p>Filling method. When video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video, the processing method for transcoding is "filling". Optional filling mode:</p><li> stretch: Stretch each frame to fill the entire screen, possibly causing the transcoded video to be "squashed" or "stretched".</li><li>black: Maintain video aspect ratio with edges filled with black.</li><li>white: Maintain video aspect ratio with edge remainder filled with white.</li><li>gauss: Maintain video aspect ratio with Gaussian blur filling for the rest of the edges.</li>Default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// <p>Control factor for constant video bitrate, value range [1, 51].</p><p><font color="red">Note:</font></p><li>If you specify this parameter, the bitrate control mode for CRF will be used to transcode (video bitrate will no longer take effect).</li><li>When the specified video stream encoding format is H.266, this field is required with a recommended value of 28.</li><li>If there are no special requirements, it is not recommended to specify this parameter.</li>
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }

        /// <summary>
        /// <p>Interval between I-frames, in frames. Value range: 0 and [1, 100000].<br>When it is set to 0 or not set, the system will automatically set the gop length.</p>
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// <p>Gop value unit.</p><p>Enumeration value:</p><ul><li>frame: Represents the number of frames.</li><li>second: Represents seconds.</li></ul><p>Default value: frame</p>
        /// </summary>
        [JsonProperty("GopUnit")]
        public string GopUnit{ get; set; }

        /// <summary>
        /// <p>Whether the transcoding output still keeps HDR when the original video is HDR (High Dynamic Range). Value ranges from:</p><li>ON: If the raw file is HDR, the transcoding output keeps HDR; otherwise, the transcoding output is SDR (Standard Dynamic Range).</li><li>OFF: Regardless of whether the raw file is HDR or SDR, the transcoding output is SDR.</li>Default value: OFF.
        /// </summary>
        [JsonProperty("PreserveHDRSwitch")]
        public string PreserveHDRSwitch{ get; set; }

        /// <summary>
        /// <p>Encoding tag, valid only when the video stream encoding format is H.265. Available values:</p><li>hvc1 refers to the hvc1 tag;</li><li>hev1 refers to the hev1 tag.</li>Default value: hvc1.
        /// </summary>
        [JsonProperty("CodecTag")]
        public string CodecTag{ get; set; }

        /// <summary>
        /// <p>Bitrate control mode.</p><p>Enumeration value:</p><ul><li>VBR: Variable Bit Rate, dynamic bitrate (VBR), adjusts the output bitrate based on the complexity of the video image to ensure higher image quality, suitable for storage scenarios and applications with high image quality requirements.</li><li>ABR: Average Bit Rate, average bitrate, maintains the average bitrate of the output video as much as possible while allowing short-term bitrate fluctuation, suitable for scenarios where maintaining a certain image quality and minimizing overall bitrate are desired.</li><li>CBR: Constant Bit Rate, constant bitrate, maintains a constant output bitrate regardless of image complexity changes, suitable for scenarios with strict network bandwidth requirements, such as live streaming.</li><li>VCRF: Constant Quality Factor, controls video quality by setting a quality factor to achieve constant quality encoding of videos, with bitrate adjustment based on content complexity, suitable for scenarios where maintaining a certain quality is desired.</li></ul><p>Default value: VBR</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>Number of B-frames between reference frames, set to auto by default.</p><p>Value ranges from 0 to 16.</p>
        /// </summary>
        [JsonProperty("Bframes")]
        public long? Bframes{ get; set; }

        /// <summary>
        /// <p>Average duration of slices. 0 or empty means auto, which automatically chooses appropriate segment duration based on video features such as GOP.</p><p>Value ranges from 0 to 10.</p><p>Unit: second.</p><p>Supports only transcoding template. Adaptive bitrate stream template is not currently supported.</p>
        /// </summary>
        [JsonProperty("HlsTime")]
        public long? HlsTime{ get; set; }

        /// <summary>
        /// <p>A predefined group of encoding tools or features allowed by video encoding standards, suitable for different scenarios.</p><p>Enumeration value:</p><ul><li>baseline: Supports only I/P frames and non-interlaced scenarios, suitable for video calls and mobile video.</li><li>main: Mainstream profile, provides I, P, and B frames, and supports both interlaced and non-interlaced modes. Mainly used in mainstream audio and video consumption products such as video players and streaming media transmission devices.</li><li>high: Highest encoding level, adds 8X8 prediction to the Main Profile and supports custom quantification. Widely used in Blu-ray storage and HDTV scenarios.</li><li>default: Automatic filling along with the original video.</li></ul><p>Default value: default</p><p>This configuration item is valid only when Codec is libx264.</p>
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
            this.SetParamSimple(map, prefix + "GopUnit", this.GopUnit);
            this.SetParamSimple(map, prefix + "PreserveHDRSwitch", this.PreserveHDRSwitch);
            this.SetParamSimple(map, prefix + "CodecTag", this.CodecTag);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Bframes", this.Bframes);
            this.SetParamSimple(map, prefix + "HlsTime", this.HlsTime);
            this.SetParamSimple(map, prefix + "VideoProfile", this.VideoProfile);
        }
    }
}

