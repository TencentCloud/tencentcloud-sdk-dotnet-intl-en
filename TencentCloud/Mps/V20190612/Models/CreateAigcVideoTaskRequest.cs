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

    public class CreateAigcVideoTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Model name.<br>Supported models:<br>Hunyuan.<br>Hailuo.<br>Kling.<br>Vidu.<br>OS.<br>GV.</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Specific version number of the model. By default, the system uses the supported stable version of the model.</p><ol><li>Hailuo: [02 and 2.3].</li><li>Kling: [2.0, 2.1, 2.5, O1, 2.6, 3.0, and 3.0-Omni].</li><li>Vidu: [q2, q2-pro, q2-turbo, q3-pro, and q3-turbo].</li><li>GV: [3.1].</li><li>OS: [2.0].</li></ol>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Scenario for the generated video.<br>Note: Not all models support scenarios.</p><ol><li>Kling supports motion control (motion_control).</li><li>Mingmou supports landscape-to-portrait conversion (land2port).</li><li>Vidu supports special effect templates (template_effect).</li></ol>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>Description of the generated video. (Note: A maximum of 2000 characters is supported.) This parameter is required when no reference image is specified.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Specifies the content you want to prevent the model from generating.<br>Note: Not all models support this.<br>For example:<br>Top lighting and bright colors.<br>People and animals.<br>Multiple vehicles and wind.</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>The default value is False, meaning the model follows instructions strictly. For better results with more nuanced prompts, set this parameter to True to automatically optimize the input prompt and improve generation quality.</p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>Image URL for video generation. The URL must be accessible from the public network.<br>Note:</p><ol><li>The recommended image size is no more than 10 MB. Different models have different size limits.</li><li>Supported image formats: JPEG and PNG.</li><li>If the OS model is used, the input image dimension should be 1280x720 or 720x1280.</li></ol>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>The model will generate a video using the image of this parameter as the ending frame.<br>Models that support this parameter:</p><ol><li>GV. If the ending frame image is specified, ImageUrl is required as the starting frame.</li><li>Kling. Version 2.1 supports starting and ending frames with a resolution of 1080P.</li><li>Vidu. q2-pro and q2-turbo support starting and ending frames.</li></ol><p>Note:</p><ol><li>The recommended image size is no more than 10 MB. Different models have different limits.</li><li>Supported image formats: JPEG and PNG.</li></ol>
        /// </summary>
        [JsonProperty("LastImageUrl")]
        public string LastImageUrl{ get; set; }

        /// <summary>
        /// <p>List of up to 3 asset images, used to describe the images the model should use for video generation.</p><p>Model that supports multiple images:</p><ol><li>GV. If multiple images are specified, ImageUrl and LastImageUrl are unavailable.</li><li>Vidu supports video generation with multiple reference images. The q2 model accepts 1 to 7 images. The ReferenceType in ImageInfos can be used to specify the subject ID for the input.</li></ol><p>Note:</p><ol><li>The image size cannot exceed 10 MB.</li><li>Supported image formats: JPEG and PNG.</li></ol>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcVideoReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>Only Kling O1 supports reference video information.<br>This can be used as a feature reference video or a video for editing. The default type is video for editing. You can choose to keep the original sound of the video.</p>
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcVideoReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// <p>Duration of the generated video.<br>Note:</p><ol><li>Kling supports 5 and 10 seconds. Default value: 5 seconds.</li><li>The std mode of Hailuo supports 6 and 10 seconds, and other modes support 6 seconds. Default value: 6 seconds.</li><li>Vidu supports 1 to 10 seconds.</li><li>GV supports 8 seconds. Default value: 8 seconds.</li><li>OS supports 4, 8, and 12 seconds. Default value: 8 seconds.</li></ol>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>Additional parameters required.</p>
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcVideoExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// <p>COS bucket information for the file result. Note: COS is required and the MPS_QcsRole role needs to be created and authorized.</p>
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// <p>Special scenario parameters required by the model, formatted as a JSON serialized string.<br>Example:<br>{"camera_control":{"type":"simple"}}.</p>
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

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
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "LastImageUrl", this.LastImageUrl);
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamArrayObj(map, prefix + "VideoInfos.", this.VideoInfos);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

