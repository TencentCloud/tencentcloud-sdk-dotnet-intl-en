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

    public class IPv6InternetAccessible : AbstractModel
    {
        
        /// <summary>
        /// Network billing mode. Values include TRAFFIC_POSTPAID_BY_HOUR and BANDWIDTH_PACKAGE. Default value: TRAFFIC_POSTPAID_BY_HOUR. To view the current account type, see Account Type Description (https://www.tencentcloud.com/document/product/1199/49090?from_cn_redirect=1#judge).
        /// <br><li> IPv6 supports TRAFFIC_POSTPAID_BY_HOUR for standard account type.
        /// <br><li> IPv6 supports BANDWIDTH_PACKAGE for classic account type.
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// Public network outbound bandwidth cap, unit: Mbps.<br>Default value: 0. At this point, no public network bandwidth is allocated to IPv6. The bandwidth cap range varies by model, availability zone, and billing mode. For specific limitations, see [Public Network Bandwidth Limit](https://www.tencentcloud.com/document/product/213/12523?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Bandwidth package ID, which can be obtained from the `BandwidthPackageId` in the return value from the [DescribeBandwidthPackages](https://www.tencentcloud.com/document/api/215/19209?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
        }
    }
}

