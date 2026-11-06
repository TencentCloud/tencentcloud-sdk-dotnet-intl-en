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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthChecker : AbstractModel
    {
        
        /// <summary>
        /// <p>Health check policy. Valid values:</p><li>HTTP;</li><li>HTTPS;</li><li>TCP;</li><li>UDP;</li><li>ICMP Ping;</li><li>NoCheck.</li>Note: NoCheck means health check policy is not enabled.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Check port, which is required when Type = HTTP, Type = HTTPS, Type = TCP, or Type = UDP.</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>Check frequency, in seconds. It indicates how often a health check task is initiated. Configurable range: 10-600 seconds.</p>
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// <p>Timeout for each health check, in seconds. If the health check time exceeds this value, the check result is determined as "unhealthy". The default value is 5s, and the value should be less than Interval.</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>Health threshold, in the number of times. It indicates that if the consecutive health check results are "healthy" for a certain number of times, an origin server is considered "healthy". The default value is 3 times, with the minimum value of 1 time.</p>
        /// </summary>
        [JsonProperty("HealthThreshold")]
        public ulong? HealthThreshold{ get; set; }

        /// <summary>
        /// <p>Unhealthy state threshold, in the number of times. It indicates that if the consecutive health check results are "unhealthy" for a certain number of times, an origin server is considered "unhealthy". The default value is 2 times.</p>
        /// </summary>
        [JsonProperty("CriticalThreshold")]
        public ulong? CriticalThreshold{ get; set; }

        /// <summary>
        /// <p>Probe path. This parameter is valid only when Type = HTTP or Type = HTTPS. It needs to include the complete host/path and should not contain a protocol, for example, www.example.com/test.</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>Probe request Host Header policy. It takes effect only when Type=HTTP or Type=HTTPS and the instance type is HTTP-dedicated (V2). Valid values:</p><li>FollowCheckURL: Follows the Host specified by the probe URL, that is, the Host part in the HealthChecker.Path field will be used as the Host address for probing;</li><li>FollowOriginGroup: Follows the origin-pull Host Header configured in the origin group, that is, the OriginGroup.HostHeader field value of the origin group where the probed origin resides will be used as the Host address for probing. If the origin group has no HostHeader configured, the Host part in the HealthChecker.Path field will be used as the Host address for probing;</li><li>FollowOrigin: Follows the origin address, that is, the OriginGroup.Records[N].Record field value (the origin address itself) of the corresponding origin record in the origin group where the probed origin resides will be used as the Host address for probing.</li>Default: FollowCheckURL.
        /// </summary>
        [JsonProperty("HostHeaderPolicy")]
        public string HostHeaderPolicy{ get; set; }

        /// <summary>
        /// <p>Request method. This parameter is valid only when Type = HTTP or Type = HTTPS. Valid values:</p><li>GET;</li><li>HEAD.</li>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>The status codes used to determine that the probe result is healthy when the probe node initiates a health check to an origin server. This parameter is valid only when Type = HTTP or Type = HTTPS.</p>
        /// </summary>
        [JsonProperty("ExpectedCodes")]
        public string[] ExpectedCodes{ get; set; }

        /// <summary>
        /// <p>This parameter is valid only when Type=HTTP or Type=HTTPS. It refers to the custom HTTP request header carried in the probe request. Up to 10 can be configured.</p>
        /// </summary>
        [JsonProperty("Headers")]
        public CustomizedHeader[] Headers{ get; set; }

        /// <summary>
        /// <p>Whether to follow 301/302 redirect. When enabled, 301/302 is considered a "healthy" status code, redirecting 3 times by default. This parameter is valid only when Type = HTTP or Type = HTTPS.</p>
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public string FollowRedirect{ get; set; }

        /// <summary>
        /// <p>The content sent by a health check. Only ASCII visible characters are allowed, with up to 500 characters. This parameter is valid only when Type = UDP.</p>
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// <p>The expected return result from an origin server during health check. Only ASCII visible characters are allowed, with up to 500 characters. This parameter is valid only when Type = UDP.</p>
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }

        /// <summary>
        /// <p>Health check probe cluster. Specifies the cluster region scope from which this load balancer instance initiates health probes. For details on the regional distribution of probe clusters, see <a href="https://www.tencentcloud.com/document/product/1552/104228?from_cn_redirect=1">Health Check Policy Introduction</a>. This can be configured only for HTTP-dedicated (V2) load balancer instances. Valid values:</p><li>global: Probes are initiated by probe clusters in all regions worldwide, including the Chinese mainland and regions outside the Chinese mainland. Clusters in each region independently maintain their own probe results;</li><li>mainland_china: Probes are initiated only by probe clusters in the Chinese mainland. Currently, the Chinese mainland shares one probe cluster, and probe results are maintained by the probe cluster in the Chinese mainland. Other regions follow the probe results of the cluster in the Chinese mainland;</li><li>overseas: Probes are initiated only by probe clusters in regions outside the Chinese mainland. Currently, regions outside the Chinese mainland contain probe clusters in multiple areas, and probe results are independently maintained by the probe clusters in each area. Probe results for the Chinese mainland are generated by aggregating the probe results of the probe clusters in all other areas.</li>Default: global.
        /// </summary>
        [JsonProperty("ProbeCluster")]
        public string ProbeCluster{ get; set; }


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
            this.SetParamSimple(map, prefix + "HostHeaderPolicy", this.HostHeaderPolicy);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "ExpectedCodes.", this.ExpectedCodes);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "FollowRedirect", this.FollowRedirect);
            this.SetParamSimple(map, prefix + "SendContext", this.SendContext);
            this.SetParamSimple(map, prefix + "RecvContext", this.RecvContext);
            this.SetParamSimple(map, prefix + "ProbeCluster", this.ProbeCluster);
        }
    }
}

