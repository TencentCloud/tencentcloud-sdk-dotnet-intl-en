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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheck : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable health check. 1: enable; 0: disable.
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public long? HealthSwitch{ get; set; }

        /// <summary>
        /// Health check response timeout period in seconds (applicable only to layer-4 listeners). Value range: 2-60. Default value: 2. This parameter should be less than the check interval.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeOut")]
        public long? TimeOut{ get; set; }

        /// <summary>
        /// Health check probing interval period. It defaults to `5`. For IPv4 CLB instances, the range is 2-300. For IPv6 CLB instances, the range is 5-300. Unit: second
        /// Note: For some IPv4 CLB instances created long ago, the range is 5-300.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntervalTime")]
        public long? IntervalTime{ get; set; }

        /// <summary>
        /// Health threshold. Default value: 3, indicating that if a forward is found healthy three consecutive times, it is considered to be normal. Value range: 2-10
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HealthNum")]
        public long? HealthNum{ get; set; }

        /// <summary>
        /// Unhealthy threshold. Default value: 3, indicating that if a forward is found unhealthy three consecutive times, it is considered to be exceptional. Value range: 2-10
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnHealthNum")]
        public long? UnHealthNum{ get; set; }

        /// <summary>
        /// Health check status code (applicable only to HTTP/HTTPS forwarding rules and HTTP health checks of TCP listeners). Value range: 1-31. Default value: 31.
        /// `1`: Returns code 1xx for healthy status. `2`: Returns code 2xx for healthy status. `4`: Returns code 3xx for healthy status. `8`: Returns code 4xx for healthy status. `16`: Returns code 5xx for healthy status. If you want multiple return codes to represent healthy, sum up the corresponding values. 
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCode")]
        public long? HttpCode{ get; set; }

        /// <summary>
        /// Health check path (applicable only to HTTP/HTTPS forwarding rules and HTTP health checks of TCP listeners).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCheckPath")]
        public string HttpCheckPath{ get; set; }

        /// <summary>
        /// Health check domain name. It's applicable only to HTTP/HTTPS forwarding rules and HTTP health checks of TCP listeners. It's required for HTTP health check of TCP listeners.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCheckDomain")]
        public string HttpCheckDomain{ get; set; }

        /// <summary>
        /// Health check method (applicable only to HTTP/HTTPS forwarding rules and HTTP health checks of TCP listeners). Value range: HEAD, GET. Default value: HEAD.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCheckMethod")]
        public string HttpCheckMethod{ get; set; }

        /// <summary>
        /// Health check port (a custom check parameter), which is the port of the real server by default. Unless you want to specify a port, it is recommended to leave it empty. (Applicable only to TCP/UDP listeners.)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckPort")]
        public long? CheckPort{ get; set; }

        /// <summary>
        /// Health check protocol (a custom check parameter), which is required if the value of CheckType is CUSTOM. This parameter represents the input format of the health check. Value range: HEX, TEXT. If the value is HEX, the characters of SendContext and RecvContext can only be selected from 0123456789ABCDEF and the length must be an even number. (Applicable only to TCP/UDP listeners.)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// Health check protocol (a custom check parameter), which is required if the value of CheckType is CUSTOM. This parameter represents the content of the request sent by the health check. Only ASCII visible characters are allowed, and the maximum length is 500. (Applicable only to TCP/UDP listeners.)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// Health check protocol (a custom check parameter), which is required if the value of CheckType is CUSTOM. This parameter represents the result returned by the health check. Only ASCII visible characters are allowed, and the maximum length is 500. (Applicable only to TCP/UDP listeners.)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }

        /// <summary>
        /// Health check protocol. Values: `TCP`, `HTTP`, `HTTPS`, `GRPC`, `PING`, and `CUSTOM`. UDP listeners support `PING`/`CUSTOM`. TCP listener support `TCP`/`HTTP`/`CUSTOM`. TCP_SSL and QUIC listeners support `TCP`/`HTTP`. HTTP rules support `HTTP`/`GRPC. HTTPS rules support `HTTP`/`HTTPS`/`GRPC`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// HTTP version. HTTP version of the backend service. Values: `HTTP/1.0`, HTTP/1.1`. It is only applicable to TCP listeners, and is required when `CheckType`=`HTTP`. 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }

        /// <summary>
        /// Specifies the type of health check source IP. `0` (default): CLB VIP. `1`: 100.64 IP range.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceIpType")]
        public long? SourceIpType{ get; set; }

        /// <summary>
        /// GRPC health check status code, which is only applicable to rules with GRPC as the backend forwarding protocol. It can be a single number (such as `20`), multiple numbers (such as `20,25`) or a range (such as `0-99`). The default value is `12`.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
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

