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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MCPInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>mcp ID</p>
        /// </summary>
        [JsonProperty("MCPId")]
        public string MCPId{ get; set; }

        /// <summary>
        /// <p>MCP name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>MCP description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>MCP URL</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>Transport protocol: sse / streamable_http / stdio</p>
        /// </summary>
        [JsonProperty("Transport")]
        public string Transport{ get; set; }

        /// <summary>
        /// <p>Authentication type: none / bearer / basic / api_key</p>
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// <p>Authentication key (masked in the response)</p>
        /// </summary>
        [JsonProperty("AuthSecret")]
        public string AuthSecret{ get; set; }

        /// <summary>
        /// <p>Timeout (s)</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>Retry count</p>
        /// </summary>
        [JsonProperty("RetryCount")]
        public long? RetryCount{ get; set; }

        /// <summary>
        /// <p>Request header JSON</p>
        /// </summary>
        [JsonProperty("Headers")]
        public string Headers{ get; set; }

        /// <summary>
        /// <p>Whether to enable</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MCPId", this.MCPId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Transport", this.Transport);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "AuthSecret", this.AuthSecret);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "RetryCount", this.RetryCount);
            this.SetParamSimple(map, prefix + "Headers", this.Headers);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

