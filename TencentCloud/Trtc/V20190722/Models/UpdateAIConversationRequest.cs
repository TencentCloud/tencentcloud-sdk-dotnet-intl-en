/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class UpdateAIConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// Task Unique ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// If you do not fill in the form, no update will be performed. Welcome message from the robot
        /// </summary>
        [JsonProperty("WelcomeMessage")]
        public string WelcomeMessage{ get; set; }

        /// <summary>
        /// If not filled in, no update will be performed. Intelligent interruption mode, 0 means the server automatically interrupts, 1 means the server does not interrupt, and the client sends an interrupt signal to interrupt
        /// </summary>
        [JsonProperty("InterruptMode")]
        public ulong? InterruptMode{ get; set; }

        /// <summary>
        /// If not filled in, no update will be performed. Used when InterruptMode is 0, the unit is milliseconds, and the default is 500ms. It means that the server will interrupt when it detects a voice that lasts for InterruptSpeechDuration milliseconds.
        /// </summary>
        [JsonProperty("InterruptSpeechDuration")]
        public ulong? InterruptSpeechDuration{ get; set; }

        /// <summary>
        /// If not filled in, no update will be performed. For LLM configuration, see the StartAIConversation API for details.
        /// </summary>
        [JsonProperty("LLMConfig")]
        public string LLMConfig{ get; set; }

        /// <summary>
        /// If not filled in, no update will be performed. For TTS configuration, see the StartAIConversation API for details.
        /// </summary>
        [JsonProperty("TTSConfig")]
        public string TTSConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "WelcomeMessage", this.WelcomeMessage);
            this.SetParamSimple(map, prefix + "InterruptMode", this.InterruptMode);
            this.SetParamSimple(map, prefix + "InterruptSpeechDuration", this.InterruptSpeechDuration);
            this.SetParamSimple(map, prefix + "LLMConfig", this.LLMConfig);
            this.SetParamSimple(map, prefix + "TTSConfig", this.TTSConfig);
        }
    }
}

