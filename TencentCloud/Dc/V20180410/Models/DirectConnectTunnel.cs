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

    public class DirectConnectTunnel : AbstractModel
    {
        
        /// <summary>
        /// Dedicated tunnel ID
        /// </summary>
        [JsonProperty("DirectConnectTunnelId")]
        public string DirectConnectTunnelId{ get; set; }

        /// <summary>
        /// Connection ID.
        /// </summary>
        [JsonProperty("DirectConnectId")]
        public string DirectConnectId{ get; set; }

        /// <summary>
        /// Dedicated tunnel status
        /// AVAILABLE: ready or connected
        /// PENDING: applying
        /// ALLOCATING: configuring
        /// ALLOCATED: configured
        /// ALTERING: modifying
        /// DELETING: deleting
        /// DELETED: deleted
        /// CONFIRMING: to be accepted
        /// REJECTED: rejected
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Connection owner, i.e., developer account ID.
        /// </summary>
        [JsonProperty("DirectConnectOwnerAccount")]
        public string DirectConnectOwnerAccount{ get; set; }

        /// <summary>
        /// Dedicated tunnel owner, i.e., developer account ID
        /// </summary>
        [JsonProperty("OwnerAccount")]
        public string OwnerAccount{ get; set; }

        /// <summary>
        /// Network type. Valid values: VPC, BMVPC, CCN.
        ///  VPC: Virtual Private Cloud; BMVPC: BM VPC; CCN: Cloud Connect Network.
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// Network of the VPC region, such as `ap-guangzhou`.
        /// </summary>
        [JsonProperty("NetworkRegion")]
        public string NetworkRegion{ get; set; }

        /// <summary>
        /// Unified VPC ID or BMVPC ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Direct connect gateway ID.
        /// </summary>
        [JsonProperty("DirectConnectGatewayId")]
        public string DirectConnectGatewayId{ get; set; }

        /// <summary>
        /// BGP: BGP routing; STATIC: Static routing. Default value: BGP routing.
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// User-side BGP, including Asn and AuthKey.
        /// </summary>
        [JsonProperty("BgpPeer")]
        public BgpPeer BgpPeer{ get; set; }

        /// <summary>
        /// User-side IP range.
        /// </summary>
        [JsonProperty("RouteFilterPrefixes")]
        public RouteFilterPrefix[] RouteFilterPrefixes{ get; set; }

        /// <summary>
        /// Dedicated tunnel `Vlan`
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
        /// Dedicated tunnel name
        /// </summary>
        [JsonProperty("DirectConnectTunnelName")]
        public string DirectConnectTunnelName{ get; set; }

        /// <summary>
        /// Dedicated tunnel creation time
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Dedicated tunnel bandwidth value
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Dedicated tunnel tag value
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// Associated custom network probe ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetDetectId")]
        public string NetDetectId{ get; set; }

        /// <summary>
        /// BGP community switch
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableBGPCommunity")]
        public bool? EnableBGPCommunity{ get; set; }

        /// <summary>
        /// Whether it is a NAT tunnel
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NatType")]
        public long? NatType{ get; set; }

        /// <summary>
        /// VPC region abbreviation, such as `gz`, `cd`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcRegion")]
        public string VpcRegion{ get; set; }

        /// <summary>
        /// Whether to enable BFD
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BfdEnable")]
        public long? BfdEnable{ get; set; }

        /// <summary>
        /// Dedicated tunnel access point type
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccessPointType")]
        public string AccessPointType{ get; set; }

        /// <summary>
        /// Direct connect gateway name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DirectConnectGatewayName")]
        public string DirectConnectGatewayName{ get; set; }

        /// <summary>
        /// VPC name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// TencentBackupAddress, i.e., Tencent-side standby IP address
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TencentBackupAddress")]
        public string TencentBackupAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectTunnelId", this.DirectConnectTunnelId);
            this.SetParamSimple(map, prefix + "DirectConnectId", this.DirectConnectId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "DirectConnectOwnerAccount", this.DirectConnectOwnerAccount);
            this.SetParamSimple(map, prefix + "OwnerAccount", this.OwnerAccount);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "NetworkRegion", this.NetworkRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayId", this.DirectConnectGatewayId);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamObj(map, prefix + "BgpPeer.", this.BgpPeer);
            this.SetParamArrayObj(map, prefix + "RouteFilterPrefixes.", this.RouteFilterPrefixes);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "DirectConnectTunnelName", this.DirectConnectTunnelName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "NetDetectId", this.NetDetectId);
            this.SetParamSimple(map, prefix + "EnableBGPCommunity", this.EnableBGPCommunity);
            this.SetParamSimple(map, prefix + "NatType", this.NatType);
            this.SetParamSimple(map, prefix + "VpcRegion", this.VpcRegion);
            this.SetParamSimple(map, prefix + "BfdEnable", this.BfdEnable);
            this.SetParamSimple(map, prefix + "AccessPointType", this.AccessPointType);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayName", this.DirectConnectGatewayName);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "TencentBackupAddress", this.TencentBackupAddress);
        }
    }
}

