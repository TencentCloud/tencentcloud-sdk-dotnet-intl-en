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

    public class ModifyListenerAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// Listener ID, format: lst- followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Cloud Load Balancer instance ID, in the format of "alb-" followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// CA certificate ID list for the listener configuration. Currently only support adding 1 CA certificate.
        /// </summary>
        [JsonProperty("CaCertificateIds")]
        public string[] CaCertificateIds{ get; set; }

        /// <summary>
        /// Whether mutual authentication is enabled.
        /// Valid values:
        /// true: enabled.
        /// false (default value): not enabled.
        /// </summary>
        [JsonProperty("CaEnabled")]
        public bool? CaEnabled{ get; set; }

        /// <summary>
        /// List of server certificate IDs.
        /// </summary>
        [JsonProperty("CertificateIds")]
        public string[] CertificateIds{ get; set; }

        /// <summary>
        /// Client Token, used for ensuring request idempotency.  
        /// 
        /// Generate a parameter value from your client to underwrite the uniqueness of the value for different requests. ClientToken supports only ASCII characters.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// List of default forward rule actions. Currently, a listener supports adding only 1 default forward rule action.
        /// </summary>
        [JsonProperty("DefaultActions")]
        public DefaultAction[] DefaultActions{ get; set; }

        /// <summary>
        /// Whether to enable Gzip compression.
        /// </summary>
        [JsonProperty("GzipEnabled")]
        public bool? GzipEnabled{ get; set; }

        /// <summary>
        /// Whether to enable HTTP/2. Only HTTPS protocol supports this parameter.
        /// </summary>
        [JsonProperty("Http2Enabled")]
        public bool? Http2Enabled{ get; set; }

        /// <summary>
        /// Specify the idle timeout for a connection. Unit: seconds.
        /// Valid values: 1-600.
        /// Default value: 15.
        /// If no access request is received within the set time, load balancing will temporarily disconnect the current connection and reestablish a new connection when the next request arrives.
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }

        /// <summary>
        /// Custom listener name, 1–255 characters in length. It must contain Chinese and harmless string characters, and can contain Chinese, letters, digits, dashes (-), forward slashes (/), half-width periods (.), and underscores (_).
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// Specify the request timeout. Unit: seconds.
        /// Value: 1-600.
        /// Default value: 60.
        /// If the real server does not respond within the timeout period, load balancing will abandon waiting and return an HTTP 504 error code to the client.
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// Security policy ID in the format of tls- followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("SecurityPolicyId")]
        public string SecurityPolicyId{ get; set; }

        /// <summary>
        /// XForwardedFor configuration.
        /// </summary>
        [JsonProperty("XForwardedForConfig")]
        public XForwardedForConfig XForwardedForConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamArraySimple(map, prefix + "CaCertificateIds.", this.CaCertificateIds);
            this.SetParamSimple(map, prefix + "CaEnabled", this.CaEnabled);
            this.SetParamArraySimple(map, prefix + "CertificateIds.", this.CertificateIds);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamArrayObj(map, prefix + "DefaultActions.", this.DefaultActions);
            this.SetParamSimple(map, prefix + "GzipEnabled", this.GzipEnabled);
            this.SetParamSimple(map, prefix + "Http2Enabled", this.Http2Enabled);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamSimple(map, prefix + "SecurityPolicyId", this.SecurityPolicyId);
            this.SetParamObj(map, prefix + "XForwardedForConfig.", this.XForwardedForConfig);
        }
    }
}

