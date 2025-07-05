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

    public class ImportKeyMaterialRequest : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded key material that encrypted with the `PublicKey` returned by `GetParametersForImport`. For the KMS of SM-CRYPTO version, the length of the key material should be 128 bits, while for KMS of FIPS-compliant version, the length should be 256 bits.
        /// </summary>
        [JsonProperty("EncryptedKeyMaterial")]
        public string EncryptedKeyMaterial{ get; set; }

        /// <summary>
        /// Import token obtained by calling `GetParametersForImport`.
        /// </summary>
        [JsonProperty("ImportToken")]
        public string ImportToken{ get; set; }

        /// <summary>
        /// Specifies the CMK into which to import key material, which must be the same as the one specified by `GetParametersForImport`.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Unix timestamp of the key material's expiration time. If this value is empty or 0, the key material will never expire. To specify the expiration time, it should be later than the current time. Maximum value: 2147443200.
        /// </summary>
        [JsonProperty("ValidTo")]
        public ulong? ValidTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EncryptedKeyMaterial", this.EncryptedKeyMaterial);
            this.SetParamSimple(map, prefix + "ImportToken", this.ImportToken);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "ValidTo", this.ValidTo);
        }
    }
}

