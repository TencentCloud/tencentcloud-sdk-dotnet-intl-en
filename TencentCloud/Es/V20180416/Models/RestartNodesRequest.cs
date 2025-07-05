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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestartNodesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Node name list
        /// </summary>
        [JsonProperty("NodeNames")]
        public string[] NodeNames{ get; set; }

        /// <summary>
        /// Whether to force restart
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }

        /// <summary>
        /// The restart mode. Valid values: `in-place` (default), `blue-green`.
        /// </summary>
        [JsonProperty("RestartMode")]
        public string RestartMode{ get; set; }

        /// <summary>
        /// The node status, applicable in the blue/green mode. The blue/green restart is risky if the node is offline.
        /// </summary>
        [JsonProperty("IsOffline")]
        public bool? IsOffline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "NodeNames.", this.NodeNames);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
            this.SetParamSimple(map, prefix + "RestartMode", this.RestartMode);
            this.SetParamSimple(map, prefix + "IsOffline", this.IsOffline);
        }
    }
}

