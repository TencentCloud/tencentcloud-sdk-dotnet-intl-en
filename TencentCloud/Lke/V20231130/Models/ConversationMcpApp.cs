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

    public class ConversationMcpApp : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ResourceUri")]
        public string ResourceUri{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ThreadId")]
        public string ThreadId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ToolResult")]
        public string ToolResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamSimple(map, prefix + "ResourceUri", this.ResourceUri);
            this.SetParamSimple(map, prefix + "ThreadId", this.ThreadId);
            this.SetParamSimple(map, prefix + "ToolResult", this.ToolResult);
        }
    }
}

