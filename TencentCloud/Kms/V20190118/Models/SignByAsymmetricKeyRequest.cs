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

    public class SignByAsymmetricKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// Signature algorithm. Supported algorithm: SM2DSA.
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// The original message or message abstract. For an original message, the length before Base64 encoding can contain up to 4,096 bytes. For a message abstract, the SM2 signature algorithm only supports 32-byte (before Base64 encoding) message abstracts.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Unique ID of a key
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Message type. Valid values: `RAW` (indicating an original message; used by default if the parameter is not passed in) and `DIGEST`.
        /// </summary>
        [JsonProperty("MessageType")]
        public string MessageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "MessageType", this.MessageType);
        }
    }
}

