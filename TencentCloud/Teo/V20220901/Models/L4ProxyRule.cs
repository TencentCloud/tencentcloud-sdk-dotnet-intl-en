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

    public class L4ProxyRule : AbstractModel
    {
        
        /// <summary>
        /// Forwarding rule ID.
        /// Note: Do not fill in L4ProxyRule as an input parameter in CreateL4ProxyRules. In ModifyL4ProxyRules, this parameter is required.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Forwarding protocol. Valid values:
        /// <li>TCP: TCP protocol;</li>
        /// <li>UDP: UDP protocol.</li>
        /// Note: L4ProxyRule is required as an input parameter in CreateL4ProxyRules. In ModifyL4ProxyRules, it is optional. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Forwarding port. You can fill it in based on the following format:
        /// <li>A single port, such as 80;</li>
        /// <li>A port range, such as 81-85, indicating five ports 81, 82, 83, 84, and 85.</li>
        /// Note: L4ProxyRule is required as an input parameter in CreateL4ProxyRules. In ModifyL4ProxyRules, it is optional. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("PortRange")]
        public string[] PortRange{ get; set; }

        /// <summary>
        /// Origin server type. Valid values:
        /// <li>IP_DOMAIN: IP/domain origin server;</li>
        /// <li>ORIGIN_GROUP: origin server group;</li>
        /// <li>LB: load balancing. Currently only available to the allowlist. </li>
        /// Note: L4ProxyRule is required as an input parameter in CreateL4ProxyRules. In ModifyL4ProxyRules, it is optional. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server address:
        /// <li>When OriginType is IP_DOMAIN, enter an IP address or domain name, for example, 8.8.8.8 or test.com;</li>
        /// <li>When OriginType is ORIGIN_GROUP, fill in the origin server group ID, such as og-537y24vf5b41; if referencing an origin server group from another site, the format is {origin server group ID}@{ZoneID}. For example: og-testorigin@zone-38moq1z10wwwy;</li>
        /// <li>When OriginType is LB, fill in the Cloud Load Balancer instance ID, for example, lb-2qwk30xf7s9g. If a load balancer from another site is referenced, the format is {Cloud Load Balancer ID}@{ZoneID}. For example: lb-2rxpamcyqfzg@zone-38moq1z10wwwy.</li>
        /// Note: L4ProxyRule is required as an input parameter in CreateL4ProxyRules. In ModifyL4ProxyRules, it is optional. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("OriginValue")]
        public string[] OriginValue{ get; set; }

        /// <summary>
        /// Origin server port, which can be set as follows:
        /// <li>A single port, such as 80;</li>
        /// <li>A port range, such as 81-85, indicating five ports 81, 82, 83, 84, and 85. When entering a port range, ensure the length corresponds with the forwarding port range. For example, if the forwarding port is 80-90, the forwarding port should be 90-100.</li>
        /// Note: L4ProxyRule is required as an input parameter in CreateL4ProxyRules. In ModifyL4ProxyRules, it is optional. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("OriginPortRange")]
        public string OriginPortRange{ get; set; }

        /// <summary>
        /// Transmission of the client IP address. Valid values:
        /// <li>TOA: TOA (selectable only when Protocol = TCP);</li> 
        /// <li>PPV1: passing via Proxy Protocol V1, available only when Protocol = TCP;</li>
        /// <li>PPV2: passing via Proxy Protocol V2;</li> 
        /// <li>SPP: transmission via Simple Proxy Protocol (selectable only when Protocol = UDP);</li> 
        /// <li>`OFF`: Do not pass the client IP.</li>
        /// Note: L4ProxyRule is optional as an input parameter in CreateL4ProxyRules. If not specified, it defaults to OFF. In ModifyL4ProxyRules, it is optional. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("ClientIPPassThroughMode")]
        public string ClientIPPassThroughMode{ get; set; }

        /// <summary>
        /// Whether to enable session persistence. Valid values:
        /// <li>`on`: Enable;</li>
        /// <li>off: Disable.</li>
        /// Note: When L4ProxyRule is used as an input parameter in CreateL4ProxyRules, this parameter is optional and defaults to off if left empty. When used as an input parameter in ModifyL4ProxyRules, this parameter is optional and retains its existing value if not specified.
        /// </summary>
        [JsonProperty("SessionPersist")]
        public string SessionPersist{ get; set; }

        /// <summary>
        /// Session persistence duration, in seconds. Value range: 30-3600.
        /// Note: L4ProxyRule is optional as an input parameter in CreateL4ProxyRules. It is valid only when SessionPersist = on. If not specified when SessionPersist = on, it defaults to 3600. In ModifyL4ProxyRules, it is optional. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// Rule tag. Enter 1-50 characters.
        /// Note: L4ProxyRule is optional as an input parameter in CreateL4ProxyRules. In ModifyL4ProxyRules, it is optional. If not specified, it will retain its existing value.
        /// </summary>
        [JsonProperty("RuleTag")]
        public string RuleTag{ get; set; }

        /// <summary>
        /// Rule status. Valid values:
        /// <li>online: enabled;</li>
        /// <li>offline: disabled;</li>
        /// <li>progress: deploying;</li>
        /// <li>stopping: disabling;</li>
        /// <li>fail: deployment or disabling failed.</li>
        /// Note: Do not fill in this parameter when L4ProxyRule is used as an input parameter in CreateL4ProxyRules or ModifyL4ProxyRules.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// BuID.
        /// </summary>
        [JsonProperty("BuId")]
        public string BuId{ get; set; }

        /// <summary>
        /// Remote authentication information.
        /// Note: RemoteAuth cannot be used as an input parameter in CreateL4ProxyRules or ModifyL4ProxyRules. If this parameter is input, it will be ignored. If the returned data of DescribeL4ProxyRules is empty, it indicates that remote authentication is disabled.
        /// </summary>
        [JsonProperty("RemoteAuth")]
        public L4ProxyRemoteAuth RemoteAuth{ get; set; }


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
            this.SetParamSimple(map, prefix + "BuId", this.BuId);
            this.SetParamObj(map, prefix + "RemoteAuth.", this.RemoteAuth);
        }
    }
}

