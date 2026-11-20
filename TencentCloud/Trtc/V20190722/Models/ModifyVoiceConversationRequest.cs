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

    public class ModifyVoiceConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>The <a href="https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#sdkappid">SdkAppId</a> of TRTC, which is the same as the SdkAppId corresponding to the conversation room.</p>
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Unique ID of the conversation task. Returned when the conversation task starts successfully.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// For the same task, `SequenceNumber` must increase with each modification request. This prevents requests from being applied out of order.
        /// </summary>
        [JsonProperty("SequenceNumber")]
        public ulong? SequenceNumber{ get; set; }

        /// <summary>
        /// Large language model (LLM) configuration. Applies only in `Cascade` mode. In `S2S` mode, the request returns an error.
        /// </summary>
        [JsonProperty("LLMConfig")]
        public VoiceConversationLLMConfig LLMConfig{ get; set; }

        /// <summary>
        /// End-to-end speech-to-speech model configuration. Applies only in `S2S` mode. In `Cascade` mode, the request returns an error.
        /// </summary>
        [JsonProperty("S2SConfig")]
        public VoiceConversationS2SConfig S2SConfig{ get; set; }

        /// <summary>
        /// Conversation control configuration. Applies only in `Cascade` mode.
        /// </summary>
        [JsonProperty("DialogConfig")]
        public VoiceConversationDialogConfig DialogConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SequenceNumber", this.SequenceNumber);
            this.SetParamObj(map, prefix + "LLMConfig.", this.LLMConfig);
            this.SetParamObj(map, prefix + "S2SConfig.", this.S2SConfig);
            this.SetParamObj(map, prefix + "DialogConfig.", this.DialogConfig);
        }
    }
}

