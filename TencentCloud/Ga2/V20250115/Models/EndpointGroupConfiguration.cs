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

    public class EndpointGroupConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <p>Terminal node group name.</p><p>Parameter format: starting with a letter or Chinese characters, 2–128 characters in length, supporting letters, digits, Chinese characters, . - _</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Region of the terminal node group.</p>
        /// </summary>
        [JsonProperty("EndpointGroupRegion")]
        public string EndpointGroupRegion{ get; set; }

        /// <summary>
        /// <p>Terminal node configuration.</p>
        /// </summary>
        [JsonProperty("EndpointConfigurations")]
        public EndpointConfigurations[] EndpointConfigurations{ get; set; }

        /// <summary>
        /// <p>Check protocol. Supports configuration of 'TCP', 'HTTP', 'PING', and 'CUSTOM'.</p><p>Enumeration values:</p><ul><li>TCP: When the CLB listener protocol where the terminal node group resides is TCP, choose TCP as the check protocol.</li><li>HTTP: When the CLB listener protocol where the terminal node group resides is HTTP or HTTPS, choose HTTP as the check protocol.</li><li>PING: When the CLB listener protocol where the terminal node group resides is UDP, choose PING as the check protocol.</li><li>CUSTOM: When the CLB listener protocol where the terminal node group resides is UDP or TCP, choose CUSTOM as the check protocol.</li></ul><p>This field is required when health check is enabled.</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// <p>Description.</p><p>Default value: empty by default, representing no configuration description.</p><p>Maximum length: 100 bytes.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Check port.</p><p>Input limit: range 1-65535.</p><p>This field is required when CheckType is CUSTOM.</p>
        /// </summary>
        [JsonProperty("CheckPort")]
        public string CheckPort{ get; set; }

        /// <summary>
        /// <p>Check content. Supports configuration 'TEXT'.</p><p>Enumeration values:</p><ul><li>TEXT: Text content.</li></ul><p>This field is required when CheckType is CUSTOM.</p>
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// <p>Check request.</p><p>Input parameter limit: The byte length must be within 1-500.</p><p>This field is required when CheckType is CUSTOM.</p>
        /// </summary>
        [JsonProperty("CheckSendContext")]
        public string CheckSendContext{ get; set; }

        /// <summary>
        /// <p>Check returned results.</p><p>Input parameter limit: The byte length must be within 1-500.</p><p>When CheckType is CUSTOM, this field is required.</p>
        /// </summary>
        [JsonProperty("CheckRecvContext")]
        public string CheckRecvContext{ get; set; }

        /// <summary>
        /// <p>Whether to enable health check.</p><p>Default value: False</p>
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// <p>Response timeout.</p><p>Value range: [1, 100]</p><p>Default value: 2</p><p>This field is required when health check is enabled.</p>
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// <p>Health check interval.</p><p>Value range: [5, 300].</p><p>Default value: 30.</p><p>This field is required when health check is enabled.</p>
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// <p>Unhealthy threshold.</p><p>Value range: [1, 10]</p><p>Default value: 3</p><p>This field is required when health check is enabled.</p>
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public ulong? UnhealthyThreshold{ get; set; }

        /// <summary>
        /// <p>Health threshold.</p><p>Value range: [1, 10]</p><p>Default value: 3</p><p>This field is required when health check is enabled.</p>
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public ulong? HealthyThreshold{ get; set; }

        /// <summary>
        /// <p>Origin-pull protocol. HTTP and HTTPS can be configured.</p><p>Enumeration values:</p><ul><li>HTTP: HTTP origin-pull. HTTP can be configured when the listener protocol where the terminal node group resides is HTTP or HTTPS.</li><li>HTTPS: HTTPS origin-pull. HTTPS can be configured when the listener protocol where the terminal node group resides is HTTPS.</li></ul><p>This field is required when the listener protocol where the terminal node group resides is HTTP or HTTPS.</p>
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// <p>Check domain name.</p><p>Input parameter limit: The byte length range is 3-80.</p><p>This field is required when CheckType is HTTP.</p>
        /// </summary>
        [JsonProperty("CheckDomain")]
        public string CheckDomain{ get; set; }

        /// <summary>
        /// <p>Check the URL.</p><p>Parameter format: must match the regular expression: ^[a-zA-Z0-9_.\-\/]{1,80}$</p><p>This field is required when CheckType is HTTP.</p>
        /// </summary>
        [JsonProperty("CheckPath")]
        public string CheckPath{ get; set; }

        /// <summary>
        /// <p>Request method. Supports configuration of 'GET' and 'HEAD'.</p><p>Enumeration values:</p><ul><li>GET: The request method is GET.</li><li>HEAD: The request method is HEAD.</li></ul><p>When CheckType is HTTP, this field is required.</p>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// <p>Status check code. Supports configuring 'http_2xx', 'http_3xx', 'http_4xx', 'http_5xx'.</p><p>Enumeration values:</p><ul><li>http_2xx: HTTP codes beginning with 2.</li><li>http_3xx: HTTP codes beginning with 3.</li><li>http_4xx: HTTP codes beginning with 4.</li><li>http_5xx: HTTP codes beginning with 5.</li></ul><p>This field is required when CheckType is HTTP.</p>
        /// </summary>
        [JsonProperty("StatusMask")]
        public string[] StatusMask{ get; set; }

        /// <summary>
        /// <p>Port mapping.</p><p>Input limits: Layer 7 supports 1 port mapping, and Layer 4 supports up to 30 port mappings.</p>
        /// </summary>
        [JsonProperty("PortOverrides")]
        public PortOverride[] PortOverrides{ get; set; }

        /// <summary>
        /// <p>Operator type. Supports configuration 'CMCC', 'CTCC', 'CUCC'.</p><p>Enumeration values:</p><ul><li>CMCC: China Mobile</li><li>CUCC: China Unicom</li><li>CTCC: China Telecom</li></ul><p>This field is required when the terminal node group region is a triple-network region.</p>
        /// </summary>
        [JsonProperty("IspType")]
        public string IspType{ get; set; }

        /// <summary>
        /// <p>HPPTS encryption algorithm suite; supports configuration 'tls_policy_1.0-2', 'tls_policy_1.1-2', 'tls_policy_1.2', 'tls_policy_1.2_strict', 'tls_policy_1.2_strict-1.3';</p><p>Enumeration values:</p><ul><li>tls_policy_1.0-2: encryption algorithm suite.</li><li>tls_policy_1.1-2: encryption algorithm suite.</li><li>tls_policy_1.2: encryption algorithm suite.</li><li>tls_policy_1.2_strict: encryption algorithm suite.</li><li>tls_policy_1.2_strict-1.3: encryption algorithm suite.</li></ul><p>This field is required when the origin-pull protocol is HTTPS.</p>
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// <p>Origin-pull protocol. Supports configuration of 'HTTP/1.1' and 'HTTP/2'.</p><p>Enumeration values:</p><ul><li>HTTP/1.1: version HTTP/1.1</li><li>HTTP/2: version HTTP/2</li></ul><p>This field is required when the origin-pull protocol is HTTPS.</p>
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EndpointGroupRegion", this.EndpointGroupRegion);
            this.SetParamArrayObj(map, prefix + "EndpointConfigurations.", this.EndpointConfigurations);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CheckPort", this.CheckPort);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "CheckSendContext", this.CheckSendContext);
            this.SetParamSimple(map, prefix + "CheckRecvContext", this.CheckRecvContext);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "HealthCheckInterval", this.HealthCheckInterval);
            this.SetParamSimple(map, prefix + "UnhealthyThreshold", this.UnhealthyThreshold);
            this.SetParamSimple(map, prefix + "HealthyThreshold", this.HealthyThreshold);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "CheckDomain", this.CheckDomain);
            this.SetParamSimple(map, prefix + "CheckPath", this.CheckPath);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamArraySimple(map, prefix + "StatusMask.", this.StatusMask);
            this.SetParamArrayObj(map, prefix + "PortOverrides.", this.PortOverrides);
            this.SetParamSimple(map, prefix + "IspType", this.IspType);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
        }
    }
}

