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

    public class RebuildVideoInfo : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RepairInfo")]
        public RepairInfo RepairInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoFrameInterpolationInfo")]
        public VideoFrameInterpolationInfo VideoFrameInterpolationInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SuperResolutionInfo")]
        public SuperResolutionInfo SuperResolutionInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HDRInfo")]
        public HDRInfo HDRInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoDenoiseInfo")]
        public VideoDenoiseInfo VideoDenoiseInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ColorInfo")]
        public ColorEnhanceInfo ColorInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SharpInfo")]
        public SharpEnhanceInfo SharpInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FaceInfo")]
        public FaceEnhanceInfo FaceInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LowLightInfo")]
        public LowLightEnhanceInfo LowLightInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScratchRepairInfo")]
        public ScratchRepairInfo ScratchRepairInfo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ArtifactRepairInfo")]
        public ArtifactRepairInfo ArtifactRepairInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RepairInfo.", this.RepairInfo);
            this.SetParamObj(map, prefix + "VideoFrameInterpolationInfo.", this.VideoFrameInterpolationInfo);
            this.SetParamObj(map, prefix + "SuperResolutionInfo.", this.SuperResolutionInfo);
            this.SetParamObj(map, prefix + "HDRInfo.", this.HDRInfo);
            this.SetParamObj(map, prefix + "VideoDenoiseInfo.", this.VideoDenoiseInfo);
            this.SetParamObj(map, prefix + "ColorInfo.", this.ColorInfo);
            this.SetParamObj(map, prefix + "SharpInfo.", this.SharpInfo);
            this.SetParamObj(map, prefix + "FaceInfo.", this.FaceInfo);
            this.SetParamObj(map, prefix + "LowLightInfo.", this.LowLightInfo);
            this.SetParamObj(map, prefix + "ScratchRepairInfo.", this.ScratchRepairInfo);
            this.SetParamObj(map, prefix + "ArtifactRepairInfo.", this.ArtifactRepairInfo);
        }
    }
}

