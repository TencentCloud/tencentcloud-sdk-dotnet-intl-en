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

    public class VideoEnhanceConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Frame rate configuration (old) for the frame interpolation. New users are recommended to use FrameRateWithDen for configuring the frame rate of frame interpolation, which supports fractions and provides better results. Note that FrameRate and FrameRateWithDen are mutually exclusive; configuring both simultaneously may cause task failures. The configuration does not take effect if the source frame rate is greater than or equal to the target frame rate.</p>
        /// </summary>
        [JsonProperty("FrameRate")]
        public FrameRateConfig FrameRate{ get; set; }

        /// <summary>
        /// <p>Super-resolution configuration. The video is not processed when the source resolution is higher than the target resolution. Note that it cannot be enabled simultaneously with LLM enhancement.</p>
        /// </summary>
        [JsonProperty("SuperResolution")]
        public SuperResolutionConfig SuperResolution{ get; set; }

        /// <summary>
        /// <p>HDR configuration.</p>
        /// </summary>
        [JsonProperty("Hdr")]
        public HdrConfig Hdr{ get; set; }

        /// <summary>
        /// <p>Video noise reduction configuration. Note that it cannot be enabled simultaneously with LLM enhancement.</p>
        /// </summary>
        [JsonProperty("Denoise")]
        public VideoDenoiseConfig Denoise{ get; set; }

        /// <summary>
        /// <p>Comprehensive enhancement configuration. Note that only one of the three items, LLM enhancement, comprehensive enhancement, and artifacts removal, can be configured.</p>
        /// </summary>
        [JsonProperty("ImageQualityEnhance")]
        public ImageQualityEnhanceConfig ImageQualityEnhance{ get; set; }

        /// <summary>
        /// <p>Color enhancement configuration.</p>
        /// </summary>
        [JsonProperty("ColorEnhance")]
        public ColorEnhanceConfig ColorEnhance{ get; set; }

        /// <summary>
        /// <p>Low-light enhancement configuration.</p>
        /// </summary>
        [JsonProperty("LowLightEnhance")]
        public LowLightEnhanceConfig LowLightEnhance{ get; set; }

        /// <summary>
        /// <p>Scratches removal configuration.</p>
        /// </summary>
        [JsonProperty("ScratchRepair")]
        public ScratchRepairConfig ScratchRepair{ get; set; }

        /// <summary>
        /// <p>Artifacts removal configuration. Note that only one of the three items, LLM enhancement, comprehensive enhancement, and artifacts removal, can be configured.</p>
        /// </summary>
        [JsonProperty("ArtifactRepair")]
        public ArtifactRepairConfig ArtifactRepair{ get; set; }

        /// <summary>
        /// <p>Enhanced scenario configuration, available values:</p><li>common (General), general enhancement parameter, suitable for various video types, foundation optimization parameters, enhance overall video quality.</li><li>AIGC, overall resolution enhancement, use AI technology to enhance video overall resolution, improve image definition.</li><li>short_play (Mini-drama & AI simulation drama), enhance face and subtitle details, highlight facial expression details and subtitle clarity, improve viewing experience.</li><li>AI_comic (AI comic drama), enhance comic style image detail.</li><li>short_video (short video), optimize complex and diverse image quality issues, target complex scenarios in short videos, optimize video quality, address multiple visual issues.</li><li>game (Gaming video), restore motion blur, enhance details, focus on enhancing the clarity of game details, restore motion blur areas, make the game screen content clearer and more various.</li><li>HD_movie_series (Ultra-high-definition TV shows and movies), obtain ultra-high-definition smooth effect, target the demand for broadcasting/OTT ultra-high-definition video, generate 4K 60fps HDR Ultra-High-Definition Standard video. Support broadcasting scenario format standards.</li><li>LQ_material (Low-quality material/Classic film restoration), overall resolution enhancement, target old video with insufficient resolution, blur distortion, scratch damage and color temperature issues due to older shooting era for specialized optimization.</li><li>lecture (Showroom/E-commerce/Conference/lecture), beautify and enhance face effect, target scenarios where people explain in showroom/e-commerce/conference/lecture, perform specialized optimization for face region, noise reduction, burr processing.</li><li>Fill-in string represents non-use of enhanced scenario.</li>
        /// </summary>
        [JsonProperty("EnhanceSceneType")]
        public string EnhanceSceneType{ get; set; }

        /// <summary>
        /// <p>LLM enhancement configuration. Note that only one of the three items, LLM enhancement, comprehensive enhancement, and artifacts removal, can be configured. It cannot intersect with super-resolution and noise reduction.</p>
        /// </summary>
        [JsonProperty("DiffusionEnhance")]
        public DiffusionEnhanceConfig DiffusionEnhance{ get; set; }

        /// <summary>
        /// <p>The new frame interpolation frame rate configuration supports fractions. Note that you must choose between this and FrameRate. The capacity will not take effect when the source frame rate is equal to or greater than the target frame rate.</p>
        /// </summary>
        [JsonProperty("FrameRateWithDen")]
        public FrameRateWithDenConfig FrameRateWithDen{ get; set; }

        /// <summary>
        /// <p>Large model repair configuration. Note that you can configure at most one of large model, comprehensive enhancement, and artifacts removal. It cannot intersect with super-resolution and noise reduction.</p>
        /// </summary>
        [JsonProperty("AiRestoration")]
        public AiRestorationConfig AiRestoration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FrameRate.", this.FrameRate);
            this.SetParamObj(map, prefix + "SuperResolution.", this.SuperResolution);
            this.SetParamObj(map, prefix + "Hdr.", this.Hdr);
            this.SetParamObj(map, prefix + "Denoise.", this.Denoise);
            this.SetParamObj(map, prefix + "ImageQualityEnhance.", this.ImageQualityEnhance);
            this.SetParamObj(map, prefix + "ColorEnhance.", this.ColorEnhance);
            this.SetParamObj(map, prefix + "LowLightEnhance.", this.LowLightEnhance);
            this.SetParamObj(map, prefix + "ScratchRepair.", this.ScratchRepair);
            this.SetParamObj(map, prefix + "ArtifactRepair.", this.ArtifactRepair);
            this.SetParamSimple(map, prefix + "EnhanceSceneType", this.EnhanceSceneType);
            this.SetParamObj(map, prefix + "DiffusionEnhance.", this.DiffusionEnhance);
            this.SetParamObj(map, prefix + "FrameRateWithDen.", this.FrameRateWithDen);
            this.SetParamObj(map, prefix + "AiRestoration.", this.AiRestoration);
        }
    }
}

