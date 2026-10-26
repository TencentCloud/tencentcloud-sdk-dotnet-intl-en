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

    public class DescribeDeviceData : AbstractModel
    {
        
        /// <summary>
        /// <p>Device ID</p>
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// <p>Device code (for national standard devices, it is the 20-digit National Standard Encoding we generated for the device; for rtmp devices, it is the 10-digit device code)</p>
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// <p>Device name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Device access protocol. 1: RTMP, 2: GB, 3: GW</p>
        /// </summary>
        [JsonProperty("AccessProtocol")]
        public long? AccessProtocol{ get; set; }

        /// <summary>
        /// <p>Device type. 1: IPC. 2: NVR.</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>Device access service node id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Device access service node name</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Device streaming protocol. 1: UDP; 2: TCP</p>
        /// </summary>
        [JsonProperty("TransportProtocol")]
        public long? TransportProtocol{ get; set; }

        /// <summary>
        /// <p>Device password</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Device description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>sip service ID</p>
        /// </summary>
        [JsonProperty("SipId")]
        public string SipId{ get; set; }

        /// <summary>
        /// <p>sip Service Domain</p>
        /// </summary>
        [JsonProperty("SipDomain")]
        public string SipDomain{ get; set; }

        /// <summary>
        /// <p>sip service IP address</p>
        /// </summary>
        [JsonProperty("SipIp")]
        public string SipIp{ get; set; }

        /// <summary>
        /// <p>sip server port</p>
        /// </summary>
        [JsonProperty("SipPort")]
        public long? SipPort{ get; set; }

        /// <summary>
        /// <p>Rtmp device streaming address (valid only for Rtmp devices)</p>
        /// </summary>
        [JsonProperty("PushStreamUrl")]
        public string PushStreamUrl{ get; set; }

        /// <summary>
        /// <p>Device status. 0: unregistered, 1: online, 2: offline, 3: disabled</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Organization ID of the device</p>
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// <p>Device gateway ID, obtained from the query gateway list API (required for gateway access only)</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>Gateway name of the device ownership</p>
        /// </summary>
        [JsonProperty("GatewayName")]
        public string GatewayName{ get; set; }

        /// <summary>
        /// <p>Device gateway protocol name</p>
        /// </summary>
        [JsonProperty("ProtocolTypeName")]
        public string ProtocolTypeName{ get; set; }

        /// <summary>
        /// <p>Gateway access protocol type. 1. Hikvision SDK, 2. Dahua SDK, 3. Uniview SDK, 4. Onvif (required for gateway access only)</p>
        /// </summary>
        [JsonProperty("ProtocolType")]
        public long? ProtocolType{ get; set; }

        /// <summary>
        /// <p>Device connectivity IP</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>Device Port</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>Device username</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>Device region</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Device vendor</p>
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// <p>Audio on/off (0: off; 1: on). Audio is dropped when turned off.</p>
        /// </summary>
        [JsonProperty("AudioSwitch")]
        public long? AudioSwitch{ get; set; }

        /// <summary>
        /// <p>Subscription switch (0: off; 1: on), enabled by default. When enabled, it subscribes to device channel adjustments. Valid only for national standard NVR devices</p>
        /// </summary>
        [JsonProperty("SubscribeSwitch")]
        public long? SubscribeSwitch{ get; set; }

        /// <summary>
        /// <p>Custom appName for RTMP publishing address</p>
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// <p>Custom streamName for RTMP publishing address</p>
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// <p>Whether to enable silent frames (0: disabled; 1: enabled)</p>
        /// </summary>
        [JsonProperty("SilentFrameSwitch")]
        public long? SilentFrameSwitch{ get; set; }

        /// <summary>
        /// <p>Rtmp device secure authentication streaming address (valid only for Rtmp devices)</p>
        /// </summary>
        [JsonProperty("PushStreamSecureUrl")]
        public string PushStreamSecureUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AccessProtocol", this.AccessProtocol);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "TransportProtocol", this.TransportProtocol);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SipId", this.SipId);
            this.SetParamSimple(map, prefix + "SipDomain", this.SipDomain);
            this.SetParamSimple(map, prefix + "SipIp", this.SipIp);
            this.SetParamSimple(map, prefix + "SipPort", this.SipPort);
            this.SetParamSimple(map, prefix + "PushStreamUrl", this.PushStreamUrl);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "GatewayName", this.GatewayName);
            this.SetParamSimple(map, prefix + "ProtocolTypeName", this.ProtocolTypeName);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "AudioSwitch", this.AudioSwitch);
            this.SetParamSimple(map, prefix + "SubscribeSwitch", this.SubscribeSwitch);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "SilentFrameSwitch", this.SilentFrameSwitch);
            this.SetParamSimple(map, prefix + "PushStreamSecureUrl", this.PushStreamSecureUrl);
        }
    }
}

