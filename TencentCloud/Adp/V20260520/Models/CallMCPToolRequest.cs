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

    public class CallMCPToolRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Capacity boundary: one request can only call the tool on this plugin</p>
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// <p>thread on the agent-exec side</p>
        /// </summary>
        [JsonProperty("ThreadId")]
        public string ThreadId{ get; set; }

        /// <summary>
        /// <p>Tool Name, used for locating the tool_id in the configured tool_list of the plugin</p>
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// <p>JSON: Original tool input parameters, passed through to the MCP Server as-is</p>
        /// </summary>
        [JsonProperty("Arguments")]
        public string Arguments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "ThreadId", this.ThreadId);
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "Arguments", this.Arguments);
        }
    }
}

