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

    public class MCPPluginConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>MCP plug-in public access address</p>
        /// </summary>
        [JsonProperty("ExternalMCPServerUrl")]
        public string ExternalMCPServerUrl{ get; set; }

        /// <summary>
        /// <p>MCP server address</p>
        /// </summary>
        [JsonProperty("MCPServerUrl")]
        public string MCPServerUrl{ get; set; }

        /// <summary>
        /// <p>MCP transmission type: SSE/Streamable<br>Enumeration values:<br>| uint | Description |<br>| --- | --- |<br>| 0 | SSE + HTTP mode |<br>| 1 | Streamable HTTP mode |</p>
        /// </summary>
        [JsonProperty("MCPTransport")]
        public long? MCPTransport{ get; set; }

        /// <summary>
        /// <p>header parameters of the MCP plug-in</p>
        /// </summary>
        [JsonProperty("PluginHeader")]
        public PluginParam[] PluginHeader{ get; set; }

        /// <summary>
        /// <p>query parameter of the MCP plug-in</p>
        /// </summary>
        [JsonProperty("PluginQuery")]
        public PluginParam[] PluginQuery{ get; set; }

        /// <summary>
        /// <p>SSE persistent connection timeout period, in seconds</p>
        /// </summary>
        [JsonProperty("SSEReadTimeout")]
        public long? SSEReadTimeout{ get; set; }

        /// <summary>
        /// <p>Request timeout period, in seconds</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>Authorization information.</p>
        /// </summary>
        [JsonProperty("AuthConfig")]
        public AuthConfig AuthConfig{ get; set; }

        /// <summary>
        /// <p>Whether the interactive interface (MCP Apps) and plug-in-level tags are supported. Default false</p>
        /// </summary>
        [JsonProperty("SupportsApps")]
        public bool? SupportsApps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExternalMCPServerUrl", this.ExternalMCPServerUrl);
            this.SetParamSimple(map, prefix + "MCPServerUrl", this.MCPServerUrl);
            this.SetParamSimple(map, prefix + "MCPTransport", this.MCPTransport);
            this.SetParamArrayObj(map, prefix + "PluginHeader.", this.PluginHeader);
            this.SetParamArrayObj(map, prefix + "PluginQuery.", this.PluginQuery);
            this.SetParamSimple(map, prefix + "SSEReadTimeout", this.SSEReadTimeout);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamObj(map, prefix + "AuthConfig.", this.AuthConfig);
            this.SetParamSimple(map, prefix + "SupportsApps", this.SupportsApps);
        }
    }
}

