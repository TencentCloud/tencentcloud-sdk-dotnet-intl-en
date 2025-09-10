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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AILatencyDetail : AbstractModel
    {
        
        /// <summary>
        /// Dialog ID.
        /// </summary>
        [JsonProperty("RoundId")]
        public string RoundId{ get; set; }

        /// <summary>
        /// Specifies the asr latency in milliseconds.
        /// </summary>
        [JsonProperty("ASRLatency")]
        public long? ASRLatency{ get; set; }

        /// <summary>
        /// Specifies the tts delay in milliseconds.
        /// </summary>
        [JsonProperty("TTSLatency")]
        public long? TTSLatency{ get; set; }

        /// <summary>
        /// llm latency (ms).
        /// </summary>
        [JsonProperty("LLMLatency")]
        public long? LLMLatency{ get; set; }

        /// <summary>
        /// llm first token latency (ms).
        /// </summary>
        [JsonProperty("LLMFirstTokenLatency")]
        public long? LLMFirstTokenLatency{ get; set; }

        /// <summary>
        /// End-To-End delay (ms).
        /// </summary>
        [JsonProperty("ETELatency")]
        public long? ETELatency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoundId", this.RoundId);
            this.SetParamSimple(map, prefix + "ASRLatency", this.ASRLatency);
            this.SetParamSimple(map, prefix + "TTSLatency", this.TTSLatency);
            this.SetParamSimple(map, prefix + "LLMLatency", this.LLMLatency);
            this.SetParamSimple(map, prefix + "LLMFirstTokenLatency", this.LLMFirstTokenLatency);
            this.SetParamSimple(map, prefix + "ETELatency", this.ETELatency);
        }
    }
}

