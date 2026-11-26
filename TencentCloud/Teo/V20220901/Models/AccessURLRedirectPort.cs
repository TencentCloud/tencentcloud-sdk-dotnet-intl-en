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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessURLRedirectPort : AbstractModel
    {
        
        /// <summary>
        /// <p>Target port configuration</p><p>Enumeration values:</p><ul><li>FollowProtocol: Use the default port of the target protocol. The port is not explicitly specified in the redirect address. The target protocol uses its default port: 80 for HTTP and 443 for HTTPS.</li><li>FollowRequest: Follow the target port of the client request. If the request address explicitly carries a port, continue to use that port. If not, the redirect address does not carry a port.</li><li>Custom: Use the designated custom port.</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>Custom destination port.</p><p>Value range: [1, 65535]</p><p>Required when Action is Custom. It is ineffective when Action is FollowProtocol or FollowRequest.</p>
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

