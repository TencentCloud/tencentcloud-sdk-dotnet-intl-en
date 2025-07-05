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

    public class RunNodeInfo : AbstractModel
    {
        
        /// <summary>
        /// Node type, 0: unspecified; 1: start node; 2: api node; 3: inquiry node; 4: answer node.
        /// </summary>
        [JsonProperty("NodeType")]
        public long? NodeType{ get; set; }

        /// <summary>
        /// Node ID.
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// Node name.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Requested API.
        /// </summary>
        [JsonProperty("InvokeApi")]
        public InvokeAPI InvokeApi{ get; set; }

        /// <summary>
        /// Values of all slots of the current node, key: SlotID. Return an Null even if there is no value.
        /// </summary>
        [JsonProperty("SlotValues")]
        public ValueInfo[] SlotValues{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamObj(map, prefix + "InvokeApi.", this.InvokeApi);
            this.SetParamArrayObj(map, prefix + "SlotValues.", this.SlotValues);
        }
    }
}

