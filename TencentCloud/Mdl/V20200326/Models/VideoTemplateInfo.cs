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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Video transcoding template name, which can contain 1-20 letters and digits.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Video codec. Valid values: H264/H265. If this parameter is left empty, the original value will be used.
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// Video bitrate. Value range: [50000,40000000]. The value can only be a multiple of 1,000. If this parameter is left empty, the original value will be used.
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public ulong? VideoBitrate{ get; set; }

        /// <summary>
        /// Video width. The input range is (0, 4096] and must be a multiple of 2. If left blank, it represents passthrough.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Video height. Input range is (0, 4096] and must be a multiple of 2. Leave empty to represent passthrough.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Video frame rate. Valid when you select SPECIFIED_HZ for FrameRateType. Input range is [1, 240]. Leave blank to represent passthrough.
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// Whether to enable top speed codec. Valid value: CLOSE/OPEN. Default value: CLOSE.
        /// </summary>
        [JsonProperty("TopSpeed")]
        public string TopSpeed{ get; set; }

        /// <summary>
        /// Top speed codec compression ratio. Value range: [0,50]. The lower the compression ratio, the higher the image quality.
        /// </summary>
        [JsonProperty("BitrateCompressionRatio")]
        public ulong? BitrateCompressionRatio{ get; set; }

        /// <summary>
        /// Bitrate control mode. Optional values: [CBR|ABR|VBR]. Default: ABR.
        /// </summary>
        [JsonProperty("RateControlMode")]
        public string RateControlMode{ get; set; }

        /// <summary>
        /// Watermark Id.
        /// </summary>
        [JsonProperty("WatermarkId")]
        public string WatermarkId{ get; set; }

        /// <summary>
        /// Whether to enable the face blur function, 1 is on, 0 is off, and the default is 0.
        /// </summary>
        [JsonProperty("FaceBlurringEnabled")]
        public ulong? FaceBlurringEnabled{ get; set; }

        /// <summary>
        /// This field indicates how to specify the output video frame rate. If selected FOLLOW_SOURCE, the output video frame rate is set to equal the frame rate of the first input video. If selected SPECIFIED_FRACTION, the output video frame rate is determined by the fraction (frame rate molecular and frame rate denominator). If selected SPECIFIED_HZ, the frame rate of the output video is determined by the HZ you input.
        /// </summary>
        [JsonProperty("FrameRateType")]
        public string FrameRateType{ get; set; }

        /// <summary>
        /// Valid when you select SPECIFIED_FRACTION as the FrameRateType. Set the output frame rate molecular.
        /// </summary>
        [JsonProperty("FrameRateNumerator")]
        public ulong? FrameRateNumerator{ get; set; }

        /// <summary>
        /// Valid when you select SPECIFIED_FRACTION for FrameRateType. Output frame rate denominator set.
        /// </summary>
        [JsonProperty("FrameRateDenominator")]
        public ulong? FrameRateDenominator{ get; set; }

        /// <summary>
        /// Number of B-frames 1-3.	
        /// </summary>
        [JsonProperty("BFramesNum")]
        public ulong? BFramesNum{ get; set; }

        /// <summary>
        /// Refer to the number of frames 1-16.	
        /// </summary>
        [JsonProperty("RefFramesNum")]
        public ulong? RefFramesNum{ get; set; }

        /// <summary>
        /// Additional video bitrate configuration.	
        /// </summary>
        [JsonProperty("AdditionalRateSettings")]
        public AdditionalRateSetting AdditionalRateSettings{ get; set; }

        /// <summary>
        /// Video encoding configuration.	
        /// </summary>
        [JsonProperty("VideoCodecDetails")]
        public VideoCodecDetail VideoCodecDetails{ get; set; }

        /// <summary>
        /// Video enhancement switch, 1: enable 0: disable.
        /// </summary>
        [JsonProperty("VideoEnhanceEnabled")]
        public ulong? VideoEnhanceEnabled{ get; set; }

        /// <summary>
        /// Video enhancement parameters array.
        /// </summary>
        [JsonProperty("VideoEnhanceSettings")]
        public VideoEnhanceSetting[] VideoEnhanceSettings{ get; set; }

        /// <summary>
        /// Colorspace configuration.
        /// </summary>
        [JsonProperty("ColorSpaceSettings")]
        public ColorSpaceSetting ColorSpaceSettings{ get; set; }

        /// <summary>
        /// Traceable watermark.
        /// </summary>
        [JsonProperty("ForensicWatermarkIds")]
        public string[] ForensicWatermarkIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "TopSpeed", this.TopSpeed);
            this.SetParamSimple(map, prefix + "BitrateCompressionRatio", this.BitrateCompressionRatio);
            this.SetParamSimple(map, prefix + "RateControlMode", this.RateControlMode);
            this.SetParamSimple(map, prefix + "WatermarkId", this.WatermarkId);
            this.SetParamSimple(map, prefix + "FaceBlurringEnabled", this.FaceBlurringEnabled);
            this.SetParamSimple(map, prefix + "FrameRateType", this.FrameRateType);
            this.SetParamSimple(map, prefix + "FrameRateNumerator", this.FrameRateNumerator);
            this.SetParamSimple(map, prefix + "FrameRateDenominator", this.FrameRateDenominator);
            this.SetParamSimple(map, prefix + "BFramesNum", this.BFramesNum);
            this.SetParamSimple(map, prefix + "RefFramesNum", this.RefFramesNum);
            this.SetParamObj(map, prefix + "AdditionalRateSettings.", this.AdditionalRateSettings);
            this.SetParamObj(map, prefix + "VideoCodecDetails.", this.VideoCodecDetails);
            this.SetParamSimple(map, prefix + "VideoEnhanceEnabled", this.VideoEnhanceEnabled);
            this.SetParamArrayObj(map, prefix + "VideoEnhanceSettings.", this.VideoEnhanceSettings);
            this.SetParamObj(map, prefix + "ColorSpaceSettings.", this.ColorSpaceSettings);
            this.SetParamArraySimple(map, prefix + "ForensicWatermarkIds.", this.ForensicWatermarkIds);
        }
    }
}

