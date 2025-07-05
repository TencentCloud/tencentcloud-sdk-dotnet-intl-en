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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndpointAuthInfo : AbstractModel
    {
        
        /// <summary>
        /// The security group allowlist in CIDR format.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WhiteIpList")]
        public string[] WhiteIpList{ get; set; }

        /// <summary>
        /// The security group blocklist in CIDR format.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BlackIpList")]
        public string[] BlackIpList{ get; set; }

        /// <summary>
        /// The authentication key. Its value is same as `X-TENCENT-PACKAGE` set in the HTTP request header.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthKey")]
        public string AuthKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "WhiteIpList.", this.WhiteIpList);
            this.SetParamArraySimple(map, prefix + "BlackIpList.", this.BlackIpList);
            this.SetParamSimple(map, prefix + "AuthKey", this.AuthKey);
        }
    }
}

