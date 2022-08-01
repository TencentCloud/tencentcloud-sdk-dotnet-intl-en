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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Origin : AbstractModel
    {
        
        /// <summary>
        /// Primary origin server list
        /// When modifying the origin server, you need to enter the corresponding OriginType.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// Primary origin server type
        /// The following types are supported for input parameters:
        /// `domain`: domain name
        /// `domainv6`: IPv6 domain name
        /// cos: COS origin
        /// `ip`: IP address
        /// ipv6: origin server list is a single IPv6 address
        /// `ip_ipv6`: multiple IPv4 addresses and one IPv6 address
        /// `ip_domain`: IP addresses and domain names (only available to beta users)
        /// `ip_domainv6`: Multiple IPv4 addresses and one IPv6 domain name
        /// `ipv6_domain`: multiple IPv6 addresses and one domain name
        /// `ipv6_domainv6`: Multiple IPv6 addresses and one IPv6 domain name
        /// `domain_domainv6`: Multiple IPv4 domain names and one IPv6 domain name
        /// `ip_ipv6_domain`: multiple IPv4 and IPv6 addresses and one domain name
        /// `ip_ipv6_domainv6`: Multiple IPv4 and IPv6 addresses and one IPv6 domain name
        /// `ip_domain_domainv6`: Multiple IPv4 addresses and IPv4 domain names and one IPv6 domain name
        /// `ipv6_domain_domainv6`: Multiple IPv4 domain names and IPv6 addresses and one IPv6 domain name
        /// `ip_ipv6_domain_domainv6`: Multiple IPv4 and IPv6 addresses and IPv4 domain names and one IPv6 domain name
        /// The following types of output parameters are added:
        /// image: Cloud Infinite origin
        /// ftp: legacy FTP origin, which is no longer maintained.
        /// When modifying `Origins`, you need to enter the corresponding OriginType.
        /// The IPv6 feature is not generally available yet. Please send in a whitelist application to use this feature.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// It is required when a COS origin or third-party origin is used for acceleration.
        /// Host header used when accessing the primary origin server. If it is left empty, the acceleration domain name will be used by default.
        /// If a wildcard domain name is accessed, then the sub-domain name during the access will be used by default.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
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
        /// Backup origin server list
        /// When modifying the backup origin server, you need to enter the corresponding BackupOriginType.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BackupOrigins")]
        public string[] BackupOrigins{ get; set; }

        /// <summary>
        /// Backup origin server type, which supports the following types:
        /// `domain`: Domain name
        /// `ip`: IP address
        /// When modifying BackupOrigins, you need to enter the corresponding BackupOriginType.
        /// The following backup origin servers are only available to beta users. Submit an application if you want to become a beta user.
        /// `ipv6_domain`: Multiple IPv6 addresses and one domain name
        /// `ip_ipv6`: Multiple IPv4 addresses and one IPv6 address
        /// `ipv6_domain`: Multiple IPv6 addresses and one domain name
        /// `ip_ipv6_domain`: Multiple IPv4 and IPv6 addresses and one domain name
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
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
        /// HTTPS advanced origin-pull configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AdvanceHttps")]
        public AdvanceHttps AdvanceHttps{ get; set; }

        /// <summary>
        /// Object storage vendor
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
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
            this.SetParamObj(map, prefix + "AdvanceHttps.", this.AdvanceHttps);
            this.SetParamSimple(map, prefix + "OriginCompany", this.OriginCompany);
        }
    }
}

