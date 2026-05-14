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

    public class ActivateHardware : AbstractModel
    {
        
        /// <summary>
        /// Vendor name
        /// </summary>
        [JsonProperty("Vendor")]
        public string Vendor{ get; set; }

        /// <summary>
        /// Device SN serial number
        /// </summary>
        [JsonProperty("SN")]
        public string SN{ get; set; }

        /// <summary>
        /// Device name.
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// device key
        /// </summary>
        [JsonProperty("DataKey")]
        public string DataKey{ get; set; }

        /// <summary>
        /// Access environment. 0: public cloud gateway; 1: private gateway; 2: public cloud gateway and private gateway. By default if left blank, public cloud gateway is selected. Specific meaning: Public cloud gateway: device can only integrate with public cloud gateway (nearby access). Private gateway: device can only integrate with private gateway that has been launched (nearby access or fixed ip). Public cloud gateway and private gateway: device can also integrate with public cloud gateway and private gateway that has been launched (nearby access or fixed ip).
        /// </summary>
        [JsonProperty("AccessScope")]
        public long? AccessScope{ get; set; }

        /// <summary>
        /// When the payer is the tenant, the tenant license payment method is available.
        /// Monthly authorization
        /// 1: Permanent license
        /// If not passed, it defaults to monthly authorization.
        /// This parameter is invalid when the manufacturer is the payer.
        /// </summary>
        [JsonProperty("LicensePayMode")]
        public long? LicensePayMode{ get; set; }

        /// <summary>
        /// device group ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Device group name. Reserved parameter. GroupId must be imported when grouping is required.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// No traffic processing method for the device. 0: pay-as-you-go, 1: truncate and accelerate
        /// </summary>
        [JsonProperty("FlowTrunc")]
        public long? FlowTrunc{ get; set; }

        /// <summary>
        /// Device ID after activation
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamSimple(map, prefix + "SN", this.SN);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DataKey", this.DataKey);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
            this.SetParamSimple(map, prefix + "LicensePayMode", this.LicensePayMode);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "FlowTrunc", this.FlowTrunc);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
        }
    }
}

