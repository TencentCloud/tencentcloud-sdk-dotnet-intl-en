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

    public class AiCutoutConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Capability configuration switch, available values: ON: Enable; OFF: Disable. Default value: ON.</p>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>Target type: "foreground" (default) / "pattern"</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Pattern matting configuration. This parameter is valid only when Type is pattern.</p>
        /// </summary>
        [JsonProperty("PatternConfig")]
        public PatternConfig PatternConfig{ get; set; }

        /// <summary>
        /// <p>Cutout model selection, optional.</p><p>Enumeration value:</p><ul><li>auto: Automatically choose appropriate model</li><li>WAND-cutout-1.0-lite: Standard version, fastest speed</li><li>WAND-cutout-2.0-lite: Enhanced, fastest speed</li><li>WAND-cutout-2.0-flash: Enhanced, quality-speed balance</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "PatternConfig.", this.PatternConfig);
            this.SetParamSimple(map, prefix + "Model", this.Model);
        }
    }
}

