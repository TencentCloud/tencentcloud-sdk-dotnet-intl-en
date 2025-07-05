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

    public class CreateNatGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// NAT gateway name
        /// </summary>
        [JsonProperty("NatGatewayName")]
        public string NatGatewayName{ get; set; }

        /// <summary>
        /// The ID of the VPC instance, which can be obtained from the `VpcId` field in response of the `DescribeVpcs` API.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The maximum outbound bandwidth of the NAT gateway (unit: Mbps). Supported parameter values: `20, 50, 100, 200, 500, 1000, 2000, 5000`. Default: `100`.
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// The concurrent connection cap of the NAT gateway. Values: `1000000, 3000000, 10000000`. The default value is `1000000`.
        /// </summary>
        [JsonProperty("MaxConcurrentConnection")]
        public ulong? MaxConcurrentConnection{ get; set; }

        /// <summary>
        /// The number of EIPs that you want to apply for. Either `AddressCount` or `PublicIpAddresses` must be passed in.
        /// </summary>
        [JsonProperty("AddressCount")]
        public ulong? AddressCount{ get; set; }

        /// <summary>
        /// The EIP array bound to the NAT gateway. Either AddressCount or PublicIpAddresses must be passed in.
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// The availability zone, such as `ap-guangzhou-1`.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Bound tags, such as [{"Key": "city", "Value": "shanghai"}]
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Subnet of the NAT gateway
        /// </summary>
        [JsonProperty("SubnetId")]
        [System.Obsolete]
        public string SubnetId{ get; set; }

        /// <summary>
        /// The bandwidth size (in Mbps) of the EIP bound to the NAT gateway, which defaults to the maximum value applicable for the current user type.
        /// </summary>
        [JsonProperty("StockPublicIpAddressesBandwidthOut")]
        public ulong? StockPublicIpAddressesBandwidthOut{ get; set; }

        /// <summary>
        /// The size of the public network IP bandwidth to be applied for (in Mbps), which defaults to the maximum value applicable for the current user type.
        /// </summary>
        [JsonProperty("PublicIpAddressesBandwidthOut")]
        public ulong? PublicIpAddressesBandwidthOut{ get; set; }

        /// <summary>
        /// Whether the public IP and the NAT gateway must be in the same availability zone. Valid values: `true` and `false`. This parameter is valid only when `Zone` is specified.
        /// </summary>
        [JsonProperty("PublicIpFromSameZone")]
        public bool? PublicIpFromSameZone{ get; set; }

        /// <summary>
        /// NAT gateway major version. `1`: Classic, `2`: Standard
        /// </summary>
        [JsonProperty("NatProductVersion")]
        public ulong? NatProductVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayName", this.NatGatewayName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "MaxConcurrentConnection", this.MaxConcurrentConnection);
            this.SetParamSimple(map, prefix + "AddressCount", this.AddressCount);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "StockPublicIpAddressesBandwidthOut", this.StockPublicIpAddressesBandwidthOut);
            this.SetParamSimple(map, prefix + "PublicIpAddressesBandwidthOut", this.PublicIpAddressesBandwidthOut);
            this.SetParamSimple(map, prefix + "PublicIpFromSameZone", this.PublicIpFromSameZone);
            this.SetParamSimple(map, prefix + "NatProductVersion", this.NatProductVersion);
        }
    }
}

