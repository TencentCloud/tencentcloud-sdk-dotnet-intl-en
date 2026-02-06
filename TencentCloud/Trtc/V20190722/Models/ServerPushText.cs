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

    public class ServerPushText : AbstractModel
    {
        
        /// <summary>
        /// Server push broadcast text.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// Whether to allow the text to interrupt the robot's speaking.
        /// </summary>
        [JsonProperty("Interrupt")]
        public bool? Interrupt{ get; set; }

        /// <summary>
        /// Broadcast the text and automatically close the dialogue task.
        /// </summary>
        [JsonProperty("StopAfterPlay")]
        public bool? StopAfterPlay{ get; set; }

        /// <summary>
        /// Server push broadcast audio.
        /// Format description: audio must be mono, sampling rate must be consistent with the corresponding TTS sampling rate, and coded as a Base64 string.
        /// Input rule: when the Audio field is provided, the system will not accept user-submitted input in the Text field. the system will play the Audio content in the Audio field directly.
        /// </summary>
        [JsonProperty("Audio")]
        public string Audio{ get; set; }

        /// <summary>
        /// Defaults to 0. valid at that time only when Interrupt is false.
        /// -0 means drop messages with Interrupt set to false during the occurrence of interaction.
        /// -1 indicates that during the occurrence of an interaction, messages with Interrupt as false will not be dropped but cached, waiting to be processed when finished.
        /// 
        /// Note: if DropMode is 1, multiple messages can be cached. if an interruption occurs subsequently, the cache of messages will be cleared.
        /// </summary>
        [JsonProperty("DropMode")]
        public ulong? DropMode{ get; set; }

        /// <summary>
        /// The message priority of ServerPushText. 0 means interruptible, 1 means not interruptible. currently only support 0. if you need to input 1, submit a ticket to contact us to grant permission.
        /// Note: after receiving a message with Priority=1, any other messages will be ignored (including messages with Priority=1) until the message processing of Priority=1 is complete. this field can be used together with the Interrupt and DropMode fields.
        /// Example:.
        /// -Priority=1, Interrupt=true, interrupts existing interaction and broadcasts immediately. the broadcast will not be interrupted during the process.
        /// -Priority=1, Interrupt=false, DropMode=1. wait for the current interaction to complete before broadcasting. the broadcast will not be interrupted during the process.
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// Whether to add the text to the llm history context.
        /// </summary>
        [JsonProperty("AddHistory")]
        public bool? AddHistory{ get; set; }

        /// <summary>
        /// If filled, it will be bound to the subtitle and sent to the terminal. note that the content must be a json string.
        /// </summary>
        [JsonProperty("MetaInfo")]
        public string MetaInfo{ get; set; }


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
            this.SetParamSimple(map, prefix + "MetaInfo", this.MetaInfo);
        }
    }
}

