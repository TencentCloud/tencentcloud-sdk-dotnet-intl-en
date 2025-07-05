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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Layer4Rule : AbstractModel
    {
        
        /// <summary>
        /// Real server port. Value range: 1–65535.
        /// </summary>
        [JsonProperty("BackendPort")]
        public ulong? BackendPort{ get; set; }

        /// <summary>
        /// Forwarding port. Value range: 1–65535.
        /// </summary>
        [JsonProperty("FrontendPort")]
        public ulong? FrontendPort{ get; set; }

        /// <summary>
        /// Forwarding rule. Valid values:
        /// TCP
        /// UDP
        /// ]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// List of real servers
        /// </summary>
        [JsonProperty("RealServers")]
        public SourceServer[] RealServers{ get; set; }

        /// <summary>
        /// Information of the Anti-DDoS instance
        /// </summary>
        [JsonProperty("InstanceDetails")]
        public InstanceRelation[] InstanceDetails{ get; set; }

        /// <summary>
        /// Information of the Anti-DDoS instance configured
        /// </summary>
        [JsonProperty("InstanceDetailRule")]
        public RuleInstanceRelation[] InstanceDetailRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackendPort", this.BackendPort);
            this.SetParamSimple(map, prefix + "FrontendPort", this.FrontendPort);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "RealServers.", this.RealServers);
            this.SetParamArrayObj(map, prefix + "InstanceDetails.", this.InstanceDetails);
            this.SetParamArrayObj(map, prefix + "InstanceDetailRule.", this.InstanceDetailRule);
        }
    }
}

