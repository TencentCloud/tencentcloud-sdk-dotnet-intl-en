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

    public class AllocateAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// The number of EIPs. Default: 1.
        /// </summary>
        [JsonProperty("AddressCount")]
        public long? AddressCount{ get; set; }

        /// <summary>
        /// The EIP line type. Default: BGP.
        /// <ul style="margin:0"><li>For a user who has activated the static single-line IP allowlist, possible values are:<ul><li>CMCC: China Mobile</li>
        /// <li>CTCC: China Telecom</li>
        /// <li>CUCC: China Unicom</li></ul>Note: Only certain regions support static single-line IP addresses.</li></ul>
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// The EIP billing method.
        /// <ul style="margin:0"><li>For bill-by-IP account beta users, valid values: <ul><li>BANDWIDTH_PACKAGE: paid by the [bandwidth package](https://intl.cloud.tencent.com/document/product/684/15255?from_cn_redirect=1)(who must also be bandwidth package beta users)</li>
        /// <li>BANDWIDTH_POSTPAID_BY_HOUR: billed by hourly bandwidth on a pay-as-you-go basis</li>
        /// <li>BANDWIDTH_PREPAID_BY_MONTH: monthly bandwidth subscription</li>
        /// <li>TRAFFIC_POSTPAID_BY_HOUR: billed by hourly traffic on a pay-as-you-go basis</li></ul>Default value: TRAFFIC_POSTPAID_BY_HOUR</li>
        /// <li>If you are not a bill-by-IP account beta user, the EIP billing is the same as that for the instance bound to the EIP. Therefore, you do not need to pass in this parameter.</li></ul>
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// The EIP outbound bandwidth cap, in Mbps.
        /// <ul style="margin:0"><li>For bill-by-IP account beta users, the bandwidth cap range is determined by the EIP billing mode. <ul><li>`BANDWIDTH_PACKAGE`: 1 Mbps to 2000 Mbps</li>
        /// <li>`BANDWIDTH_POSTPAID_BY_HOUR`: 1 Mbps to 100 Mbps</li>
        /// <li>`BANDWIDTH_PREPAID_BY_MONTH`: 1 Mbps to 200 Mbps</li>
        /// <li>`TRAFFIC_POSTPAID_BY_HOUR`: 1 Mbps to 100 Mbps</li></ul>Default value: 1 Mbps </li>
        /// <li>If you are not a bill-by-IP account beta user, the EIP outbound bandwidth cap is subject to the bandwidth cap of the instance bound to the EIP. Therefore, you do not need to pass in this parameter. </li></ul>
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// A required billing parameter for an EIP billed by monthly bandwidth subscription. For EIPs using other billing modes, it can be ignored.
        /// </summary>
        [JsonProperty("AddressChargePrepaid")]
        public AddressChargePrepaid AddressChargePrepaid{ get; set; }

        /// <summary>
        /// EIP type. Default value: EIP.
        /// <ul style="margin:0"><li>For beta users of AIA, the value can be:</li></ul>`AnycastEIP`: an AIA IP address. For more information, see [Anycast Internet Acceleration](https://intl.cloud.tencent.com/document/product/644?from_cn_redirect=1).</li></ul>Note: Anycast EIPs are supported only in partial regions. </li></ul>
        /// <ul style="margin:0"><li>For beta users of dedicated IP, the value can be: <ul><li>`HighQualityEIP`: Dedicated IP</li></ul>Note that dedicated IPs are only available in partial regions. </li></ul>
        /// </ul>
        /// <ul style="margin:0"><li>For beta users of Anti-DDoS IP, the value can be: <ul><li>`AntiDDoSEIP`: Anti-DDoS EIP</li></ul>Note that Anti-DDoS IPs are only available in partial regions. </li></ul>
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// Anycast publishing region
        /// <ul style="margin:0"><li>Valid for users who have activated AIA. Values:<ul><li>ANYCAST_ZONE_GLOBAL: global publishing region </li><li>ANYCAST_ZONE_OVERSEAS: overseas publishing region</li><li><b>**[Disused]**</b> ANYCAST_ZONE_A: publishing region A (updated to ANYCAST_ZONE_GLOBAL)</li><li><b>**[Disused]**</b> ANYCAST_ZONE_B: publishing region B (updated to ANYCAST_ZONE_GLOBAL)</li></ul>Default: ANYCAST_ZONE_OVERSEAS.</li></ul>
        /// </summary>
        [JsonProperty("AnycastZone")]
        public string AnycastZone{ get; set; }

        /// <summary>
        /// <b>**[Disused]**</b>
        /// Whether the Anycast EIP can be bound to CLB instances.
        /// <ul style="margin:0"><li>Valid for users who have activated the AIA. Values:<ul><li>TRUE: the Anycast EIP can be bound to CLB instances.</li>
        /// <li>FALSE: the Anycast EIP can be bound to CVMs, NAT gateways, and HAVIPs.</li></ul>Default: FALSE.</li></ul>
        /// </summary>
        [JsonProperty("ApplicableForCLB")]
        public bool? ApplicableForCLB{ get; set; }

        /// <summary>
        /// List of tags to be bound.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The unique ID of a BGP bandwidth package. If you configure this parameter and set InternetChargeType as BANDWIDTH_PACKAGE, the new EIP is added to this package and billed by the bandwidth package mode.
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// EIP name, which is the custom EIP name given by the user when applying for the EIP. Default: not named
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// Network egress. It defaults to `center_egress1`.
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// Anti-DDoS service package ID. This is required when you want to request an u200dAnti-DDoS IP.
        /// </summary>
        [JsonProperty("AntiDDoSPackageId")]
        public string AntiDDoSPackageId{ get; set; }

        /// <summary>
        /// A string used to ensure the idempotency of the request. Generate a value based on your client. This can ensure that the value is unique for different requests. It only supports ASCII characters and can contain up to 64 characters. 
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressCount", this.AddressCount);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamObj(map, prefix + "AddressChargePrepaid.", this.AddressChargePrepaid);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "AnycastZone", this.AnycastZone);
            this.SetParamSimple(map, prefix + "ApplicableForCLB", this.ApplicableForCLB);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "AddressName", this.AddressName);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
            this.SetParamSimple(map, prefix + "AntiDDoSPackageId", this.AntiDDoSPackageId);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
        }
    }
}

