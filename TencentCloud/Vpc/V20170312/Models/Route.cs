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

    public class Route : AbstractModel
    {
        
        /// <summary>
        /// Destination IP range, such as 112.20.51.0/24. Values cannot be in the VPC IP range.
        /// </summary>
        [JsonProperty("DestinationCidrBlock")]
        public string DestinationCidrBlock{ get; set; }

        /// <summary>
        /// Type of the next hop. Currently supported types are:
        /// CVM: CVM of the public gateway type;
        /// VPN: VPN gateway;
        /// DIRECTCONNECT: direct connect gateway;
        /// PEERCONNECTION: peering connection;
        /// SSLVPN: sslvpn gateway;
        /// NAT: NAT gateway; 
        /// NORMAL_CVM: normal CVM;
        /// EIP: public IP address of the CVM;
        /// CCN: Cloud Connect Network.
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// Next hop address. You simply need to specify the gateway ID of a different next hop type, and the system will automatically match the next hop address.
        /// Important note: When the GatewayType is EIP, the GatewayId has a fixed value `0`
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// The ID of the routing policy.
        /// </summary>
        [JsonProperty("RouteId")]
        public ulong? RouteId{ get; set; }

        /// <summary>
        /// The description of the routing policy.
        /// </summary>
        [JsonProperty("RouteDescription")]
        public string RouteDescription{ get; set; }

        /// <summary>
        /// Whether it is enabled
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// The route type. Currently, the following types are supported:
        /// USER: User route;
        /// NETD: Network probe route. When creating a network probe route, the system delivers by default. It cannot be edited or deleted;
        /// CCN: CCN route. The system delivers by default. It cannot be edited or deleted.
        /// Users can only add and operate USER-type routes.
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// Route table instance ID, such as rtb-azd4dt1c.
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DestinationCidrBlock", this.DestinationCidrBlock);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "RouteDescription", this.RouteDescription);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
        }
    }
}

