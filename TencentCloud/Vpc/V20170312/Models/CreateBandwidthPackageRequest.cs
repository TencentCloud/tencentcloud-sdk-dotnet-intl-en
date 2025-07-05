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

    public class CreateBandwidthPackageRequest : AbstractModel
    {
        
        /// <summary>
        /// The network type of the bandwidth package. Default value: `BGP`. Valid values:
        /// `BGP`
        /// `HIGH_QUALITY_BGP`
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// The billing mode of the bandwidth package. Default value: `ENHANCED95_POSTPAID_BY_MONTH`. Valid values:
        /// <li>`ENHANCED95_POSTPAID_BY_MONTH`: Pay-as-you-go - Enhanced 95th percentile</li>
        /// <li>`PRIMARY_TRAFFIC_POSTPAID_BY_HOUR`: Postpaid - Main Traffic Billing</li>
        /// <li>`BANDWIDTH_POSTPAID_BY_DAY`: General BGP, Pay-as-you-go - Bandwidth-based</li>
        /// <li>`PEAK_BANDWIDTH_POSTPAID_BY_DAY`: Static single-line, Pay-as-you-go - Daily billed</li>
        /// <li>`TOP5_POSTPAID_BY_MONTH`: Pay-as-you-go - Monthly top 5th, If you need to use this Bglling mode, please submit a ticket.</li>
        /// 
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// The name of the bandwidth package.
        /// </summary>
        [JsonProperty("BandwidthPackageName")]
        public string BandwidthPackageName{ get; set; }

        /// <summary>
        /// The number of bandwidth packages to create. Valid range: 1-20. It can only be "1" for bill-by-CVM accounts.
        /// </summary>
        [JsonProperty("BandwidthPackageCount")]
        public ulong? BandwidthPackageCount{ get; set; }

        /// <summary>
        /// The limit of the bandwidth package in Mbps. The value '-1' indicates there is no limit. This feature is currently in beta.
        /// </summary>
        [JsonProperty("InternetMaxBandwidth")]
        public long? InternetMaxBandwidth{ get; set; }

        /// <summary>
        /// The list of tags to be bound.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The protocol type of the bandwidth package. Valid values: 'ipv4' and 'ipv6'. Default value: 'ipv4'.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        ///     Network egress. It defaults to `center_egress1`. Valid values:
        /// center_egress1,center_egress2,center_egress3
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "BandwidthPackageName", this.BandwidthPackageName);
            this.SetParamSimple(map, prefix + "BandwidthPackageCount", this.BandwidthPackageCount);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidth", this.InternetMaxBandwidth);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
        }
    }
}

