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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDirectConnectTunnelRequest : AbstractModel
    {
        
        /// <summary>
        /// Direct Connect ID, such as `dc-kd7d06of`.
        /// </summary>
        [JsonProperty("DirectConnectId")]
        public string DirectConnectId{ get; set; }

        /// <summary>
        /// Dedicated tunnel name.
        /// </summary>
        [JsonProperty("DirectConnectTunnelName")]
        public string DirectConnectTunnelName{ get; set; }

        /// <summary>
        /// Connection owner, who is the current customer by default.
        /// The developer account ID should be entered for shared connections.
        /// </summary>
        [JsonProperty("DirectConnectOwnerAccount")]
        public string DirectConnectOwnerAccount{ get; set; }

        /// <summary>
        /// Network type. Valid values: VPC, BMVPC, CCN. Default value: VPC.
        /// VPC: Virtual Private Cloud.
        /// BMVPC: BM VPC.
        /// CCN: Cloud Connect Network.
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// Network region.
        /// </summary>
        [JsonProperty("NetworkRegion")]
        public string NetworkRegion{ get; set; }

        /// <summary>
        /// Unified VPC ID or BMVPC ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Direct connect gateway ID, such as `dcg-d545ddf`.
        /// </summary>
        [JsonProperty("DirectConnectGatewayId")]
        public string DirectConnectGatewayId{ get; set; }

        /// <summary>
        /// Direct Connect bandwidth in Mbps.
        /// Default value: connection bandwidth value.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// BGP: BGP routing.
        /// STATIC: Static routing.
        /// Default value: BGP routing.
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// BgpPeer, which is BGP information on the user side and includes Asn and AuthKey.
        /// </summary>
        [JsonProperty("BgpPeer")]
        public BgpPeer BgpPeer{ get; set; }

        /// <summary>
        /// Static routing, i.e., IP range of the user's IDC.
        /// </summary>
        [JsonProperty("RouteFilterPrefixes")]
        public RouteFilterPrefix[] RouteFilterPrefixes{ get; set; }

        /// <summary>
        /// VLAN. Value range: 0-3,000.
        /// 0: sub-interface not enabled.
        /// Default value: Non-zero.
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// TencentAddress: Tencent-side IP address.
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// CustomerAddress: User-side IP address.
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// TencentBackupAddress, i.e., Tencent-side standby IP address
        /// </summary>
        [JsonProperty("TencentBackupAddress")]
        public string TencentBackupAddress{ get; set; }

        /// <summary>
        /// Cloud Attached Connection Service ID
        /// </summary>
        [JsonProperty("CloudAttachId")]
        public string CloudAttachId{ get; set; }

        /// <summary>
        /// Whether to enable BFD
        /// </summary>
        [JsonProperty("BfdEnable")]
        public long? BfdEnable{ get; set; }

        /// <summary>
        /// Whether to enable NQA
        /// </summary>
        [JsonProperty("NqaEnable")]
        public long? NqaEnable{ get; set; }

        /// <summary>
        /// BFD configuration information
        /// </summary>
        [JsonProperty("BfdInfo")]
        public BFDInfo BfdInfo{ get; set; }

        /// <summary>
        /// NQA configuration information
        /// </summary>
        [JsonProperty("NqaInfo")]
        public NQAInfo NqaInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectId", this.DirectConnectId);
            this.SetParamSimple(map, prefix + "DirectConnectTunnelName", this.DirectConnectTunnelName);
            this.SetParamSimple(map, prefix + "DirectConnectOwnerAccount", this.DirectConnectOwnerAccount);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "NetworkRegion", this.NetworkRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayId", this.DirectConnectGatewayId);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamObj(map, prefix + "BgpPeer.", this.BgpPeer);
            this.SetParamArrayObj(map, prefix + "RouteFilterPrefixes.", this.RouteFilterPrefixes);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "TencentBackupAddress", this.TencentBackupAddress);
            this.SetParamSimple(map, prefix + "CloudAttachId", this.CloudAttachId);
            this.SetParamSimple(map, prefix + "BfdEnable", this.BfdEnable);
            this.SetParamSimple(map, prefix + "NqaEnable", this.NqaEnable);
            this.SetParamObj(map, prefix + "BfdInfo.", this.BfdInfo);
            this.SetParamObj(map, prefix + "NqaInfo.", this.NqaInfo);
        }
    }
}

