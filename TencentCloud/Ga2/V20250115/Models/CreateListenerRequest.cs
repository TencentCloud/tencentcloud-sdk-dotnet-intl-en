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

    public class CreateListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Global acceleration instance ID.</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>Name.</p><p>Parameter format: starting with a letter or Chinese characters, 2–128 characters in length, supporting letters, digits, Chinese characters, . - _</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Port range.</p>
        /// </summary>
        [JsonProperty("PortRanges")]
        public PortRanges PortRanges{ get; set; }

        /// <summary>
        /// <p>Description. Maximum length cannot exceed 100 characters.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Listening type, defaults to smart routing.</p><p>Enumeration values:</p><ul><li>Standard: Smart routing.</li></ul>
        /// </summary>
        [JsonProperty("ListenerType")]
        public string ListenerType{ get; set; }

        /// <summary>
        /// <p>Protocol. Default value: TCP. Supports configuration of 'TCP', 'UDP', 'HTTP', and 'HTTPS'.</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>Connection idle wait time.</p><p>1. For HTTP/HTTPS listener, the default value is 15, with a supported range of 1-60.<br>2. For TCP listener, the default value is 900, with a supported range of 10-900.<br>3. For UDP listener, the default value is 20, with a supported range of 10-20.</p>
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }

        /// <summary>
        /// <p>Layer-4 source IP retrieval mode. Supports 'TOA', 'ProxyProtocol', and 'ProxyProtocolV2'.</p><p>This parameter can be filled in only when the Layer-4 source IP retrieval mode is enabled.</p>
        /// </summary>
        [JsonProperty("GetRealIpType")]
        public string GetRealIpType{ get; set; }

        /// <summary>
        /// <p>Whether to enable session persistence. Supports configuration of 'Open' and 'Close'.</p><p>Enumeration values:</p><ul><li>Open: enable.</li><li>Close: disable.</li></ul><p>Only supported for layer-4 listeners. For layer-7 listeners, modification is not supported.</p>
        /// </summary>
        [JsonProperty("ClientAffinity")]
        public string ClientAffinity{ get; set; }

        /// <summary>
        /// <p>Request timeout.</p><p>Value range: [1, 180]</p><p>Default value: 60</p><p>This parameter is configurable only for HTTPS listeners.</p>
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// <p>Whether to enable layer-7 source IP retrieval mode.</p>
        /// </summary>
        [JsonProperty("XForwardedForRealIp")]
        public bool? XForwardedForRealIp{ get; set; }

        /// <summary>
        /// <p>Parsing method.</p><p>Enumeration values:</p><ul><li>UNIDIRECTIONAL: two-way.</li><li>U: one-way.</li></ul><p>For an HTTPS listener, this field is required.</p>
        /// </summary>
        [JsonProperty("CertificationType")]
        public string CertificationType{ get; set; }

        /// <summary>
        /// <p>Encryption algorithm kit. Supports configuration of 'tls_policy_1.0-2', 'tls_policy_1.1-2', 'tls_policy_1.2', 'tls_policy_1.2_strict', 'tls_policy_1.2_strict-1.3'.</p>
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// <p>Server certificate.</p><p>Input limit: currently only support importing one cert; to use multiple certs, use the cert api CreateListenerAdditionalCert to add other certs.</p><p>This field is required for HTTPS listeners.</p>
        /// </summary>
        [JsonProperty("ServerCertificates")]
        public string[] ServerCertificates{ get; set; }

        /// <summary>
        /// <p>Client certificate.</p><p>Input limit: 1. Currently only support importing one cert. To use multiple certs, use the cert api CreateListenerAdditionalCert to add other certs. 2. The cert must be a CA certificate.</p><p>This field is required when HTTPS listener and mutual authentication are enabled.</p>
        /// </summary>
        [JsonProperty("ClientCaCertificates")]
        public string[] ClientCaCertificates{ get; set; }

        /// <summary>
        /// <p>HTTPS listener supports version selection</p><p>Enumeration values:</p><ul><li>HTTP/1.1: HTTP/1.1</li><li>HTTP/2: HTTP/2</li></ul>
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "PortRanges.", this.PortRanges);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ListenerType", this.ListenerType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "GetRealIpType", this.GetRealIpType);
            this.SetParamSimple(map, prefix + "ClientAffinity", this.ClientAffinity);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamSimple(map, prefix + "XForwardedForRealIp", this.XForwardedForRealIp);
            this.SetParamSimple(map, prefix + "CertificationType", this.CertificationType);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamArraySimple(map, prefix + "ServerCertificates.", this.ServerCertificates);
            this.SetParamArraySimple(map, prefix + "ClientCaCertificates.", this.ClientCaCertificates);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
        }
    }
}

