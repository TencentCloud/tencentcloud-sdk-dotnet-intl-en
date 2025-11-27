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

    public class RuleOutput : AbstractModel
    {
        
        /// <summary>
        /// Forwarding rule ID
        /// </summary>
        [JsonProperty("LocationId")]
        public string LocationId{ get; set; }

        /// <summary>
        /// Domain name of the forwarding rule
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Path of forwarding rules.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Session persistence time
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// Health Check Information
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Certificate information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateOutput Certificate{ get; set; }

        /// <summary>
        /// Request forwarding method in the rules.WRR, LEAST_CONN, and IP_HASH respectively indicate weighted round robin, least connections, and IP hash.
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// ID of the listener to which the forwarding rule belongs
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Redirection target information of the forwarding rule
        /// </summary>
        [JsonProperty("RewriteTarget")]
        public RewriteTarget RewriteTarget{ get; set; }

        /// <summary>
        /// Whether to enable gzip
        /// </summary>
        [JsonProperty("HttpGzip")]
        public bool? HttpGzip{ get; set; }

        /// <summary>
        /// Whether the forwarding rule is automatically created
        /// </summary>
        [JsonProperty("BeAutoCreated")]
        public bool? BeAutoCreated{ get; set; }

        /// <summary>
        /// Whether to use as the default domain name
        /// </summary>
        [JsonProperty("DefaultServer")]
        public bool? DefaultServer{ get; set; }

        /// <summary>
        /// Whether to enable Http2
        /// </summary>
        [JsonProperty("Http2")]
        public bool? Http2{ get; set; }

        /// <summary>
        /// Forwarding protocol between CLB and real server
        /// </summary>
        [JsonProperty("ForwardType")]
        public string ForwardType{ get; set; }

        /// <summary>
        /// Forwarding rule creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Real server type. NODE indicates binding to a general node, and TARGETGROUP indicates binding to a target group.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Basic information of a bound target group. This field will be returned if a target group is bound to a rule.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetGroup")]
        public BasicTargetGroupInfo TargetGroup{ get; set; }

        /// <summary>
        /// WAF instance ID.
        /// </summary>
        [JsonProperty("WafDomainId")]
        public string WafDomainId{ get; set; }

        /// <summary>
        /// Called server routing. valid when ForwardType is TRPC. currently not yet available.
        /// </summary>
        [JsonProperty("TrpcCallee")]
        public string TrpcCallee{ get; set; }

        /// <summary>
        /// TRPC calling service api. valid when ForwardType is TRPC. currently not yet available.
        /// </summary>
        [JsonProperty("TrpcFunc")]
        public string TrpcFunc{ get; set; }

        /// <summary>
        /// QUIC status. QUIC_ACTIVE means enabled, QUIC_INACTIVE means not enabled. note that only HTTPS domain names can enable QUIC.
        /// </summary>
        [JsonProperty("QuicStatus")]
        public string QuicStatus{ get; set; }

        /// <summary>
        /// Specifies the domain name list of the forwarding rule.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// List of bound target groups
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetGroupList")]
        public BasicTargetGroupInfo[] TargetGroupList{ get; set; }

        /// <summary>
        /// OAuth configuration status.
        /// </summary>
        [JsonProperty("OAuth")]
        public OAuth OAuth{ get; set; }

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
            this.SetParamSimple(map, prefix + "LocationId", this.LocationId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamObj(map, prefix + "RewriteTarget.", this.RewriteTarget);
            this.SetParamSimple(map, prefix + "HttpGzip", this.HttpGzip);
            this.SetParamSimple(map, prefix + "BeAutoCreated", this.BeAutoCreated);
            this.SetParamSimple(map, prefix + "DefaultServer", this.DefaultServer);
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "ForwardType", this.ForwardType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamObj(map, prefix + "TargetGroup.", this.TargetGroup);
            this.SetParamSimple(map, prefix + "WafDomainId", this.WafDomainId);
            this.SetParamSimple(map, prefix + "TrpcCallee", this.TrpcCallee);
            this.SetParamSimple(map, prefix + "TrpcFunc", this.TrpcFunc);
            this.SetParamSimple(map, prefix + "QuicStatus", this.QuicStatus);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArrayObj(map, prefix + "TargetGroupList.", this.TargetGroupList);
            this.SetParamObj(map, prefix + "OAuth.", this.OAuth);
            this.SetParamSimple(map, prefix + "CookieName", this.CookieName);
        }
    }
}

