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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Device : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the IP address of the device used by the service subscriber. <br>
        /// Note: Currently, only IPv4 addresses can be recorded.
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// This field indicates the MAC address used by the service subscriber to facilitate device identification and management. Its format and value are consistent with those of the standard MAC address.
        /// </summary>
        [JsonProperty("Mac")]
        public string Mac{ get; set; }

        /// <summary>
        /// * In beta test. Available soon.*
        /// </summary>
        [JsonProperty("TokenId")]
        public string TokenId{ get; set; }

        /// <summary>
        /// * In beta test. Available soon.*
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// This field represents the **IMEI** (International Mobile Equipment Identity) number of the device used by the service subscriber. IMEI can be used to identify each independent mobile communication device, such as a mobile phone, which is convenient for device identification and management. <br>Note: IMEI is formatted with **15 to 17 numbers only**.
        /// </summary>
        [JsonProperty("IMEI")]
        public string IMEI{ get; set; }

        /// <summary>
        /// **Dedicated for iOS device**. This field indicates the **IDFA** (Identifier for Advertising) corresponding to the service subscriber. IDFA, a string of hexadecimal 32 characters including numbers and letters, is provided by Apple Inc. to identify the user.<br>
        /// Note: Since the iOS14 update in 2021, Apple Inc. has allowed users to manually activate or deactivate IDFA, so the validity of the string identifier may be reduced.
        /// </summary>
        [JsonProperty("IDFA")]
        public string IDFA{ get; set; }

        /// <summary>
        /// **Dedicated for iOS device**. This field indicates the **IDFV** (Identifier for Vendor) corresponding to the service subscriber. IDFV, a string of hexadecimal 32 characters including numbers and letters, is provided by Apple Inc. to identify the vendor. IDFV can also be used as a unique device identifier.
        /// </summary>
        [JsonProperty("IDFV")]
        public string IDFV{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Mac", this.Mac);
            this.SetParamSimple(map, prefix + "TokenId", this.TokenId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "IMEI", this.IMEI);
            this.SetParamSimple(map, prefix + "IDFA", this.IDFA);
            this.SetParamSimple(map, prefix + "IDFV", this.IDFV);
        }
    }
}

