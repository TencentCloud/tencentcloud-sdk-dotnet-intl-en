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

    public class CreateDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// Product ID, globally unique ID assigned by Tencent Cloud during product creation
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// Device name. It is a string of 1 to 48 characters. Letters, digits, and :_- are allowed.
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// Device attribute
        /// </summary>
        [JsonProperty("Attribute")]
        public Attribute Attribute{ get; set; }

        /// <summary>
        /// Whether to use custom PSK, no by default
        /// </summary>
        [JsonProperty("DefinedPsk")]
        public string DefinedPsk{ get; set; }

        /// <summary>
        /// ISP, required for a NB-IoT product. `1`: China Telecom; `2`: China Mobile; `3`: China Unicom
        /// </summary>
        [JsonProperty("Isp")]
        public ulong? Isp{ get; set; }

        /// <summary>
        /// IMEI, required for a NB-IoT product
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// DevEUI of a LoRa device, required when you create a LoRa device
        /// </summary>
        [JsonProperty("LoraDevEui")]
        public string LoraDevEui{ get; set; }

        /// <summary>
        /// MoteType of a LoRa device
        /// </summary>
        [JsonProperty("LoraMoteType")]
        public ulong? LoraMoteType{ get; set; }

        /// <summary>
        /// Skey, required when you create a LoRa device
        /// </summary>
        [JsonProperty("Skey")]
        public string Skey{ get; set; }

        /// <summary>
        /// AppKey of a LoRa device
        /// </summary>
        [JsonProperty("LoraAppKey")]
        public string LoraAppKey{ get; set; }

        /// <summary>
        /// Private CA certificate
        /// </summary>
        [JsonProperty("TlsCrt")]
        public string TlsCrt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamObj(map, prefix + "Attribute.", this.Attribute);
            this.SetParamSimple(map, prefix + "DefinedPsk", this.DefinedPsk);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "LoraDevEui", this.LoraDevEui);
            this.SetParamSimple(map, prefix + "LoraMoteType", this.LoraMoteType);
            this.SetParamSimple(map, prefix + "Skey", this.Skey);
            this.SetParamSimple(map, prefix + "LoraAppKey", this.LoraAppKey);
            this.SetParamSimple(map, prefix + "TlsCrt", this.TlsCrt);
        }
    }
}

