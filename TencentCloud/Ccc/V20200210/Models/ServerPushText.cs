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

    public class ServerPushText : AbstractModel
    {
        
        /// <summary>
        /// Specifies the server push broadcast text.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// Whether to allow the text to interrupt the robot's speaking.
        /// </summary>
        [JsonProperty("Interrupt")]
        public bool? Interrupt{ get; set; }

        /// <summary>
        /// Specifies whether to automatically close the dialogue task after broadcasting the text.
        /// </summary>
        [JsonProperty("StopAfterPlay")]
        public bool? StopAfterPlay{ get; set; }

        /// <summary>
        /// Specifies the server push broadcast audio.
        /// Format description: audio must be mono, sampling rate should be consistent with the corresponding TTS, and coded as a Base64 string.
        /// Input rules: when the Audio field is provided, the system will not accept input in the Text field. the system will play the Audio content in the Audio field directly.
        /// </summary>
        [JsonProperty("Audio")]
        public string Audio{ get; set; }

        /// <summary>
        /// Defaults to 0. valid only when Interrupt is false.
        /// -0 indicates that messages with Interrupt set to false will be dropped when there is an interaction.
        /// -Indicates that when there is an interaction in progress, messages with Interrupt set to false will not be dropped but cached and processed after the current interaction is completed.
        /// 
        /// Note: when DropMode is 1, the cache allows multiple messages. if an interruption occurs subsequently, cached messages will be cleared.
        /// </summary>
        [JsonProperty("DropMode")]
        public ulong? DropMode{ get; set; }

        /// <summary>
        /// Message priority of ServerPushText. 0 means interruptible. 1 means not interruptible.
        /// Note: after receiving a message with Priority=1, any other messages will be ignored (including messages with Priority=1) until the message processing of Priority=1 is complete. this field can be used together with the Interrupt and DropMode fields.
        /// Example.
        /// -Priority=1, Interrupt=true. specifies to Interrupt existing interaction and broadcast immediately. the broadcast will not be interrupted during the process.
        /// -Priority=1, Interrupt=false, DropMode=1. waits for the current interaction to complete before broadcasting. the broadcast will not be interrupted during the process.
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// Specifies whether the text is added to the llm history context.
        /// </summary>
        [JsonProperty("AddHistory")]
        public bool? AddHistory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Interrupt", this.Interrupt);
            this.SetParamSimple(map, prefix + "StopAfterPlay", this.StopAfterPlay);
            this.SetParamSimple(map, prefix + "Audio", this.Audio);
            this.SetParamSimple(map, prefix + "DropMode", this.DropMode);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "AddHistory", this.AddHistory);
        }
    }
}

