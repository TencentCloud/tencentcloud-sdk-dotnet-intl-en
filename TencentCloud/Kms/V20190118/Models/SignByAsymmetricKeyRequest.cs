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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SignByAsymmetricKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Signature algorithm. Supported algorithms: SM2DSA, ECC_P256_R1, ECDSA384_SHA384, RSA_PSS_SHA_256, RSA_PKCS1_SHA_256, RSA_PSS_SHA_384, RSA_PKCS1_SHA_384, RSA_PSS_SHA_512, RSA_PKCS1_SHA_512, etc. For more supported algorithms, query them through the ListAlgorithms API.</p>
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// <p>Message original text or message digest. If the message original text is provided, its length (before Base64 encoding) cannot exceed 4096 bytes. If the message digest is provided, its length (before Base64 encoding) must be 32 bytes.</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// <p>Unique identifier of the key</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>Message type: RAW or DIGEST. If not specified, RAW is used by default, indicating the message original text.</p>
        /// </summary>
        [JsonProperty("MessageType")]
        public string MessageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "MessageType", this.MessageType);
        }
    }
}

