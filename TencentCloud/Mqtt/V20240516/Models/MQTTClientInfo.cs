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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MQTTClientInfo : AbstractModel
    {
        
        /// <summary>
        /// Client ID
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Client network address.
        /// </summary>
        [JsonProperty("ClientAddress")]
        public string ClientAddress{ get; set; }

        /// <summary>
        /// MQTT protocol version.
        /// 3: indicates MQTT version 3.1.
        /// 4: indicates MQTT 3.1.1.
        /// 5: indicates the MQTT 5.0 protocol.
        /// </summary>
        [JsonProperty("ProtocolVersion")]
        public long? ProtocolVersion{ get; set; }

        /// <summary>
        /// Keep-alive duration. Unit: second.
        /// </summary>
        [JsonProperty("Keepalive")]
        public long? Keepalive{ get; set; }

        /// <summary>
        /// Connection status. CONNECTED: connected; DISCONNECTED: not connected.
        /// </summary>
        [JsonProperty("ConnectionStatus")]
        public string ConnectionStatus{ get; set; }

        /// <summary>
        /// Client creation time. millisecond-level timestamp.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Last connection establishment time. millisecond-level timestamp.
        /// </summary>
        [JsonProperty("ConnectTime")]
        public long? ConnectTime{ get; set; }

        /// <summary>
        /// Last disconnection time, only applicable to persistent sessions (cleanSession=false) and when the client is currently disconnected, millisecond-level timestamp.
        /// </summary>
        [JsonProperty("DisconnectTime")]
        public long? DisconnectTime{ get; set; }

        /// <summary>
        /// Client subscription list.
        /// </summary>
        [JsonProperty("MQTTClientSubscriptions")]
        public MQTTClientSubscription[] MQTTClientSubscriptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientAddress", this.ClientAddress);
            this.SetParamSimple(map, prefix + "ProtocolVersion", this.ProtocolVersion);
            this.SetParamSimple(map, prefix + "Keepalive", this.Keepalive);
            this.SetParamSimple(map, prefix + "ConnectionStatus", this.ConnectionStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ConnectTime", this.ConnectTime);
            this.SetParamSimple(map, prefix + "DisconnectTime", this.DisconnectTime);
            this.SetParamArrayObj(map, prefix + "MQTTClientSubscriptions.", this.MQTTClientSubscriptions);
        }
    }
}

