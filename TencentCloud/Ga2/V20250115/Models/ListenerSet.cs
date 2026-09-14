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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListenerSet : AbstractModel
    {
        
        /// <summary>
        /// Global acceleration instance ID.
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// Listener ID.
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Listener name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Listener description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Protocol.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Port range.
        /// </summary>
        [JsonProperty("PortRanges")]
        public PortRanges PortRanges{ get; set; }

        /// <summary>
        /// Whether to enable layer-7 access to source IP mode.
        /// </summary>
        [JsonProperty("XForwardedForRealIp")]
        public bool? XForwardedForRealIp{ get; set; }

        /// <summary>
        /// Enable session persistence.
        /// </summary>
        [JsonProperty("ClientAffinity")]
        public string ClientAffinity{ get; set; }

        /// <summary>
        /// Session persistence time.
        /// </summary>
        [JsonProperty("ClientAffinityTime")]
        public ulong? ClientAffinityTime{ get; set; }

        /// <summary>
        /// SSL decryption method.
        /// </summary>
        [JsonProperty("CertificationType")]
        public string CertificationType{ get; set; }

        /// <summary>
        /// Server certificate.
        /// </summary>
        [JsonProperty("ServerCertificates")]
        public string[] ServerCertificates{ get; set; }

        /// <summary>
        /// Client certificate.
        /// </summary>
        [JsonProperty("ClientCaCertificates")]
        public string[] ClientCaCertificates{ get; set; }

        /// <summary>
        /// TLS password suite package.
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// HTTP version.
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }

        /// <summary>
        /// Request timeout.
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Listener routing type.
        /// </summary>
        [JsonProperty("ListenerType")]
        public string ListenerType{ get; set; }

        /// <summary>
        /// Listener status.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Number of terminal node groups belonging to the listener.
        /// </summary>
        [JsonProperty("EndpointGroupCounts")]
        public ulong? EndpointGroupCounts{ get; set; }

        /// <summary>
        /// Method for obtaining the source IP at Layer 4.
        /// </summary>
        [JsonProperty("GetRealIpType")]
        public string GetRealIpType{ get; set; }

        /// <summary>
        /// Connection timeout.
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "PortRanges.", this.PortRanges);
            this.SetParamSimple(map, prefix + "XForwardedForRealIp", this.XForwardedForRealIp);
            this.SetParamSimple(map, prefix + "ClientAffinity", this.ClientAffinity);
            this.SetParamSimple(map, prefix + "ClientAffinityTime", this.ClientAffinityTime);
            this.SetParamSimple(map, prefix + "CertificationType", this.CertificationType);
            this.SetParamArraySimple(map, prefix + "ServerCertificates.", this.ServerCertificates);
            this.SetParamArraySimple(map, prefix + "ClientCaCertificates.", this.ClientCaCertificates);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ListenerType", this.ListenerType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EndpointGroupCounts", this.EndpointGroupCounts);
            this.SetParamSimple(map, prefix + "GetRealIpType", this.GetRealIpType);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
        }
    }
}

