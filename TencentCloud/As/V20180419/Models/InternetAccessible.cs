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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetAccessible : AbstractModel
    {
        
        /// <summary>
        /// Network billing type. Valid values: <li>BANDWIDTH_PREPAID: prepaid by bandwidth;</li> <li>TRAFFIC_POSTPAID_BY_HOUR: postpaid by traffic per hour;</li> <li>BANDWIDTH_POSTPAID_BY_HOUR: postpaid by bandwidth per hour;</li> <li>BANDWIDTH_PACKAGE: bandwidth package users.</li> Default value: TRAFFIC_POSTPAID_BY_HOUR.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// The maximum outbound bandwidth in Mbps of the public network. The default value is 0 Mbps. The upper limit of bandwidth varies by model. For more information, see [Purchase Network Bandwidth](https://intl.cloud.tencent.com/document/product/213/509?from_cn_redirect=1).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Whether to assign a public IP address. Valid values: <li>TRUE: Allocate a public IP address.</li> <li>FALSE: Do not allocate a public IP address.</li> When the public network bandwidth is greater than 0 Mbps, you can choose whether to enable this feature based on your needs. By default, this feature is enabled. When the public network bandwidth is 0, public IP address assignment is not allowed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicIpAssigned")]
        public bool? PublicIpAssigned{ get; set; }

        /// <summary>
        /// Bandwidth package ID. You can obtain the ID from the `BandwidthPackageId` field in the response of the [DescribeBandwidthPackages](https://intl.cloud.tencent.com/document/api/215/19209?from_cn_redirect=1) API.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// Describes the line type. For details, refer to [EIP Product Overview](https://intl.cloud.tencent.com/document/product/1199/41646?from_cn_redirect=1). default value: `BGP`.
        /// 
        /// <Li>BGP: general bgp line.</li>
        /// For a user who has enabled the static single-line IP allowlist, valid values include:
        ///  <li>CMCC: China Mobile</li> <li>CTCC: China Telecom</li> <li>CUCC: China Unicom</li>
        /// Note: Only certain regions support static single-line IP addresses.
        /// 
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// Type of public IP address.
        /// 
        /// <li> WanIP: Ordinary public IP address. </li> <li> HighQualityEIP: High Quality EIP is supported only in Singapore and Hong Kong. </li> <li> AntiDDoSEIP: Anti-DDoS IP is supported only in specific regions. For details, see [EIP Product Overview](https://cloud.tencent.com/document/product/1199/41646). </li> Specify the type of public IPv4 address to assign a public IPv4 address to the resource. Premium IP and Anti-DDoS IP features are gradually released in select regions. For usage, [submit a ticket for consultation](https://console.cloud.tencent.com/workorder/category).
        /// </summary>
        [JsonProperty("IPv4AddressType")]
        public string IPv4AddressType{ get; set; }

        /// <summary>
        /// Anti-DDoS service package ID. This is required when you want to request an Anti-DDoS IP.
        /// </summary>
        [JsonProperty("AntiDDoSPackageId")]
        public string AntiDDoSPackageId{ get; set; }

        /// <summary>
        /// Whether to delete the bound EIP when the instance is destroyed.
        /// 
        /// Range of values:
        /// 
        /// <li>TRUE: retain the EIP</li> <li>FALSE: not retain the EIP</li>
        /// 
        /// Note that when the IPv4AddressType field specifies the EIP type, the default behavior is not to retain the EIP. 
        /// WanIP is unaffected by this field and will always be deleted with the instance. 
        /// Changing this field configuration will take effect immediately for resources already bound to a scaling group.
        /// </summary>
        [JsonProperty("IsKeepEIP")]
        public bool? IsKeepEIP{ get; set; }


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
            this.SetParamSimple(map, prefix + "AntiDDoSPackageId", this.AntiDDoSPackageId);
            this.SetParamSimple(map, prefix + "IsKeepEIP", this.IsKeepEIP);
        }
    }
}

