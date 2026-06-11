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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KafkaProtocolInfo : AbstractModel
    {
        
        /// <summary>
        /// Protocol type. Supported protocol types include plaintext, sasl_plaintext, or sasl_ssl. Recommend using sasl_ssl. Protocol enables encrypted connection and also requires user authentication.
        /// 
        /// -Protocol is required when IsEncryptionAddr is true.
        /// -Supported protocol types are as follows:
        /// -plaintext: Plaintext without encryption protocol
        /// -sasl_ssl: sasl authentication + ssl encryption
        /// -ssl: Pure ssl/TLS encryption protocol
        /// -sasl_plaintext: SASL authentication + unencrypted tunnel
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Encryption type, supports PLAIN, SCRAM-SHA-256, or SCRAM-SHA-512.
        /// 
        /// -Mechanism is required when Protocol is `sasl_plaintext` or `sasl_ssl`.
        /// -Supported encryption types are as follows.
        /// -PLAIN: plaintext authentication
        /// -SCRAM-SHA-256: Based on challenge-response mechanism, uses PBKDF2-HMAC-SHA256 algorithm.
        /// -SCRAM-SHA-512: Enhanced SCRAM that uses the PBKDF2-HMAC-SHA512 algorithm.
        /// </summary>
        [JsonProperty("Mechanism")]
        public string Mechanism{ get; set; }

        /// <summary>
        /// Username.
        /// Required when Protocol is sasl_plaintext or sasl_ssl
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// User password.
        /// Required when Protocol is sasl_plaintext or sasl_ssl
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Mechanism", this.Mechanism);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
        }
    }
}

