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

    public class NatGateway : AbstractModel
    {
        
        /// <summary>
        /// NAT gateway ID.
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// NAT gateway name.
        /// </summary>
        [JsonProperty("NatGatewayName")]
        public string NatGatewayName{ get; set; }

        /// <summary>
        /// NAT gateway creation time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// The status of the NAT gateway.
        ///  `PENDING`: Being created, `DELETING`: Being deleted, `AVAILABLE`: Running, `UPDATING`: Being upgraded,
        /// `FAILED`: Failed.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// The maximum outbound bandwidth of the gateway. Unit: Mbps.
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// The concurrent connections cap of the gateway.
        /// </summary>
        [JsonProperty("MaxConcurrentConnection")]
        public ulong? MaxConcurrentConnection{ get; set; }

        /// <summary>
        /// The public IP object array of the bound NAT gateway.
        /// </summary>
        [JsonProperty("PublicIpAddressSet")]
        public NatGatewayAddress[] PublicIpAddressSet{ get; set; }

        /// <summary>
        /// The NAT gateway status. `AVAILABLE`: Operating, `UNAVAILABLE`: Unavailable, `INSUFFICIENT`: Service suspended due to account overdue.
        /// </summary>
        [JsonProperty("NetworkState")]
        public string NetworkState{ get; set; }

        /// <summary>
        /// The port forwarding rules of the NAT gateway.
        /// </summary>
        [JsonProperty("DestinationIpPortTranslationNatRuleSet")]
        public DestinationIpPortTranslationNatRule[] DestinationIpPortTranslationNatRuleSet{ get; set; }

        /// <summary>
        /// VPC instance ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The availability zone in which the NAT gateway is located.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// ID of the direct connect gateway bound.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DirectConnectGatewayIds")]
        public string[] DirectConnectGatewayIds{ get; set; }

        /// <summary>
        /// Subnet ID.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Tag key-value pairs.
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// The list of the security groups bound to the NAT Gateway
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecurityGroupSet")]
        public string[] SecurityGroupSet{ get; set; }

        /// <summary>
        /// SNAT forwarding rule of the NAT gateway.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceIpTranslationNatRuleSet")]
        public SourceIpTranslationNatRule[] SourceIpTranslationNatRuleSet{ get; set; }

        /// <summary>
        /// Whether the NAT gateway is dedicated.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsExclusive")]
        public bool? IsExclusive{ get; set; }

        /// <summary>
        /// Bandwidth of the gateway cluster where the dedicated NAT Gateway resides. Unit: Mbps. This field does not exist when the `IsExclusive` field is set to `false`.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExclusiveGatewayBandwidth")]
        public ulong? ExclusiveGatewayBandwidth{ get; set; }

        /// <summary>
        /// Whether the NAT gateway is blocked. Values: `NORMAL`, `RESTRICTED`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RestrictState")]
        public string RestrictState{ get; set; }

        /// <summary>
        /// NAT gateway major version. `1`: Classic, `2`: Standard
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NatProductVersion")]
        public ulong? NatProductVersion{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SmartScheduleMode")]
        public bool? SmartScheduleMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "NatGatewayName", this.NatGatewayName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "MaxConcurrentConnection", this.MaxConcurrentConnection);
            this.SetParamArrayObj(map, prefix + "PublicIpAddressSet.", this.PublicIpAddressSet);
            this.SetParamSimple(map, prefix + "NetworkState", this.NetworkState);
            this.SetParamArrayObj(map, prefix + "DestinationIpPortTranslationNatRuleSet.", this.DestinationIpPortTranslationNatRuleSet);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "DirectConnectGatewayIds.", this.DirectConnectGatewayIds);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamArraySimple(map, prefix + "SecurityGroupSet.", this.SecurityGroupSet);
            this.SetParamArrayObj(map, prefix + "SourceIpTranslationNatRuleSet.", this.SourceIpTranslationNatRuleSet);
            this.SetParamSimple(map, prefix + "IsExclusive", this.IsExclusive);
            this.SetParamSimple(map, prefix + "ExclusiveGatewayBandwidth", this.ExclusiveGatewayBandwidth);
            this.SetParamSimple(map, prefix + "RestrictState", this.RestrictState);
            this.SetParamSimple(map, prefix + "NatProductVersion", this.NatProductVersion);
            this.SetParamSimple(map, prefix + "SmartScheduleMode", this.SmartScheduleMode);
        }
    }
}

