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
        /// Network connection billing plan. Valid value: <br><li>TRAFFIC_POSTPAID_BY_HOUR: pay after use. You are billed for your traffic, by the hour.
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
        /// The EIP line type. 
        ///  <li>BGP Default: BGP</li>
        /// 
        /// For a user who has activated the static single-line IP allowlist, possible values are:
        /// 
        ///  <li>CMCC: China Mobile</li>
        ///  <li>CTCC: China Telecom</li>
        ///  <li>CUCC: China Unicom</li>
        /// 
        /// Note: Only certain regions support static single-line IP addresses.
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// AddressType. Default value: `WanIP`.
        /// 
        /// For beta users of dedicated IP, the value can be:
        /// <li>HighQualityEIP: Dedicated IP</li>
        /// Note that dedicated IPs are only available in partial regions.
        /// 
        /// For beta users of Anti-DDoS IP, the value can be:
        /// <li>AntiDDoSEIP: Anti-DDoS EIP</li>
        /// Note that Anti-DDoS IPs are only available in partial regions.
        /// 
        /// This feature is currently in gradually released phase. To access it, please contact us.
        /// </summary>
        [JsonProperty("IPv4AddressType")]
        public string IPv4AddressType{ get; set; }

        /// <summary>
        /// Indicates the type of EIPv6. Valid values:
        /// 
        /// <li>EIPv6: common IPv6</li>
        /// <li>HighQualityEIPv6: dedicated IPv6</li>
        /// Note: Contact the product team to enable the dedicated IPv6 allowlist. The dedicated IPv6 is only supported in some regions. 
        /// 
        /// Default: `EIPv6`
        /// 
        /// This feature is currently in gradually released phase. To access it, please contact us.
        /// </summary>
        [JsonProperty("IPv6AddressType")]
        public string IPv6AddressType{ get; set; }

        /// <summary>
        /// Anti-DDoS service package ID. This is required when you want to request an Anti-DDoS IP.
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

