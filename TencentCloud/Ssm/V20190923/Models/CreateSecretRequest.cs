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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSecretRequest : AbstractModel
    {
        
        /// <summary>
        /// Secret name, which must be unique within a region. The name can be up to 128 bytes, contain letters, digits, hyphens (-), and underscores (_), and must begin with a letter or digit.
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// Secret version. It can be up to 64 bytes, contain letters, digits, hyphens (-), and underscores (_), and must begin with a letter or digit. `SecretName` and `VersionId` are used to query the Secret information.
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// Description information, such as the detailed use cases. It can be up to 2048 bytes.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// KMS CMK used for Secret encryption. If this parameter is left empty, SecretsManager will create a CMK by default. You can also specify a KMS CMK that is created in the same region.
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// Base64-encoded plaintext of a binary Secret. Either `SecretBinary` or `SecretString` must be set. A maximum of 4096 bytes is supported.
        /// </summary>
        [JsonProperty("SecretBinary")]
        public string SecretBinary{ get; set; }

        /// <summary>
        /// Plaintext of a Secret, in text format. Base64 encoding is not required. Either `SecretBinary` or `SecretString` must be set. A maximum of 4096 bytes is supported.
        /// </summary>
        [JsonProperty("SecretString")]
        public string SecretString{ get; set; }

        /// <summary>
        /// List of tags.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "SecretBinary", this.SecretBinary);
            this.SetParamSimple(map, prefix + "SecretString", this.SecretString);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

