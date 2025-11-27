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

    public class TargetGroupHealthCheck : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable the health check.
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public bool? HealthSwitch{ get; set; }

        /// <summary>
        /// Health check method. among them, only the new version V2 target group type supports this parameter. valid values: TCP | HTTP | HTTPS | PING | CUSTOM. among them:.
        /// <ur><li>When the backend forwarding protocol of the target group is TCP, the health check method supports TCP/HTTP/CUSTOM, with a default value of TCP.</li><li>when the backend forwarding protocol of the target group is UDP, the health check method supports PING/CUSTOM, with a default value of PING.</li><li>when the backend forwarding protocol of the target group is HTTP, the health check method supports HTTP/TCP, with a default value of HTTP.</li><li>when the backend forwarding protocol of the target group is HTTPS, the health check method supports HTTPS/TCP, with a default value of HTTPS.</li><li>when the backend forwarding protocol of the target group is GRPC, the health check method supports GRPC/TCP, with a default value of GRPC.</li></ur>.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Custom check parameters. health check port, defaults to the port of the backend service unless you want to specify a specific port, otherwise leave it blank. (applicable only to TCP/UDP target group).
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Health check timeout. The default is 2 seconds. Value range: 2-30 seconds.
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Detection interval time. The default is 5 seconds. Value range: 2-300 seconds.
        /// </summary>
        [JsonProperty("GapTime")]
        public long? GapTime{ get; set; }

        /// <summary>
        /// Health detection threshold. The default is 3 times. Value range: 2-10 times.
        /// </summary>
        [JsonProperty("GoodLimit")]
        public long? GoodLimit{ get; set; }

        /// <summary>
        /// Unhealth detection threshold. The default is 3 times. Value range: 2-10 times.
        /// </summary>
        [JsonProperty("BadLimit")]
        public long? BadLimit{ get; set; }

        /// <summary>
        /// Indicates whether jumbo frames are enabled for probe packets of all rss in the target group. enabled by default. this parameter is supported only for GWLB type target groups.
        /// </summary>
        [JsonProperty("JumboFrame")]
        public bool? JumboFrame{ get; set; }

        /// <summary>
        /// Health check status code (applicable only to HTTP/HTTPS target group and HTTP health check method of TCP target group). value range: 1~31. default: 31. among them: <url> <li>1 means post-detection return value 1xx represents health.</li> <li>2 means return 2xx represents health.</li> <li>4 means return 3xx represents health.</li> <li>8 means return 4xx represents health.</li> <li>16 means return 5xx represents health.</li></url> to have multiple return codes represent health, sum up corresponding values.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCode")]
        public long? HttpCode{ get; set; }

        /// <summary>
        /// Health check domain name. among them: <ur><li>applicable only to HTTP/HTTPS target groups and TCP target groups when using HTTP health check method.</li><li>targeting HTTP/HTTPS target groups, this parameter is required when using HTTP health check method.</li></ur>.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCheckDomain")]
        public string HttpCheckDomain{ get; set; }

        /// <summary>
        /// Health check path (applicable only to HTTP/HTTPS forwarding rules and HTTP health checks of TCP listeners).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCheckPath")]
        public string HttpCheckPath{ get; set; }

        /// <summary>
        /// Health check method (applicable only to HTTP/HTTPS forwarding rules and HTTP health checks of TCP listeners). Default: HEAD. Valid values: HEAD and GET.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpCheckMethod")]
        public string HttpCheckMethod{ get; set; }

        /// <summary>
        /// Input format of health check. required when health check method is CUSTOM. valid values: HEX or TEXT. among them:<ur><li>TEXT: TEXT format.</li><li>HEX: hexadecimal format. characters of SendContext and RecvContext can only be selected from 0123456789ABCDEF and the length must be an even number.</li><li>applicable only to TCP/UDP target group.</li></ur>.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// CUSTOM check parameters. required when the CheckType value is CUSTOM, represents the content of the request sent by the health check, only ASCII visible characters, maximum length limit 500. applicable only to TCP/UDP target group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// CUSTOM check parameters. required when the CheckType value is CUSTOM. represents the result returned by the health check. only ASCII visible characters are allowed. maximum length limit is 500. (applicable only to TCP/UDP target group).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }

        /// <summary>
        /// HTTP version, where: <ur><li>this field is required if the value of CheckType is HTTP.</li><li>supports configuration options: HTTP/1.0, HTTP/1.1.</li><li>applicable only to TCP target group.</li></ur>.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }

        /// <summary>
        /// Health check status code when the protocol is GRPC. (this parameter applies only to target groups with the backend forwarding protocol of GRPC.) default value: 12. valid values: a single numerical value, multiple numerical values, or a range. for example, 20, 20,25, or 0-99.
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
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "GapTime", this.GapTime);
            this.SetParamSimple(map, prefix + "GoodLimit", this.GoodLimit);
            this.SetParamSimple(map, prefix + "BadLimit", this.BadLimit);
            this.SetParamSimple(map, prefix + "JumboFrame", this.JumboFrame);
            this.SetParamSimple(map, prefix + "HttpCode", this.HttpCode);
            this.SetParamSimple(map, prefix + "HttpCheckDomain", this.HttpCheckDomain);
            this.SetParamSimple(map, prefix + "HttpCheckPath", this.HttpCheckPath);
            this.SetParamSimple(map, prefix + "HttpCheckMethod", this.HttpCheckMethod);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "SendContext", this.SendContext);
            this.SetParamSimple(map, prefix + "RecvContext", this.RecvContext);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
            this.SetParamSimple(map, prefix + "ExtendedCode", this.ExtendedCode);
        }
    }
}

