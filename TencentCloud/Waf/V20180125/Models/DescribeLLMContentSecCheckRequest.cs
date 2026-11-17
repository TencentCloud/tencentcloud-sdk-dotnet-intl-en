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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLLMContentSecCheckRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Service id. Pass the service id corresponding to the protection policy to use. The model will detect all rules under this service id.</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>Traffic type, indicating inbound or outbound traffic. 1: inbound, 2: outbound. Both inbound and outbound are required.</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>Instance id. Required.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Content to review</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>id of the question-answer conversation</p>
        /// </summary>
        [JsonProperty("ChatId")]
        public string ChatId{ get; set; }

        /// <summary>
        /// <p>id that identifies the user, used for rate limiting. If not specified, rate limiting will not take effect.</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>token usage. If not specified, the default token calculation method will be used to calculate model consumption, because this value is added in the outbound direction, that is, Type=2.</p>
        /// </summary>
        [JsonProperty("TokenUsage")]
        public ulong? TokenUsage{ get; set; }

        /// <summary>
        /// <p>Base64-encoded image data. The maximum body size is 10 MB.</p>
        /// </summary>
        [JsonProperty("ImageEncode")]
        public string ImageEncode{ get; set; }

        /// <summary>
        /// <p>Tool name in the tool_call scenario</p>
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// <p>Tool parameters in the tool_call scenario</p>
        /// </summary>
        [JsonProperty("ToolArgs")]
        public string ToolArgs{ get; set; }

        /// <summary>
        /// <p>id of the multi-turn conversation</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Request content for intent detection</p>
        /// </summary>
        [JsonProperty("IntentContent")]
        public IntentContent IntentContent{ get; set; }

        /// <summary>
        /// <p>Client source IP address, used for allowlist matching and other scenarios. Supports IPv4 and IPv6 formats.</p>
        /// </summary>
        [JsonProperty("ClientIP")]
        public string ClientIP{ get; set; }

        /// <summary>
        /// Multi-turn historical user input, arranged from oldest to newest, used only for prompt injection detection
        /// Input parameter limits: Up to 10 entries. If exceeded, only the latest 10 entries are retained. The combined length of History + Content cannot exceed 6K characters. If exceeded, the earliest History entries are discarded first.
        /// </summary>
        [JsonProperty("History")]
        public string[] History{ get; set; }

        /// <summary>
        /// List of URLs to be detected, used for malicious URL detection
        /// Input parameter limits: Up to 50 URLs. A single URL cannot exceed 2048 characters. If exceeded, it will be truncated.
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ChatId", this.ChatId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "TokenUsage", this.TokenUsage);
            this.SetParamSimple(map, prefix + "ImageEncode", this.ImageEncode);
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "ToolArgs", this.ToolArgs);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamObj(map, prefix + "IntentContent.", this.IntentContent);
            this.SetParamSimple(map, prefix + "ClientIP", this.ClientIP);
            this.SetParamArraySimple(map, prefix + "History.", this.History);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
        }
    }
}

