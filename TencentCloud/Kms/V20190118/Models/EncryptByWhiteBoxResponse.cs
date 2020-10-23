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

    public class EncryptByWhiteBoxResponse : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded initialization vector, which will be used by the encryption algorithm. If this parameter is passed in by the caller, it will be returned as-is; otherwise, the backend service will generate a random one and return it.
        /// </summary>
        [JsonProperty("InitializationVector")]
        public string InitializationVector{ get; set; }

        /// <summary>
        /// Base64-encoded ciphertext after encryption
        /// </summary>
        [JsonProperty("CipherText")]
        public string CipherText{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InitializationVector", this.InitializationVector);
            this.SetParamSimple(map, prefix + "CipherText", this.CipherText);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

