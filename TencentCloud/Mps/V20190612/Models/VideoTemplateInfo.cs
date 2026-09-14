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

    public class VideoTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Encoding format for video streams. Optional values:
        /// <li>h264: H.264 encoding.</li>
        /// <li>h265: H.265 encoding.</li>
        /// <li>h266: H.266 encoding.</li>
        /// <li>av1: AOMedia Video 1 encoding</li>
        /// <li>vp8: VP8 encoding.</li>
        /// <li>vp9: VP9 encoding.</li>
        /// <li>mpeg2: MPEG2 encoding.</li>
        /// <li>dnxhd: DNxHD encoding.</li>
        /// <li>mv-hevc: MV-HEVC encoding.</li>
        /// 
        /// Note: av1 encoding container currently only supports mp4, webm, and mkv.
        /// Note: H.266 encoding containers currently only support mp4, hls, ts, and mov.
        /// Note: VP8 and VP9 encoding containers currently only support webm and mkv.
        /// Note: MPEG2 and dnxhd encoding containers currently only support mxf.
        /// Note: The MV-HEVC codec currently only supports mp4, hls, and mov. Among them, the HLS format only supports the MP4 segmented format and requires the input source to be a panoramic video (with multiple views).
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Video frame rate. Value range:
        /// When FpsDenominator is empty, the range is [0, 120], in Hz.
        /// When FpsDenominator is not empty, the Fps/FpsDenominator range is [0, 120].
        /// If the value is 0, the frame rate will be the same as that of the source video.
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// Bitrate of the video stream. Value range: 0 and [128, 100000]. Unit: kbps.
        /// If the value is 0, the bitrate of the video will be the same as that of the source video.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// Resolution adaptation, available values:
        /// <li>open: turn on. At this point, Width represents the long side of the video, and Height indicates the short side of the video;</li>
        /// <li>close: close. At this point, Width represents the width of the video, and Height indicates the height of the video.</li>
        /// Default value: open.
        /// Note: In self-adaptation mode, Width cannot be less than Height.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Maximum value of the video stream width (or long edge) in px. Value range: 0 and [128, 4096].
        /// <li>If both Width and Height are 0, the resolution is the same as the source.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be proportionally scaled.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be proportionally scaled.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// Default value: 0.
        /// Note: If Codec is set to MV-HEVC, the maximum value can be 7680.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum value of the video stream height (or short side). Value range: 0 and [128, 4096]. Unit: px.
        /// <li>If both Width and Height are 0, the resolution is the same as the source.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be proportionally scaled.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be proportionally scaled.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// Default value: 0.
        /// Note: If Codec is set to MV-HEVC, the maximum value can be 7680.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Interval between I-frames (keyframes), which can be customized in frames or seconds. GOP value range: 0 and [1, 100000].
        /// If this parameter is 0 or left blank, the system will automatically set the GOP length.
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("GopUnit")]
        public string GopUnit{ get; set; }

        /// <summary>
        /// Filling method, when video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video, the processing method for transcoding is "padding". Optional filling modes:
        /// <li> stretch: stretches each frame to fill the entire screen, possibly causing the transcoded video to be "squashed" or "stretched";</li>
        /// <li>black: Keep black, maintain video aspect ratio, edges filled with black.</li>
        /// <li>White: Leave blank, maintain video aspect ratio, edge remainder filled with white.</li>
        /// <li>gauss: Gaussian blur, maintain video aspect ratio, and use Gaussian blur filling for the rest of the edges.</li>
        /// <li>smarttailor: intelligent cropping: smartly select video images to ensure proportional image cropping.</li>
        /// Default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HlsTime")]
        public ulong? HlsTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SegmentType")]
        public long? SegmentType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FpsDenominator")]
        public long? FpsDenominator{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Stereo3dType")]
        public string Stereo3dType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoProfile")]
        public string VideoProfile{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoLevel")]
        public string VideoLevel{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Bframes")]
        public long? Bframes{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Sar")]
        public string Sar{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NoScenecut")]
        public long? NoScenecut{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BitDepth")]
        public long? BitDepth{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RawPts")]
        public long? RawPts{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Compress")]
        public long? Compress{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SegmentSpecificInfo")]
        public SegmentSpecificInfo SegmentSpecificInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScenarioBased")]
        public long? ScenarioBased{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }


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
            this.SetParamSimple(map, prefix + "GopUnit", this.GopUnit);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Vcrf", this.Vcrf);
            this.SetParamSimple(map, prefix + "HlsTime", this.HlsTime);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "FpsDenominator", this.FpsDenominator);
            this.SetParamSimple(map, prefix + "Stereo3dType", this.Stereo3dType);
            this.SetParamSimple(map, prefix + "VideoProfile", this.VideoProfile);
            this.SetParamSimple(map, prefix + "VideoLevel", this.VideoLevel);
            this.SetParamSimple(map, prefix + "Bframes", this.Bframes);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Sar", this.Sar);
            this.SetParamSimple(map, prefix + "NoScenecut", this.NoScenecut);
            this.SetParamSimple(map, prefix + "BitDepth", this.BitDepth);
            this.SetParamSimple(map, prefix + "RawPts", this.RawPts);
            this.SetParamSimple(map, prefix + "Compress", this.Compress);
            this.SetParamObj(map, prefix + "SegmentSpecificInfo.", this.SegmentSpecificInfo);
            this.SetParamSimple(map, prefix + "ScenarioBased", this.ScenarioBased);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
        }
    }
}

