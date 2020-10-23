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

    public class Subnet : AbstractModel
    {
        
        /// <summary>
        /// The `ID` of the `VPC` instance.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet instance `ID`, such as `subnet-bthucmmy`.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Subnet name.
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// The `IPv4` `CIDR` of the subnet.
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// Whether it is the default subnet.
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// Whether to enable broadcast.
        /// </summary>
        [JsonProperty("EnableBroadcast")]
        public bool? EnableBroadcast{ get; set; }

        /// <summary>
        /// Availability Zone.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// The route table instance ID, such as `rtb-l2h8d7c2`.
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// Creation Time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// The number of available IPv4 addresses
        /// </summary>
        [JsonProperty("AvailableIpAddressCount")]
        public ulong? AvailableIpAddressCount{ get; set; }

        /// <summary>
        /// The `IPv6` `CIDR` of the subnet.
        /// </summary>
        [JsonProperty("Ipv6CidrBlock")]
        public string Ipv6CidrBlock{ get; set; }

        /// <summary>
        /// The associated `ACL`ID
        /// </summary>
        [JsonProperty("NetworkAclId")]
        public string NetworkAclId{ get; set; }

        /// <summary>
        /// Whether it is a `SNAT` address pool subnet.
        /// </summary>
        [JsonProperty("IsRemoteVpcSnat")]
        public bool? IsRemoteVpcSnat{ get; set; }

        /// <summary>
        /// The total number of IPv4 addresses in the subnet.
        /// </summary>
        [JsonProperty("TotalIpAddressCount")]
        public ulong? TotalIpAddressCount{ get; set; }

        /// <summary>
        /// Tag key-value pairs
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "EnableBroadcast", this.EnableBroadcast);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "AvailableIpAddressCount", this.AvailableIpAddressCount);
            this.SetParamSimple(map, prefix + "Ipv6CidrBlock", this.Ipv6CidrBlock);
            this.SetParamSimple(map, prefix + "NetworkAclId", this.NetworkAclId);
            this.SetParamSimple(map, prefix + "IsRemoteVpcSnat", this.IsRemoteVpcSnat);
            this.SetParamSimple(map, prefix + "TotalIpAddressCount", this.TotalIpAddressCount);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

