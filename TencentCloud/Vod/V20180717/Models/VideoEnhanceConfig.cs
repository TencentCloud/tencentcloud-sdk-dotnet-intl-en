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
        /// <li>common: general enhancement parameters, which are basic optimization parameters suitable for various video types, enhancing overall video quality.</li>
        /// <li>AIGC: overall resolution enhancement. It leverages AI technology to improve the overall video resolution and enhance image clarity.</li>
        /// <li>short_play: enhance facial and subtitle details, emphasizing characters' facial expressions and subtitle clarity to improve the viewing experience.</li>
        /// <li>short_video: optimize complex and diverse image quality issues, tailoring quality enhancements for the complex scenarios such as short videos to address various visual issues.</li>
        /// <li>game (video): fix motion blur and enhance details, with a focus on enhancing the clarity of game details and restoring blurry areas during motions to make the image content during gaming clearer and richer.</li>
        /// <li>HD_movie_series (UHD TV shows and movies), obtain smooth UHD effect, target the demand for UHD video from broadcasting/TV Stations and OTT, generate 4K 60fps HDR Ultra-High-Definition Standard Video. Support broadcasting scenario format standards.</li>
        /// <li>LQ_material: low-definition material/old video restoration. It enhances overall resolution, and solves issues of old videos, such as low resolution, blur, distortion, scratches, and color temperature due to their age.</li>
        /// <li>lecture: live shows, e-commerce, conferences, and lectures. It improves the face display effect and performs specific optimizations, including face region enhancement, noise reduction, and artifacts removal, for scenarios involving human explanation, such as live shows, e-commerce, conferences, and lectures.</li>
        /// <li>Input of a null string indicates that the enhancement scenario is not used.</li>
        /// </summary>
        [JsonProperty("EnhanceScenarioType")]
        public string EnhanceScenarioType{ get; set; }

        /// <summary>
        /// Super-resolution configuration. The video will not be processed when the source resolution exceeds the target resolution. Note that large model enhancement cannot be enabled simultaneously.
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
        /// Video noise reduction configuration. Note that it cannot be enabled simultaneously with large model enhancement.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Denoise")]
        public VideoDenoiseInfo Denoise{ get; set; }

        /// <summary>
        /// Comprehensive enhancement configuration. Note that only one of the three items, large model, comprehensive enhancement, and jitter removal, can be configured.
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
        /// Remove scratch configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScratchRepair")]
        public ScratchRepairInfo ScratchRepair{ get; set; }

        /// <summary>
        /// Artifacts removal configuration. Note that only one of the three items, large model, comprehensive enhancement, and artifacts removal, can be configured.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ArtifactRepair")]
        public ArtifactRepairInfo ArtifactRepair{ get; set; }

        /// <summary>
        /// Large model enhancement configuration. Note that you can configure only one of the large model, comprehensive enhancement, and deburr options. It cannot intersect with super-resolution or noise reduction.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiffusionEnhance")]
        public DiffusionEnhanceInfo DiffusionEnhance{ get; set; }

        /// <summary>
        /// Frame interpolation frame rate configuration supports fractions. Note that it is mutually exclusive with FrameRate. The capacity will not take effect when the source frame rate is equal to or greater than the target frame rate.
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

