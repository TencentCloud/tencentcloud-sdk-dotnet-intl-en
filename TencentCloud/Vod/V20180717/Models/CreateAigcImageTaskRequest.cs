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

    public class CreateAigcImageTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Model name. valid values:.
        /// <li>GEM:Gemini;</li>
        /// <Li>Qwen: qianwen.</li>
        /// <Li>Hunyuan: hunyuan.</li>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Model version. valid values:.
        /// <li>When ModelName is GEM, optional values are 2.5, 3.0;</li>
        /// <li>When ModelName is Qwen, optional values are 0925.</li>
        /// <li>When ModelName is Hunyuan, the optional values are 3.0.</li>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// File information of the input image for the AIGC image generation task. By default only one image can be specified; when using the GEM model, version 2.5 supports up to 3 images and version 3.0 supports up to 14 images.
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcImageTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// The prompt content for image generation. this parameter is required when FileInfos is empty.
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
        /// Output media file configuration for the task.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcImageOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// An identifier for deduplication. if there has been a request with the same identifier within the past 3 days, an error will be returned for the current request. the maximum length is 50 characters. leaving it blank or using an empty string indicates no deduplication.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Source context, used to pass through user request information. the audio and video quality revival complete callback will return the value of this field. longest 1000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Task priority. the higher the value, the higher the priority. value range is from -10 to 10. if left blank, the default value is 0.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// Reserved field, used when special purpose.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

