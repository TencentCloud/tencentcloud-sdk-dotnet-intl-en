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
        /// Model name.
        /// Supported models:Hunyuan,
        /// Hailuo,
        /// Kling,
        /// Vidu,
        /// OS,
        /// GV.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Specific version number of the model. By default, the system uses the supported stable version of the model.1. Hailuo: [02 and 2.3].2. Kling: [2.0, 2.1, 2.5, O1, and 2.6].3. Vidu: [q2, q2-pro, and q2-turbo].4. GV: [3.1].5. OS: [2.0].
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// Scenario for the generated video.Note: Not all models support scenarios.1. Kling supports motion control (motion_control).2. Mingmou supports landscape-to-portrait conversion (land2port).3. Vidu supports special effect templates (template_effect).
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// Description of the generated video. (Note: A maximum of 2000 characters is supported.) This parameter is required when no reference image is specified.
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// Content you want to prevent the model from generating.Note: Not all models support this.For example:Top lighting and bright color.People and animals.Multiple vehicles and wind.
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// The default value is False, meaning the model follows instructions strictly. For better results with more nuanced prompts, set this parameter to True to automatically optimize the input prompt and improve generation quality.
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// Image URL for video generation. The URL must be accessible from the public network.Note:1. The recommended image size is no more than 10 MB. Different models have different size limits.2. Supported image formats: JPEG and PNG.3. If the OS model is used, the input image dimension should be 1280x720 or 720x1280.
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// The model will generate a video using the image of this parameter as the ending frame.Models that support this parameter:1. GV. If the ending frame image is specified, ImageUrl is required as the starting frame.2. Kling. Version 2.1 supports starting and ending frames with a resolution of 1080P.3. Vidu. q2-pro and q2-turbo support starting and ending frames.Note:1. The recommended image size is no more than 10 MB. Different models have different limits.2. Supported image formats: JPEG and PNG.
        /// </summary>
        [JsonProperty("LastImageUrl")]
        public string LastImageUrl{ get; set; }

        /// <summary>
        /// List of up to 3 asset images, used to describe the images the model should use for video generation.Model that supports multiple images:1. GV. If multiple images are specified, ImageUrl and LastImageUrl are unavailable.2. Vidu supports video generation with multiple reference images. The q2 model accepts 1 to 7 images. The ReferenceType in ImageInfos can be used to specify the subject ID for the input.Note:1. The image size cannot exceed 10 MB.2. Supported image formats: JPEG and PNG.
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcVideoReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// Duration of the generated video.Note:1. Kling supports 5 and 10 seconds. Default value: 5 seconds.2. The std mode of Hailuo supports 6 and 10 seconds, and other modes support 6 seconds. Default value: 6 seconds.3. Vidu supports 1 to 10 seconds.4. GV supports 8 seconds. Default value: 8 seconds.5. OS supports 4, 8, and 12 seconds. Default value: 8 seconds.
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Additional parameters required.
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcVideoExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// COS bucket information for the file result. Note: COS is required and the MPS_QcsRole role needs to be created and authorized.
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// Special scenario parameters required by the model, formatted as a JSON serialized string.Example:{\"camera_control\":{\"type\":\"simple\"}}
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

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
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "LastImageUrl", this.LastImageUrl);
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

