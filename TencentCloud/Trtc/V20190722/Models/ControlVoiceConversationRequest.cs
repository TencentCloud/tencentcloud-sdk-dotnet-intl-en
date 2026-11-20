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

    public class ControlVoiceConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// The TRTC [SdkAppId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#sdkappid). It must be the same SdkAppId as the conversation room.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Unique ID of the conversation task. Returned when the conversation task starts successfully.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Control command.
        /// Valid values:
        /// 
        /// - `Interrupt`: Force-interrupt the AI bot's current speech.
        /// - `invokellm`: Inject text into the current conversation context to trigger one LLM response. Not supported in `S2S` mode.
        /// - `invoketts`: Inject text into the current TTS so the AI bot broadcasts it. Not supported in `S2S` mode.
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// Configuration for injecting text into the LLM. Required when `Command` is `invokellm`.
        /// </summary>
        [JsonProperty("InvokeLLM")]
        public VoiceConversationInvokeLLM InvokeLLM{ get; set; }

        /// <summary>
        /// Configuration for injecting text into TTS. Required when `Command` is `invoketts`.
        /// </summary>
        [JsonProperty("InvokeTTS")]
        public VoiceConversationInvokeTTS InvokeTTS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamObj(map, prefix + "InvokeLLM.", this.InvokeLLM);
            this.SetParamObj(map, prefix + "InvokeTTS.", this.InvokeTTS);
        }
    }
}

