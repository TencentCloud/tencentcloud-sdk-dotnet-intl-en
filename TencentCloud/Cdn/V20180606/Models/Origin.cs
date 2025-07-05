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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Origin : AbstractModel
    {
        
        /// <summary>
        /// List of primary origin servers
        /// <font color=red>When modifying the origins, you need to specify `OriginType`.</font>
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// Primary origin server type
        /// <font color=red>This field is used together with `Origins`.</font>
        /// Input:
        /// `domain`: Domain name
        /// `domainv6`: IPv6 domain name
        /// `cos`: COS bucket address
        /// `third_party`: Third-party object storage origin
        /// `igtm`: IGTM origin
        /// `ip`: IP address
        /// `ipv6`: One IPv6 address
        /// `ip_ipv6`: Multiple IPv4 addresses and one IPv6 address
        /// `ip_domain`: IP addresses and domain names (only available to beta users)
        /// `ip_domainv6`: Multiple IPv4 addresses and one IPv6 domain name
        /// `ipv6_domain`: Multiple IPv6 addresses and one domain name
        /// `ipv6_domainv6`: Multiple IPv6 addresses and one IPv6 domain name
        /// `domain_domainv6`: Multiple IPv4 domain names and one IPv6 domain name
        /// `ip_ipv6_domain`: Multiple IPv4 and IPv6 addresses and one domain name
        /// `ip_ipv6_domainv6`: Multiple IPv4 and IPv6 addresses and one IPv6 domain name
        /// `ip_domain_domainv6`: Multiple IPv4 addresses and IPv4 domain names and one IPv6 domain name
        /// `ipv6_domain_domainv6`: Multiple IPv4 domain names and IPv6 addresses and one IPv6 domain name
        /// `ip_ipv6_domain_domainv6`: Multiple IPv4 and IPv6 addresses and IPv4 domain names and one IPv6 domain name
        /// Output:
        /// `image`: Cloud Infinite origin
        /// `ftp`: FTP origin (disused)
        /// When modifying `Origins`, you need to specify `OriginType`.
        /// The IPv6 feature is now only available to beta users. Submit a ticket if you need it.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin-pull host header.
        /// <font color=red>This field is required when `OriginType=cos/third-party`.</font>
        /// If not specified, this field defaults to the acceleration domain name.
        /// For a wildcard domain name, the sub-domain name during the access is used by default.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// When OriginType is COS, you can specify if access to private buckets is allowed.
        /// Note: To enable this configuration, you need to first grant CDN access to the private bucket. Values: `on` and `off`.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CosPrivateAccess")]
        public string CosPrivateAccess{ get; set; }

        /// <summary>
        /// Origin-pull protocol configuration
        /// http: forced HTTP origin-pull
        /// follow: protocol follow origin-pull
        /// https: forced HTTPS origin-pull. This only supports origin server port 443 for origin-pull.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OriginPullProtocol")]
        public string OriginPullProtocol{ get; set; }

        /// <summary>
        /// List of secondary origin servers
        /// <font color=red>This field is used together with `BackupOriginType`.</font>
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupOrigins")]
        public string[] BackupOrigins{ get; set; }

        /// <summary>
        /// Secondary origin type
        /// <font color=red>This field is used together with `BackupOrigins`.</font>
        /// Values:
        /// `domain`: Domain name
        /// `ip`: IP address
        /// The following secondary origin types are only available to beta users. Submit a ticket to use it.
        /// `ipv6_domain`: Multiple IPv6 addresses and one domain name
        /// `ip_ipv6`: Multiple IPv4 addresses and one IPv6 address
        /// `ipv6_domain`: Multiple IPv6 addresses and one domain name
        /// `ip_ipv6_domain`: Multiple IPv4 and IPv6 addresses and one domain name
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupOriginType")]
        public string BackupOriginType{ get; set; }

        /// <summary>
        /// Host header used when accessing the backup origin server. If it is left empty, the `ServerName` of primary origin server will be used by default.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BackupServerName")]
        public string BackupServerName{ get; set; }

        /// <summary>
        /// Origin-pull path
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BasePath")]
        public string BasePath{ get; set; }

        /// <summary>
        /// Origin-pull path rewriting configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PathRules")]
        public PathRule[] PathRules{ get; set; }

        /// <summary>
        /// Path-based origin-pull configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PathBasedOrigin")]
        public PathBasedOriginRule[] PathBasedOrigin{ get; set; }

        /// <summary>
        /// HTTPS origin-pull SNI
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Sni")]
        public OriginSni Sni{ get; set; }

        /// <summary>
        /// HTTPS advanced origin-pull configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AdvanceHttps")]
        public AdvanceHttps AdvanceHttps{ get; set; }

        /// <summary>
        /// Third-party object storage service vendor
        /// <font color=red>This field is required when `OriginType=third-party`.</font>
        /// Values:
        /// `aws_s3`: AWS S3
        /// `ali_oss`: Alibaba Cloud OSS
        /// `hw_obs`: Huawei Cloud OBS
        /// `Qiniu_kodo`: Qiniu Kodo
        /// `Others`: Other object storage service vendors. Only AWS signature-compatible object storage services are supported, such as Tencent Cloud COS for Finance Zone.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginCompany")]
        public string OriginCompany{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Origins.", this.Origins);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "CosPrivateAccess", this.CosPrivateAccess);
            this.SetParamSimple(map, prefix + "OriginPullProtocol", this.OriginPullProtocol);
            this.SetParamArraySimple(map, prefix + "BackupOrigins.", this.BackupOrigins);
            this.SetParamSimple(map, prefix + "BackupOriginType", this.BackupOriginType);
            this.SetParamSimple(map, prefix + "BackupServerName", this.BackupServerName);
            this.SetParamSimple(map, prefix + "BasePath", this.BasePath);
            this.SetParamArrayObj(map, prefix + "PathRules.", this.PathRules);
            this.SetParamArrayObj(map, prefix + "PathBasedOrigin.", this.PathBasedOrigin);
            this.SetParamObj(map, prefix + "Sni.", this.Sni);
            this.SetParamObj(map, prefix + "AdvanceHttps.", this.AdvanceHttps);
            this.SetParamSimple(map, prefix + "OriginCompany", this.OriginCompany);
        }
    }
}

