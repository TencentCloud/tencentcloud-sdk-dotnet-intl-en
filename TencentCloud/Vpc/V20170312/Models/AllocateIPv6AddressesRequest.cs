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

    public class AllocateIPv6AddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// EIPv6 name, which is the custom EIPv6 name given by the user when the user applies for the EIPv6. Default: not named.
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// Indicates the type of EIPv6. Valid values:
        /// 
        /// - EIPv6: common IPv6
        /// - HighQualityEIPv6: dedicated IPv6
        /// Note: Contact the product team to enable the dedicated IPv6 allowlist. The dedicated IPv6 is only supported in some regions.
        /// 
        /// Default: EIPv6.
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Number of applied EIPv6 addresses. Default: 1.
        /// </summary>
        [JsonProperty("AddressCount")]
        public long? AddressCount{ get; set; }

        /// <summary>
        /// Indicates the billing method of EIPv6. Valid values:
        /// 
        /// - BANDWIDTH_PACKAGE: billed by [Bandwidth Package](https://intl.cloud.tencent.com/document/product/684/15255?from_cn_redirect=1)
        /// - TRAFFIC_POSTPAID_BY_HOUR: postpaid by traffic on an hourly basis
        /// 
        /// Default: TRAFFIC_POSTPAID_BY_HOUR.
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// Indicates the type of EIPv6 line. Default: BGP.
        /// 
        /// For a user who has enabled the static single-line IP allowlist, valid values include:
        /// - CMCC: China Mobile
        /// - CTCC: China Telecom
        /// - CUCC: China Unicom
        /// Note: The static single-line IP is only supported in some regions.
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// EIPv6 bandwidth cap, in Mbps.
        /// 
        /// Valid values depend on the EIP billing method:
        /// 
        /// - BANDWIDTH_PACKAGE: 1 Mbps to 2000 Mbps
        /// - TRAFFIC_POSTPAID_BY_HOUR: 1 Mbps to 100 Mbps
        /// 
        /// Default: 1 Mbps.
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Unique ID of the bandwidth package.
        /// Setting this parameter and having InternetChargeType as BANDWIDTH_PACKAGE indicate that the created EIP will join this BGP bandwidth package and the billing method of bandwidth package will be adopted.
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// List of tags to be associated.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// EIPv6 network egress. Valid values:
        /// 
        /// - CENTER_EGRESS_1: Central egress point 1
        /// - CENTER_EGRESS_2: Central egress point 2
        /// - CENTER_EGRESS_3: Central egress point 3
        /// Note: The network egress for different Internet Service Providers (ISPs) or resource types requires contacting the product team for enablement.
        /// 
        /// Default: CENTER_EGRESS_1.
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressName", this.AddressName);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "AddressCount", this.AddressCount);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
        }
    }
}

