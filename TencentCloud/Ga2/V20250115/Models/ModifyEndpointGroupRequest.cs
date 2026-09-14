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

    public class ModifyEndpointGroupRequest : AbstractModel
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
        /// <p>Terminal node group ID.</p>
        /// </summary>
        [JsonProperty("EndpointGroupId")]
        public string EndpointGroupId{ get; set; }

        /// <summary>
        /// <p>Terminal node configuration.</p>
        /// </summary>
        [JsonProperty("EndpointConfigurations")]
        public EndpointConfigurations[] EndpointConfigurations{ get; set; }

        /// <summary>
        /// <p>Name.</p><p>Parameter format: starting with a letter or Chinese characters, 2–128 characters in length, supporting letters, digits, Chinese characters, . - _</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Description.</p><p>Input limit: maximum length cannot exceed 100 bytes.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Whether to enable health check.</p>
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// <p>Response timeout.</p><p>Value range: [1, 100]</p><p>This parameter is required when health check is enabled.</p>
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// <p>Health check interval.</p><p>Value range: [5, 300].</p><p>This parameter is required when health check is enabled.</p>
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// <p>Unhealthy threshold.</p><p>Value range: [1, 10]</p><p>This field is required when health check is enabled.</p>
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public ulong? UnhealthyThreshold{ get; set; }

        /// <summary>
        /// <p>Health threshold.</p><p>Value range: [1, 10]</p><p>This field is required when health check is enabled.</p>
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public ulong? HealthyThreshold{ get; set; }

        /// <summary>
        /// <p>Select the protocol.</p><p>Input parameter limits: support filling in: 'TCP', 'HTTP', 'PING', 'CUSTOM'.</p><p>1. When the listener is TCP, you can choose CUSTOM+TCP.<br>2. When the listener is UDP, you can choose PING+CUSTOM.<br>3. When the listener is HTTP or HTTPS, you can choose HTTP.</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// <p>Check port.</p><p>Value range: [1, 65535]</p><p>This field is required when CheckType is CUSTOM.</p>
        /// </summary>
        [JsonProperty("CheckPort")]
        public ulong? CheckPort{ get; set; }

        /// <summary>
        /// <p>Check content.</p><p>Input parameter limit: Only TEXT is supported.</p><p>This field is required when CheckType is CUSTOM.</p>
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// <p>Check request.</p><p>Input parameter limit: The length range is 1-500.</p><p>This field is required when CheckType is CUSTOM.</p>
        /// </summary>
        [JsonProperty("CheckSendContext")]
        public string CheckSendContext{ get; set; }

        /// <summary>
        /// <p>Check returned results.</p><p>Input parameter limit: length range is 1-500.</p><p>When CheckType is CUSTOM, this field is required.</p>
        /// </summary>
        [JsonProperty("CheckRecvContext")]
        public string CheckRecvContext{ get; set; }

        /// <summary>
        /// <p>Check domain name.</p><p>Input parameter limit: The length range is 3-80.</p><p>This field is required when CheckType is HTTP.</p>
        /// </summary>
        [JsonProperty("CheckDomain")]
        public string CheckDomain{ get; set; }

        /// <summary>
        /// <p>Check the URL.</p><p>Input parameter limit: length range 3-80.</p><p>This field is required when CheckType is HTTP.</p>
        /// </summary>
        [JsonProperty("CheckPath")]
        public string CheckPath{ get; set; }

        /// <summary>
        /// <p>Request method.</p><p>Input parameter limit: support filling in 'GET', 'HEAD'.</p><p>This field is required when CheckType is HTTP.</p>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// <p>Status check code.</p><p>Input parameter limits: support selecting 'http_2xx', 'http_3xx', 'http_4xx', 'http_5xx'.</p><p>This field is required when CheckType is HTTP.</p>
        /// </summary>
        [JsonProperty("StatusMask")]
        public string[] StatusMask{ get; set; }

        /// <summary>
        /// <p>Origin-pull protocol.</p><p>Input parameter limits. Supported values: 'HTTP', 'HTTPS'.</p><p>When the CLB listener protocol is HTTP, only HTTP can be configured. When it is HTTPS, HTTP or HTTPS can be configured.</p>
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// <p>Port mapping.</p><p>When the CLB listener protocol is HTTP or HTTPS, one pair can be configured. When the CLB listener protocol is UDP or TCP, up to 30 pairs can be configured.</p>
        /// </summary>
        [JsonProperty("PortOverrides")]
        public PortOverride[] PortOverrides{ get; set; }

        /// <summary>
        /// <p>HPPTS encryption algorithm kit</p><p>Input parameter limit: support selecting 'tls_policy_1.0-2', 'tls_policy_1.1-2', 'tls_policy_1.2', 'tls_policy_1.2_strict', 'tls_policy_1.2_strict-1.3'.</p><p>This parameter can be modified only when the CLB listener protocol is HTTPS.</p>
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// <p>Only the HTTPS back-to-source protocol supports selecting ['HTTP/1.1', 'HTTP/2']</p><p>Enumeration values:</p><ul><li>HTTP/1.1: version HTTP/1.1</li><li>HTTP/2: version HTTP/2</li></ul>
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "EndpointGroupId", this.EndpointGroupId);
            this.SetParamArrayObj(map, prefix + "EndpointConfigurations.", this.EndpointConfigurations);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "HealthCheckInterval", this.HealthCheckInterval);
            this.SetParamSimple(map, prefix + "UnhealthyThreshold", this.UnhealthyThreshold);
            this.SetParamSimple(map, prefix + "HealthyThreshold", this.HealthyThreshold);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "CheckPort", this.CheckPort);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "CheckSendContext", this.CheckSendContext);
            this.SetParamSimple(map, prefix + "CheckRecvContext", this.CheckRecvContext);
            this.SetParamSimple(map, prefix + "CheckDomain", this.CheckDomain);
            this.SetParamSimple(map, prefix + "CheckPath", this.CheckPath);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamArraySimple(map, prefix + "StatusMask.", this.StatusMask);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamArrayObj(map, prefix + "PortOverrides.", this.PortOverrides);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
        }
    }
}

