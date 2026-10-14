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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeLicenseRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// License type<li>oss: open source edition</li><li>basic: basic version</li><li>platinum: platinum version</li>Default value: platinum
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// Indicates whether to use vouchers automatically<li>0: Do not use automatically.</li><li>1: Use automatically.</li>Default value: 0.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// Voucher ID list. Only one voucher can be specified.
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// Whether xpack security authentication is enabled for basic version 6.8 (and above versions)<li>1: not enabled</li><li>2: enabled</li><li>If no parameter is passed, the original status is maintained by default. When passing a parameter, note that it can only change from not enabled to enabled, and cannot change from enabled to not enabled</li>
        /// </summary>
        [JsonProperty("BasicSecurityType")]
        public ulong? BasicSecurityType{ get; set; }

        /// <summary>
        /// Whether to force restart <li>true: force restart</li><li>false: do not force restart</li> Default value: false
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "BasicSecurityType", this.BasicSecurityType);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
        }
    }
}

