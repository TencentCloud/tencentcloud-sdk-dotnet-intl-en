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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EncryptionKey : AbstractModel
    {
        
        /// <summary>
        /// Specifies the KeyId for KMS instance encryption.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Alias name of the KMS instance encryption Key.
        /// </summary>
        [JsonProperty("KeyAlias")]
        public string KeyAlias{ get; set; }

        /// <summary>
        /// Specifies the ciphertext of the instance encryption key DEK.
        /// </summary>
        [JsonProperty("DEKCipherTextBlob")]
        public string DEKCipherTextBlob{ get; set; }

        /// <summary>
        /// Whether the key is enabled. valid values: 1 (enabled), 0 (disabled).
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// Specifies the region of the KMS key.
        /// </summary>
        [JsonProperty("KeyRegion")]
        public string KeyRegion{ get; set; }

        /// <summary>
        /// Creation time of the DEK key.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Specifies the Id of the KMS service cluster where the key resides. being empty indicates the key is in the default KMS cluster. a non-empty value indicates the key is in the specified KMS service cluster.
        /// </summary>
        [JsonProperty("KMSClusterId")]
        public string KMSClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyAlias", this.KeyAlias);
            this.SetParamSimple(map, prefix + "DEKCipherTextBlob", this.DEKCipherTextBlob);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "KeyRegion", this.KeyRegion);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "KMSClusterId", this.KMSClusterId);
        }
    }
}

