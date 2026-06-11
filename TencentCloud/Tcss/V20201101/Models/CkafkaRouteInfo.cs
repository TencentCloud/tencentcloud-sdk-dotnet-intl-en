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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CkafkaRouteInfo : AbstractModel
    {
        
        /// <summary>
        /// Routing ID
        /// </summary>
        [JsonProperty("RouteID")]
        public long? RouteID{ get; set; }

        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Domain Port
        /// </summary>
        [JsonProperty("DomainPort")]
        public ulong? DomainPort{ get; set; }

        /// <summary>
        /// Virtual IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Virtual IP Type
        /// </summary>
        [JsonProperty("VipType")]
        public long? VipType{ get; set; }

        /// <summary>
        /// Access type
        /// 0: PLAINTEXT (plaintext mode, no user information included, supported by older versions and community edition)
        /// 	SASL_PLAINTEXT (plaintext mode, however, login authentication with SASL is performed at the start of data transmission, only supported by community version).
        /// 	2: SSL (SSL encrypted communication, no user information included, supported by older versions and community edition)
        /// 	3: SASL_SSL (SSL encrypted communication. Authenticate the login with SASL when data transmission starts. Only supported by community version)
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteID", this.RouteID);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainPort", this.DomainPort);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VipType", this.VipType);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
        }
    }
}

