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

    public class AiDecomposeConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Capability configuration switch.</p><p>Enumeration values: </p><ul><li>ON: Enable the layer separation feature.</li><li>OFF: Disable the layer separation feature.</li></ul><p>Default value: ON</p>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>Expected number of layers.</p><p>Value range: [2, 17]</p>
        /// </summary>
        [JsonProperty("Layers")]
        public long? Layers{ get; set; }

        /// <summary>
        /// <p>Prompt content.</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>Model name.</p><p>Enumeration value:</p><ul><li>decompose-1.0-flash: 1.0 version flash model.</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Layers", this.Layers);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "Model", this.Model);
        }
    }
}

