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

    public class VendorHardware : AbstractModel
    {
        
        /// <summary>
        /// Hardware id
        /// </summary>
        [JsonProperty("HardwareId")]
        public string HardwareId{ get; set; }

        /// <summary>
        /// Hardware Serial Number
        /// </summary>
        [JsonProperty("SN")]
        public string SN{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Activation status, empty: all; 1: to be activated; 2: activated
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Activation time
        /// </summary>
        [JsonProperty("ActiveTime")]
        public string ActiveTime{ get; set; }

        /// <summary>
        /// vendor remarks
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Device ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// License billing mode: 1. Tenant monthly payment 2. Manufacturer monthly payment 3. Permanent license.
        /// Note: When the device is paid by the tenant and inactive (not selected for monthly or permanent payment), this parameter returns 1, indicating only that the tenant has paid. This parameter will be subsequently deprecated. For new access, please use LicensePayMode and Payer.
        /// </summary>
        [JsonProperty("LicenseChargingMode")]
        public long? LicenseChargingMode{ get; set; }

        /// <summary>
        /// Last online time
        /// </summary>
        [JsonProperty("LastOnlineTime")]
        public string LastOnlineTime{ get; set; }

        /// <summary>
        /// Authorization validity period
        /// 0: Monthly authorization
        /// 1: Permanent license
        /// -1: Unknown
        /// </summary>
        [JsonProperty("LicensePayMode")]
        public long? LicensePayMode{ get; set; }

        /// <summary>
        /// Payer
        /// 0: Customer payment
        /// 1: Manufacturer payment
        /// </summary>
        [JsonProperty("Payer")]
        public long? Payer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HardwareId", this.HardwareId);
            this.SetParamSimple(map, prefix + "SN", this.SN);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "LicenseChargingMode", this.LicenseChargingMode);
            this.SetParamSimple(map, prefix + "LastOnlineTime", this.LastOnlineTime);
            this.SetParamSimple(map, prefix + "LicensePayMode", this.LicensePayMode);
            this.SetParamSimple(map, prefix + "Payer", this.Payer);
        }
    }
}

