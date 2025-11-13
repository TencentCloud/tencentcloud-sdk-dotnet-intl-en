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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetAccessible : AbstractModel
    {
        
        /// <summary>
        /// Network connection billing plan. Valid value:
        /// 
        /// <li>TRAFFIC_POSTPAID_BY_HOUR: pay after use. You are billed for your traffic, by the hour. </li>
        /// <li>BANDWIDTH_PACKAGE: Bandwidth package user. </li>
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// The maximum outbound bandwidth of the public network, in Mbps. The default value is 0 Mbps. The upper limit of bandwidth varies for different models. For more information, see [Purchase Network Bandwidth](https://intl.cloud.tencent.com/document/product/213/12523?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Whether to allocate a public IP address. Valid values:<br><li>true: Allocate a public IP address.</li><li>false: Do not allocate a public IP address.</li><br>When the public network bandwidth is greater than 0 Mbps, you can choose whether to enable the public IP address. The public IP address is enabled by default. When the public network bandwidth is 0, allocating the public IP address is not supported. This parameter is only used as an input parameter in the RunInstances API.
        /// </summary>
        [JsonProperty("PublicIpAssigned")]
        public bool? PublicIpAssigned{ get; set; }

        /// <summary>
        /// Bandwidth package ID. it can be obtained through the `BandwidthPackageId` in the return value from the DescribeBandwidthPackages api. this parameter is used as an input parameter only in the RunInstances api.
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// Line type. for details on various types of lines and supported regions, refer to [EIP IP address types](https://cloud.tencent.com/document/product/1199/41646). default value: BGP.
        /// <Li>BGP: specifies the general bgp line.</li>.
        /// For a user with static single-line IP allowlist enabled, valid values include:.
        /// <Li>CMCC: china mobile.</li>.
        /// <Li>CTCC: china telecom</li>.
        /// <Li>CUCC: china unicom</li>.
        /// Note: The static single-line IP is only supported in some regions.
        /// 
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// Specifies the public IP type.
        /// 
        /// <Li>WanIP: specifies the public ip address.</li>.
        /// <Li>HighQualityEIP: specifies a high quality ip. high quality ip is only supported in Singapore and hong kong (china).</li>.
        /// <li> AntiDDoSEIP: specifies the anti-ddos eip. only partial regions support anti-ddos eip. details visible in the [elastic IP product overview](https://www.tencentcloud.comom/document/product/1199/41646?from_cn_redirect=1).</li>.
        /// If needed, assign a public IPv4 address to the resource by specifying the IPv4 address type.
        /// 
        /// This feature is in beta test in selected regions. submit a ticket for consultation (https://console.cloud.tencent.com/workorder/category) if needed.
        /// </summary>
        [JsonProperty("IPv4AddressType")]
        public string IPv4AddressType{ get; set; }

        /// <summary>
        /// Indicates the type of elastic public IPv6.
        /// <Li>EIPv6: elastic ip version 6.</li>.
        /// <Li>HighQualityEIPv6: specifies the high quality ipv6. highqualityeipv6 is only supported in hong kong (china).</li>.
        /// If needed, assign an elastic IPv6 address for resource allocation.
        /// 
        /// This feature is in beta test in selected regions. submit a ticket for consultation (https://console.cloud.tencent.com/workorder/category) if needed.
        /// </summary>
        [JsonProperty("IPv6AddressType")]
        public string IPv6AddressType{ get; set; }

        /// <summary>
        /// DDoS protection package unique ID. this field is required when applying for a ddos protection IP.
        /// </summary>
        [JsonProperty("AntiDDoSPackageId")]
        public string AntiDDoSPackageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "PublicIpAssigned", this.PublicIpAssigned);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "IPv4AddressType", this.IPv4AddressType);
            this.SetParamSimple(map, prefix + "IPv6AddressType", this.IPv6AddressType);
            this.SetParamSimple(map, prefix + "AntiDDoSPackageId", this.AntiDDoSPackageId);
        }
    }
}

