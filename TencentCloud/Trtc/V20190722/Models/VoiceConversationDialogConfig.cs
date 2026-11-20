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

    public class VoiceConversationDialogConfig : AbstractModel
    {
        
        /// <summary>
        /// Interrupt mode. Default: 0.
        /// Valid values:
        /// - 0: Automatic. When STT returns text, it interrupts TTS playback. Use this mode with InterruptSpeechDuration.
        /// - 1: Manual. The bot is interrupted only by the Interrupt command from the server or client API.
        /// - 2: Keyword.
        /// </summary>
        [JsonProperty("InterruptMode")]
        public ulong? InterruptMode{ get; set; }

        /// <summary>
        /// Minimum duration of user speech that triggers an automatic interrupt. Default: 200. Unit: ms.
        /// </summary>
        [JsonProperty("InterruptSpeechDuration")]
        public ulong? InterruptSpeechDuration{ get; set; }

        /// <summary>
        /// Preset keywords that interrupt the bot. Use them when the user must explicitly indicate the intent to interrupt. You can set up to 128 keywords. Applies only when `InterruptMode` is 2.
        /// </summary>
        [JsonProperty("InterruptKeywords")]
        public string[] InterruptKeywords{ get; set; }

        /// <summary>
        /// How long the user is silent before the bot asks a follow-up question. Valid range: 0 to 300. 0 turns this off. Default: 0. Unit: seconds.
        /// 
        /// </summary>
        [JsonProperty("SilenceFollowUp")]
        public ulong? SilenceFollowUp{ get; set; }

        /// <summary>
        /// <p>Text of the proactive follow-up question.</p>
        /// </summary>
        [JsonProperty("SilenceFollowUpText")]
        public string SilenceFollowUpText{ get; set; }

        /// <summary>
        /// Welcome message the bot broadcasts when an anchor enters the room for the first time. It is broadcast again when the anchor leaves the room and enters again.
        /// </summary>
        [JsonProperty("WelcomeMessage")]
        public string WelcomeMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InterruptMode", this.InterruptMode);
            this.SetParamSimple(map, prefix + "InterruptSpeechDuration", this.InterruptSpeechDuration);
            this.SetParamArraySimple(map, prefix + "InterruptKeywords.", this.InterruptKeywords);
            this.SetParamSimple(map, prefix + "SilenceFollowUp", this.SilenceFollowUp);
            this.SetParamSimple(map, prefix + "SilenceFollowUpText", this.SilenceFollowUpText);
            this.SetParamSimple(map, prefix + "WelcomeMessage", this.WelcomeMessage);
        }
    }
}

