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
        /// 
        /// </summary>
        [JsonProperty("PublicAccessEndpoint")]
        public string PublicAccessEndpoint{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WebConsoleEndpoint")]
        public string WebConsoleEndpoint{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WebConsoleUsername")]
        public string WebConsoleUsername{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WebConsolePassword")]
        public string WebConsolePassword{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PublicAccessEndpointStatus")]
        public bool? PublicAccessEndpointStatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PublicControlConsoleSwitchStatus")]
        public bool? PublicControlConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VpcControlConsoleSwitchStatus")]
        public bool? VpcControlConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VpcWebConsoleEndpoint")]
        public string VpcWebConsoleEndpoint{ get; set; }

        /// <summary>
        /// Status of the public network access point in the console. Valid values: OFF, ON, CREATING, and DELETING.
        /// </summary>
        [JsonProperty("PublicWebConsoleSwitchStatus")]
        public string PublicWebConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// Vpc console switch state. example value.
        /// OFF/ON/CREATING/DELETING
        /// </summary>
        [JsonProperty("VpcWebConsoleSwitchStatus")]
        public string VpcWebConsoleSwitchStatus{ get; set; }

        /// <summary>
        /// Status of the public network access point in the console. Valid values: OFF, ON, CREATING, and DELETING.
        /// </summary>
        [JsonProperty("PublicDataStreamStatus")]
        public string PublicDataStreamStatus{ get; set; }

        /// <summary>
        /// Prometheus information.
        /// </summary>
        [JsonProperty("PrometheusEndpointInfo")]
        public PrometheusEndpointInfo PrometheusEndpointInfo{ get; set; }

        /// <summary>
        /// Public domain name access point.
        /// </summary>
        [JsonProperty("WebConsoleDomainEndpoint")]
        public string WebConsoleDomainEndpoint{ get; set; }

        /// <summary>
        /// VPC information used by the control plane.
        /// </summary>
        [JsonProperty("ControlPlaneEndpointInfo")]
        public VpcEndpointInfo ControlPlaneEndpointInfo{ get; set; }

        /// <summary>
        /// Encrypted TLS data stream public network access point.
        /// </summary>
        [JsonProperty("PublicTlsAccessEndpoint")]
        public string PublicTlsAccessEndpoint{ get; set; }

        /// <summary>
        /// Specifies whether to reuse the public IP address.
        /// </summary>
        [JsonProperty("PublicIpReused")]
        public bool? PublicIpReused{ get; set; }


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
        }
    }
}

