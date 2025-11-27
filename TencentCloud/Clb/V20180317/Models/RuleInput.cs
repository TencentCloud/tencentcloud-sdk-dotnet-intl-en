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

    public class RuleInput : AbstractModel
    {
        
        /// <summary>
        /// Forwarding rule path. Length: 1-200.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// The domain name associated with the forwarding rule. It can contain 1-80 characters. Only one domain name can be entered. If you need to enter multiple domain names, use `Domains`.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Session persistence duration, in seconds. 0 indicates that session persistence is disabled, and a value ranging from 30 to 86400 indicates that session persistence is enabled.
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// Health check information. For more information, please see [Health Check](https://intl.cloud.tencent.com/document/product/214/6097?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Certificate information. `Certificate` and `MultiCertInfo` cannot be specified at the same time. 
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateInput Certificate{ get; set; }

        /// <summary>
        /// Request forwarding method of the rule. Value range: WRR, LEAST_CONN, IP_HASH
        /// They represent weighted round robin, least connections, and IP hash, respectively. Default value: WRR.
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// Specifies the forwarding protocol between cloud load balancer and backend service. currently supports HTTP/HTTPS/GRPC/GRPCS/TRPC. TRPC is not yet available. default HTTP.
        /// </summary>
        [JsonProperty("ForwardType")]
        public string ForwardType{ get; set; }

        /// <summary>
        /// Whether to set this domain name as the default domain name. Note: Only one default domain name can be set under one listener.
        /// </summary>
        [JsonProperty("DefaultServer")]
        public bool? DefaultServer{ get; set; }

        /// <summary>
        /// Whether to enable HTTP/2. Note: HTTP/2 can be enabled only for HTTPS domain names.
        /// </summary>
        [JsonProperty("Http2")]
        public bool? Http2{ get; set; }

        /// <summary>
        /// Target real server type. NODE: binding a general node; TARGETGROUP: binding a target group.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// TRPC callee server route, which is required when `ForwardType` is "TRPC". This is now only for internal usage.
        /// </summary>
        [JsonProperty("TrpcCallee")]
        public string TrpcCallee{ get; set; }

        /// <summary>
        /// TRPC calling service API, which is required when `ForwardType` is "TRPC". This is now only for internal usage.
        /// </summary>
        [JsonProperty("TrpcFunc")]
        public string TrpcFunc{ get; set; }

        /// <summary>
        /// Whether to enable QUIC. Note: QUIC can be enabled only for HTTPS domain names
        /// </summary>
        [JsonProperty("Quic")]
        public bool? Quic{ get; set; }

        /// <summary>
        /// The domain name associated with the forwarding rule. Each contain 1-80 characters. If you only need to enter one domain name, use `Domain` instead.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// Certificate information. You can specify multiple server-side certificates with different algorithm types. `Certificate` and `MultiCertInfo` cannot be specified at the same time. 
        /// </summary>
        [JsonProperty("MultiCertInfo")]
        public MultiCertInfo MultiCertInfo{ get; set; }

        /// <summary>
        /// Specifies the custom cookie name.
        /// </summary>
        [JsonProperty("CookieName")]
        public string CookieName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "ForwardType", this.ForwardType);
            this.SetParamSimple(map, prefix + "DefaultServer", this.DefaultServer);
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "TrpcCallee", this.TrpcCallee);
            this.SetParamSimple(map, prefix + "TrpcFunc", this.TrpcFunc);
            this.SetParamSimple(map, prefix + "Quic", this.Quic);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamObj(map, prefix + "MultiCertInfo.", this.MultiCertInfo);
            this.SetParamSimple(map, prefix + "CookieName", this.CookieName);
        }
    }
}

