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

    public class DeviceBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique ID of the device</p>
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// <p>Device name</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>The time when the device is created, in ms</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Last online time of the device, in ms</p>
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// <p>Remark of the device</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Access environment. 0: public cloud gateway; 1: private gateway; 2: public cloud gateway and private gateway. Defaults to public cloud gateway. Specific meaning: Public cloud gateway: The device can only access the public cloud gateway (nearby access). Private gateway: The device can only access the already launched private gateway (nearby access or fixed ip access). Public cloud gateway and private gateway: The device can also access both the public cloud gateway and the already launched private gateway (nearby access or fixed ip access).</p>
        /// </summary>
        [JsonProperty("AccessScope")]
        public long? AccessScope{ get; set; }

        /// <summary>
        /// <p>license authorization validity period 0: monthly authorization 1: permanent license</p>
        /// </summary>
        [JsonProperty("LicensePayMode")]
        public long? LicensePayMode{ get; set; }

        /// <summary>
        /// <p>Payment party 0: Manufacturer pays 1: Customer pays</p>
        /// </summary>
        [JsonProperty("Payer")]
        public long? Payer{ get; set; }

        /// <summary>
        /// <p>device group ID</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>Device group name</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>Device data transfer plan processing method, 0: pay-as-you-go, 1: truncate acceleration</p>
        /// </summary>
        [JsonProperty("FlowTrunc")]
        public long? FlowTrunc{ get; set; }

        /// <summary>
        /// <p>Device sn</p>
        /// </summary>
        [JsonProperty("Sn")]
        public string Sn{ get; set; }

        /// <summary>
        /// <p>Manufacturer</p>
        /// </summary>
        [JsonProperty("Vendor")]
        public string Vendor{ get; set; }

        /// <summary>
        /// <p>Access region list.</p>
        /// </summary>
        [JsonProperty("AllowedRegions")]
        public string[] AllowedRegions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
            this.SetParamSimple(map, prefix + "LicensePayMode", this.LicensePayMode);
            this.SetParamSimple(map, prefix + "Payer", this.Payer);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "FlowTrunc", this.FlowTrunc);
            this.SetParamSimple(map, prefix + "Sn", this.Sn);
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamArraySimple(map, prefix + "AllowedRegions.", this.AllowedRegions);
        }
    }
}

