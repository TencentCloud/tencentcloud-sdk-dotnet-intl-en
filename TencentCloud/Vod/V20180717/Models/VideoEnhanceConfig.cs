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

    public class VideoEnhanceConfig : AbstractModel
    {
        
        /// <summary>
        /// Enhancement scenario configuration. Valid values:
        /// <li>common: common enhancement parameters, which are basic optimization parameters suitable for various video types, enhancing overall image quality.</li>
        /// <li>AIGC: overall resolution enhancement. It uses AI technology to improve the overall video resolution and image clarity.</li>
        /// <li>short_play: enhance facial and subtitle details, emphasizing characters' facial expressions and subtitle clarity to improve the viewing experience.</li>
        /// <li>short_video: optimize complex and diverse image quality issues, tailoring quality enhancements for the complex scenarios such as short videos to address various visual issues.</li>
        /// <li>game: fix motion blur and enhance details, with a focus on enhancing the clarity of game details and restoring blurry areas during motions to make the image content during gaming clearer and richer.</li>
        /// <li>HD_movie_series: provide a smooth playback effect for UHD videos. Standard 4K HDR videos with an FPS of 60 are generated to meet the needs of broadcasting/OTT for UHD videos. Formats for broadcasting scenarios are supported.</li>
        /// <li>LQ_material: low-definition material/old video restoration. It enhances overall resolution, and solves issues of old videos, such as low resolution, blur, distortion, scratches, and color temperature due to their age.</li>
        /// <li>lecture: live shows, e-commerce, conferences, and lectures. It improves the face display effect and performs specific optimizations, including face region enhancement, noise reduction, and artifacts removal, for scenarios involving human explanation, such as live shows, e-commerce, conferences, and lectures.</li>
        /// <li>Input of a null string indicates that the enhancement scenario is not used.</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnhanceScenarioType")]
        public string EnhanceScenarioType{ get; set; }

        /// <summary>
        /// Super-resolution configuration. The video is not processed when the source resolution is higher than the target resolution. Note that it cannot be enabled simultaneously with Large Model enhancement.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SuperResolution")]
        public SuperResolutionInfo SuperResolution{ get; set; }

        /// <summary>
        /// HDR configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Hdr")]
        public HDRInfo Hdr{ get; set; }

        /// <summary>
        /// Video noise reduction configuration. Note that it cannot be enabled simultaneously with LLM enhancement.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Denoise")]
        public VideoDenoiseInfo Denoise{ get; set; }

        /// <summary>
        /// Comprehensive enhancement configuration. Note that only one of the three items, LLM enhancement, comprehensive enhancement, and artifacts removal, can be configured.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImageQualityEnhance")]
        public ImageQualityEnhanceInfo ImageQualityEnhance{ get; set; }

        /// <summary>
        /// Color enhancement configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ColorEnhance")]
        public ColorEnhanceInfo ColorEnhance{ get; set; }

        /// <summary>
        /// Low-light enhancement configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LowLightEnhance")]
        public LowLightEnhanceInfo LowLightEnhance{ get; set; }

        /// <summary>
        /// Banding removal configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScratchRepair")]
        public ScratchRepairInfo ScratchRepair{ get; set; }

        /// <summary>
        /// Artifacts removal configuration. Note that only one of the three items, LLM enhancement, comprehensive enhancement, and artifacts removal, can be configured.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ArtifactRepair")]
        public ArtifactRepairInfo ArtifactRepair{ get; set; }

        /// <summary>
        /// Large Model enhancement configuration. Note that only one of the three items, LLM enhancement, comprehensive enhancement, and artifacts removal, can be configured. It cannot be enabled simultaneously with super-resolution and noise reduction.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiffusionEnhance")]
        public DiffusionEnhanceInfo DiffusionEnhance{ get; set; }

        /// <summary>
        /// Frame rate configuration for the frame interpolation, which supports fractions. Note that it is mutually exclusive with FrameRate. The configuration does not take effect if the source frame rate is greater than or equal to the target frame rate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FrameRateWithDen")]
        public FrameRateWithDenInfo FrameRateWithDen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnhanceScenarioType", this.EnhanceScenarioType);
            this.SetParamObj(map, prefix + "SuperResolution.", this.SuperResolution);
            this.SetParamObj(map, prefix + "Hdr.", this.Hdr);
            this.SetParamObj(map, prefix + "Denoise.", this.Denoise);
            this.SetParamObj(map, prefix + "ImageQualityEnhance.", this.ImageQualityEnhance);
            this.SetParamObj(map, prefix + "ColorEnhance.", this.ColorEnhance);
            this.SetParamObj(map, prefix + "LowLightEnhance.", this.LowLightEnhance);
            this.SetParamObj(map, prefix + "ScratchRepair.", this.ScratchRepair);
            this.SetParamObj(map, prefix + "ArtifactRepair.", this.ArtifactRepair);
            this.SetParamObj(map, prefix + "DiffusionEnhance.", this.DiffusionEnhance);
            this.SetParamObj(map, prefix + "FrameRateWithDen.", this.FrameRateWithDen);
        }
    }
}

