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

    public class MCPToolMeta : AbstractModel
    {
        
        /// <summary>
        /// <p>UI extended meta information of the tool, corresponding to _meta.UI in the MCP protocol, declaring the interactive UI resource (ResourceUri) associated with the tool and the caller Visibility. Returned only when the tool supports MCP Apps or declares Visibility; this field is empty for text tools. For details, see the MCPToolUIMeta structure definition.</p>
        /// </summary>
        [JsonProperty("Ui")]
        public MCPToolUIMeta Ui{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Ui.", this.Ui);
        }
    }
}

