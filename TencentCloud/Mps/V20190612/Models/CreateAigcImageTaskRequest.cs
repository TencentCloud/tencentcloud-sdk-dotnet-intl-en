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

    public class CreateAigcImageTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Model name.
        /// Supported models:Hunyuan,
        /// GEM,
        /// Qwen.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Specific version number of the model. By default, the system uses the supported stable version of the model.1. GEM: [2.5 and 3.0].
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// Description of the generated image. (Note: A maximum of 1000 characters is supported.) This parameter is required when no reference image is specified.
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Specifies the content you want to prevent the model from generating. Note: Not all models support this. For example: top lighting, bright colors, people, animals, multiple vehicles, and wind.
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// The default value is False, meaning the model follows instructions strictly. For better results with more nuanced prompts, set this parameter to True to automatically optimize the input prompt and improve generation quality.
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// Reference resource images. By default, one image can be specified.Model that supports multiple images:1. GEM supports up to 3 resource images.Note:1. The recommended image size is less than 7 MB. Different models have different limits.2. Supported image format: JPEG, PNG, and WebP.
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// Additional parameters required for the model.
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcImageExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// COS bucket information for the file result. Note: COS is required and the MPS_QcsRole role needs to be created and authorized.
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// API operator name.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

