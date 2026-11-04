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

    public class ConversationExperience : AbstractModel
    {
        
        /// <summary>
        /// <p>AI Call Configuration</p>
        /// </summary>
        [JsonProperty("AiCall")]
        public AICallConfig AiCall{ get; set; }

        /// <summary>
        /// <p>Background image configuration</p>
        /// </summary>
        [JsonProperty("BackgroundImage")]
        public BackgroundImage BackgroundImage{ get; set; }

        /// <summary>
        /// <p>Fallback response switch</p>
        /// </summary>
        [JsonProperty("EnableFallbackReply")]
        public bool? EnableFallbackReply{ get; set; }

        /// <summary>
        /// <p>Whether to use recommended questions.</p>
        /// </summary>
        [JsonProperty("EnableRecommended")]
        public bool? EnableRecommended{ get; set; }

        /// <summary>
        /// <p>Whether to use online search.</p>
        /// </summary>
        [JsonProperty("EnableWebSearch")]
        public bool? EnableWebSearch{ get; set; }

        /// <summary>
        /// <p>Fallback response</p>
        /// </summary>
        [JsonProperty("FallbackReply")]
        public string FallbackReply{ get; set; }

        /// <summary>
        /// <p>Input box configuration</p>
        /// </summary>
        [JsonProperty("InputBoxConfig")]
        public InputBoxConfig InputBoxConfig{ get; set; }

        /// <summary>
        /// <p>Output method. Enumeration values: 1: streaming, 2: non-streaming</p>
        /// </summary>
        [JsonProperty("Method")]
        public long? Method{ get; set; }

        /// <summary>
        /// <p>Recommended question generation prompt mode. Enumeration value: 1: Prompt that outputs recommended questions combined with the knowledge base only</p>
        /// </summary>
        [JsonProperty("RecommendPromptMode")]
        public long? RecommendPromptMode{ get; set; }

        /// <summary>
        /// <p>A new message interrupts the ongoing message</p>
        /// </summary>
        [JsonProperty("EnableNewMessageInterrupt")]
        public bool? EnableNewMessageInterrupt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AiCall.", this.AiCall);
            this.SetParamObj(map, prefix + "BackgroundImage.", this.BackgroundImage);
            this.SetParamSimple(map, prefix + "EnableFallbackReply", this.EnableFallbackReply);
            this.SetParamSimple(map, prefix + "EnableRecommended", this.EnableRecommended);
            this.SetParamSimple(map, prefix + "EnableWebSearch", this.EnableWebSearch);
            this.SetParamSimple(map, prefix + "FallbackReply", this.FallbackReply);
            this.SetParamObj(map, prefix + "InputBoxConfig.", this.InputBoxConfig);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "RecommendPromptMode", this.RecommendPromptMode);
            this.SetParamSimple(map, prefix + "EnableNewMessageInterrupt", this.EnableNewMessageInterrupt);
        }
    }
}

