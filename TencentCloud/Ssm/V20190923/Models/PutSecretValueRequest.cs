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

    public class PutSecretValueRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of a Secret where the version is added to.
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// ID of the new Secret version. It can be up to 64 bytes, contain letters, digits, hyphens (-), and underscores (_), and must begin with a letter or digit.
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// Base64-encoded binary credential information.
        /// Either `SecretBinary` or `SecretString` must be set.
        /// </summary>
        [JsonProperty("SecretBinary")]
        public string SecretBinary{ get; set; }

        /// <summary>
        /// Secret information plaintext in text format, base64 encoding is not needed. Either `SecretBinary` or `SecretString` must be set.
        /// </summary>
        [JsonProperty("SecretString")]
        public string SecretString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "SecretBinary", this.SecretBinary);
            this.SetParamSimple(map, prefix + "SecretString", this.SecretString);
        }
    }
}

