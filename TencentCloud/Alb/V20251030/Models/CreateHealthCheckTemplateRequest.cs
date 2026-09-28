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

    public class CreateHealthCheckTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether to preview this request.
        /// - **false** (default): Send a normal request to directly modify the health check template.
        /// - **true**: Send a preview request to check whether the parameters, format, and service limits of the health check template to modify meet the requirements.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// Health check status code. Value:
        /// - When the health check protocol is **HTTP/HTTPS**:
        /// 	- **http_1xx**
        /// 	- **http_2xx** (default value)
        /// 	-  **http_3xx**
        /// 	-  **http_4xx**
        /// 	-  **http_5xx**
        /// - When the health check protocol is **GRPC/GRPCS**: the default value is **12**, the value range is **0-99**, and the input value can be a numerical value, multiple values, a range, or a composite, for example:
        /// 	- **"20"**
        /// 	- **"0-99"**
        /// </summary>
        [JsonProperty("HealthCheckCodes")]
        public string[] HealthCheckCodes{ get; set; }

        /// <summary>
        /// Threshold for determining backend service health. After the health check succeeds consecutively for this number of times, the backend service status changes from **unhealthy** to **healthy**.
        /// Value range: **2**-**10**.
        /// Default value: **2**.
        /// </summary>
        [JsonProperty("HealthCheckHealthyThreshold")]
        public ulong? HealthCheckHealthyThreshold{ get; set; }

        /// <summary>
        /// Health check domain name.
        /// Length limit: **1–255** characters.
        /// It can contain lowercase letters, digits, dashes (-), and half-width periods (.).
        /// 
        /// > This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP/HTTPS/GRPC/GRPCS**.
        /// </summary>
        [JsonProperty("HealthCheckHost")]
        public string HealthCheckHost{ get; set; }

        /// <summary>
        /// HTTP version for health check. Value:
        /// - **HTTP1.1** (default)
        /// - **HTTP1.0** 
        /// > This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**.
        /// </summary>
        [JsonProperty("HealthCheckHttpVersion")]
        public string HealthCheckHttpVersion{ get; set; }

        /// <summary>
        /// The interval of health check. Unit: second. Value range: **2**-**300**. Default value: **5**.
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// Health check method. Valid values: - **GET** - **HEAD** (default value) 
        /// > This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**.
        /// </summary>
        [JsonProperty("HealthCheckMethod")]
        public string HealthCheckMethod{ get; set; }

        /// <summary>
        /// Forwarding rule path for health check. Length: **1-80** characters. Only can use letters, numbers, characters `-/.%?#&=` as well as extended characters `_;~!（)*[]@$^:',+`. The URL must start with a forward slash (/). 
        /// > The forwarding rule path parameter takes effect only when **HealthCheckProtocol** is **HTTP/HTTPS/GRPC/GRPCS**.
        /// </summary>
        [JsonProperty("HealthCheckPath")]
        public string HealthCheckPath{ get; set; }

        /// <summary>
        /// Health check access to the backend server port. Value range: **0-65535**. Default value: **0**, which means the backend server port.
        /// </summary>
        [JsonProperty("HealthCheckPort")]
        public ulong? HealthCheckPort{ get; set; }

        /// <summary>
        /// Health check protocol. Valid values:
        /// - **HTTP** (default): Check whether the server application is healthy by sending HEAD or GET requests to simulate browser access requests.
        /// - **HTTPS**: Check whether the server application is healthy by sending HEAD or GET requests to simulate browser access requests. (Data encryption, more secure compared with HTTP.)
        /// - **TCP**: Detect whether the server port is alive by sending SYN handshake messages.
        /// - **GRPC**: Check whether the server application is healthy by sending a POST or GET request.
        /// - **GRPCS**: Check whether the server application is healthy by sending a POST or GET request.
        /// </summary>
        [JsonProperty("HealthCheckProtocol")]
        public string HealthCheckProtocol{ get; set; }

        /// <summary>
        /// Health check template name. It must be 1-255 characters long and can contain digits, upper- and lower-case letters, Chinese characters, half-width periods (.), underscores (_), and dashes (-).
        /// </summary>
        [JsonProperty("HealthCheckTemplateName")]
        public string HealthCheckTemplateName{ get; set; }

        /// <summary>
        /// timeout period for the health check. Unit: seconds.
        /// Valid values: **2**-**60**.
        /// Default value: **2**.
        /// </summary>
        [JsonProperty("HealthCheckTimeout")]
        public ulong? HealthCheckTimeout{ get; set; }

        /// <summary>
        /// Threshold for determining an unhealthy backend service. The backend service status changes from healthy to unhealthy after the health check fails consecutively for this number of times.
        /// Value range: **2**-**10**.
        /// Default value: **2**.
        /// </summary>
        [JsonProperty("HealthCheckUnhealthyThreshold")]
        public ulong? HealthCheckUnhealthyThreshold{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
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
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

