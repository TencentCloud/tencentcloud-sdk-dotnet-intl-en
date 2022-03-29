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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Device : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the IP address of the business user's device and supports recording both **IPv4 and IPv6** addresses. It needs to be used together with the `IpType` parameter.
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// This field indicates the MAC address of the business user, which makes it easier to identify and manage devices. Its format and value are the same as those of a standard MAC address.
        /// </summary>
        [JsonProperty("Mac")]
        public string Mac{ get; set; }

        /// <summary>
        /// *In beta test. Stay tuned.*
        /// </summary>
        [JsonProperty("TokenId")]
        public string TokenId{ get; set; }

        /// <summary>
        /// *In beta test. Stay tuned.*
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// This field indicates the international mobile equipment identity **(IMEI)** number of the business user's device, which can be used to identify each mobile communication device such as mobile phone for easier device identification and management.<br>Note: the format is **15–17 digits**.
        /// </summary>
        [JsonProperty("IMEI")]
        public string IMEI{ get; set; }

        /// <summary>
        /// **For iOS devices**: this field indicates the identifier for advertisers **(IDFA)** of the business user, which is provided by Apple to identify the user and contains a hexadecimal string of 32 digits and letters.<br>
        /// Note: as iOS 14 has been updated by Apple to allow users to manually enable or disable IDFA since 2021, the validity of this string may be reduced.
        /// </summary>
        [JsonProperty("IDFA")]
        public string IDFA{ get; set; }

        /// <summary>
        /// **For iOS devices**: this field indicates the identifier for vendors **(IDFV)** of the business user, which is provided by Apple to identify the app vendor and contains a hexadecimal string of 32 digits and letters. It can be used to uniquely identify a device.
        /// </summary>
        [JsonProperty("IDFV")]
        public string IDFV{ get; set; }

        /// <summary>
        /// This field indicates the type of the recorded IP address. Valid values: **0** (IPv4 address), **1** (IPv6 address). It needs to be used together with the `IpType` parameter.
        /// </summary>
        [JsonProperty("IpType")]
        public ulong? IpType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Mac", this.Mac);
            this.SetParamSimple(map, prefix + "TokenId", this.TokenId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "IMEI", this.IMEI);
            this.SetParamSimple(map, prefix + "IDFA", this.IDFA);
            this.SetParamSimple(map, prefix + "IDFV", this.IDFV);
            this.SetParamSimple(map, prefix + "IpType", this.IpType);
        }
    }
}

