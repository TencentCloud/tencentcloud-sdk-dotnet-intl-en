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

    public class AddUserDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Device name, only supports Chinese, English, numbers, spaces, Chinese and English parentheses, _, -, length not exceeding 128 characters; (device name no need to be globally unique and can be duplicated)</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Device access protocol (1: RTMP, 2: GB, 6: ISUP)</p><p>Enumeration values:</p><ul><li>1: RTMP</li><li>2: GB</li><li>6: ISUP</li></ul><p>Default value: 2</p>
        /// </summary>
        [JsonProperty("AccessProtocol")]
        public long? AccessProtocol{ get; set; }

        /// <summary>
        /// <p>Device type. 1: IPC; 2: NVR. (If the device access protocol is RTMP, only select IPC as the device type.)</p><p>Enumeration values:</p><ul><li>1: IPC</li><li>2: NVR</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>ID of the organization to which the device belongs. Obtain from the organization query api DescribeOrganization.</p>
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// <p>Device access service node ID (Value field obtained from the DescribeRegionDomain API for querying available service nodes of a device)</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Device streaming protocol. 1: UDP, 2: TCP. (Valid for national standard devices. UDP by default if not specified)</p>
        /// </summary>
        [JsonProperty("TransportProtocol")]
        public long? TransportProtocol{ get; set; }

        /// <summary>
        /// <p>Device password (required for national standard devices, length of 1-64 characters)</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Device description, length not exceeding 128 characters</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Device access gateway ID (deprecated, reserved for compatibility, can be ignored)</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>Gateway access protocol type (deprecated, reserved for compatibility, can be ignored)</p>
        /// </summary>
        [JsonProperty("ProtocolType")]
        public long? ProtocolType{ get; set; }

        /// <summary>
        /// <p>Device access IP (deprecated, reserved for compatibility, can be ignored)</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>Device port (deprecated, reserved for compatibility, can be ignored)</p><p>Value range: [1, 65535]</p><p>Unit: port</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>Device username (deprecated, reserved for compatibility, can be ignored)</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>Device SN (deprecated, reserved for compatibility, can be ignored)</p>
        /// </summary>
        [JsonProperty("SNCode")]
        public string SNCode{ get; set; }

        /// <summary>
        /// <p>Custom AppName for RTMP publishing address (required for RTMP only, support English, digits, _, -, ., length not exceeding 64 characters)</p>
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// <p>Custom StreamName for RTMP publishing address (required for RTMP only, supports English, digits, _, -, ., length not exceeding 64 characters)</p>
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AccessProtocol", this.AccessProtocol);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "TransportProtocol", this.TransportProtocol);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "SNCode", this.SNCode);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
        }
    }
}

