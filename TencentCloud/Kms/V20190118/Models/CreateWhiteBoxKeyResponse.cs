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

    public class CreateWhiteBoxKeyResponse : AbstractModel
    {
        
        /// <summary>
        /// Base64-encoded encryption key
        /// </summary>
        [JsonProperty("EncryptKey")]
        public string EncryptKey{ get; set; }

        /// <summary>
        /// Base64-encoded decryption key
        /// </summary>
        [JsonProperty("DecryptKey")]
        public string DecryptKey{ get; set; }

        /// <summary>
        /// Globally unique white-box key ID
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Tag operation return code. 0: success; 1: internal error; 2: business processing error
        /// </summary>
        [JsonProperty("TagCode")]
        public ulong? TagCode{ get; set; }

        /// <summary>
        /// Tag operation return message
        /// </summary>
        [JsonProperty("TagMsg")]
        public string TagMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "EncryptKey", this.EncryptKey);
            this.SetParamSimple(map, prefix + "DecryptKey", this.DecryptKey);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "TagCode", this.TagCode);
            this.SetParamSimple(map, prefix + "TagMsg", this.TagMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

