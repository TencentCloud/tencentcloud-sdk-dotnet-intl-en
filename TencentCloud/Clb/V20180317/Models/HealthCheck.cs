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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheck : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable health check. 1: Enable; 0: Disable.
        /// 
        /// It is enabled by default.
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public long? HealthSwitch{ get; set; }

        /// <summary>
        /// Health check response timeout, in seconds. Value range: 2–60. Default value: 2. The response timeout should be less than the check interval.
        /// </summary>
        [JsonProperty("TimeOut")]
        public long? TimeOut{ get; set; }

        /// <summary>
        /// Health check interval, in seconds. Default value: 5. Value range: 2–300 for IPv4 CLB instances and 5–300 for IPv6 CLB instances.
        /// Note: The value range is 5–300 for some IPv4 CLB instances of early versions.
        /// </summary>
        [JsonProperty("IntervalTime")]
        public long? IntervalTime{ get; set; }

        /// <summary>
        /// Healthy threshold. Default: 3, indicating that if a forwarding is found healthy three consecutive times, it is considered to be normal. Value range: 2-10. Unit: times.
        /// </summary>
        [JsonProperty("HealthNum")]
        public long? HealthNum{ get; set; }

        /// <summary>
        /// Unhealthy threshold. Default: 3, indicating that if a forwarding is found unhealthy three consecutive times, it is considered to be exceptional. Value range: 2-10. Unit: times.
        /// </summary>
        [JsonProperty("UnHealthNum")]
        public long? UnHealthNum{ get; set; }

        /// <summary>
        /// Health check status code. (This parameter applies only to HTTP/HTTPS forwarding rules and the HTTP health check method of TCP listeners.) Value range: 1–31. Default value: 31.
        /// 1: return 1xx after the check (healthy); 2: return 2xx after the check (healthy); 4: return 3xx after the check (healthy); 8: return 4xx after the check (healthy); 16: return 5xx after the check (healthy). If you expect that multiple codes represent a healthy real server, set the value to the sum of the corresponding values.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCode")]
        public long? HttpCode{ get; set; }

        /// <summary>
        /// Health check path (applicable only to HTTP/HTTPS forwarding rules and HTTP health checks of TCP listeners).
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCheckPath")]
        public string HttpCheckPath{ get; set; }

        /// <summary>
        /// Health check domain name, which will be contained in a Host header field of the HTTP protocol. (This parameter applies only to HTTP/HTTPS listeners and the HTTP health check method of TCP listeners. For TCP listeners, this parameter is required if the HTTP health check method is used.)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCheckDomain")]
        public string HttpCheckDomain{ get; set; }

        /// <summary>
        /// Health check method (applicable only to HTTP/HTTPS forwarding rules and HTTP health checks of TCP listeners). Default: HEAD. Valid values: HEAD and GET.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCheckMethod")]
        public string HttpCheckMethod{ get; set; }

        /// <summary>
        /// A custom check parameter, representing the health check port, which is the port of the real server by default. Unless you want to specify a port, it is recommended to leave it empty. (Applicable only to TCP/UDP listeners)
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckPort")]
        public long? CheckPort{ get; set; }

        /// <summary>
        /// A custom check parameter, which is required if the value of CheckType (health check protocol) is CUSTOM. This parameter represents the input format of the health check. Valid values: HEX and TEXT. If the value is HEX, the characters of SendContext and RecvContext can only be selected from 0123456789ABCDEF and the length must be an even number. (Applicable only to TCP/UDP listeners.)
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// A custom check parameter, which is required if the value of CheckType (health check protocol) is CUSTOM. This parameter represents the content of the request sent by the health check. Only ASCII visible characters are allowed, and the maximum length is 500. (Applicable only to TCP/UDP listeners.)
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// A custom check parameter, which is required if the value of CheckType (health check protocol) is CUSTOM. This parameter represents the result returned by the health check. Only ASCII visible characters are allowed, and the maximum length is 500. (Applicable only to TCP/UDP listeners.)
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }

        /// <summary>
        /// Protocol used for health checks. Valid values: TCP (for TCP listeners, TCP_SSL listeners, and QUIC listeners), HTTP (for TCP listeners, TCP_SSL listeners, QUIC listeners, HTTP rules, and HTTPS rules), HTTPS (for HTTPS rules), GRPC (for HTTP rules and HTTPS rules), PING (for UDP listeners), and CUSTOM (for UDP listeners and TCP listeners). The default value is HTTP for HTTP listeners, TCP for TCP, TCP_SSL, and QUIC listeners, and PING for UDP listeners. For HTTPS listeners, the protocol is the same as the backend forwarding protocol.
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// HTTP version. This field indicates the HTTP version of real servers and is required if the value of CheckType is HTTP. Valid values: HTTP/1.0 and HTTP/1.1. (This field applies only to TCP listeners.)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }

        /// <summary>
        /// Source IP address type for health checks. 0: use the LB VIP as the source IP address; 1: use an IP address in the 100.64 range as the source IP address.
        /// </summary>
        [JsonProperty("SourceIpType")]
        public long? SourceIpType{ get; set; }

        /// <summary>
        /// Health check status code when the protocol is GRPC. (This parameter applies only to rules with the backend forwarding protocol of GRPC.) Default value: 12. You can enter a single numerical value, multiple numerical values, or a range. For example, 20, 20,25, or 0-99.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtendedCode")]
        public string ExtendedCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthSwitch", this.HealthSwitch);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "HealthNum", this.HealthNum);
            this.SetParamSimple(map, prefix + "UnHealthNum", this.UnHealthNum);
            this.SetParamSimple(map, prefix + "HttpCode", this.HttpCode);
            this.SetParamSimple(map, prefix + "HttpCheckPath", this.HttpCheckPath);
            this.SetParamSimple(map, prefix + "HttpCheckDomain", this.HttpCheckDomain);
            this.SetParamSimple(map, prefix + "HttpCheckMethod", this.HttpCheckMethod);
            this.SetParamSimple(map, prefix + "CheckPort", this.CheckPort);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "SendContext", this.SendContext);
            this.SetParamSimple(map, prefix + "RecvContext", this.RecvContext);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
            this.SetParamSimple(map, prefix + "SourceIpType", this.SourceIpType);
            this.SetParamSimple(map, prefix + "ExtendedCode", this.ExtendedCode);
        }
    }
}

