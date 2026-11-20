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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VoiceConversationLLMConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>LLM API type, for example, openai (OpenAI-compatible API).</p>
        /// </summary>
        [JsonProperty("LLMType")]
        public string LLMType{ get; set; }

        /// <summary>
        /// <p>Model name, for example, gpt-4o-mini</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>OpenAI-compatible endpoint.</p>
        /// </summary>
        [JsonProperty("APIUrl")]
        public string APIUrl{ get; set; }

        /// <summary>
        /// Provider API key.
        /// </summary>
        [JsonProperty("APIKey")]
        public string APIKey{ get; set; }

        /// <summary>
        /// <p>System prompt.</p>
        /// </summary>
        [JsonProperty("SystemPrompt")]
        public string SystemPrompt{ get; set; }

        /// <summary>
        /// <p>Text used to generate TTS audio when the LLM call fails.</p>
        /// </summary>
        [JsonProperty("FailureMessage")]
        public string FailureMessage{ get; set; }

        /// <summary>
        /// <p>Maximum number of tokens in a single response. 0 means no limit. Default: 0. If the model outputs more tokens than MaxTokens, the response is truncated.</p>
        /// </summary>
        [JsonProperty("MaxTokens")]
        public ulong? MaxTokens{ get; set; }

        /// <summary>
        /// <p>Whether to enable thinking mode. Availability depends on the model provider. Enabling thinking mode consumes output tokens.</p>
        /// </summary>
        [JsonProperty("ThinkingMode")]
        public bool? ThinkingMode{ get; set; }

        /// <summary>
        /// <p>Number of conversation turns cached for the LLM. Valid range: 0 to 50. Recommended range: 10 to 30. The total number of tokens in this context must not exceed the LLM context limit.</p>
        /// </summary>
        [JsonProperty("MaxHistory")]
        public ulong? MaxHistory{ get; set; }

        /// <summary>
        /// <p>Maximum rounds of MCP tool calls, ranging from 0 to 50. Default: 10.</p>
        /// </summary>
        [JsonProperty("MaxToolRound")]
        public ulong? MaxToolRound{ get; set; }

        /// <summary>
        /// Timeout for a single request, in milliseconds. Valid range: 1000 to 60000. Default: 10000.
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>Sampling temperature, ranging from 0.0 to 2.0. Default: 1.0.</p>
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// <p>Top p nucleus sampling. Valid range: 0.0 to 1.0. Default: 1.0.</p>
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// <p>MCP Server parameters.</p>
        /// </summary>
        [JsonProperty("McpServer")]
        public VoiceConversationMcpServer McpServer{ get; set; }

        /// <summary>
        /// <p>Custom HTTP request headers.</p>
        /// </summary>
        [JsonProperty("CustomHeaders")]
        public KeyValueItem[] CustomHeaders{ get; set; }

        /// <summary>
        /// Provider-specific parameters, such as DeepSeek's reasoning_effort and Hunyuan's enable_enhancement.
        /// </summary>
        [JsonProperty("CustomFields")]
        public KeyValueItem[] CustomFields{ get; set; }

        /// <summary>
        /// <p>Initial conversation history. Each item uses this format: `{"Role": "user"/"assistant"/"system", "Content": "xxx"}`.</p>
        /// </summary>
        [JsonProperty("HistoryMessages")]
        public VoiceConversationHistoryMessage[] HistoryMessages{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LLMType", this.LLMType);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "APIUrl", this.APIUrl);
            this.SetParamSimple(map, prefix + "APIKey", this.APIKey);
            this.SetParamSimple(map, prefix + "SystemPrompt", this.SystemPrompt);
            this.SetParamSimple(map, prefix + "FailureMessage", this.FailureMessage);
            this.SetParamSimple(map, prefix + "MaxTokens", this.MaxTokens);
            this.SetParamSimple(map, prefix + "ThinkingMode", this.ThinkingMode);
            this.SetParamSimple(map, prefix + "MaxHistory", this.MaxHistory);
            this.SetParamSimple(map, prefix + "MaxToolRound", this.MaxToolRound);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamObj(map, prefix + "McpServer.", this.McpServer);
            this.SetParamArrayObj(map, prefix + "CustomHeaders.", this.CustomHeaders);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArrayObj(map, prefix + "HistoryMessages.", this.HistoryMessages);
        }
    }
}

