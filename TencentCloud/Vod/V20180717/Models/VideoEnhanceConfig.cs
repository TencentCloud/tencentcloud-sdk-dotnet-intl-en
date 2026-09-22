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
        /// <li>HD_movie_series (UHD TV shows and movies) obtains smooth UHD effect, targeting the demand for UHD video in broadcasting/OTT, and generates Ultra-High-Definition Standard Video at 4K 60fps HDR. It supports broadcasting scenario format standards.</li>
        /// <li>LQ_material: low-definition material/old video restoration. It enhances overall resolution, and solves issues of old videos, such as low resolution, blur, distortion, scratches, and color temperature due to their age.</li>
        /// <li>lecture: live shows, e-commerce, conferences, and lectures. It improves the face display effect and performs specific optimizations, including face region enhancement, noise reduction, and artifacts removal, for scenarios involving human explanation, such as live shows, e-commerce, conferences, and lectures.</li>
        /// <li>Input of a null string indicates that the enhancement scenario is not used.</li>
        /// </summary>
        [JsonProperty("EnhanceScenarioType")]
        public string EnhanceScenarioType{ get; set; }

        /// <summary>
        /// Super-resolution configuration. If the source resolution is higher than the target resolution, the video will not be processed. Note that it cannot be enabled simultaneously with large model enhancement.
        /// </summary>
        [JsonProperty("SuperResolution")]
        public SuperResolutionInfo SuperResolution{ get; set; }

        /// <summary>
        /// HDR configuration.
        /// </summary>
        [JsonProperty("Hdr")]
        public HDRInfo Hdr{ get; set; }

        /// <summary>
        /// Video noise reduction configuration. Note that it cannot be enabled simultaneously with large model enhancement.
        /// </summary>
        [JsonProperty("Denoise")]
        public VideoDenoiseInfo Denoise{ get; set; }

        /// <summary>
        /// Comprehensive enhancement configuration. Note that only one of the three items, LLM enhancement, comprehensive enhancement, and artifacts removal, can be configured.
        /// </summary>
        [JsonProperty("ImageQualityEnhance")]
        public ImageQualityEnhanceInfo ImageQualityEnhance{ get; set; }

        /// <summary>
        /// Color enhancement configuration.
        /// </summary>
        [JsonProperty("ColorEnhance")]
        public ColorEnhanceInfo ColorEnhance{ get; set; }

        /// <summary>
        /// Low-light enhancement configuration.
        /// </summary>
        [JsonProperty("LowLightEnhance")]
        public LowLightEnhanceInfo LowLightEnhance{ get; set; }

        /// <summary>
        /// Scratch configuration.
        /// </summary>
        [JsonProperty("ScratchRepair")]
        public ScratchRepairInfo ScratchRepair{ get; set; }

        /// <summary>
        /// Artifacts removal configuration. Note that only one of the three items, LLM enhancement, comprehensive enhancement, and artifacts removal, can be configured.
        /// </summary>
        [JsonProperty("ArtifactRepair")]
        public ArtifactRepairInfo ArtifactRepair{ get; set; }

        /// <summary>
        /// LLM enhancement configuration. Note that only one of the three items, LLM enhancement, comprehensive enhancement, and artifacts removal, can be configured. It cannot be enabled simultaneously with super resolution or noise reduction.
        /// </summary>
        [JsonProperty("DiffusionEnhance")]
        public DiffusionEnhanceInfo DiffusionEnhance{ get; set; }

        /// <summary>
        /// Frame interpolation frame rate configuration. Fractions are supported. Note that you can only specify either this parameter or FrameRate. The capacity will not take effect when the source frame rate is equal to or greater than the target frame rate.
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

