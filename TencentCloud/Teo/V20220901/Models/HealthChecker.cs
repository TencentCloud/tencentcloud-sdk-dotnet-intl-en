/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthChecker : AbstractModel
    {
        
        /// <summary>
        /// Health check policy. Valid values:
        /// <li>HTTP.</li>
        /// <li>HTTPS.</li>
        /// <li>TCP.</li>
        /// <li>UDP.</li>
        /// <li>ICMP Ping.</li>
        /// <li>NoCheck.</li>
        /// Note: NoCheck means the health check policy is not enabled.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Check port, which is required when Type = HTTP, Type = HTTPS, Type = TCP, or Type = UDP.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Check frequency, in seconds. It indicates how often a health check task is initiated. Valid values: 30, 60, 180, 300, 600.
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// Timeout for each health check, in seconds. If the health check time exceeds this value, the check result is determined as "unhealthy". The default value is 5s, and the value should be less than Interval.
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// Healthy state threshold, in the number of times. It indicates that if the consecutive health check results are "healthy" for a certain number of times, an origin server is considered "healthy". The default value is 3 times, with the minimum value of 1 time.
        /// </summary>
        [JsonProperty("HealthThreshold")]
        public ulong? HealthThreshold{ get; set; }

        /// <summary>
        /// Unhealthy state threshold, in the number of times. It indicates that if the consecutive health check results are "unhealthy" for a certain number of times, an origin server is considered "unhealthy". The default value is 2 times.
        /// </summary>
        [JsonProperty("CriticalThreshold")]
        public ulong? CriticalThreshold{ get; set; }

        /// <summary>
        /// Probe path. This parameter is valid only when Type = HTTP or Type = HTTPS. It needs to include the complete host/path and should not contain a protocol, for example, www.example.com/test.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// Request method. This parameter is valid only when Type = HTTP or Type = HTTPS. Valid values:
        /// <li>GET.</li>
        /// <li>HEAD.</li>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// The status codes used to determine that the probe result is healthy when the probe node initiates a health check to an origin server. This parameter is valid only when Type = HTTP or Type = HTTPS.
        /// </summary>
        [JsonProperty("ExpectedCodes")]
        public string[] ExpectedCodes{ get; set; }

        /// <summary>
        /// The custom HTTP request header carried by a probe request, with a maximum value of 10. This parameter is valid only when Type = HTTP or Type = HTTPS.
        /// </summary>
        [JsonProperty("Headers")]
        public CustomizedHeader[] Headers{ get; set; }

        /// <summary>
        /// Whether to follow 301/302 redirect. When enabled, 301/302 is considered a "healthy" status code, redirecting 3 times by default. This parameter is valid only when Type = HTTP or Type = HTTPS.
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public string FollowRedirect{ get; set; }

        /// <summary>
        /// The content sent by a health check. Only ASCII visible characters are allowed, with up to 500 characters. This parameter is valid only when Type = UDP.
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// The expected return result from an origin server during health check. Only ASCII visible characters are allowed, with up to 500 characters. This parameter is valid only when Type = UDP.
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "HealthThreshold", this.HealthThreshold);
            this.SetParamSimple(map, prefix + "CriticalThreshold", this.CriticalThreshold);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "ExpectedCodes.", this.ExpectedCodes);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "FollowRedirect", this.FollowRedirect);
            this.SetParamSimple(map, prefix + "SendContext", this.SendContext);
            this.SetParamSimple(map, prefix + "RecvContext", this.RecvContext);
        }
    }
}

