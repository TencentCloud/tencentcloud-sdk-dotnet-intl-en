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
        /// 
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LastImageUrl")]
        public string LastImageUrl{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcVideoReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcVideoReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AudioInfos")]
        public AigcVideoReferenceAudioInfo[] AudioInfos{ get; set; }

        /// <summary>
        /// <p>Entity information.</p>
        /// </summary>
        [JsonProperty("SubjectInfos")]
        public AigcVideoReferenceSubjectInfo[] SubjectInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcVideoExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

        /// <summary>
        /// 
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
            this.SetParamArrayObj(map, prefix + "AudioInfos.", this.AudioInfos);
            this.SetParamArrayObj(map, prefix + "SubjectInfos.", this.SubjectInfos);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

