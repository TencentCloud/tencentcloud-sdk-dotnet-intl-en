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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupBound : AbstractModel
    {
        
        /// <summary>
        /// Execution policy.
        /// - ACCEPT: allow. Access requests for the port can be released.
        /// - DROP: reject. Data packets are discarded without any response.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Inbound IP address or IP range for database access.
        /// </summary>
        [JsonProperty("CidrIp")]
        public string CidrIp{ get; set; }

        /// <summary>
        /// Port for database access.
        /// </summary>
        [JsonProperty("PortRange")]
        public string PortRange{ get; set; }

        /// <summary>
        /// Transport layer protocol: TCP.
        /// </summary>
        [JsonProperty("IpProtocol")]
        public string IpProtocol{ get; set; }

        /// <summary>
        /// Security group ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Parameter template ID for the IP address or IP address group. Log in to the [parameter template console](https://console.cloud.tencent.com/vpc/template/ip) to obtain the parameter template IP address details.
        /// </summary>
        [JsonProperty("AddressModule")]
        public string AddressModule{ get; set; }

        /// <summary>
        /// Parameter template ID for the protocol port or protocol port group. Log in to the [parameter template console](https://console.cloud.tencent.com/vpc/template/protoport) to obtain the parameter template protocol port details.
        /// </summary>
        [JsonProperty("ServiceModule")]
        public string ServiceModule{ get; set; }

        /// <summary>
        /// Security group description information.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "CidrIp", this.CidrIp);
            this.SetParamSimple(map, prefix + "PortRange", this.PortRange);
            this.SetParamSimple(map, prefix + "IpProtocol", this.IpProtocol);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AddressModule", this.AddressModule);
            this.SetParamSimple(map, prefix + "ServiceModule", this.ServiceModule);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
        }
    }
}

