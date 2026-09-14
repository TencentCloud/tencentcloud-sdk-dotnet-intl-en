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

    public class EndpointGroupConfigurationSet : AbstractModel
    {
        
        /// <summary>
        /// <p>Global acceleration instance ID.</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>Listener instance ID.</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>Terminal node group ID.</p>
        /// </summary>
        [JsonProperty("EndpointGroupId")]
        public string EndpointGroupId{ get; set; }

        /// <summary>
        /// <p>Name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Region.</p>
        /// </summary>
        [JsonProperty("EndpointGroupRegion")]
        public string EndpointGroupRegion{ get; set; }

        /// <summary>
        /// <p>Description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Endpoint information.</p>
        /// </summary>
        [JsonProperty("EndpointConfigurations")]
        public EndpointConfigurations[] EndpointConfigurations{ get; set; }

        /// <summary>
        /// <p>Whether to enable health check.</p>
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// <p>Response timeout.</p>
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// <p>Health check interval.</p>
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// <p>Unhealthy threshold.</p>
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public ulong? UnhealthyThreshold{ get; set; }

        /// <summary>
        /// <p>Health threshold.</p>
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public ulong? HealthyThreshold{ get; set; }

        /// <summary>
        /// <p>Select the protocol.</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// <p>Check port.</p>
        /// </summary>
        [JsonProperty("CheckPort")]
        public ulong? CheckPort{ get; set; }

        /// <summary>
        /// <p>Check content.</p>
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// <p>Check request.</p>
        /// </summary>
        [JsonProperty("CheckSendContext")]
        public string CheckSendContext{ get; set; }

        /// <summary>
        /// <p>Check returned results.</p>
        /// </summary>
        [JsonProperty("CheckRecvContext")]
        public string CheckRecvContext{ get; set; }

        /// <summary>
        /// <p>Check domain name.</p>
        /// </summary>
        [JsonProperty("CheckDomain")]
        public string CheckDomain{ get; set; }

        /// <summary>
        /// <p>Check the URL.</p>
        /// </summary>
        [JsonProperty("CheckPath")]
        public string CheckPath{ get; set; }

        /// <summary>
        /// <p>Request method.</p>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// <p>Status check code.</p>
        /// </summary>
        [JsonProperty("StatusMask")]
        public string[] StatusMask{ get; set; }

        /// <summary>
        /// <p>Terminal node group type.</p>
        /// </summary>
        [JsonProperty("EndpointGroupType")]
        public string EndpointGroupType{ get; set; }

        /// <summary>
        /// <p>Origin-pull protocol.</p>
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// <p>Port mapping info.</p>
        /// </summary>
        [JsonProperty("PortOverrides")]
        public PortOverride[] PortOverrides{ get; set; }

        /// <summary>
        /// <p>Whether the custom endpoint group is bound to a Layer 7 forwarding rule.</p>
        /// </summary>
        [JsonProperty("VirtualExistForwardingRuleFlag")]
        public bool? VirtualExistForwardingRuleFlag{ get; set; }

        /// <summary>
        /// <p>Public IP address of the egress terminal node group.</p>
        /// </summary>
        [JsonProperty("OriginPublicIps")]
        public string[] OriginPublicIps{ get; set; }

        /// <summary>
        /// <p>Operator type. China Mobile (CMCC), China Unicom (CUCC), China Telecom (CTCC).</p>
        /// </summary>
        [JsonProperty("IspType")]
        public string IspType{ get; set; }

        /// <summary>
        /// <p>HPPTS encryption algorithm kit</p>
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// <p>Only the HTTPS back-to-source protocol supports selecting ['HTTP/1.1', 'HTTP/2']</p><p>Enumeration values:</p><ul><li>HTTP/1.1: Version HTTP/1.1</li><li>HTTP/2: Version HTTP/2</li></ul>
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
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EndpointGroupRegion", this.EndpointGroupRegion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "EndpointConfigurations.", this.EndpointConfigurations);
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
            this.SetParamSimple(map, prefix + "EndpointGroupType", this.EndpointGroupType);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamArrayObj(map, prefix + "PortOverrides.", this.PortOverrides);
            this.SetParamSimple(map, prefix + "VirtualExistForwardingRuleFlag", this.VirtualExistForwardingRuleFlag);
            this.SetParamArraySimple(map, prefix + "OriginPublicIps.", this.OriginPublicIps);
            this.SetParamSimple(map, prefix + "IspType", this.IspType);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
        }
    }
}

