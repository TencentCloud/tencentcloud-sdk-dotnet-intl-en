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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KnowledgeQaPlugin : AbstractModel
    {
        
        /// <summary>
        /// Plugin ID.
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// Plugin name.
        /// </summary>
        [JsonProperty("PluginName")]
        public string PluginName{ get; set; }

        /// <summary>
        /// Plugin icon.
        /// </summary>
        [JsonProperty("PluginIcon")]
        public string PluginIcon{ get; set; }

        /// <summary>
        /// Tool ID.
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }

        /// <summary>
        /// Tool name.
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// Tool description.
        /// </summary>
        [JsonProperty("ToolDesc")]
        public string ToolDesc{ get; set; }

        /// <summary>
        /// Tool input parameter.
        /// </summary>
        [JsonProperty("Inputs")]
        public PluginToolReqParam[] Inputs{ get; set; }

        /// <summary>
        /// Whether the plugin is bound to the knowledge library.
        /// </summary>
        [JsonProperty("IsBindingKnowledge")]
        public bool? IsBindingKnowledge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "PluginName", this.PluginName);
            this.SetParamSimple(map, prefix + "PluginIcon", this.PluginIcon);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "ToolDesc", this.ToolDesc);
            this.SetParamArrayObj(map, prefix + "Inputs.", this.Inputs);
            this.SetParamSimple(map, prefix + "IsBindingKnowledge", this.IsBindingKnowledge);
        }
    }
}

