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

    public class DocToVideoInput : AbstractModel
    {
        
        /// <summary>
        /// <p>Document link for video generation.</p><p>Supported document types: pdf, pptx, docx, png, jpg<br>Document count limit: 3<br>Document size limit: 10MB<br>Document page limit: 100</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string[] FileUrl{ get; set; }

        /// <summary>
        /// <p>Prompt information for video generation.</p><p>Prompt length limit: 2,000 characters.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Document-to-video model name</p><p>Default value: Wand</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>Document-to-video model version number</p><p>Default value: 1.0</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>Aspect ratio of the generated video.</p><p>Enumeration values: </p><ul><li>16:9: 16:9</li><li>9:16: 9:16</li><li>1:1: 1:1</li></ul><p>Default value: 16:9</p>
        /// </summary>
        [JsonProperty("Ratio")]
        public string Ratio{ get; set; }

        /// <summary>
        /// <p>Language of the generated video.</p><p>Enumeration values: </p><ul><li>zh: Chinese</li><li>en: English</li><li>ja: Japanese</li><li>ko: Korean</li><li>ru: Russian</li><li>fr: French</li><li>es: Spanish</li><li>de: German</li></ul><p>Default value: zh</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>Video duration for reference.</p><p>This is not an exact duration; it serves as a reference for the LLM only.</p><p>Range: [15, 1200]</p><p>Unit: second</p>
        /// </summary>
        [JsonProperty("ReferenceDuration")]
        public long? ReferenceDuration{ get; set; }

        /// <summary>
        /// <p>Whether the AI dubbing feature is enabled.</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("EnableTTS")]
        public bool? EnableTTS{ get; set; }

        /// <summary>
        /// <p>Voice ID. Valid only when AI dubbing feature is enabled.</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileUrl.", this.FileUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "ReferenceDuration", this.ReferenceDuration);
            this.SetParamSimple(map, prefix + "EnableTTS", this.EnableTTS);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
        }
    }
}

