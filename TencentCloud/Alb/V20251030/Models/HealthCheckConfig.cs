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

    public class HealthCheckConfig : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the health check.
        /// - **true**: enable.
        /// - **false**: not enabled.
        /// </summary>
        [JsonProperty("HealthCheckEnabled")]
        public bool? HealthCheckEnabled{ get; set; }

        /// <summary>
        /// Health check status code. Value:
        /// - When the health check protocol is **HTTP/HTTPS**:
        /// 	- **http_1xx**
        /// 	- **http_2xx** (default value)
        /// 	-  **http_3xx**
        /// 	-  **http_4xx**
        /// 	-  **http_5xx**
        /// - When the health check protocol is **gRPC**: default value: 12, value range: 0-99. The input value can be a numerical value, multiple values, a range, or a composite of these, for example:
        /// 	- **"20"**
        /// 	- **"0-99"**
        /// > This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP**, **HTTPS**, **GRPC**, or **GRPCS**.
        /// </summary>
        [JsonProperty("HealthCheckCodes")]
        public string[] HealthCheckCodes{ get; set; }

        /// <summary>
        /// Threshold for determining backend service health. After the number of consecutive successful health checks reaches this value, the backend service status changes from **unhealthy** to **healthy**.
        /// Value range: **2**-**10**.
        /// Default value: **2**.
        /// </summary>
        [JsonProperty("HealthCheckHealthyThreshold")]
        public ulong? HealthCheckHealthyThreshold{ get; set; }

        /// <summary>
        /// Health check domain. If this parameter is not set, the intranet IP of the backend service is used as the health check address by default.
        /// Domain restriction:
        /// -Length limit: **1-255** characters.
        /// - It can contain lowercase letters, digits, hyphens (-), and half-width periods (.).
        /// -At least one half-width period (.) is required, and it cannot appear at the beginning or end.
        /// -The rightmost domain tag can only contain letters. It cannot contain digits or en dashes (-).
        /// -En dash (-) cannot appear at the beginning or end.
        /// >This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP**, **HTTPS**, **GRPC**, or **GRPCS**.
        /// </summary>
        [JsonProperty("HealthCheckHost")]
        public string HealthCheckHost{ get; set; }

        /// <summary>
        /// HTTP version for health check.
        /// - **HTTP1.1** (default)
        /// - **HTTP1.0** 
        /// > This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**.
        /// </summary>
        [JsonProperty("HealthCheckHttpVersion")]
        public string HealthCheckHttpVersion{ get; set; }

        /// <summary>
        /// Health check interval. Unit: second.
        /// Valid values: **2**-**300**.
        /// Default value: **5**.
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// Health check method. Valid values:
        /// - **GET**
        /// - **HEAD** (default value)
        /// > This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**.
        /// </summary>
        [JsonProperty("HealthCheckMethod")]
        public string HealthCheckMethod{ get; set; }

        /// <summary>
        /// Forwarding rule path for health check.
        /// Length: 1–80 characters. Only letters, digits, characters `-/.%?#&=` and extended characters `_;~!()*[]@$^:',+` can be used. The URL must start with a forward slash (/).
        /// > The forwarding rule path parameter takes effect only when **HealthCheckProtocol** is set to **HTTP**, **HTTPS**, **GRPC**, or **GRPCS**.
        /// </summary>
        [JsonProperty("HealthCheckPath")]
        public string HealthCheckPath{ get; set; }

        /// <summary>
        /// Health check accesses the backend server port.
        /// 
        /// Valid values: **0-65535**.
        /// 
        /// Default value: **0**, which indicates the backend server port.
        /// </summary>
        [JsonProperty("HealthCheckPort")]
        public ulong? HealthCheckPort{ get; set; }

        /// <summary>
        /// Health check protocol. Valid values:
        /// - **HTTP** (default): Simulate browser access requests by sending HEAD or GET requests to check whether the server application is healthy.
        /// - **HTTPS**: Checks the health of a server application by sending HEAD or GET requests to simulate browser access requests. (Encrypts data and is more secure compared with HTTP.)
        /// - **TCP**: Detect whether the server port is alive by sending SYN handshake messages.
        /// - **GRPC**: Check whether the server application is healthy by sending a POST request.
        /// - **GRPCS**: Send a POST request to check whether the server application is healthy.
        /// </summary>
        [JsonProperty("HealthCheckProtocol")]
        public string HealthCheckProtocol{ get; set; }

        /// <summary>
        /// timeout period for health check. Unit: seconds.
        /// Valid values: **2**-**60**.
        /// Default value: **2**.
        /// </summary>
        [JsonProperty("HealthCheckTimeout")]
        public ulong? HealthCheckTimeout{ get; set; }

        /// <summary>
        /// Threshold for determining an unhealthy backend service. The backend service status changes from **healthy** to **unhealthy** after the health check fails this number of consecutive times.
        /// Value range: **2**-**10**.
        /// Default value: **2**.
        /// </summary>
        [JsonProperty("HealthCheckUnhealthyThreshold")]
        public ulong? HealthCheckUnhealthyThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthCheckEnabled", this.HealthCheckEnabled);
            this.SetParamArraySimple(map, prefix + "HealthCheckCodes.", this.HealthCheckCodes);
            this.SetParamSimple(map, prefix + "HealthCheckHealthyThreshold", this.HealthCheckHealthyThreshold);
            this.SetParamSimple(map, prefix + "HealthCheckHost", this.HealthCheckHost);
            this.SetParamSimple(map, prefix + "HealthCheckHttpVersion", this.HealthCheckHttpVersion);
            this.SetParamSimple(map, prefix + "HealthCheckInterval", this.HealthCheckInterval);
            this.SetParamSimple(map, prefix + "HealthCheckMethod", this.HealthCheckMethod);
            this.SetParamSimple(map, prefix + "HealthCheckPath", this.HealthCheckPath);
            this.SetParamSimple(map, prefix + "HealthCheckPort", this.HealthCheckPort);
            this.SetParamSimple(map, prefix + "HealthCheckProtocol", this.HealthCheckProtocol);
            this.SetParamSimple(map, prefix + "HealthCheckTimeout", this.HealthCheckTimeout);
            this.SetParamSimple(map, prefix + "HealthCheckUnhealthyThreshold", this.HealthCheckUnhealthyThreshold);
        }
    }
}

