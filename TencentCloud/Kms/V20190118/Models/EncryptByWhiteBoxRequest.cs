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

    public class EncryptByWhiteBoxRequest : AbstractModel
    {
        
        /// <summary>
        /// Globally unique white-box key ID
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Base64-encoded text to be encrypted. The size of the original text cannot exceed 4 KB.
        /// </summary>
        [JsonProperty("PlainText")]
        public string PlainText{ get; set; }

        /// <summary>
        /// Base64-encoded initialization vector of 16 bytes, which will be used by the encryption algorithm. If this parameter is not passed in, the backend service will generate a random one. You should save this value as a parameter for decryption.
        /// </summary>
        [JsonProperty("InitializationVector")]
        public string InitializationVector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "PlainText", this.PlainText);
            this.SetParamSimple(map, prefix + "InitializationVector", this.InitializationVector);
        }
    }
}

