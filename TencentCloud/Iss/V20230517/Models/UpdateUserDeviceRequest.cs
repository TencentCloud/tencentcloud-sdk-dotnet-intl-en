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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateUserDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Device ID (obtain from the device list API ListDevices)</p><p>For parameter values, see <a href="https://www.tencentcloud.com/document/api/1344/95871?from_cn_redirect=1">ListDevices</a></p>
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// <p>Device name (only supports Chinese, English, numbers, spaces, Chinese and English parentheses, _, -, length not exceeding 128 characters)</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Device streaming protocol. Only valid for national standard devices. Fill in 0 to make no change (1: UDP, 2: TCP)</p>
        /// </summary>
        [JsonProperty("TransportProtocol")]
        public long? TransportProtocol{ get; set; }

        /// <summary>
        /// <p>Device password (only supported for national standard devices, length not exceeding 64 characters)</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Device description (length not exceeding 128 characters)</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Device access IP (deprecated, reserved for compatibility, can be ignored)</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>Device Port (deprecated, reserved for compatibility, can be ignored)</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>Device username (deprecated, reserved for compatibility, can be ignored)</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>Gateway device access protocol (deprecated, reserved for compatibility, can be ignored)</p>
        /// </summary>
        [JsonProperty("ProtocolType")]
        public long? ProtocolType{ get; set; }

        /// <summary>
        /// <p>Audio on/off (0: off; 1: on), enabled by default. Audio is dropped when turned off.</p>
        /// </summary>
        [JsonProperty("AudioSwitch")]
        public long? AudioSwitch{ get; set; }

        /// <summary>
        /// <p>Subscription switch (0: off; 1: on). Default On. When enabled, it subscribes to device channel transitions. Valid only for national standard NVR devices.</p>
        /// </summary>
        [JsonProperty("SubscribeSwitch")]
        public long? SubscribeSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to enable silent frame (0: disabled; 1: enabled)</p>
        /// </summary>
        [JsonProperty("SilentFrameSwitch")]
        public long? SilentFrameSwitch{ get; set; }

        /// <summary>
        /// <p>Clock sync switch (only effective for national standard devices)</p><p>Enumeration values:</p><ul><li>0: Off</li><li>1: On</li></ul><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("TimeSyncSwitch")]
        public long? TimeSyncSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TransportProtocol", this.TransportProtocol);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamSimple(map, prefix + "AudioSwitch", this.AudioSwitch);
            this.SetParamSimple(map, prefix + "SubscribeSwitch", this.SubscribeSwitch);
            this.SetParamSimple(map, prefix + "SilentFrameSwitch", this.SilentFrameSwitch);
            this.SetParamSimple(map, prefix + "TimeSyncSwitch", this.TimeSyncSwitch);
        }
    }
}

