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
        /// Model name. 
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Model version. 
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// File information of the input image for the AIGC image generation task.
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcImageTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// The prompt content for image generation.
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Prevent the model from generating image generation prompts.
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// Whether to optimize Prompt content automatically. when Enabled, it will optimize the passed in Prompt automatically to enhance generation quality. valid values: <li>Enabled: turn on;</li> <li>Disabled: turn off;</li>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("GenerationMode")]
        public string GenerationMode{ get; set; }

        /// <summary>
        /// Output media file configuration for the task.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcImageOutputConfig OutputConfig{ get; set; }


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
        }
    }
}

