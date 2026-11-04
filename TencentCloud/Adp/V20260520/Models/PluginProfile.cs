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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginProfile : AbstractModel
    {
        
        /// <summary>
        /// Plug-in author
        /// </summary>
        [JsonProperty("Author")]
        public string Author{ get; set; }

        /// <summary>
        /// Plugin description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Plug-in icon url
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// Plugin name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Plug-in product type</p><p>Enumeration values:</p><ul><li>0: ordinary plug-in</li><li>1: connector plug-in</li></ul>
        /// </summary>
        [JsonProperty("PluginClass")]
        public long? PluginClass{ get; set; }

        /// <summary>
        /// <p>Plugin type</p><p>Enumeration values:</p><ul><li>0: API</li><li>1: Code</li><li>2: MCP</li><li>3: Application</li></ul>
        /// </summary>
        [JsonProperty("PluginKind")]
        public long? PluginKind{ get; set; }

        /// <summary>
        /// <p>Plug-in source</p><p>Enumeration values:</p><ul><li>0: custom plugin</li><li>1: official plug-in</li><li>2: third-party plugin</li></ul>
        /// </summary>
        [JsonProperty("PluginSource")]
        public long? PluginSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Author", this.Author);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PluginClass", this.PluginClass);
            this.SetParamSimple(map, prefix + "PluginKind", this.PluginKind);
            this.SetParamSimple(map, prefix + "PluginSource", this.PluginSource);
        }
    }
}

