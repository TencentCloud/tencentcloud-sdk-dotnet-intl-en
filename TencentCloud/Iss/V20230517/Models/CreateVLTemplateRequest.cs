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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVLTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>AI model</p><p>Enumeration values:</p><ul><li>ivc-vl-1.0: View large model</li></ul>
        /// </summary>
        [JsonProperty("AIModel")]
        public string AIModel{ get; set; }

        /// <summary>
        /// <p>Template name. Supports only Chinese, English, digits, _, and -, with a maximum length of 32 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Prompt content, maximum 2MB</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Analysis mode</p><p>Enumeration values:</p><ul><li>image: image mode</li><li>video: video mode</li></ul>
        /// </summary>
        [JsonProperty("AnalysisMode")]
        public string AnalysisMode{ get; set; }

        /// <summary>
        /// <p>List of effective periods, up to 100 entries</p>
        /// </summary>
        [JsonProperty("Times")]
        public EffectiveTime[] Times{ get; set; }

        /// <summary>
        /// <p>Template description. Maximum length: 256 characters.</p>
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// <p>Image scenario configuration (required when AnalysisMode=image)</p>
        /// </summary>
        [JsonProperty("ImageConfig")]
        public ImageSceneInfo ImageConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AIModel", this.AIModel);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "AnalysisMode", this.AnalysisMode);
            this.SetParamArrayObj(map, prefix + "Times.", this.Times);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamObj(map, prefix + "ImageConfig.", this.ImageConfig);
        }
    }
}

