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

    public class VoiceConversationInvokeLLM : AbstractModel
    {
        
        /// <summary>
        /// <p>The injected content.</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Priority. If no conversation is in progress, the injected content is sent to the LLM. Otherwise, the behavior depends on this value. Default: 0.
        /// Valid values:
        /// - 0: High. Interrupt the current conversation, clear the waiting queue, and send the injected content to the LLM.
        /// - 1: Medium. Do not interrupt the current conversation. Clear the waiting queue and queue the injected content. If no conversation is in progress, the injected content is still queued.
        /// - 2: Low. Discard the injected content.
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

