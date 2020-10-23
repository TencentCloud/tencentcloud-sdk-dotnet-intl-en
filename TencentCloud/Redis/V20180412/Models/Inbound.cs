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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Inbound : AbstractModel
    {
        
        /// <summary>
        /// Policy. Valid values: ACCEPT, DROP.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// All the addresses that the address group ID represents.
        /// </summary>
        [JsonProperty("AddressModule")]
        public string AddressModule{ get; set; }

        /// <summary>
        /// Source IP or IP address range, such as 192.168.0.0/16.
        /// </summary>
        [JsonProperty("CidrIp")]
        public string CidrIp{ get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Network protocol, such as UDP and TCP, etc.
        /// </summary>
        [JsonProperty("IpProtocol")]
        public string IpProtocol{ get; set; }

        /// <summary>
        /// Port.
        /// </summary>
        [JsonProperty("PortRange")]
        public string PortRange{ get; set; }

        /// <summary>
        /// All the protocols and ports that the service group ID represents.
        /// </summary>
        [JsonProperty("ServiceModule")]
        public string ServiceModule{ get; set; }

        /// <summary>
        /// All the addresses that the security group ID represents.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "AddressModule", this.AddressModule);
            this.SetParamSimple(map, prefix + "CidrIp", this.CidrIp);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "IpProtocol", this.IpProtocol);
            this.SetParamSimple(map, prefix + "PortRange", this.PortRange);
            this.SetParamSimple(map, prefix + "ServiceModule", this.ServiceModule);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

