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

    public class CreateVoiceConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// The TRTC [SdkAppId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#sdkappid). It must be the same SdkAppId as the conversation room.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// [Room ID](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#roomid) of the TRTC room where the conversation runs. Room IDs are numeric by default. If the room ID is a string, set RoomIdType to 1.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// Room ID type. It must match the room ID type of the conversation room. 0 is a numeric room ID, and 1 is a string room ID.
        /// Valid values:
        /// - 0: numeric room ID (Default)
        /// - 1: string room ID
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// <p>Chatbot configuration.</p>
        /// </summary>
        [JsonProperty("AgentConfig")]
        public VoiceConversationConfig AgentConfig{ get; set; }

        /// <summary>
        /// Conversation pipeline mode: `Cascade` (default, three-stage pipeline) or `S2S` (end-to-end speech-to-speech model).
        /// Valid values:
        /// - Cascade: three-stage pipeline (default). Speech recognition, a large language model, and text-to-speech.
        /// - S2S: end-to-end speech-to-speech model.
        /// Default: Cascade
        /// </summary>
        [JsonProperty("ConversationMode")]
        public string ConversationMode{ get; set; }

        /// <summary>
        /// End-to-end speech-to-speech model configuration. Required only in `S2S` mode. Ignored in `Cascade` mode.
        /// </summary>
        [JsonProperty("S2SConfig")]
        public VoiceConversationS2SConfig S2SConfig{ get; set; }

        /// <summary>
        /// <p>Speech recognition configuration. <strong>Required only in <code>Cascade</code> mode</strong>; ignored in <code>S2S</code> mode.</p>
        /// </summary>
        [JsonProperty("STTConfig")]
        public VoiceConversationSTTConfig STTConfig{ get; set; }

        /// <summary>
        /// Large language model (LLM) configuration. Required only in `Cascade` mode. Ignored in `S2S` mode.
        /// </summary>
        [JsonProperty("LLMConfig")]
        public VoiceConversationLLMConfig LLMConfig{ get; set; }

        /// <summary>
        /// <p>Text to speech configuration. <strong>Required only in <code>Cascade</code> mode</strong>; ignored in <code>S2S</code> mode.</p>
        /// </summary>
        [JsonProperty("TTSConfig")]
        public VoiceConversationTTSConfig TTSConfig{ get; set; }

        /// <summary>
        /// Conversation control configuration. Not supported in `S2S` mode.
        /// </summary>
        [JsonProperty("DialogConfig")]
        public VoiceConversationDialogConfig DialogConfig{ get; set; }

        /// <summary>
        /// Visual understanding configuration. Not supported in `S2S` mode.
        /// </summary>
        [JsonProperty("VisionConfig")]
        public VoiceConversationVisionConfig VisionConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamObj(map, prefix + "AgentConfig.", this.AgentConfig);
            this.SetParamSimple(map, prefix + "ConversationMode", this.ConversationMode);
            this.SetParamObj(map, prefix + "S2SConfig.", this.S2SConfig);
            this.SetParamObj(map, prefix + "STTConfig.", this.STTConfig);
            this.SetParamObj(map, prefix + "LLMConfig.", this.LLMConfig);
            this.SetParamObj(map, prefix + "TTSConfig.", this.TTSConfig);
            this.SetParamObj(map, prefix + "DialogConfig.", this.DialogConfig);
            this.SetParamObj(map, prefix + "VisionConfig.", this.VisionConfig);
        }
    }
}

