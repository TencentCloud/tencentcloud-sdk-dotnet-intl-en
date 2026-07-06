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
        /// <p>Model name.<br>Supported models:<br>Hunyuan.<br>Hailuo.<br>Kling.<br>Vidu.<br>PixVerse.<br>Mingmou.<br>H2.</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Specific version number of the model. By default, the system uses the supported stable version of the model.</p><ol><li>Hunyuan: [1.5].</li><li>Hailuo: [02, 2.3, and 2.3-fast].</li><li>Kling: [1.6, 2.0, 2.1, 2.5, O1, 2.6, 3.0, and 3.0-Omni].</li><li>Vidu: [q2, q2-pro, q2-turbo, q3-pro, q3-turbo, q3, and q3-mix].</li><li>PixVerse: [v5.6, v6, and c1].</li><li>H2: [1.0].</li></ol>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Scenario for the generated video.<br>Note: Not all models support scenarios.</p><ol><li>Kling supports: motion control (motion_control), digital human (avatar_i2v), and lip sync (lip_sync).</li><li>Mingmou supports: landscape-to-portrait conversion (land2port).</li><li>Vidu supports: effect templates (template_effect).</li><li>Hunyuan supports: 3D world model (3d_scene). The returned file is not a video.</li></ol>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>Description of the generated video. This parameter is required when no image is specified.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Specifies the content you want to prevent the model from generating.<br>Note: Not all models support this.<br>For example:<br>Top lighting and bright colors.<br>People and animals.<br>Multiple vehicles and wind.</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>The default value is False, meaning the model follows instructions strictly.<br>For better results with more nuanced prompts, set this parameter to True to automatically optimize the input prompt and improve generation quality.</p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>Image URL used for video generation. The URL must be accessible from the public network.<br>Note:</p><ol><li>The recommended image size is no more than 10 MB. Different models have different size limits. See the model website for a more complete description.</li><li>Supported image formats: JPEG and PNG.</li></ol>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>The model will generate a video using the image of this parameter as the ending frame.<br>Models that support this parameter:</p><ol><li>Kling 2.0, O1, 3.0, and 3.0-Omni support starting and ending frames.</li><li>Kling 1.6, 2.1, 2.5, and 2.6 support starting and ending frames with Resolution:1080p.</li><li>Vidu q2-pro, q2-turbo, q3-pro, and q3-turbo support starting and ending frames.</li><li>PixVerse v5.6, v6, and c1 support starting and ending frames.</li><li>Hailuo 02 supports starting and ending frames.</li></ol><p>Note:</p><ol><li>The recommended image size is no more than 10 MB. Different models have different limits.</li><li>Supported image formats: JPEG and PNG.</li></ol>
        /// </summary>
        [JsonProperty("LastImageUrl")]
        public string LastImageUrl{ get; set; }

        /// <summary>
        /// <p>List of multiple asset resource images used to describe the resource images used by the model for video generation.</p><p>Models that support multiple images:</p><ol><li>Vidu q2, q2-pro, q3-turbo, q3, and q3-mix support video generation with multiple reference images. One to 7 images can be uploaded. The ReferenceType in ImageInfos can be used to specify the subject ID for the input.</li><li>Kling O1, 3.0-Omni, and 1.6 support video generation with multiple reference images.<ol><li>Kling 1.6 allows uploading 1 to 4 images.</li><li>Kling O1 and 3.0-Omni allow uploading 1 to 7 images. If a reference video is present, 0 to 4 images can be uploaded.</li></ol></li><li>PixVerse, v5.6, v6, and c1 support video generation with multiple reference images. One to 7 images can be uploaded, and image names need to be specified via the Text field in ImageInfos.</li><li>H2 1.0 supports video generation with multiple image parameters. One to 9 images can be uploaded. If a reference video is present, 0 to 5 images can be uploaded.</li></ol><p>Note:</p><ol><li>The image size cannot exceed 10 MB.</li><li>Supported image formats: JPEG and PNG.</li></ol>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcVideoReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>Only Kling O1, Kling 3.0-Omni, Vidu q2-pro, and H2 1.0 support reference video information.</p><ol><li>For Kling O1 and 3.0-Omni, the reference video can be used as a feature reference video or a video for editing. The default type is video for editing. You can choose to keep the original sound of the video.</li><li>Vidu q2-pro supports video reference.</li><li>H2 1.0 supports video reference.</li></ol>
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcVideoReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// <p>Duration of the generated video.<br>Note:</p><ol><li>Kling: default value: 5 seconds.<ul><li>O1 supports 3 to 10 seconds.</li><li>3.0-Omni supports 3 to 15 seconds, or 3 to 10 seconds when a video reference is used.</li><li>3.0 supports 3 to 15 seconds.</li><li>Other versions support 5 and 10 seconds.</li></ul></li><li>The std mode of Hailuo supports 6 and 10 seconds, and other modes support 6 seconds. Default value: 6 seconds.</li><li>Vidu: default value: 5 seconds.<ul><li>q3-pro, q3-turbo, q3, and q3-mix support 3 to 16 seconds.</li><li>q2-pro, q2-turbo, and q2 support 1 to 10 seconds.</li></ul></li><li>PixVerse: default value: 5 seconds.<ul><li>v5.6 supports 5, 8, and 10 seconds.</li><li>v6 and c1 support 1 to 15 seconds.</li></ul></li><li>H2 supports 3 to 15 seconds. Default value: 5 seconds.</li></ol>
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
        /// <p>Special scenario parameters or storyboard prompts required by the model, formatted as a JSON serialized string.<br>Example:<br>{"camera_control":{"type":"simple"}}.</p>
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

