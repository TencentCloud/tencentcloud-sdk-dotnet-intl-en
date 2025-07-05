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
        /// Signature algorithm. The valid values include `SM2DSA`, `ECC_P256_R1`, `RSA_PSS_SHA_256`, and `RSA_PKCS1_SHA_256`, etc. You can get a full list of supported algorithms using the ListAlgorithms API.
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// Full message or message abstract. Before Base64 encoding, an original message can contain up to 4,096 bytes while a message abstract must be 32 bytes.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Unique ID of a key
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Message type. Valid values: `RAW` (indicating an original message; used by default if the parameter is not passed in) and `DIGEST`.
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

