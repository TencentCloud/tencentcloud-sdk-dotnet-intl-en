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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HTTPSListener : AbstractModel
    {
        
        /// <summary>
        /// Listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Listener name
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// Listener port
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Listener protocol. Valid values: HTTP, HTTPS. The value `HTTPS` is used for this structure
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Listener status:
        /// 0: running;
        /// 1: creating;
        /// 2: terminating;
        /// 3: adjusting origin server;
        /// 4: modifying configuration.
        /// </summary>
        [JsonProperty("ListenerStatus")]
        public ulong? ListenerStatus{ get; set; }

        /// <summary>
        /// Server SSL certificate ID of the listener
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Protocol used in the forwarding from connections to origin servers
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// Listener creation time; using UNIX timestamp.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Server SSL certificate alias
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// Client CA certificate ID of the listener
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public string ClientCertificateId{ get; set; }

        /// <summary>
        /// Listener authentication mode. Valid values:
        /// 0: one-way authentication;
        /// 1: mutual authentication.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }

        /// <summary>
        /// Client CA certificate alias
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientCertificateAlias")]
        public string ClientCertificateAlias{ get; set; }

        /// <summary>
        /// Alias information of multiple client CA certificates.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PolyClientCertificateAliasInfo")]
        public CertificateAliasInfo[] PolyClientCertificateAliasInfo{ get; set; }

        /// <summary>
        /// Whether to support HTTP3. Values:
        /// `0`: Do not support HTTP3 access;
        /// `1`: Support HTTP3 access.
        /// If HTTP3 is supported for a connection, the listener will use the port that is originally accessed to UDP, and a UDP listener with the same port cannot be created.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }

        /// <summary>
        /// Connection ID of the listener. A null value is returned if the listener is associated with the connection group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Connection group ID of the listener. A null value is returned if the listener is associated with a specific connection.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ListenerStatus", this.ListenerStatus);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "ClientCertificateId", this.ClientCertificateId);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "ClientCertificateAlias", this.ClientCertificateAlias);
            this.SetParamArrayObj(map, prefix + "PolyClientCertificateAliasInfo.", this.PolyClientCertificateAliasInfo);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
        }
    }
}

