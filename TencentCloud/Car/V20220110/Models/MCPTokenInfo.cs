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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MCPTokenInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>TokenId</p><p>Used to manage Token data. It can be used to extend the validity period of the corresponding Token.</p>
        /// </summary>
        [JsonProperty("TokenId")]
        public string TokenId{ get; set; }

        /// <summary>
        /// <p>Token name (comment)</p>
        /// </summary>
        [JsonProperty("TokenName")]
        public string TokenName{ get; set; }

        /// <summary>
        /// <p>User Id</p><p>This UserId is always used to operate cloud rendering concurrent resources. (If this parameter is empty, no restriction is applied.)</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>Permission scope</p><p>Default value: [&quot;*&quot;]</p><p>Used to specify operation permissions. By default, all permissions are granted.</p>
        /// </summary>
        [JsonProperty("Scopes")]
        public string[] Scopes{ get; set; }

        /// <summary>
        /// <p>Token status</p><p>Valid values:</p><ul><li>ACTIVE: Normal status. The token has not been revoked, but it may not be within its validity period.</li><li>REVOKED: The token has been revoked and is permanently invalid.</li></ul><p>Default value: ACTIVE</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Token creation time</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>Token expiration time</p>
        /// </summary>
        [JsonProperty("ExpiresTime")]
        public string ExpiresTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TokenId", this.TokenId);
            this.SetParamSimple(map, prefix + "TokenName", this.TokenName);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArraySimple(map, prefix + "Scopes.", this.Scopes);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiresTime", this.ExpiresTime);
        }
    }
}

