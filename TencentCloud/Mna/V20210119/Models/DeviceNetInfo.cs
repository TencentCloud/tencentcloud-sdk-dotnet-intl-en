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

    public class DeviceNetInfo : AbstractModel
    {
        
        /// <summary>
        /// Network type:
        /// Data
        /// 1:Wi-Fi
        /// 2: Wired
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Enable or disable.
        /// </summary>
        [JsonProperty("DataEnable")]
        public bool? DataEnable{ get; set; }

        /// <summary>
        /// Uplink speed limit
        /// </summary>
        [JsonProperty("UploadLimit")]
        public string UploadLimit{ get; set; }

        /// <summary>
        /// Downstream speed limit
        /// </summary>
        [JsonProperty("DownloadLimit")]
        public string DownloadLimit{ get; set; }

        /// <summary>
        /// receive real-time speed
        /// </summary>
        [JsonProperty("DataRx")]
        public ulong? DataRx{ get; set; }

        /// <summary>
        /// Send real-time speed
        /// </summary>
        [JsonProperty("DataTx")]
        public ulong? DataTx{ get; set; }

        /// <summary>
        /// Operator type:
        /// 1: CMCC;
        /// 2: CTCC 
        /// 3: CUCC
        /// </summary>
        [JsonProperty("Vendor")]
        public long? Vendor{ get; set; }

        /// <summary>
        /// Connection status:
        /// 0: connectionless
        /// 1: Connecting
        /// 2: Connected
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Signal strength/Measurement unit: dbm
        /// </summary>
        [JsonProperty("SignalStrength")]
        public long? SignalStrength{ get; set; }

        /// <summary>
        /// Data network type:
        /// -1: Invalid value.   
        /// 2:2G 
        /// 3:3G 
        /// 4:4G 
        /// 5:5G
        /// </summary>
        [JsonProperty("Rat")]
        public long? Rat{ get; set; }

        /// <summary>
        /// NIC Name
        /// </summary>
        [JsonProperty("NetInfoName")]
        public string NetInfoName{ get; set; }

        /// <summary>
        /// Downstream real-time rate (floating-point type replaces the integer type of the previous version DataRx).
        /// </summary>
        [JsonProperty("DownRate")]
        public float? DownRate{ get; set; }

        /// <summary>
        /// Uplink real-time rate (floating-point type replaces the integer of the previous version TxRate)
        /// </summary>
        [JsonProperty("UpRate")]
        public float? UpRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DataEnable", this.DataEnable);
            this.SetParamSimple(map, prefix + "UploadLimit", this.UploadLimit);
            this.SetParamSimple(map, prefix + "DownloadLimit", this.DownloadLimit);
            this.SetParamSimple(map, prefix + "DataRx", this.DataRx);
            this.SetParamSimple(map, prefix + "DataTx", this.DataTx);
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "SignalStrength", this.SignalStrength);
            this.SetParamSimple(map, prefix + "Rat", this.Rat);
            this.SetParamSimple(map, prefix + "NetInfoName", this.NetInfoName);
            this.SetParamSimple(map, prefix + "DownRate", this.DownRate);
            this.SetParamSimple(map, prefix + "UpRate", this.UpRate);
        }
    }
}

