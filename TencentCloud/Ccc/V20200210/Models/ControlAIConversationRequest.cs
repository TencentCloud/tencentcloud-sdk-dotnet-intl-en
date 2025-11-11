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

    public class ControlAIConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the session ID.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// App ID (required). can be used to view https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Control command. currently supported commands are as follows:.
        /// 
        /// -ServerPushText. specifies the text sent by the server to the AI robot for broadcast.
        /// -InvokeLLM. specifies the server sends text to the large model to trigger a dialogue.
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// Specifies the server-sent broadcast text Command. required when Command is ServerPushText.
        /// </summary>
        [JsonProperty("ServerPushText")]
        public ServerPushText ServerPushText{ get; set; }

        /// <summary>
        /// The server sends a Command to proactively request the large model. when Command is InvokeLLM, it sends the content to the large model and adds X-Invoke-LLM="1" to the header.
        /// </summary>
        [JsonProperty("InvokeLLM")]
        public InvokeLLM InvokeLLM{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamObj(map, prefix + "ServerPushText.", this.ServerPushText);
            this.SetParamObj(map, prefix + "InvokeLLM.", this.InvokeLLM);
        }
    }
}

