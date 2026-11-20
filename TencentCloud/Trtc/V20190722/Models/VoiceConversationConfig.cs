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

    public class VoiceConversationConfig : AbstractModel
    {
        
        /// <summary>
        /// [UserId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#userid) used by the conversation service in the TRTC room. It must not match a UserId already used by another TRTC user or by the conversation service. Include the room ID in the UserId.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// [UserSig](https://www.tencentcloud.com/document/product/647/45910?from_cn_redirect=1#UserSig) for the conversation service to join the TRTC room. It is the authentication signature of this UserId and works like a login password. For how to calculate UserSig, see the linked topic.
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// <p>UserId of the anchor whose audio the conversation service subscribes to. Specify one anchor only.</p>
        /// </summary>
        [JsonProperty("TargetUserId")]
        public string[] TargetUserId{ get; set; }

        /// <summary>
        /// <p>Parameters of the bot that publishes TTS audio back to the room.</p>
        /// </summary>
        [JsonProperty("TTSPushRoomParams")]
        public TranscriptionUserInfoParams TTSPushRoomParams{ get; set; }

        /// <summary>
        /// <p>If an anchor in the conversation stays out of the TRTC room, or stays in the audience role, for longer than `MaxIdleTime`, the conversation task stops automatically. Valid range: 5 to 86400 (24 hours). Default: 30. Unit: seconds.</p>
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// Filters content returned by the LLM. Text inside the specified brackets is not played. If this parameter is not set, nothing is filtered. Valid range: 1 to 5. Example: 1. 
        /// Not supported in S2S mode.
        /// Valid values:
        /// - 1: Chinese parentheses 
        /// - 2: English parentheses
        /// - 3: Chinese square brackets
        /// - 4: English square brackets
        /// - 5: English curly braces
        /// </summary>
        [JsonProperty("FilterBracketsContent")]
        public ulong?[] FilterBracketsContent{ get; set; }

        /// <summary>
        /// Subtitle display mode. Not supported in S2S mode.
        /// Valid values:
        /// - 0: Show subtitles as soon as possible.
        /// - 1: Show subtitles sentence by sentence in real time.
        /// </summary>
        [JsonProperty("SubtitleMode")]
        public ulong? SubtitleMode{ get; set; }

        /// <summary>
        /// Controls how a new conversation turn starts. Default: `auto`. Not supported in S2S mode.
        /// Valid values:
        /// 
        /// - `auto`: The backend detects the end of a sentence from the silence duration, and then calls the LLM.
        /// </summary>
        [JsonProperty("TurnDetectionMode")]
        public string TurnDetectionMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamArraySimple(map, prefix + "TargetUserId.", this.TargetUserId);
            this.SetParamObj(map, prefix + "TTSPushRoomParams.", this.TTSPushRoomParams);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamArraySimple(map, prefix + "FilterBracketsContent.", this.FilterBracketsContent);
            this.SetParamSimple(map, prefix + "SubtitleMode", this.SubtitleMode);
            this.SetParamSimple(map, prefix + "TurnDetectionMode", this.TurnDetectionMode);
        }
    }
}

