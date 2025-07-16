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

    public class GetDataKeyPlaintextRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique id of a data key.
        /// </summary>
        [JsonProperty("DataKeyId")]
        public string DataKeyId{ get; set; }

        /// <summary>
        /// PEM formatted public key string, supporting RSA2048 and SM2 public keys, and used to encrypt the plaintext value in the returned data. If it is empty, plaintext value will not be encrypted.
        /// </summary>
        [JsonProperty("EncryptionPublicKey")]
        public string EncryptionPublicKey{ get; set; }

        /// <summary>
        /// Asymmetric encryption algorithm, used in conjunction with EncryptionPublicKey to encrypt the returned data. It currently supports SM2 (returns ciphertext in C1C3C2 format), SM2_C1C3C2_ASN1 (returns ciphertext in C1C3C2 ASN1 format), RSAES_PKCS1_V1_5, RSAES_OAEP_SHA_1, and RSAES_OAEP_SHA_256. If it is empty, the default value SM2 is used.
        /// </summary>
        [JsonProperty("EncryptionAlgorithm")]
        public string EncryptionAlgorithm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataKeyId", this.DataKeyId);
            this.SetParamSimple(map, prefix + "EncryptionPublicKey", this.EncryptionPublicKey);
            this.SetParamSimple(map, prefix + "EncryptionAlgorithm", this.EncryptionAlgorithm);
        }
    }
}

