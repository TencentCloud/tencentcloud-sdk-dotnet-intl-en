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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationProxyRule : AbstractModel
    {
        
        /// <summary>
        /// The protocol. Values:
        /// <li>`TCP`: TCP protocol.</li>
        /// <li>`UDP`: UDP protocol.</li>
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// The access port, which can be:
        /// <li>A single port, such as 80</li>
        /// <li>A port range, such as 81-82</li>
        /// Note that each rule can have up to 20 ports.
        /// </summary>
        [JsonProperty("Port")]
        public string[] Port{ get; set; }

        /// <summary>
        /// The origin type. Values:
        /// <li>`custom`: Specified origins</li>
        /// <li>`origins`: Origin group</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server information:
        /// <li>When `OriginType=custom`, it indicates one or more origin servers, such as ["8.8.8.8","9.9.9.9"] or ["test.com"].</li>
        /// <li>When `OriginType=origins`, it indicates an origin group ID, such as ["origin-537f5b41-162a-11ed-abaa-525400c5da15"].</li>
        /// </summary>
        [JsonProperty("OriginValue")]
        public string[] OriginValue{ get; set; }

        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// The rule status. Values:
        /// <li>`online`: Enabled.</li>
        /// <li>`offline`: Disabled.</li>
        /// <li>`progress`: Deploying</li>
        /// <li>`stopping`: Disabling</li>
        /// <li>`fail`: Failed to deploy or disable</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Passes the client IP. Values:
        /// <li>`TOA`: Pass the client IP via TOA (available only when `Proto=TCP`).</li>
        /// <li>`PPV1`: Pass the client IP via Proxy Protocol V1 (available only when `Proto=TCP`).</li>
        /// <li>`PPV2`: Pass the client IP via Proxy Protocol V2.</li>
        /// <li>`OFF`: Not pass the client IP.</li>Default value: OFF.
        /// </summary>
        [JsonProperty("ForwardClientIp")]
        public string ForwardClientIp{ get; set; }

        /// <summary>
        /// Whether to enable session persistence. Values:
        /// <li>`true`: Enable</li>
        /// <li>`false`: Disable</li>Default value: false
        /// </summary>
        [JsonProperty("SessionPersist")]
        public bool? SessionPersist{ get; set; }

        /// <summary>
        /// The origin port, which can be:
        /// <li>A single port, such as 80</li>
        /// <li>A port range, such as 81-82</li>
        /// </summary>
        [JsonProperty("OriginPort")]
        public string OriginPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamArraySimple(map, prefix + "Port.", this.Port);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArraySimple(map, prefix + "OriginValue.", this.OriginValue);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ForwardClientIp", this.ForwardClientIp);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
            this.SetParamSimple(map, prefix + "OriginPort", this.OriginPort);
        }
    }
}

