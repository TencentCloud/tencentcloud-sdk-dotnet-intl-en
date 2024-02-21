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

    public class L4ProxyRule : AbstractModel
    {
        
        /// <summary>
        /// Forwarding rule ID.
        /// Note: Do not fill in this parameter when L4ProxyRule is used as an input parameter in CreateL4ProxyRules; it must be filled in when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Forwarding protocol. Valid values:
        /// <li>TCP: TCP protocol;</li>
        /// <li>UDP: UDP protocol.</li>
        /// Note: This parameter must be filled in when L4ProxyRule is used as an input parameter in CreateL4ProxyRules; it is optional when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Forwarding port, which can be set as follows:
        /// <li>A single port, such as 80;</li>
        /// <li>A range of ports, such as 81-85, representing ports 81, 82, 83, 84, 85.</li>
        /// Note: This parameter must be filled in when L4ProxyRule is used as an input parameter in CreateL4ProxyRules; it is optional when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("PortRange")]
        public string[] PortRange{ get; set; }

        /// <summary>
        /// Origin server type. Valid values:
        /// <li>IP_DOMAIN: IP/Domain name origin server;</li>
        /// <li>ORIGIN_GROUP: Origin server group;</li>
        /// <li>LB: Cloud Load Balancer, currently only open to the allowlist.</li>
        /// Note: This parameter must be filled in when L4ProxyRule is used as an input parameter in CreateL4ProxyRules; it is optional when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server address.
        /// <li>When OriginType is set to IP_DOMAIN, enter the IP address or domain name, such as 8.8.8.8 or test.com;</li>
        /// <li>When OriginType is set to ORIGIN_GROUP, enter the origin server group ID, such as og-537y24vf5b41;</li>
        /// <li>When OriginType is set to LB, enter the Cloud Load Balancer instance ID, such as lb-2qwk30xf7s9g.</li>
        /// Note: This parameter must be filled in when L4ProxyRule is used as an input parameter in CreateL4ProxyRules; it is optional when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("OriginValue")]
        public string[] OriginValue{ get; set; }

        /// <summary>
        /// Origin server port, which can be set as follows:<li>A single port, such as 80;</li>
        /// <li>A range of ports, such as 81-85, representing ports 81, 82, 83, 84, 85. When inputting a range of ports, ensure that the length corresponds with that of the forwarding port range. For example, if the forwarding port range is 80-90, this port range should be 90-100.</li>
        /// Note: This parameter must be filled in when L4ProxyRule is used as an input parameter in CreateL4ProxyRules; it is optional when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("OriginPortRange")]
        public string OriginPortRange{ get; set; }

        /// <summary>
        /// Transmission of the client IP address. Valid values:<li>TOA: Available only when Protocol=TCP;</li> 
        /// <li>PPV1: Transmission via Proxy Protocol V1. Available only when Protocol=TCP;</li>
        /// <li>PPV2: Transmission via Proxy Protocol V2;</li> 
        /// <li>SPP: Transmission via Simple Proxy Protocol. Available only when Protocol=UDP;</li> 
        /// <li>OFF: No transmission.</li>
        /// Note: This parameter is optional when L4ProxyRule is used as an input parameter in CreateL4ProxyRules, and if not specified, the default value OFF will be used; it is optional when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("ClientIPPassThroughMode")]
        public string ClientIPPassThroughMode{ get; set; }

        /// <summary>
        /// Specifies whether to enable session persistence. Valid values:
        /// <li>on: Enable;</li>
        /// <li>off: Disable.</li>
        /// Note: This parameter is optional when L4ProxyRule is used as an input parameter in CreateL4ProxyRules, and if not specified, the default value off will be used; it is optional when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("SessionPersist")]
        public string SessionPersist{ get; set; }

        /// <summary>
        /// Session persistence period, with a range of 30-3600, measured in seconds.
        /// Note: This parameter is optional when L4ProxyRule is used as an input parameter in CreateL4ProxyRules. It is valid only when SessionPersist is set to on and defaults to 3600 if not specified. It is optional when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// Rule tag. Accepts 1-50 arbitrary characters.
        /// Note: This parameter is optional when L4ProxyRule is used as an input parameter in CreateL4ProxyRules; it is optional when L4ProxyRule is used as an input parameter in ModifyL4ProxyRules. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("RuleTag")]
        public string RuleTag{ get; set; }

        /// <summary>
        /// Rule status. Valid values:<li>online: Enabled;</li>
        /// <li>offline: Disabled;</li>
        /// <li>progress: Deploying;</li>
        /// <li>stopping: Disabling;</li>
        /// <li>fail: Failed to deploy or disable.</li>
        /// Note: Do not set this parameter when L4ProxyRule is used as an input parameter in CreateL4ProxyRules and ModifyL4ProxyRules.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArraySimple(map, prefix + "PortRange.", this.PortRange);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArraySimple(map, prefix + "OriginValue.", this.OriginValue);
            this.SetParamSimple(map, prefix + "OriginPortRange", this.OriginPortRange);
            this.SetParamSimple(map, prefix + "ClientIPPassThroughMode", this.ClientIPPassThroughMode);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamSimple(map, prefix + "RuleTag", this.RuleTag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

