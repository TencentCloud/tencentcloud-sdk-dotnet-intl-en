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

    public class ControlAIConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// Task unique identifier.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Control command. currently supports the following commands: - ServerPushText: server sends text to the AI robot, and the AI robot will broadcast the text. - InvokeLLM: server sends text to the large model to trigger dialogue.
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// Server-Sent broadcast text Command. required when Command is ServerPushText.
        /// </summary>
        [JsonProperty("ServerPushText")]
        public ServerPushText ServerPushText{ get; set; }

        /// <summary>
        /// The server sends a Command to proactively request the large model. when Command is InvokeLLM, it sends the content request to the large model and adds X-Invoke-LLM="1" to the header.
        /// </summary>
        [JsonProperty("InvokeLLM")]
        public InvokeLLM InvokeLLM{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamObj(map, prefix + "ServerPushText.", this.ServerPushText);
            this.SetParamObj(map, prefix + "InvokeLLM.", this.InvokeLLM);
        }
    }
}

