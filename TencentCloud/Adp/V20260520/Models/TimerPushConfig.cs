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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimerPushConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Enumeration values:<br>| uint | Description |<br>| --- | --- |<br>| 0 |  |<br>| 1 | Do not push |<br>| 2 | WeChat official account |<br>| 3 | WeCom AI chatbot |</p>
        /// </summary>
        [JsonProperty("PushChannel")]
        public long? PushChannel{ get; set; }

        /// <summary>
        /// <p>Push session ID</p>
        /// </summary>
        [JsonProperty("PushTargetId")]
        public string PushTargetId{ get; set; }

        /// <summary>
        /// <p>Enumeration values:<br>| uint | Description |<br>| --- | --- |<br>| 0 |  |<br>| 1 | User (WeChat official account openid) |<br>| 2 | Group chat (WeCom chatbot chat_id) |</p>
        /// </summary>
        [JsonProperty("PushTargetType")]
        public long? PushTargetType{ get; set; }

        /// <summary>
        /// <p>url for pushing webhook</p>
        /// </summary>
        [JsonProperty("PushWebhookUrl")]
        public string PushWebhookUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PushChannel", this.PushChannel);
            this.SetParamSimple(map, prefix + "PushTargetId", this.PushTargetId);
            this.SetParamSimple(map, prefix + "PushTargetType", this.PushTargetType);
            this.SetParamSimple(map, prefix + "PushWebhookUrl", this.PushWebhookUrl);
        }
    }
}

