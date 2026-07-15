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
        /// <p>Model name.<br>Supported models:<br>Hunyuan.<br>Qwen.<br>Vidu.<br>Kling.<br>MJ.</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Specific version number of the model. By default, the system uses the supported stable version of the model.</p><ol><li>Hunyuan: [3.0].</li><li>Vidu: [q2].</li><li>Kling: [2.1, O1, 3.0, and 3.0-Omni].</li><li>Qwen: [0925].</li><li>MJ: [v7].</li></ol>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Used for scene-based image generation; only supported by some models.</p><p>Enumeration value:</p><ul><li>3d_panorama: panoramic view. Only Hunyuan supports this.</li></ul>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>Description of the generated image. This parameter is required when no reference image is specified.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Specifies the content you want to prevent the model from generating. Note: Not all models support this.</p><p>For example: top lighting, bright colors, people, animals, multiple vehicles, and wind.</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>The default value is False, meaning the model follows instructions strictly.<br>For better results with more nuanced prompts, set this parameter to True to automatically optimize the input prompt and improve generation quality.</p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>Reference resource images. By default, one image can be specified.</p><p>Models supporting multiple images:</p><ol><li>Kling 2.1 supports up to 4 images as resource image input.</li><li>Kling 3.0-Omni supports up to 10 images as resource image input.</li><li>Kling O1 supports up to 10 images as resource image input.</li><li>Vidu q2 supports up to 7 images as resource image input.</li><li>Hunyuan 3.0 supports up to 3 images as resource image input.</li><li>MJ v7 supports up to 3 images as resource image input.</li></ol><p>Note:</p><ol><li>The recommended image size is less than 7 MB. Different models have different limits.</li><li>Supported image formats: JPEG, PNG, and WebP.</li></ol>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>Specifies the number of output images. One image is supported by default.</p>
        /// </summary>
        [JsonProperty("OutputImageCount")]
        public long? OutputImageCount{ get; set; }

        /// <summary>
        /// <p>Additional parameters required for the model.</p>
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcImageExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// <p>Special scenario parameters required by the model, formatted as a JSON serialized string.</p><ol><li>Hunyuan 3.0 supports freely setting resolution width and height within [512, 2048] pixels, with the product of width and height less than or equal to 1024x1024 pixels.</li><li>Qwen 0925 supports freely setting resolution width and height, with a valid total pixel range of [512x512=261632, 2048x2048=4194304].</li></ol><p>Example: {"size":"1024x1024"}.</p>
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
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamSimple(map, prefix + "OutputImageCount", this.OutputImageCount);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

