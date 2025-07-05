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

    public class InquiryPriceAllocateAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// EIP billing method.
        /// 
        /// <ul style="margin:0"><li>Users with standard account type. Valid values: <ul>
        /// <li>BANDWIDTH_POSTPAID_BY_HOUR: billed by hourly bandwidth on a pay-as-you-go basis.</li>
        /// <li>BANDWIDTH_PREPAID_BY_MONTH: monthly bandwidth subscription.</li>
        /// <li>TRAFFIC_POSTPAID_BY_HOUR: billed by hourly traffic on a pay-as-you-go basis.</li></ul>Default value: TRAFFIC_POSTPAID_BY_HOUR.</li>
        /// </ul>
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// The EIP outbound bandwidth cap, in Mbps.
        /// <ul style="margin:0"><li>For users with standard account type, the range of optional values depends on the EIP billing method:<ul>
        /// <li>`BANDWIDTH_POSTPAID_BY_HOUR`: 1 Mbps to 100 Mbps.</li>
        /// <li>`BANDWIDTH_PREPAID_BY_MONTH`: 1 Mbps to 200 Mbps</li>
        /// <li>`TRAFFIC_POSTPAID_BY_HOUR`: 1 Mbps to 100 Mbps.</li></ul>Default value: 1 Mbps.</li></ul>
        /// <li>For users with traditional account type, the EIP outbound bandwidth cap is subject to the public network egress bandwidth limit of the bound instance. No need to pass this parameter.</li></ul>
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// A required billing parameter for an EIP billed by "BANDWIDTH_PREPAID_BY_MONTH". When the EIP is billed by "BANDWIDTH_PREPAID_BY_MONTH" this parameter is required. For other scenarios, it can be ignored.
        /// </summary>
        [JsonProperty("AddressChargePrepaid")]
        public AddressChargePrepaid AddressChargePrepaid{ get; set; }

        /// <summary>
        /// EIP type. Default value: EIP.
        /// 
        /// 
        /// 
        /// <ul style="margin:0"><li>High quality EIP, valid values: <ul><li>HighQualityEIP: high quality EIP</li></ul>Note: High quality EIP is supported only in some regions.</li></ul><ul style="margin:0">
        ///         <li>High-defense IP, valid values: <ul>
        ///                 <li>AntiDDoSEIP: high-defense IP</li>
        ///             </ul>
        ///         </li>
        ///     </ul>
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamObj(map, prefix + "AddressChargePrepaid.", this.AddressChargePrepaid);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
        }
    }
}

