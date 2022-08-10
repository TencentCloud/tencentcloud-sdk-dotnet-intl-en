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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApplicationProxyRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Proxy ID
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Protocol. Valid values: `TCP` and `UDP`.
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// Port. Valid values:
        /// `80`: Port 80
        /// `81-90`: Port range 81-90
        /// </summary>
        [JsonProperty("Port")]
        public string[] Port{ get; set; }

        /// <summary>
        /// Origin server type. Valid values:
        /// `custom`: Specified origins
        /// `origins`: Origin group
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server information:
        /// When `OriginType=custom`, it indicates one or more origin servers. Example:
        /// OriginValue=["8.8.8.8:80","9.9.9.9:80"]
        /// OriginValue=["test.com:80"]
        /// 
        /// When `OriginType=origins`, it indicates an origin group ID. Example:
        /// OriginValue=["origin-xxx"]
        /// </summary>
        [JsonProperty("OriginValue")]
        public string[] OriginValue{ get; set; }

        /// <summary>
        /// Passes the client IP. When `Proto=TCP`, valid values:
        /// `TOA`: Pass the client IP via TOA.
        /// `PPV1`: Pass the client IP via Proxy Protocol V1.
        /// `PPV2`: Pass the client IP via Proxy Protocol V2.
        /// `OFF`: Do not pass the client IP.
        /// When `Proto=UDP`, valid values:
        /// `PPV2`: Pass the client IP via Proxy Protocol V2.
        /// `OFF`: Do not pass the client IP.
        /// </summary>
        [JsonProperty("ForwardClientIp")]
        public string ForwardClientIp{ get; set; }

        /// <summary>
        /// Specifies whether to enable session persistence
        /// </summary>
        [JsonProperty("SessionPersist")]
        public bool? SessionPersist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamArraySimple(map, prefix + "Port.", this.Port);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArraySimple(map, prefix + "OriginValue.", this.OriginValue);
            this.SetParamSimple(map, prefix + "ForwardClientIp", this.ForwardClientIp);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
        }
    }
}

