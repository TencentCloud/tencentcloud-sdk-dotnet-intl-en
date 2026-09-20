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

    public class AigcImageTaskInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Model name.</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Model version.</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>AIGC image generation task input file information.</p>
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcImageTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>Prompt for image generation. This parameter is required when FileInfos is empty.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Prompt to prevent the model from image generation.</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>Whether to optimize Prompt content automatically. When Enabled, the passed-in Prompt will be optimized automatically to enhance generation quality. Valid values: <li>Enabled: enable;</li> <li>Disabled: disable;</li></p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>Generation mode. Valid values: <li>Standard: standard mode;</li> <li>Professional: high-quality mode;</li></p>
        /// </summary>
        [JsonProperty("GenerationMode")]
        public string GenerationMode{ get; set; }

        /// <summary>
        /// <p>AIGC image generation output result file output.</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcImageOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// <p>Random seed of the model.</p>
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// <p>Scenario type. Values are as follows: <li>When ModelName is Hunyuan: 3d_panorama means panoramic view;</li><li>Other ModelName values are not currently supported.</li></p>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>Pass-through parameter.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamSimple(map, prefix + "GenerationMode", this.GenerationMode);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

