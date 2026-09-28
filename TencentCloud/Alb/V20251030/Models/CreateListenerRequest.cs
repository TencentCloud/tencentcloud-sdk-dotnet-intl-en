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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Default forwarding rule action list. Currently, a listener supports adding only 1 default forwarding rule action.</p>
        /// </summary>
        [JsonProperty("DefaultActions")]
        public DefaultAction[] DefaultActions{ get; set; }

        /// <summary>
        /// <p>Port used by the load balancing instance frontend. Value: 1-65535.</p>
        /// </summary>
        [JsonProperty("ListenerPort")]
        public ulong? ListenerPort{ get; set; }

        /// <summary>
        /// <p>Listening protocol. Parameter Value: HTTP, HTTPS, or QUIC.</p>
        /// </summary>
        [JsonProperty("ListenerProtocol")]
        public string ListenerProtocol{ get; set; }

        /// <summary>
        /// <p>Cloud Load Balancer instance ID. The format is alb- followed by 8 alphanumeric characters.</p>
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// <p>List of CA certificate IDs configured for the listener. Currently, a listener supports adding only 1 CA certificate.<br>This parameter is required when the CaEnabled parameter value is true.</p>
        /// </summary>
        [JsonProperty("CaCertificateIds")]
        public string[] CaCertificateIds{ get; set; }

        /// <summary>
        /// <p>Whether mutual authentication is enabled.<br>Value:<br>true: enabled.<br>false (default value): not enabled.</p>
        /// </summary>
        [JsonProperty("CaEnabled")]
        public bool? CaEnabled{ get; set; }

        /// <summary>
        /// <p>List of server certificate IDs.</p>
        /// </summary>
        [JsonProperty("CertificateIds")]
        public string[] CertificateIds{ get; set; }

        /// <summary>
        /// <p>Client token, used to ensure the idempotency of requests.  </p><p>Generate a parameter value from your client to ensure the uniqueness of the value for different requests. ClientToken supports only ASCII characters.</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>Whether Gzip compression is enabled. Value: true (default): yes. false: no</p>
        /// </summary>
        [JsonProperty("GzipEnabled")]
        public bool? GzipEnabled{ get; set; }

        /// <summary>
        /// <p>Whether HTTP/2 is enabled. Default value: false for HTTP and true for HTTPS. Only the HTTPS protocol supports this parameter.</p>
        /// </summary>
        [JsonProperty("Http2Enabled")]
        public bool? Http2Enabled{ get; set; }

        /// <summary>
        /// <p>Connection idle timeout, in seconds.<br>Value range: 1–600.<br>Default value: 15.<br>If no access request is received within the timeout period, load balancing will disconnect the current connection and create a new connection when the next request arrives.</p>
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }

        /// <summary>
        /// <p>Custom listener name, containing 1–255 characters. It must contain Chinese and harmless string characters, and can contain Chinese, letters, digits, dashes (-), forward slashes (/), half-width periods (.), and underscores (_).</p>
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// <p>Connection request timeout period. Unit: second. Value: 1–600. Default value: 60. If the real server does not return a response within the timeout period, load balancing will abandon waiting and return an HTTP 504 error code to the client.</p>
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// <p>Security policy ID, format: tls- followed by 8 alphanumeric characters.</p>
        /// </summary>
        [JsonProperty("SecurityPolicyId")]
        public string SecurityPolicyId{ get; set; }

        /// <summary>
        /// <p>Tag list. Supports up to 20.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>X-Forwarded-For configuration</p>
        /// </summary>
        [JsonProperty("XForwardedForConfig")]
        public XForwardedForConfig XForwardedForConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DefaultActions.", this.DefaultActions);
            this.SetParamSimple(map, prefix + "ListenerPort", this.ListenerPort);
            this.SetParamSimple(map, prefix + "ListenerProtocol", this.ListenerProtocol);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamArraySimple(map, prefix + "CaCertificateIds.", this.CaCertificateIds);
            this.SetParamSimple(map, prefix + "CaEnabled", this.CaEnabled);
            this.SetParamArraySimple(map, prefix + "CertificateIds.", this.CertificateIds);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "GzipEnabled", this.GzipEnabled);
            this.SetParamSimple(map, prefix + "Http2Enabled", this.Http2Enabled);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamSimple(map, prefix + "SecurityPolicyId", this.SecurityPolicyId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "XForwardedForConfig.", this.XForwardedForConfig);
        }
    }
}

