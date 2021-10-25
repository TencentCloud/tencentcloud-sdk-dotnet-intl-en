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

namespace TencentCloud.Iotcloud.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceResponse : AbstractModel
    {
        
        /// <summary>
        /// Device name
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// Whether the device is online. `0`: offline; `1`: online
        /// </summary>
        [JsonProperty("Online")]
        public ulong? Online{ get; set; }

        /// <summary>
        /// Device login time
        /// </summary>
        [JsonProperty("LoginTime")]
        public ulong? LoginTime{ get; set; }

        /// <summary>
        /// Device firmware version
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Last updated time of the device
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public ulong? LastUpdateTime{ get; set; }

        /// <summary>
        /// Device certificate
        /// </summary>
        [JsonProperty("DeviceCert")]
        public string DeviceCert{ get; set; }

        /// <summary>
        /// Device key
        /// </summary>
        [JsonProperty("DevicePsk")]
        public string DevicePsk{ get; set; }

        /// <summary>
        /// Device attribute
        /// </summary>
        [JsonProperty("Tags")]
        public DeviceTag[] Tags{ get; set; }

        /// <summary>
        /// Device type
        /// </summary>
        [JsonProperty("DeviceType")]
        public ulong? DeviceType{ get; set; }

        /// <summary>
        /// International Mobile Equipment Identity (IMEI)
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// ISP
        /// </summary>
        [JsonProperty("Isp")]
        public ulong? Isp{ get; set; }

        /// <summary>
        /// IP address
        /// </summary>
        [JsonProperty("ConnIP")]
        public ulong? ConnIP{ get; set; }

        /// <summary>
        /// Device ID at the NB-IoT ISP
        /// </summary>
        [JsonProperty("NbiotDeviceID")]
        public string NbiotDeviceID{ get; set; }

        /// <summary>
        /// DevEUI of a LoRa device
        /// </summary>
        [JsonProperty("LoraDevEui")]
        public string LoraDevEui{ get; set; }

        /// <summary>
        /// MoteType of a LoRa device
        /// </summary>
        [JsonProperty("LoraMoteType")]
        public ulong? LoraMoteType{ get; set; }

        /// <summary>
        /// SDK log level of the device
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("LogLevel")]
        public ulong? LogLevel{ get; set; }

        /// <summary>
        /// The first time when the device went online
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("FirstOnlineTime")]
        public ulong? FirstOnlineTime{ get; set; }

        /// <summary>
        /// The last time when the device went offline
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("LastOfflineTime")]
        public ulong? LastOfflineTime{ get; set; }

        /// <summary>
        /// Device creation time
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Whether the device certificate has been obtained. `0`: no; `1`: yes
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CertState")]
        public ulong? CertState{ get; set; }

        /// <summary>
        /// Whether the device is enabled
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("EnableState")]
        public ulong? EnableState{ get; set; }

        /// <summary>
        /// Device tags
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Labels")]
        public DeviceLabel[] Labels{ get; set; }

        /// <summary>
        /// IP address of the MQTT client
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ClientIP")]
        public string ClientIP{ get; set; }

        /// <summary>
        /// Firmware update time of the device
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("FirmwareUpdateTime")]
        public ulong? FirmwareUpdateTime{ get; set; }

        /// <summary>
        /// Account ID of the creator
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateUserId")]
        public ulong? CreateUserId{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Online", this.Online);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "DeviceCert", this.DeviceCert);
            this.SetParamSimple(map, prefix + "DevicePsk", this.DevicePsk);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "ConnIP", this.ConnIP);
            this.SetParamSimple(map, prefix + "NbiotDeviceID", this.NbiotDeviceID);
            this.SetParamSimple(map, prefix + "LoraDevEui", this.LoraDevEui);
            this.SetParamSimple(map, prefix + "LoraMoteType", this.LoraMoteType);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
            this.SetParamSimple(map, prefix + "FirstOnlineTime", this.FirstOnlineTime);
            this.SetParamSimple(map, prefix + "LastOfflineTime", this.LastOfflineTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CertState", this.CertState);
            this.SetParamSimple(map, prefix + "EnableState", this.EnableState);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "ClientIP", this.ClientIP);
            this.SetParamSimple(map, prefix + "FirmwareUpdateTime", this.FirmwareUpdateTime);
            this.SetParamSimple(map, prefix + "CreateUserId", this.CreateUserId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

