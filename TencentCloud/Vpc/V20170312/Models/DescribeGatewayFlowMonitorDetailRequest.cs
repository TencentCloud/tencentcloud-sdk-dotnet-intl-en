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

    public class DescribeGatewayFlowMonitorDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// The point in time. This indicates details of this minute will be queried. For example, in `2019-02-28 18:15:20`, details at `18:15` will be queried.
        /// </summary>
        [JsonProperty("TimePoint")]
        public string TimePoint{ get; set; }

        /// <summary>
        /// The instance ID of the VPN gateway, such as `vpn-ltjahce6`.
        /// </summary>
        [JsonProperty("VpnId")]
        public string VpnId{ get; set; }

        /// <summary>
        /// The instance ID of the Direct Connect gateway, such as `dcg-ltjahce6`.
        /// </summary>
        [JsonProperty("DirectConnectGatewayId")]
        public string DirectConnectGatewayId{ get; set; }

        /// <summary>
        /// The instance ID of the peering connection, such as `pcx-ltjahce6`.
        /// </summary>
        [JsonProperty("PeeringConnectionId")]
        public string PeeringConnectionId{ get; set; }

        /// <summary>
        /// The instance ID of the NAT gateway, such as `nat-ltjahce6`.
        /// </summary>
        [JsonProperty("NatId")]
        public string NatId{ get; set; }

        /// <summary>
        /// Offset.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The returned quantity.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// The order field supports `InPkg`, `OutPkg`, `InTraffic`, and `OutTraffic`.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Order methods. Ascending: `ASC`, Descending: `DESC`.
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimePoint", this.TimePoint);
            this.SetParamSimple(map, prefix + "VpnId", this.VpnId);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayId", this.DirectConnectGatewayId);
            this.SetParamSimple(map, prefix + "PeeringConnectionId", this.PeeringConnectionId);
            this.SetParamSimple(map, prefix + "NatId", this.NatId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

