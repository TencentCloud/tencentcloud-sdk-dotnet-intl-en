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
        /// 
        /// </summary>
        [JsonProperty("EnhanceScenarioType")]
        public string EnhanceScenarioType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SuperResolution")]
        public SuperResolutionInfo SuperResolution{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Hdr")]
        public HDRInfo Hdr{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Denoise")]
        public VideoDenoiseInfo Denoise{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ImageQualityEnhance")]
        public ImageQualityEnhanceInfo ImageQualityEnhance{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ColorEnhance")]
        public ColorEnhanceInfo ColorEnhance{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LowLightEnhance")]
        public LowLightEnhanceInfo LowLightEnhance{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScratchRepair")]
        public ScratchRepairInfo ScratchRepair{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ArtifactRepair")]
        public ArtifactRepairInfo ArtifactRepair{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DiffusionEnhance")]
        public DiffusionEnhanceInfo DiffusionEnhance{ get; set; }

        /// <summary>
        /// 
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

