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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpstreamHealthChecker : AbstractModel
    {
        
        /// <summary>
        /// Specifies whether to enable active health check
        /// </summary>
        [JsonProperty("EnableActiveCheck")]
        public bool? EnableActiveCheck{ get; set; }

        /// <summary>
        /// Specifies whether the enable passive health check
        /// </summary>
        [JsonProperty("EnablePassiveCheck")]
        public bool? EnablePassiveCheck{ get; set; }

        /// <summary>
        /// The HTTP status code that indicates that the upstream is healthy
        /// </summary>
        [JsonProperty("HealthyHttpStatus")]
        public string HealthyHttpStatus{ get; set; }

        /// <summary>
        /// The HTTP status code that indicates that the upstream is unhealthy
        /// </summary>
        [JsonProperty("UnhealthyHttpStatus")]
        public string UnhealthyHttpStatus{ get; set; }

        /// <summary>
        /// The threshold on consecutive TCP errors. Range: [0, 254]. `0` indicates not to check TCP.
        /// </summary>
        [JsonProperty("TcpFailureThreshold")]
        public ulong? TcpFailureThreshold{ get; set; }

        /// <summary>
        /// The threshold on consecutive timeouts. Range: [0, 254]. `0` indicates not to check TCP.
        /// </summary>
        [JsonProperty("TimeoutThreshold")]
        public ulong? TimeoutThreshold{ get; set; }

        /// <summary>
        /// The threshold on consecutive HTTP errors. Range: [0, 254]. `0` indicates not to check HTTP.
        /// </summary>
        [JsonProperty("HttpFailureThreshold")]
        public ulong? HttpFailureThreshold{ get; set; }

        /// <summary>
        /// The path for active health check. It defaults to `/`.
        /// </summary>
        [JsonProperty("ActiveCheckHttpPath")]
        public string ActiveCheckHttpPath{ get; set; }

        /// <summary>
        /// The timeout period for active health check in seconds. Default: `5`. 
        /// </summary>
        [JsonProperty("ActiveCheckTimeout")]
        public ulong? ActiveCheckTimeout{ get; set; }

        /// <summary>
        /// The interval for active health check in seconds. Default: `5`. 
        /// </summary>
        [JsonProperty("ActiveCheckInterval")]
        public ulong? ActiveCheckInterval{ get; set; }

        /// <summary>
        /// Header of the active health check request
        /// </summary>
        [JsonProperty("ActiveRequestHeader")]
        public UpstreamHealthCheckerReqHeaders[] ActiveRequestHeader{ get; set; }

        /// <summary>
        /// The period for an abnormal to recover automatically in seconds. If only the passive health check is enabled, it must be greater than 0. Otherwise the abnormal nodes can not recovered automatically. The default value is 30 seconds. 
        /// </summary>
        [JsonProperty("UnhealthyTimeout")]
        public ulong? UnhealthyTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableActiveCheck", this.EnableActiveCheck);
            this.SetParamSimple(map, prefix + "EnablePassiveCheck", this.EnablePassiveCheck);
            this.SetParamSimple(map, prefix + "HealthyHttpStatus", this.HealthyHttpStatus);
            this.SetParamSimple(map, prefix + "UnhealthyHttpStatus", this.UnhealthyHttpStatus);
            this.SetParamSimple(map, prefix + "TcpFailureThreshold", this.TcpFailureThreshold);
            this.SetParamSimple(map, prefix + "TimeoutThreshold", this.TimeoutThreshold);
            this.SetParamSimple(map, prefix + "HttpFailureThreshold", this.HttpFailureThreshold);
            this.SetParamSimple(map, prefix + "ActiveCheckHttpPath", this.ActiveCheckHttpPath);
            this.SetParamSimple(map, prefix + "ActiveCheckTimeout", this.ActiveCheckTimeout);
            this.SetParamSimple(map, prefix + "ActiveCheckInterval", this.ActiveCheckInterval);
            this.SetParamArrayObj(map, prefix + "ActiveRequestHeader.", this.ActiveRequestHeader);
            this.SetParamSimple(map, prefix + "UnhealthyTimeout", this.UnhealthyTimeout);
        }
    }
}

