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

    public class ClawAgentConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Agent Team Collaboration Configuration</p>
        /// </summary>
        [JsonProperty("AgentTeamConfig")]
        public ClawAgentAgentTeamConfig AgentTeamConfig{ get; set; }

        /// <summary>
        /// <p>Long-term memory configuration</p>
        /// </summary>
        [JsonProperty("LongMemoryConfig")]
        public ClawAgentLongMemoryConfig LongMemoryConfig{ get; set; }

        /// <summary>
        /// <p>Channel context timeout configuration clearing</p>
        /// </summary>
        [JsonProperty("ChannelContextTimeoutConfig")]
        public ClawAgentChannelContextTimeoutConfig ChannelContextTimeoutConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AgentTeamConfig.", this.AgentTeamConfig);
            this.SetParamObj(map, prefix + "LongMemoryConfig.", this.LongMemoryConfig);
            this.SetParamObj(map, prefix + "ChannelContextTimeoutConfig.", this.ChannelContextTimeoutConfig);
        }
    }
}

