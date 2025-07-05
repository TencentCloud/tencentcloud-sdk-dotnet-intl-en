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

    public class CreateSSHKeyPairSecretResponse : AbstractModel
    {
        
        /// <summary>
        /// Name of the created secret.
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// ID of the created SSH key.
        /// </summary>
        [JsonProperty("SSHKeyID")]
        public string SSHKeyID{ get; set; }

        /// <summary>
        /// Name of the created SSH key.
        /// </summary>
        [JsonProperty("SSHKeyName")]
        public string SSHKeyName{ get; set; }

        /// <summary>
        /// Tag return code. `0`: success; `1`: internal error; `2`: business processing error.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagCode")]
        public ulong? TagCode{ get; set; }

        /// <summary>
        /// Tag return message.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
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
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "SSHKeyID", this.SSHKeyID);
            this.SetParamSimple(map, prefix + "SSHKeyName", this.SSHKeyName);
            this.SetParamSimple(map, prefix + "TagCode", this.TagCode);
            this.SetParamSimple(map, prefix + "TagMsg", this.TagMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

