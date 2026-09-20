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

    public class UpdateEKYCWebhookRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ID of the Webhook configuration to be updated</p>
        /// </summary>
        [JsonProperty("WebhookId")]
        public long? WebhookId{ get; set; }

        /// <summary>
        /// <p>New Webhook name</p>
        /// </summary>
        [JsonProperty("WebhookName")]
        public string WebhookName{ get; set; }

        /// <summary>
        /// New callback URL, which must use the HTTPS protocol.
        /// </summary>
        [JsonProperty("WebhookURL")]
        public string WebhookURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WebhookId", this.WebhookId);
            this.SetParamSimple(map, prefix + "WebhookName", this.WebhookName);
            this.SetParamSimple(map, prefix + "WebhookURL", this.WebhookURL);
        }
    }
}

