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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatCompletionsRequest : AbstractModel
    {
        
        /// <summary>
        /// Model name.
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// Chat contextual information.
        /// Description:
        /// 1. Length: up to 40. Arranged in array from old to new by conversation time.
        /// 2. Message.Role: system, user, assistant. Optional.
        /// Among them, the system role is optional. If it exists, it must be at the beginning of the list. User and assistant need to alternate, starting with a user question and ending with a user question. Content cannot be empty. An example of the order of roles: [system (optional) user assistant user assistant user...].
        /// </summary>
        [JsonProperty("Messages")]
        public Message[] Messages{ get; set; }

        /// <summary>
        /// Whether it is streaming output.
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// Controls the randomness of the generated content. a relatively high value generates more diversified output.
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// Maximum number of generated tokens.
        /// </summary>
        [JsonProperty("MaxTokens")]
        public long? MaxTokens{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EnableSearch")]
        public bool? EnableSearch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "MaxTokens", this.MaxTokens);
            this.SetParamSimple(map, prefix + "EnableSearch", this.EnableSearch);
        }
    }
}

