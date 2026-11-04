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

    public class AgentTool : AbstractModel
    {
        
        /// <summary>
        /// <p>Tool configuration field</p>
        /// </summary>
        [JsonProperty("Config")]
        public AgentToolBasicConfig Config{ get; set; }

        /// <summary>
        /// <p>Tool name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Tool status</p><p>Enumeration values:</p><ul><li>1: available</li><li>2: unavailable</li><li>3: invalid</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Calling method</p><p>Enumeration values:</p><ul><li>0: Non-streaming</li><li>1: Streaming</li></ul>
        /// </summary>
        [JsonProperty("StreamMode")]
        public long? StreamMode{ get; set; }

        /// <summary>
        /// <p>Tool access mode</p><p>Enumeration values:</p><ul><li>0: Not specified</li><li>1: Read-only</li><li>2: Write/Delete</li></ul>
        /// </summary>
        [JsonProperty("ToolAccessMode")]
        public long? ToolAccessMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StreamMode", this.StreamMode);
            this.SetParamSimple(map, prefix + "ToolAccessMode", this.ToolAccessMode);
        }
    }
}

