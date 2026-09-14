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

    public class ModifyListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Global acceleration instance ID.</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>Listener ID.</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>Name.</p><p>Parameter format: starting with a letter or Chinese characters, 2–128 characters in length, supporting letters, digits, Chinese characters, . - _</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Description. Maximum length cannot exceed 100 bytes.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Connection idle wait time.</p><p>1. For HTTP/HTTPS listener, the supported range is 1-60. 2. For TCP listener, the supported range is 10-900. 3. For UDP listener, the supported range is 10-20.</p>
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }

        /// <summary>
        /// <p>Whether to enable session persistence.</p><p>Enumeration values:</p><ul><li>Open: on.</li><li>Close: off.</li></ul><p>TCP/UDP listeners support modification of this parameter.</p>
        /// </summary>
        [JsonProperty("ClientAffinity")]
        public string ClientAffinity{ get; set; }

        /// <summary>
        /// <p>Session persistence duration.</p><p>Value range: [60, 3600]</p>
        /// </summary>
        [JsonProperty("ClientAffinityTime")]
        public ulong? ClientAffinityTime{ get; set; }

        /// <summary>
        /// <p>Request timeout.</p><p>Value range: [1, 180]</p><p>This parameter can be modified only for HTTPS listeners.</p>
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// <p>Whether to enable the layer 7 method of obtaining the client IP.</p><p>This parameter modification is supported only for HTTPS/HTTP listeners.</p>
        /// </summary>
        [JsonProperty("XForwardedForRealIp")]
        public bool? XForwardedForRealIp{ get; set; }

        /// <summary>
        /// <p>Parsing method.</p><p>Enumeration values:</p><ul><li>UNIDIRECTIONAL: two-way.</li><li>MUTUAL: one-way.</li></ul><p>Only HTTPS/HTTP listeners support modifying this parameter.</p>
        /// </summary>
        [JsonProperty("CertificationType")]
        public string CertificationType{ get; set; }

        /// <summary>
        /// <p>Encryption algorithm kit.</p><p>Input limits: support selecting tls_policy_1.0-2', 'tls_policy_1.1-2', 'tls_policy_1.2', 'tls_policy_1.2_strict', 'tls_policy_1.2_strict-1.3'.</p><p>Only HTTPS listeners support modifying this parameter.</p>
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// <p>Server certificate.</p><p>Input limit: currently only support importing one cert; to use multiple certs, use the cert api CreateListenerAdditionalCert to add other certs.</p><p>Only HTTPS listeners support modification of this parameter.</p>
        /// </summary>
        [JsonProperty("ServerCertificates")]
        public string[] ServerCertificates{ get; set; }

        /// <summary>
        /// <p>Client certificate.</p><p>Input limitations: 1. Currently only support importing one certificate; to use multiple certificates, use the certificate api CreateListenerAdditionalCert to add other certificates. 2. The certificate must be a CA certificate.</p><p>Only HTTPS listeners support modification of this parameter, and mutual authentication must be enabled.</p>
        /// </summary>
        [JsonProperty("ClientCaCertificates")]
        public string[] ClientCaCertificates{ get; set; }

        /// <summary>
        /// <p>Method of obtaining the source IP.</p><p>Input parameter limits: support selecting 'ProxyProtocol', 'Close', 'ProxyProtocolV2', 'TOA'.</p><p>Only TCP listeners support modification of this parameter.</p>
        /// </summary>
        [JsonProperty("GetRealIpType")]
        public string GetRealIpType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "ClientAffinity", this.ClientAffinity);
            this.SetParamSimple(map, prefix + "ClientAffinityTime", this.ClientAffinityTime);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamSimple(map, prefix + "XForwardedForRealIp", this.XForwardedForRealIp);
            this.SetParamSimple(map, prefix + "CertificationType", this.CertificationType);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamArraySimple(map, prefix + "ServerCertificates.", this.ServerCertificates);
            this.SetParamArraySimple(map, prefix + "ClientCaCertificates.", this.ClientCaCertificates);
            this.SetParamSimple(map, prefix + "GetRealIpType", this.GetRealIpType);
        }
    }
}

