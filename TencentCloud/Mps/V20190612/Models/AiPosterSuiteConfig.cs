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

    public class AiPosterSuiteConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Image output mode.</p><p>Enumeration values:</p><ul><li>auto: fully automatic mode. CustomVariables can be passed in this mode.</li><li>modify: modification mode. The corresponding description needs to be provided in the AddOnParameter.ExtPrompt field in this mode. CustomVariables cannot be passed in this mode.</li></ul><p>Default value: auto.</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>Ecommerce platform visual template ID.</p><p>If you need a personalized visual template, submit a ticket.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>Sub-image configuration.</p>
        /// </summary>
        [JsonProperty("Recipe")]
        public RecipeItem[] Recipe{ get; set; }

        /// <summary>
        /// <p>Sub-image text language.</p><p>Enumeration values:</p><ul><li>zh-CN: Simplified Chinese.</li><li>en-US: American English.</li></ul><p>Default value: zh-CN.</p><p>If you need more languages, submit a ticket.</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>Sub-image aspect ratio.</p><p>Enumeration values:</p><ul><li>1:1: 1:1.</li><li>3:4: 3:4.</li><li>4:3: 4:3.</li><li>9:16: 9:16.</li><li>16:9: 16:9.</li></ul><p>Default value: 1:1.</p>
        /// </summary>
        [JsonProperty("PanelRatio")]
        public string PanelRatio{ get; set; }

        /// <summary>
        /// <p>Sub-image resolution.</p><p>Enumeration values:</p><ul><li>720: 720.</li><li>1K: 1K.</li><li>2K: 2K.</li><li>4K: 4K.</li></ul><p>Default value: 1K.</p>
        /// </summary>
        [JsonProperty("PanelResolution")]
        public string PanelResolution{ get; set; }

        /// <summary>
        /// <p>User-defined variable.</p>
        /// </summary>
        [JsonProperty("CustomVariables")]
        public CustomVariable[] CustomVariables{ get; set; }

        /// <summary>
        /// <p>Model name.</p><p>Enumeration value:</p><ul><li>WAND-suite-1.0-flash: WAND-suite-1.0-flash.</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArrayObj(map, prefix + "Recipe.", this.Recipe);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "PanelRatio", this.PanelRatio);
            this.SetParamSimple(map, prefix + "PanelResolution", this.PanelResolution);
            this.SetParamArrayObj(map, prefix + "CustomVariables.", this.CustomVariables);
            this.SetParamSimple(map, prefix + "Model", this.Model);
        }
    }
}

