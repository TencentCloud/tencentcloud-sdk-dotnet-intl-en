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

    public class CreateKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Alias that makes the key easier to identify and understand. It cannot be empty and must contain 1-60 alphanumeric characters, hyphens (-), or underscores (_), and start with a letter or digit. Aliases prefixed with kms- are reserved for cloud services. The alias must be unique.</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>Description of the CMK. Maximum length: 1024 bytes.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Specifies the purpose of the key. The default value is "ENCRYPT_DECRYPT", which indicates creating a symmetric encryption/decryption key. Other supported purposes: "ASYMMETRIC_DECRYPT_RSA_2048" indicates creating an RSA2048 asymmetric key for encryption/decryption; "ASYMMETRIC_DECRYPT_RSA_3072" indicates creating an RSA3072 asymmetric key for encryption/decryption; "ASYMMETRIC_DECRYPT_RSA_4096" indicates creating an RSA4096 asymmetric key for encryption/decryption; "ASYMMETRIC_DECRYPT_SM2" indicates creating an SM2 asymmetric key for encryption/decryption; "ASYMMETRIC_SIGN_VERIFY_SM2" indicates creating an SM2 asymmetric key for signature generation and verification; "ASYMMETRIC_SIGN_VERIFY_ECC" indicates creating an ECC asymmetric key for signature generation and verification; "ASYMMETRIC_SIGN_VERIFY_RSA_2048" indicates creating an RSA_2048 asymmetric key for signature generation and verification; "ASYMMETRIC_SIGN_VERIFY_RSA_3072" indicates creating an RSA_3072 asymmetric key for signature generation and verification; <br>"ASYMMETRIC_SIGN_VERIFY_RSA_4096" indicates creating an RSA_4096 asymmetric key for signature generation and verification; "ASYMMETRIC_SIGN_VERIFY_ECDSA384" indicates creating an ECDSA384 asymmetric key for signature generation and verification. For the complete list of key purposes and supported algorithms, call the ListAlgorithms API.</p>
        /// </summary>
        [JsonProperty("KeyUsage")]
        public string KeyUsage{ get; set; }

        /// <summary>
        /// <p>Specifies the key type. The default value is 1. 1 indicates the default type, where the CMK is created by KMS. 2 indicates the EXTERNAL type, where you need to import the key material. For more information, see the GetParametersForImport and ImportKeyMaterial APIs.</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>Tag list.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>HSM cluster ID corresponding to KMS Advanced Edition (valid only for KMS exclusive/managed service instances).</p>
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KeyUsage", this.KeyUsage);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
        }
    }
}

