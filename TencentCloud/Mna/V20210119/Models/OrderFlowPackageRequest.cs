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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrderFlowPackageRequest : AbstractModel
    {
        
        /// <summary>
        /// Traffic package specification type. Values are as follows:
        /// DEVICE_1_FLOW_20G,DEVICE_2_FLOW_50G,
        /// DEVICE_3_FLOW_100G,
        /// DEVICE_5_FLOW_500G represents traffic packages of 20G, 50G, 100G, and 500G gear selection.
        /// Gear selection also impacts the bandwidth cap of the data transfer plan.
        /// 20G: Bind up to 1 device.
        /// 50G: Bind up to 2 devices.
        /// 100G: Bind up to 3 devices.
        /// 500G: Bind up to 5 devices.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Device ID list bound to the data transfer plan. Number of bundled instances depends on the specification tiers of the plan.
        /// 20G: Bind up to 1 device.
        /// 50G: Bind up to 2 devices.
        /// 100G: Bind up to 3 devices.
        /// 500G: Bind up to 5 devices.
        /// </summary>
        [JsonProperty("DeviceList")]
        public string[] DeviceList{ get; set; }

        /// <summary>
        /// Whether the service is automatically renewed conflicts with traffic truncation. You can only enable one option.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public bool? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Region flag. 0: Chinese mainland, 1: outside the Chinese mainland
        /// </summary>
        [JsonProperty("PackageRegion")]
        public long? PackageRegion{ get; set; }

        /// <summary>
        /// Whether traffic truncation is enabled. This option conflicts with auto renewal.
        /// </summary>
        [JsonProperty("FlowTruncFlag")]
        public bool? FlowTruncFlag{ get; set; }

        /// <summary>
        /// Whether to automatically select voucher. Default false.
        /// Selection strategy for multiple vouchers: Deduct vouchers by this priority - voucher that can offset the total amount of the Payment Order, voucher with the earliest Expiration, voucher with the maximum deductible amount, voucher with the minimum balance, cash voucher. Only one voucher can be deducted at most.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// Designated voucher ID. This parameter is invalid when selecting voucher automatically. Only one voucher can be input.
        /// Note: If the designated voucher does not meet the order deduction conditions, proceed with normal payment without deducting the voucher.
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamArraySimple(map, prefix + "DeviceList.", this.DeviceList);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PackageRegion", this.PackageRegion);
            this.SetParamSimple(map, prefix + "FlowTruncFlag", this.FlowTruncFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
        }
    }
}

