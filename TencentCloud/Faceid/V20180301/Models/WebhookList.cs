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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebhookList : AbstractModel
    {
        
        /// <summary>
        /// <p>Callback unique ID</p>
        /// </summary>
        [JsonProperty("WebhookId")]
        public long? WebhookId{ get; set; }

        /// <summary>
        /// <p>Callback URL name</p>
        /// </summary>
        [JsonProperty("WebhookName")]
        public string WebhookName{ get; set; }

        /// <summary>
        /// <p>Callback enumeration scenario.</p>
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// <p>Callback URL, must use HTTPS</p>
        /// </summary>
        [JsonProperty("WebhookURL")]
        public string WebhookURL{ get; set; }

        /// <summary>
        /// <p>Addition Time</p><p>Parameter format: Format example: 2026-09-09 14:33:41</p>
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// <p>Update time</p><p>Parameter format: Format example: 2026-09-09 14:33:41</p>
        /// </summary>
        [JsonProperty("ModTime")]
        public string ModTime{ get; set; }

        /// <summary>
        /// <p>Callback request key</p>
        /// </summary>
        [JsonProperty("SignatureKey")]
        public string SignatureKey{ get; set; }

        /// <summary>
        /// <p>Existence of callback API key</p>
        /// </summary>
        [JsonProperty("HasSignatureKey")]
        public bool? HasSignatureKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WebhookId", this.WebhookId);
            this.SetParamSimple(map, prefix + "WebhookName", this.WebhookName);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "WebhookURL", this.WebhookURL);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "ModTime", this.ModTime);
            this.SetParamSimple(map, prefix + "SignatureKey", this.SignatureKey);
            this.SetParamSimple(map, prefix + "HasSignatureKey", this.HasSignatureKey);
        }
    }
}

