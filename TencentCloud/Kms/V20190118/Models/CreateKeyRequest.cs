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
        /// Unique alias that makes a key more recognizable and understandable. This parameter cannot be empty, can contain 1-60 letters, digits, `-`, and `_`, and must begin with a letter or digit. The `kms-` prefix is used for Tencent Cloud products.
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// CMK description of up to 1,024 bytes in length
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Specifies the key purpose, defaults to "ENCRYPT_DECRYPT" indicating the creation of a symmetric encryption/decryption key. other supported purposes include "ASYMMETRIC_DECRYPT_RSA_2048" for RSA2048 ASYMMETRIC keys used to ENCRYPT and DECRYPT, "ASYMMETRIC_DECRYPT_SM2" for SM2 ASYMMETRIC keys used to ENCRYPT and DECRYPT, "ASYMMETRIC_SIGN_VERIFY_SM2" for SM2 ASYMMETRIC keys used for signature verification, "ASYMMETRIC_SIGN_VERIFY_ECC" for ECC ASYMMETRIC keys used for signature verification, "ASYMMETRIC_SIGN_VERIFY_RSA_2048" for RSA_2048 ASYMMETRIC keys used for signature verification, and "ASYMMETRIC_SIGN_VERIFY_ECDSA384" for ECDSA384 ASYMMETRIC keys used for signature verification. the complete list of key purposes and algorithm support can be obtained through the ListAlgorithms api.
        /// </summary>
        [JsonProperty("KeyUsage")]
        public string KeyUsage{ get; set; }

        /// <summary>
        /// Specifies the key type. Default value: 1. Valid value: 1 - default type, indicating that the CMK is created by KMS; 2 - EXTERNAL type, indicating that you need to import key material. For more information, please see the `GetParametersForImport` and `ImportKeyMaterial` API documents.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Tag list
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// ID of the HSM cluster. This field is only valid for Exclusive and Managed KMS instances.
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

