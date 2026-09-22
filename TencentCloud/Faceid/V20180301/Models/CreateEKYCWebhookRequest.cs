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

    public class CreateEKYCWebhookRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Webhook name, used for console display</p>
        /// </summary>
        [JsonProperty("WebhookName")]
        public string WebhookName{ get; set; }

        /// <summary>
        /// <p>Callback URL, which must use the HTTPS protocol</p>
        /// </summary>
        [JsonProperty("WebhookURL")]
        public string WebhookURL{ get; set; }

        /// <summary>
        /// <p>Business scenario. Default if not passed: AML_SCREENING_RESULT_CHANGE. For parameter values, see the enumeration below.</p><p>Enumeration values:</p><ul><li>AML_SCREENING_RESULT_CHANGE: AML anti-money laundering screening result change notification (default value)    </li><li>NONDOC_VERIFICATION_RESULT: Non-document (NonDoc) verification result notification</li></ul>
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// <p>Callback signature key, up to 128 characters. Used for HMAC-SHA256 signature verification of subsequent callback messages. If not passed, signature is not enabled. We recommend using OpenSSL random bytes to generate the key. Recommended command: openssl rand -base64 32</p><blockquote><p>Our side uses your configured <code>SignatureKey</code> to calculate an HMAC-SHA256 signature over "timestamp (<code>X-Webhook-Timestamp</code>) + <code>.</code> + request body", and puts the hexadecimal result in the request header <code>X-Webhook-Signature</code>. The message itself is unencrypted and transmitted over HTTPS. Use the same key to recalculate and compare the signature by the same rule to confirm that the notification source is trustworthy and the content has not been tampered with.</p></blockquote>
        /// </summary>
        [JsonProperty("SignatureKey")]
        public string SignatureKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WebhookName", this.WebhookName);
            this.SetParamSimple(map, prefix + "WebhookURL", this.WebhookURL);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "SignatureKey", this.SignatureKey);
        }
    }
}

