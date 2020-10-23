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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssociateNatGatewayAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// The ID of the NAT gateway, such as `nat-df45454`.
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// The number of EIPs you want to apply for. The system will create the same number of EIPs as you require. Either `AddressCount` or `PublicAddresses` must be passed in.
        /// </summary>
        [JsonProperty("AddressCount")]
        public ulong? AddressCount{ get; set; }

        /// <summary>
        /// Array of the EIPs bound to the NAT gateway. Either `AddressCount` or `PublicAddresses` must be passed in.
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// The availability zone of the EIP, which is passed in when the EIP is automatically assigned.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "AddressCount", this.AddressCount);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
        }
    }
}

