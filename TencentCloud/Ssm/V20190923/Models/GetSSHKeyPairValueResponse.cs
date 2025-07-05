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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetSSHKeyPairValueResponse : AbstractModel
    {
        
        /// <summary>
        /// ID of the SSH key.
        /// </summary>
        [JsonProperty("SSHKeyID")]
        public string SSHKeyID{ get; set; }

        /// <summary>
        /// Plaintext value of the Base64-encoded public key.
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// Plaintext value of the Base64-encoded private key.
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// ID of the project to which the SSH key belongs.
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// Description of the SSH key.
        /// The description can be modified in the CVM console.
        /// </summary>
        [JsonProperty("SSHKeyDescription")]
        public string SSHKeyDescription{ get; set; }

        /// <summary>
        /// Name of the SSH key.
        /// The name can be modified in the CVM console.
        /// </summary>
        [JsonProperty("SSHKeyName")]
        public string SSHKeyName{ get; set; }

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
            this.SetParamSimple(map, prefix + "SSHKeyID", this.SSHKeyID);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "SSHKeyDescription", this.SSHKeyDescription);
            this.SetParamSimple(map, prefix + "SSHKeyName", this.SSHKeyName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

