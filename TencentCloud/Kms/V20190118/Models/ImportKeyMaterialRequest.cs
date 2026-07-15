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
        /// <p>base64-encoded encrypted key material using the PublicKey returned by GetParametersForImport. For KMS in national cryptography version regions, the length requirement for imported key material is 128 bit. For KMS in FIPS 140-2 version regions, the length requirement for imported key material is 256 bit.</p>
        /// </summary>
        [JsonProperty("EncryptedKeyMaterial")]
        public string EncryptedKeyMaterial{ get; set; }

        /// <summary>
        /// <p>Import token obtained by calling GetParametersForImport.</p>
        /// </summary>
        [JsonProperty("ImportToken")]
        public string ImportToken{ get; set; }

        /// <summary>
        /// <p>The CMK designated for importing key material must be identical to the CMK specified in GetParametersForImport.</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>Expiration time of the key material in unix timestamp. If unspecified or 0, the key material does not expire. If specified, the expiration time must be greater than the current time and supports up to 2147443200.</p>
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

