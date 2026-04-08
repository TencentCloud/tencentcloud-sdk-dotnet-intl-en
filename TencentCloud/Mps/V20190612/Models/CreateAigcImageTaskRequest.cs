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
        /// <p>Model name.<br>Supported models:<br>Hunyuan.<br>GEM.<br>Qwen.</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Specify the model version number. By default, the system uses the supported stable version of the model.</p><ol><li>GEM: [2.5 and 3.0].</li></ol>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Description of the generated image. (Note: Supports up to 1000 characters.) This parameter is required when no reference image is passed in.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Specifies the content you want to prevent the model from generating. Note: Not all models support this. For example: top lighting, bright colors, people, animals, multiple vehicles, and wind.</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>The default value is False, meaning the model follows instructions strictly. For better results with more nuanced prompts, set this parameter to True to automatically optimize the input prompt and improve generation quality.</p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>Used for inputting image information as a resource for reference. Default support for inputting an image.</p><p>Models supporting multi-image input:</p><ol><li>GEM, supporting up to 3 images as resource input.</li></ol><p>Note:</p><ol><li>Recommended image less than 7M. Limits vary by model.</li><li>Format support: jpeg, png, webp.</li></ol>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>Additional parameters required for the model.</p>
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcImageExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// <p>Used to input some special scene parameters required by the model, serialized into a string in Json format. Example: {"size":"2048x2048"}</p>
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

        /// <summary>
        /// <p>COS bucket information for the file result. Note: COS is required and the MPS_QcsRole role needs to be created and authorized.</p>
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// <p>API operator name.</p>
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
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

