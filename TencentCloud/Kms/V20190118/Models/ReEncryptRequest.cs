/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ReEncryptRequest : AbstractModel
    {
        
        /// <summary>
        /// Ciphertext to be re-encrypted
        /// </summary>
        [JsonProperty("CiphertextBlob")]
        public string CiphertextBlob{ get; set; }

        /// <summary>
        /// CMK used for re-encryption. If this parameter is empty, the ciphertext will be re-encrypted by using the original CMK (as long as the key is not rotated, the ciphertext will not be refreshed)
        /// </summary>
        [JsonProperty("DestinationKeyId")]
        public string DestinationKeyId{ get; set; }

        /// <summary>
        /// JSON string of the key-value pair used during ciphertext encryption by `CiphertextBlob`. If not used during encryption, this parameter will be empty
        /// </summary>
        [JsonProperty("SourceEncryptionContext")]
        public string SourceEncryptionContext{ get; set; }

        /// <summary>
        /// JSON string of the key-value pair used during re-encryption. If this field is used, the same string should be entered when the returned new ciphertext is decrypted
        /// </summary>
        [JsonProperty("DestinationEncryptionContext")]
        public string DestinationEncryptionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CiphertextBlob", this.CiphertextBlob);
            this.SetParamSimple(map, prefix + "DestinationKeyId", this.DestinationKeyId);
            this.SetParamSimple(map, prefix + "SourceEncryptionContext", this.SourceEncryptionContext);
            this.SetParamSimple(map, prefix + "DestinationEncryptionContext", this.DestinationEncryptionContext);
        }
    }
}

