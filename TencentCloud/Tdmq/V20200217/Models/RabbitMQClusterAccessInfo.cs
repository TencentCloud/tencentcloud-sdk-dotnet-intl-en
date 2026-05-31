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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQClusterAccessInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster public network access address</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicAccessEndpoint")]
        public string PublicAccessEndpoint{ get; set; }

        /// <summary>
        /// <p>Public network access URL of the cluster Web console</p>
        /// </summary>
        [JsonProperty("WebConsoleEndpoint")]
        public string WebConsoleEndpoint{ get; set; }

        /// <summary>
        /// <p>Cluster Web console login username</p>
        /// </summary>
        [JsonProperty("WebConsoleUsername")]
        public string WebConsoleUsername{ get; set; }

        /// <summary>
        /// <p>Cluster Web console login password</p>
        /// </summary>
        [JsonProperty("WebConsolePassword")]
        public string WebConsolePassword{ get; set; }

        /// <summary>
        /// <p>Abandoned</p>
        /// </summary>
        [JsonProperty("PublicAccessEndpointStatus")]
        public bool? PublicAccessEndpointStatus{ get; set; }

        /// <summary>
        /// <p>Deprecated</p>
        /// </summary>
        [JsonProperty("PublicControlConsoleSwitchStatus")]
        public bool? PublicControlConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// <p>Abandoned</p>
        /// </summary>
        [JsonProperty("VpcControlConsoleSwitchStatus")]
        public bool? VpcControlConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// <p>VPC access URL of the Web console</p>
        /// </summary>
        [JsonProperty("VpcWebConsoleEndpoint")]
        public string VpcWebConsoleEndpoint{ get; set; }

        /// <summary>
        /// <p>Status of the public network access switch in the Web console</p><p>Enumeration value:</p><ul><li>OFF: Closed</li><li>ON: ON</li><li>CREATING: CREATING</li><li>DELETING: DELETING</li><li>CREATE_FAILURE: Creation failed</li><li>DELETE_FAILURE: Deletion failed</li></ul>
        /// </summary>
        [JsonProperty("PublicWebConsoleSwitchStatus")]
        public string PublicWebConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// <p>Web console VPC access switch status</p><p>Enumeration values:</p><ul><li>OFF: Closed</li><li>ON: Enabled</li><li>CREATING: Creating</li><li>DELETING: Deleting</li><li>CREATE_FAILURE: Creation failed</li><li>DELETE_FAILURE: Deletion failed</li></ul>
        /// </summary>
        [JsonProperty("VpcWebConsoleSwitchStatus")]
        public string VpcWebConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// <p>Public network access point switch state</p><p>Enumeration value:</p><ul><li>OFF: Closed</li><li>ON: Enabled</li><li>CREATING: Creating</li><li>DELETING: Deleting</li><li>CREATE_FAILURE: Creation failure</li><li>DELETE_FAILURE: Deletion failure</li></ul>
        /// </summary>
        [JsonProperty("PublicDataStreamStatus")]
        public string PublicDataStreamStatus{ get; set; }

        /// <summary>
        /// <p>Prometheus info</p>
        /// </summary>
        [JsonProperty("PrometheusEndpointInfo")]
        public PrometheusEndpointInfo PrometheusEndpointInfo{ get; set; }

        /// <summary>
        /// <p>public domain name access point</p>
        /// </summary>
        [JsonProperty("WebConsoleDomainEndpoint")]
        public string WebConsoleDomainEndpoint{ get; set; }

        /// <summary>
        /// <p>VPC information used by the control plane</p>
        /// </summary>
        [JsonProperty("ControlPlaneEndpointInfo")]
        public VpcEndpointInfo ControlPlaneEndpointInfo{ get; set; }

        /// <summary>
        /// <p>TLS encrypted data stream public network access point</p>
        /// </summary>
        [JsonProperty("PublicTlsAccessEndpoint")]
        public string PublicTlsAccessEndpoint{ get; set; }

        /// <summary>
        /// <p>Whether to reuse the public IP address</p>
        /// </summary>
        [JsonProperty("PublicIpReused")]
        public bool? PublicIpReused{ get; set; }

        /// <summary>
        /// <p>Error information of public network access operations for the Web console</p>
        /// </summary>
        [JsonProperty("PublicWebConsoleErrorMessage")]
        public string PublicWebConsoleErrorMessage{ get; set; }

        /// <summary>
        /// <p>Error information of VPC access operations in the Web console</p>
        /// </summary>
        [JsonProperty("VpcWebConsoleErrorMessage")]
        public string VpcWebConsoleErrorMessage{ get; set; }

        /// <summary>
        /// <p>Error information of public network access point operations</p>
        /// </summary>
        [JsonProperty("PublicDataStreamErrorMessage")]
        public string PublicDataStreamErrorMessage{ get; set; }

        /// <summary>
        /// <p>Public network Stream access point</p>
        /// </summary>
        [JsonProperty("PublicStreamAccessEndpoint")]
        public string PublicStreamAccessEndpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicAccessEndpoint", this.PublicAccessEndpoint);
            this.SetParamSimple(map, prefix + "WebConsoleEndpoint", this.WebConsoleEndpoint);
            this.SetParamSimple(map, prefix + "WebConsoleUsername", this.WebConsoleUsername);
            this.SetParamSimple(map, prefix + "WebConsolePassword", this.WebConsolePassword);
            this.SetParamSimple(map, prefix + "PublicAccessEndpointStatus", this.PublicAccessEndpointStatus);
            this.SetParamSimple(map, prefix + "PublicControlConsoleSwitchStatus", this.PublicControlConsoleSwitchStatus);
            this.SetParamSimple(map, prefix + "VpcControlConsoleSwitchStatus", this.VpcControlConsoleSwitchStatus);
            this.SetParamSimple(map, prefix + "VpcWebConsoleEndpoint", this.VpcWebConsoleEndpoint);
            this.SetParamSimple(map, prefix + "PublicWebConsoleSwitchStatus", this.PublicWebConsoleSwitchStatus);
            this.SetParamSimple(map, prefix + "VpcWebConsoleSwitchStatus", this.VpcWebConsoleSwitchStatus);
            this.SetParamSimple(map, prefix + "PublicDataStreamStatus", this.PublicDataStreamStatus);
            this.SetParamObj(map, prefix + "PrometheusEndpointInfo.", this.PrometheusEndpointInfo);
            this.SetParamSimple(map, prefix + "WebConsoleDomainEndpoint", this.WebConsoleDomainEndpoint);
            this.SetParamObj(map, prefix + "ControlPlaneEndpointInfo.", this.ControlPlaneEndpointInfo);
            this.SetParamSimple(map, prefix + "PublicTlsAccessEndpoint", this.PublicTlsAccessEndpoint);
            this.SetParamSimple(map, prefix + "PublicIpReused", this.PublicIpReused);
            this.SetParamSimple(map, prefix + "PublicWebConsoleErrorMessage", this.PublicWebConsoleErrorMessage);
            this.SetParamSimple(map, prefix + "VpcWebConsoleErrorMessage", this.VpcWebConsoleErrorMessage);
            this.SetParamSimple(map, prefix + "PublicDataStreamErrorMessage", this.PublicDataStreamErrorMessage);
            this.SetParamSimple(map, prefix + "PublicStreamAccessEndpoint", this.PublicStreamAccessEndpoint);
        }
    }
}

