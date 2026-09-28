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

    public class ModifyHealthCheckTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Health check template ID. The format is `hct-` followed by alphanumeric characters.</p>
        /// </summary>
        [JsonProperty("HealthCheckTemplateId")]
        public string HealthCheckTemplateId{ get; set; }

        /// <summary>
        /// <p>Whether to preview this request.</p><ul><li><strong>false</strong> (default): Send a normal request to directly modify the health check template.</li><li><strong>true</strong>: Send a preview request to check whether the parameters, format, and service limits of the modified health check template meet the requirements.</li></ul>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>Health check status code. Value:</p><ul><li>When the health check protocol is <strong>HTTP/HTTPS</strong>:<ul><li><strong>HTTP_1xx</strong></li><li><strong>HTTP_2xx</strong> (default value)</li><li><strong>HTTP_3xx</strong></li><li><strong>HTTP_4xx</strong></li><li><strong>HTTP_5xx</strong></li></ul></li><li>When the health check protocol is <strong>GRPC/GRPCS</strong>: the default value is <strong>12</strong>, the value range is <strong>0-99</strong>, and the input value can be a numerical value, multiple values, a range, or a combination, for example:<ul><li><strong>"20"</strong></li><li><strong>"0-99"</strong></li></ul></li></ul>
        /// </summary>
        [JsonProperty("HealthCheckCodes")]
        public string[] HealthCheckCodes{ get; set; }

        /// <summary>
        /// <p>Threshold for determining backend service health. After the health check succeeds consecutively for this number of times, the backend service status changes from <strong>unhealthy</strong> to <strong>healthy</strong>.<br>Value range: <strong>2</strong>-<strong>10</strong>.<br>Default value: <strong>2</strong>.</p>
        /// </summary>
        [JsonProperty("HealthCheckHealthyThreshold")]
        public ulong? HealthCheckHealthyThreshold{ get; set; }

        /// <summary>
        /// <p>Health check domain name.<br>Length limit: <strong>1-255</strong> characters.<br>It can contain lowercase letters, digits, dashes (-), and half-width periods (.).</p><blockquote><p>This parameter takes effect only when <strong>HealthCheckProtocol</strong> is set to <strong>HTTP/HTTPS/GRPC/GRPCS</strong>.</p></blockquote>
        /// </summary>
        [JsonProperty("HealthCheckHost")]
        public string HealthCheckHost{ get; set; }

        /// <summary>
        /// <p>HTTP version for health check. Valid values:</p><ul><li><strong>HTTP1.1</strong> (default)</li><li><strong>HTTP1.0</strong> <blockquote><p>This parameter takes effect only when <strong>HealthCheckProtocol</strong> is set to <strong>HTTP</strong> or <strong>HTTPS</strong>.</p></blockquote></li></ul>
        /// </summary>
        [JsonProperty("HealthCheckHttpVersion")]
        public string HealthCheckHttpVersion{ get; set; }

        /// <summary>
        /// <p>The interval of health check. Unit: second. Value range: <strong>2</strong>-<strong>300</strong>. Default value: <strong>5</strong>.</p>
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// <p>Health check method. Value: - <strong>GET</strong> - <strong>HEAD</strong> (default value) </p><blockquote><p>This parameter takes effect only when <strong>HealthCheckProtocol</strong> is set to <strong>HTTP</strong> or <strong>HTTPS</strong>.</p></blockquote>
        /// </summary>
        [JsonProperty("HealthCheckMethod")]
        public string HealthCheckMethod{ get; set; }

        /// <summary>
        /// <p>Forwarding rule path for health check. The length is <strong>1-80</strong> characters. Only letters, digits, characters <code>-/.%?#&amp;=</code>, and extended characters <code>_;~!（)*[]@$^:&#39;,+</code> can be used. The URL must start with a forward slash (/). </p><blockquote><p>The forwarding rule path parameter takes effect only when <strong>HealthCheckProtocol</strong> is <strong>HTTP/HTTPS/GRPC/GRPCS</strong>.</p></blockquote>
        /// </summary>
        [JsonProperty("HealthCheckPath")]
        public string HealthCheckPath{ get; set; }

        /// <summary>
        /// <p>Health check access to the backend server port. Value range: <strong>0-65535</strong>. Default value: <strong>0</strong>, which means the backend server port.</p>
        /// </summary>
        [JsonProperty("HealthCheckPort")]
        public ulong? HealthCheckPort{ get; set; }

        /// <summary>
        /// <p>Health check protocol. Valid values:</p><ul><li><strong>HTTP</strong> (default): Sends HEAD or GET requests to simulate browser access requests and check whether the server application is healthy.</li><li><strong>HTTPS</strong>: Sends HEAD or GET requests to simulate browser access requests and check whether the server application is healthy. (Encrypts data and is more secure than HTTP.)</li><li><strong>TCP</strong>: Sends SYN handshake messages to detect whether the server port is alive.</li><li><strong>GRPC</strong>: Sends POST or GET requests to check whether the server application is healthy.</li><li><strong>GRPCS</strong>: Sends POST or GET requests to check whether the server application is healthy.</li></ul>
        /// </summary>
        [JsonProperty("HealthCheckProtocol")]
        public string HealthCheckProtocol{ get; set; }

        /// <summary>
        /// <p>Health check template name. It is 1-255 characters long and can contain digits, upper- and lower-case letters, Chinese characters, half-width periods (.), underscores (_), and dashes (-).</p>
        /// </summary>
        [JsonProperty("HealthCheckTemplateName")]
        public string HealthCheckTemplateName{ get; set; }

        /// <summary>
        /// <p>Health check response timeout, in seconds.<br>Value range: <strong>2</strong>-<strong>60</strong>.<br>Default value: <strong>2</strong>.</p>
        /// </summary>
        [JsonProperty("HealthCheckTimeout")]
        public ulong? HealthCheckTimeout{ get; set; }

        /// <summary>
        /// <p>Threshold for determining an unhealthy backend service. After how many consecutive health check failures, the backend service status changes from <strong>healthy</strong> to <strong>unhealthy</strong>.<br>Value range: <strong>2</strong>-<strong>10</strong>.<br>Default value: <strong>2</strong>.</p>
        /// </summary>
        [JsonProperty("HealthCheckUnhealthyThreshold")]
        public ulong? HealthCheckUnhealthyThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthCheckTemplateId", this.HealthCheckTemplateId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamArraySimple(map, prefix + "HealthCheckCodes.", this.HealthCheckCodes);
            this.SetParamSimple(map, prefix + "HealthCheckHealthyThreshold", this.HealthCheckHealthyThreshold);
            this.SetParamSimple(map, prefix + "HealthCheckHost", this.HealthCheckHost);
            this.SetParamSimple(map, prefix + "HealthCheckHttpVersion", this.HealthCheckHttpVersion);
            this.SetParamSimple(map, prefix + "HealthCheckInterval", this.HealthCheckInterval);
            this.SetParamSimple(map, prefix + "HealthCheckMethod", this.HealthCheckMethod);
            this.SetParamSimple(map, prefix + "HealthCheckPath", this.HealthCheckPath);
            this.SetParamSimple(map, prefix + "HealthCheckPort", this.HealthCheckPort);
            this.SetParamSimple(map, prefix + "HealthCheckProtocol", this.HealthCheckProtocol);
            this.SetParamSimple(map, prefix + "HealthCheckTemplateName", this.HealthCheckTemplateName);
            this.SetParamSimple(map, prefix + "HealthCheckTimeout", this.HealthCheckTimeout);
            this.SetParamSimple(map, prefix + "HealthCheckUnhealthyThreshold", this.HealthCheckUnhealthyThreshold);
        }
    }
}

