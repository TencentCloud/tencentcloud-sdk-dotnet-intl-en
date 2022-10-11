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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRuleAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Forwarding rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// The strategy used by the listener to access the origin server. Values: `rr` (round-robin), `wrr` (weighted round-robin), `lc` (the least-connections strategy), `lrtt` (the least-response-time strategy).
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// Whether to enable the origin server health check:
        /// 1: enable;
        /// 0: disable.
        /// </summary>
        [JsonProperty("HealthCheck")]
        public ulong? HealthCheck{ get; set; }

        /// <summary>
        /// Health check configuration parameters
        /// </summary>
        [JsonProperty("CheckParams")]
        public RuleCheckParams CheckParams{ get; set; }

        /// <summary>
        /// Forwarding rule path
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Protocol types of the forwarding from acceleration connection to origin server, which supports default, HTTP and HTTPS.
        /// If `ForwardProtocol=default`, the `ForwardProtocol` of the listener will be used.
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// The forwarding host, which is carried in the request forwarded from the acceleration connection to the origin server.
        /// If `ForwardHost=default`, the domain name configured with the forwarding rule will be used. For other cases, the value set in this field will be used.
        /// </summary>
        [JsonProperty("ForwardHost")]
        public string ForwardHost{ get; set; }

        /// <summary>
        /// Specifies whether to enable Server Name Indication (SNI). Valid values: `ON` (enable) and `OFF` (disable).
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
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "HealthCheck", this.HealthCheck);
            this.SetParamObj(map, prefix + "CheckParams.", this.CheckParams);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "ForwardHost", this.ForwardHost);
            this.SetParamSimple(map, prefix + "ServerNameIndicationSwitch", this.ServerNameIndicationSwitch);
            this.SetParamSimple(map, prefix + "ServerNameIndication", this.ServerNameIndication);
            this.SetParamSimple(map, prefix + "ForcedRedirect", this.ForcedRedirect);
        }
    }
}

