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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApiKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// Custom key name.
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// Key type. Valid values: auto, manual (custom key). Default value: auto.
        /// </summary>
        [JsonProperty("AccessKeyType")]
        public string AccessKeyType{ get; set; }

        /// <summary>
        /// Custom key ID, which is required if `AccessKeyType` is `manual`. It can contain 5-50 letters, digits, and underscores.
        /// </summary>
        [JsonProperty("AccessKeyId")]
        public string AccessKeyId{ get; set; }

        /// <summary>
        /// Custom key, which is required if `AccessKeyType` is `manual`. It can contain 10-50 letters, digits, and underscores.
        /// </summary>
        [JsonProperty("AccessKeySecret")]
        public string AccessKeySecret{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "AccessKeyType", this.AccessKeyType);
            this.SetParamSimple(map, prefix + "AccessKeyId", this.AccessKeyId);
            this.SetParamSimple(map, prefix + "AccessKeySecret", this.AccessKeySecret);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

