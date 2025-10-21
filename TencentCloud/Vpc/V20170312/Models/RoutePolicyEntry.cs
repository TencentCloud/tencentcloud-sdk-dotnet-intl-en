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

    public class RoutePolicyEntry : AbstractModel
    {
        
        /// <summary>
        /// Specifies the unique ID of the IPv4 routing strategy entry.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RoutePolicyEntryId")]
        public string RoutePolicyEntryId{ get; set; }

        /// <summary>
        /// Destination ip range.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// Describes the routing strategy rule.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Routing Type
        /// 
        /// Specifies the USER-customized data type.
        /// NETD: specifies the route for network detection.
        /// CCN: CCN route.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// Next hop type. types currently supported:.
        /// CVM: cloud virtual machine with public network gateway type.
        /// VPN: vpn gateway.
        /// DIRECTCONNECT: direct connect gateway.
        /// PEERCONNECTION: peering connection.
        /// HAVIP: high availability virtual ip.
        /// NAT: specifies the nat gateway. 
        /// EIP: specifies the public ip address of the cloud virtual machine.
        /// LOCAL_GATEWAY: specifies the local gateway.
        /// PVGW: pvgw gateway.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// Gateway unique ID.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Priority. a smaller value indicates a higher priority.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// Action.
        /// DROP: drop.
        /// DISABLE: receive and disable.
        /// ACCEPT: receive and enable.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Creation time.
        /// 
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Specifies the region.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoutePolicyEntryId", this.RoutePolicyEntryId);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

