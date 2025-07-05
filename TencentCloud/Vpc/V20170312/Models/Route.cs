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
        /// Type of the next hop. Valid values:
        /// `CVM`: public gateway CVM;
        /// `VPN`: VPN gateway;
        /// `DIRECTCONNECT`: direct connect gateway;
        /// `PEERCONNECTION`: peering connection;
        /// `HAVIP`: HAVIP;
        /// `NAT`: NAT Gateway; 
        /// `NORMAL_CVM`: normal CVM;
        /// `EIP`: public IP address of the CVM;
        /// `LOCAL_GATEWAY`: local gateway.
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// Next hop address. You simply need to specify the gateway ID of a different next hop type, and the system will automatically match the next hop address. 
        /// Note: If `GatewayType` is set to `NORMAL_CVM`, `GatewayId` should be the private IP of the instance.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Routing policy ID. The IPv4 routing policy will have a meaningful value, while the IPv6 routing policy is always 0. We recommend using the unique ID `RouteItemId` for the routing policy.
        /// This field is required when you want to delete a routing policy.
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
        /// Destination IPv6 IP range, which cannot be included in VPC IP range, such as 2402:4e00:1000:810b::/64.
        /// </summary>
        [JsonProperty("DestinationIpv6CidrBlock")]
        public string DestinationIpv6CidrBlock{ get; set; }

        /// <summary>
        /// Unique routing policy ID.
        /// </summary>
        [JsonProperty("RouteItemId")]
        public string RouteItemId{ get; set; }

        /// <summary>
        /// Whether the routing policy is published to CCN.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublishedToVbc")]
        public bool? PublishedToVbc{ get; set; }

        /// <summary>
        /// Creation time of the routing policy
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DestinationCidrBlock", this.DestinationCidrBlock);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "RouteDescription", this.RouteDescription);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamSimple(map, prefix + "DestinationIpv6CidrBlock", this.DestinationIpv6CidrBlock);
            this.SetParamSimple(map, prefix + "RouteItemId", this.RouteItemId);
            this.SetParamSimple(map, prefix + "PublishedToVbc", this.PublishedToVbc);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

