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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceSlowlogDetail : AbstractModel
    {
        
        /// <summary>
        /// Slow log duration
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Client address
        /// </summary>
        [JsonProperty("Client")]
        public string Client{ get; set; }

        /// <summary>
        /// Command
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// Command line details
        /// </summary>
        [JsonProperty("CommandLine")]
        public string CommandLine{ get; set; }

        /// <summary>
        /// Execution duration
        /// </summary>
        [JsonProperty("ExecuteTime")]
        public string ExecuteTime{ get; set; }

        /// <summary>
        /// Node ID
        /// </summary>
        [JsonProperty("Node")]
        public string Node{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Client", this.Client);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "CommandLine", this.CommandLine);
            this.SetParamSimple(map, prefix + "ExecuteTime", this.ExecuteTime);
            this.SetParamSimple(map, prefix + "Node", this.Node);
        }
    }
}

