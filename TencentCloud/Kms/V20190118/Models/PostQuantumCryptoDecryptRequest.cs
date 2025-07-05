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

    public class PostQuantumCryptoDecryptRequest : AbstractModel
    {
        
        /// <summary>
        /// The ciphertext data to be decrypted.
        /// </summary>
        [JsonProperty("CiphertextBlob")]
        public string CiphertextBlob{ get; set; }

        /// <summary>
        /// PEM-encoded public key (2048-bit RSA/SM2 key), which can be used to encrypt the `Plaintext` returned. If this field is left empty, the `Plaintext` will not be encrypted.
        /// </summary>
        [JsonProperty("EncryptionPublicKey")]
        public string EncryptionPublicKey{ get; set; }

        /// <summary>
        /// Asymmetric encryption algorithm. It is used in combination with `EncryptionPublicKey` to encrypt the returned data. Values: `SM2`(Return the ciphertext in the format of "C1C3C2"), `SM2_C1C3C2_ASN1` (Return the ciphertext in the format of "C1C3C2 ASN1"), `RSAES_PKCS1_V1_5`, `RSAES_OAEP_SHA_1`, `RSAES_OAEP_SHA_256`. It defaults to `SM2` if it's not specified. 
        /// </summary>
        [JsonProperty("EncryptionAlgorithm")]
        public string EncryptionAlgorithm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CiphertextBlob", this.CiphertextBlob);
            this.SetParamSimple(map, prefix + "EncryptionPublicKey", this.EncryptionPublicKey);
            this.SetParamSimple(map, prefix + "EncryptionAlgorithm", this.EncryptionAlgorithm);
        }
    }
}

