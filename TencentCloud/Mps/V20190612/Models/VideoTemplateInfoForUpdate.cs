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

    public class VideoTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Video stream encoding format. Valid values:
        /// <li>h264: H.264 encoding.</li>
        /// <li>h265: H.265 encoding.</li>
        /// <li>h266: H.266 encoding.</li>
        /// <li>av1: AOMedia Video 1 encoding.</li>
        /// <li>vp8: VP8 encoding.</li>
        /// <li>vp9: VP9 encoding.</li>
        /// <li>mpeg2: MPEG2 encoding.</li>
        /// <li>dnxhd: DNxHD encoding.</li>
        /// <li>mv-hevc: MV-HEVC encoding.</li>
        /// Note: A resolution within 640x480 should be specified for H.265 encoding.
        /// 
        /// Note: AV1 encoding containers only support mp4, webm, and mkv.
        /// Note: H.266 encoding containers only support mp4, hls, ts, and mov.
        /// Note: VP8 and VP9 encoding containers only support webm and mkv.
        /// Note: MPEG2 and DNxHD encoding containers only support mxf.
        /// Note: MV-HEVC encoding containers only support mp4, hls, and mov. Among them, the hls format only supports mp4 segmentation format.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Video frame rate. Value range:
        /// When FpsDenominator is empty, the range is [0, 120], in Hz.
        /// When FpsDenominator is not empty, the Fps/FpsDenominator range is [0, 120].
        /// If the value is 0, the frame rate will be the same as that of the source video.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// Bitrate of a video stream, in kbps. Value range: 0 and [128, 100000].If the value is 0, the bitrate of the video will be the same as that of the source video.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// Resolution adaption. Valid values:
        /// <li>open: Enabled. When resolution adaption is enabled, `Width` indicates the long side of a video, while `Height` indicates the short side.</li>
        /// <li>close: Disabled. When resolution adaption is disabled, `Width` indicates the width of a video, while `Height` indicates the height.</li>
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
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum value of the height (or short side) of a video stream in px. Value range: 0 and [128, 4,096].
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Frame interval between I keyframes. Value range: 0 and [1,100000]. If this parameter is 0, the system will automatically set the GOP length.
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// Fill type. "Fill" refers to the way of processing a screenshot when its aspect ratio is different from that of the source video. The following fill types are supported:
        /// <li> stretch: stretch. The screenshot will be stretched frame by frame to match the aspect ratio of the source video, which may make the screenshot "shorter" or "longer";</li>
        /// <li>black: fill with black. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with black color blocks.</li>
        /// <li>white: fill with white. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with white color blocks.</li>
        /// <li>gauss: fill with Gaussian blur. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with Gaussian blur.</li>
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// The control factor of video constant bitrate. Value range: [0, 51]. This parameter will be disabled if you enter `0`.
        /// It is not recommended to specify this parameter if there are no special requirements.
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }

        /// <summary>
        /// Whether to enable adaptive encoding. Valid values:
        /// <li>0: Disable</li>
        /// <li>1: Enable</li>
        /// Default value: 0. If this parameter is set to `1`, multiple streams with different resolutions and bitrates will be generated automatically. The highest resolution, bitrate, and quality of the streams are determined by the values of `width` and `height`, `Bitrate`, and `Vcrf` in `VideoTemplate` respectively. If these parameters are not set in `VideoTemplate`, the highest resolution generated will be the same as that of the source video, and the highest video quality will be close to VMAF 95. To use this parameter or learn about the billing details of adaptive encoding, please contact your sales rep.
        /// </summary>
        [JsonProperty("ContentAdaptStream")]
        public ulong? ContentAdaptStream{ get; set; }

        /// <summary>
        /// HLS segment type. Valid values:
        /// <li>0: HLS+TS segment.</li>
        /// <li>2: HLS+TS byte range.</li>
        /// <li>7: HLS+MP4 segment.</li>
        /// <li>5: HLS+MP4 byte range.</li>
        /// Default value: 0
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SegmentType")]
        public long? SegmentType{ get; set; }

        /// <summary>
        /// Denominator of the frame rate.
        /// Note: The value must be greater than 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FpsDenominator")]
        public long? FpsDenominator{ get; set; }

        /// <summary>
        /// 3D video splicing mode, which is only valid for MV-HEVC 3D videos. Valid values:
        /// <li>side_by_side: side-by-side view.</li>
        /// <li>top_bottom: top-bottom view.</li>
        /// Default value: side_by_side.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Stereo3dType")]
        public string Stereo3dType{ get; set; }


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
            this.SetParamSimple(map, prefix + "ContentAdaptStream", this.ContentAdaptStream);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "FpsDenominator", this.FpsDenominator);
            this.SetParamSimple(map, prefix + "Stereo3dType", this.Stereo3dType);
        }
    }
}

