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

    public class Tool : AbstractModel
    {
        
        /// <summary>
        /// <p>Tool billing information</p>
        /// </summary>
        [JsonProperty("Billing")]
        public ToolBilling Billing{ get; set; }

        /// <summary>
        /// <p>Tool call count</p><p>Unit: count</p>
        /// </summary>
        [JsonProperty("CallCount")]
        public ulong? CallCount{ get; set; }

        /// <summary>
        /// <p>Tool description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Tool name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Plug-in ID</p>
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// <table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>TOOL_ACCESS_MODE_UNKNOWN</td><td>0</td><td>Not specified</td></tr><tr><td>TOOL_ACCESS_MODE_READ_ONLY</td><td>1</td><td>Read-only</td></tr><tr><td>TOOL_ACCESS_MODE_WRITE_DELETE</td><td>2</td><td>Write/Delete</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("ToolAccessMode")]
        public long? ToolAccessMode{ get; set; }

        /// <summary>
        /// <p>Tool configuration info</p>
        /// </summary>
        [JsonProperty("ToolConfig")]
        public ToolConfig ToolConfig{ get; set; }

        /// <summary>
        /// <p>Tool ID</p>
        /// </summary>
        [JsonProperty("ToolId")]
        public string ToolId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Billing.", this.Billing);
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "ToolAccessMode", this.ToolAccessMode);
            this.SetParamObj(map, prefix + "ToolConfig.", this.ToolConfig);
            this.SetParamSimple(map, prefix + "ToolId", this.ToolId);
        }
    }
}

