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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Layer-7 listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Domain name of the forwarding rule
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Path of the forwarding rule
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// The origin server type of the forwarding rule, which supports IP and DOMAIN types.
        /// </summary>
        [JsonProperty("RealServerType")]
        public string RealServerType{ get; set; }

        /// <summary>
        /// The strategy used by the listener to access the origin server. Values: `rr` (round-robin), `wrr` (weighted round-robin), `lc` (the least-connections strategy).
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// Whether the health check is enabled for rules. 1: enabled; 0: disabled.
        /// </summary>
        [JsonProperty("HealthCheck")]
        public ulong? HealthCheck{ get; set; }

        /// <summary>
        /// Parameters related to origin server health check
        /// </summary>
        [JsonProperty("CheckParams")]
        public RuleCheckParams CheckParams{ get; set; }

        /// <summary>
        /// Protocol types of the forwarding from acceleration connection to origin server, which supports HTTP or HTTPS.
        /// If this field is not passed in, it indicates that the ForwardProtocol of the corresponding listener will be used.
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// The host to which the acceleration connection forwards. If this parameter is not specified, the default host will be used, i.e., the host with which the client initiates HTTP requests.
        /// </summary>
        [JsonProperty("ForwardHost")]
        public string ForwardHost{ get; set; }

        /// <summary>
        /// Whether to enable SNI. Values: `on` (enable), `off` (disable). For creation of HTTP listener forwarding rules, SNI is disabled by default.
        /// </summary>
        [JsonProperty("ServerNameIndicationSwitch")]
        public string ServerNameIndicationSwitch{ get; set; }

        /// <summary>
        /// Server Name Indication (SNI). This field is required when `ServerNameIndicationSwitch` is `ON`.
        /// </summary>
        [JsonProperty("ServerNameIndication")]
        public string ServerNameIndication{ get; set; }

        /// <summary>
        /// Enables HTTP-to-HTTPS force redirect for a forwarding rule. Enter a hostname and path of the current forwarding rule.
        /// </summary>
        [JsonProperty("ForcedRedirect")]
        public string ForcedRedirect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "RealServerType", this.RealServerType);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "HealthCheck", this.HealthCheck);
            this.SetParamObj(map, prefix + "CheckParams.", this.CheckParams);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "ForwardHost", this.ForwardHost);
            this.SetParamSimple(map, prefix + "ServerNameIndicationSwitch", this.ServerNameIndicationSwitch);
            this.SetParamSimple(map, prefix + "ServerNameIndication", this.ServerNameIndication);
            this.SetParamSimple(map, prefix + "ForcedRedirect", this.ForcedRedirect);
        }
    }
}

