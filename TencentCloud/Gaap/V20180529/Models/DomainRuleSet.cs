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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainRuleSet : AbstractModel
    {
        
        /// <summary>
        /// Forwarding rule domain name.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Forwarding rule list of the domain name.
        /// </summary>
        [JsonProperty("RuleSet")]
        public RuleInfo[] RuleSet{ get; set; }

        /// <summary>
        /// Server certificate ID of the domain. When it is `default`, it indicates that the default certificate will be used (i.e., the certificate configured for the listener).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Server certificate name of the domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// Client certificate ID of the domain. When it is `default`, it indicates that the default certificate will be used (i.e., the certificate configured for the listener).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public string ClientCertificateId{ get; set; }

        /// <summary>
        /// Client certificate name of the domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientCertificateAlias")]
        public string ClientCertificateAlias{ get; set; }

        /// <summary>
        /// Basic authentication configuration ID of the domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BasicAuthConfId")]
        public string BasicAuthConfId{ get; set; }

        /// <summary>
        /// Basic authentication status:
        /// 0: disabled;
        /// 1: enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BasicAuth")]
        public long? BasicAuth{ get; set; }

        /// <summary>
        /// Basic authentication configuration name of the domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BasicAuthConfAlias")]
        public string BasicAuthConfAlias{ get; set; }

        /// <summary>
        /// Origin server authentication certificate ID of the domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealServerCertificateId")]
        public string RealServerCertificateId{ get; set; }

        /// <summary>
        /// Origin server authentication status:
        /// 0: disabled;
        /// 1: enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealServerAuth")]
        public long? RealServerAuth{ get; set; }

        /// <summary>
        /// Origin server authentication certificate name of the domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealServerCertificateAlias")]
        public string RealServerCertificateAlias{ get; set; }

        /// <summary>
        /// Connection authentication certificate ID of the domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GaapCertificateId")]
        public string GaapCertificateId{ get; set; }

        /// <summary>
        /// Connection authentication status:
        /// 0: disabled;
        /// 1: enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GaapAuth")]
        public long? GaapAuth{ get; set; }

        /// <summary>
        /// Connection authentication certificate name of the domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GaapCertificateAlias")]
        public string GaapCertificateAlias{ get; set; }

        /// <summary>
        /// Origin server authentication domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealServerCertificateDomain")]
        public string RealServerCertificateDomain{ get; set; }

        /// <summary>
        /// Returns IDs and aliases of multiple certificates when there are multiple client certificates.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PolyClientCertificateAliasInfo")]
        public CertificateAliasInfo[] PolyClientCertificateAliasInfo{ get; set; }

        /// <summary>
        /// Returns IDs and aliases of multiple certificates when there are multiple origin certificates.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PolyRealServerCertificateAliasInfo")]
        public CertificateAliasInfo[] PolyRealServerCertificateAliasInfo{ get; set; }

        /// <summary>
        /// Domain name status.
        /// 0: running;
        /// 1: changing;
        /// 2: deleting.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DomainStatus")]
        public ulong? DomainStatus{ get; set; }

        /// <summary>
        /// Blocking-related status of the domain name. `BANNED`: the domain name is blocked; `RECOVER`: the domain name is unblocked or normal; `BANNING`: the domain name is being blocked; `RECOVERING`: the domain name is being unblocked; `BAN_FAILED`: the blocking fails; RECOVER_FAILED: the unblocking fails.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BanStatus")]
        public string BanStatus{ get; set; }

        /// <summary>
        /// Specifies whether to enable HTTP3. Valid values:
        /// `0`: disable HTTP3;
        /// `1`: enable HTTP3.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArrayObj(map, prefix + "RuleSet.", this.RuleSet);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "ClientCertificateId", this.ClientCertificateId);
            this.SetParamSimple(map, prefix + "ClientCertificateAlias", this.ClientCertificateAlias);
            this.SetParamSimple(map, prefix + "BasicAuthConfId", this.BasicAuthConfId);
            this.SetParamSimple(map, prefix + "BasicAuth", this.BasicAuth);
            this.SetParamSimple(map, prefix + "BasicAuthConfAlias", this.BasicAuthConfAlias);
            this.SetParamSimple(map, prefix + "RealServerCertificateId", this.RealServerCertificateId);
            this.SetParamSimple(map, prefix + "RealServerAuth", this.RealServerAuth);
            this.SetParamSimple(map, prefix + "RealServerCertificateAlias", this.RealServerCertificateAlias);
            this.SetParamSimple(map, prefix + "GaapCertificateId", this.GaapCertificateId);
            this.SetParamSimple(map, prefix + "GaapAuth", this.GaapAuth);
            this.SetParamSimple(map, prefix + "GaapCertificateAlias", this.GaapCertificateAlias);
            this.SetParamSimple(map, prefix + "RealServerCertificateDomain", this.RealServerCertificateDomain);
            this.SetParamArrayObj(map, prefix + "PolyClientCertificateAliasInfo.", this.PolyClientCertificateAliasInfo);
            this.SetParamArrayObj(map, prefix + "PolyRealServerCertificateAliasInfo.", this.PolyRealServerCertificateAliasInfo);
            this.SetParamSimple(map, prefix + "DomainStatus", this.DomainStatus);
            this.SetParamSimple(map, prefix + "BanStatus", this.BanStatus);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
        }
    }
}

