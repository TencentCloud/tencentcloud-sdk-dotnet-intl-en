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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySpartaProtectionRequest : AbstractModel
    {
        
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Required. Unique domain name ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// Required. Instance ID of the domain name
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// Certificate type. 0: no certificate, with only the HTTP listening port configured; 1: self-owned certificate; 2: managed certificate.
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// When CertType is 1, this parameter is required, indicating the self-owned certificate chain
        /// </summary>
        [JsonProperty("Cert")]
        public string Cert{ get; set; }

        /// <summary>
        /// When CertType=1, this parameter is required, indicating the private key of the self-owned certificate.
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// When CertType is 2, this parameter must be filled, indicating the certificate ID hosted on Tencent Cloud's SSL platform
        /// </summary>
        [JsonProperty("SSLId")]
        public string SSLId{ get; set; }

        /// <summary>
        /// Whether a layer-7 proxy service is deployed before the WAF. 0: No proxy service is deployed; 1: The proxy service is deployed. The WAF will use XFF to obtain the client IP address; 2: The proxy service is deployed. The WAF will use remote_addr to obtain the client IP address; 3: The proxy service is deployed. The WAF will use a custom header in ip_headers to obtain the client IP address.
        /// </summary>
        [JsonProperty("IsCdn")]
        public long? IsCdn{ get; set; }

        /// <summary>
        /// Origin-pull protocol for HTTPS when the service is configured with an HTTPS port.
        /// http: Use the HTTP protocol for origin-pull. It is used with HttpsUpstreamPort.
        /// https: Use the HTTPS protocol for origin-pull.
        /// </summary>
        [JsonProperty("UpstreamScheme")]
        public string UpstreamScheme{ get; set; }

        /// <summary>
        /// HTTPS upstream port, required only when UpstreamScheme is http
        /// </summary>
        [JsonProperty("HttpsUpstreamPort")]
        public string HttpsUpstreamPort{ get; set; }

        /// <summary>
        /// Whether to enable forced redirection from HTTP to HTTPS. 0: disable; 1: enable
        /// </summary>
        [JsonProperty("HttpsRewrite")]
        public ulong? HttpsRewrite{ get; set; }

        /// <summary>
        /// upstream type. 0: proxy to upstream by IP; 1: proxy to upstream by domain name
        /// </summary>
        [JsonProperty("UpstreamType")]
        public long? UpstreamType{ get; set; }

        /// <summary>
        /// Upstream domain when proxy to upstream by domain. When UpstreamType=1, this field needs to be filled
        /// </summary>
        [JsonProperty("UpstreamDomain")]
        public string UpstreamDomain{ get; set; }

        /// <summary>
        /// Upstream IP list when proxy to upstream by IP. When UpstreamType=0, this field is required
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        /// Whether to enable HTTP2. You should enable HTTPS as well. 0: disable; 1: enable
        /// </summary>
        [JsonProperty("IsHttp2")]
        public long? IsHttp2{ get; set; }

        /// <summary>
        /// Whether to enable WebSocket. 0: disable; 1: enable
        /// </summary>
        [JsonProperty("IsWebsocket")]
        public long? IsWebsocket{ get; set; }

        /// <summary>
        /// Load balancing policy for upstream. 0: round-robin scheduling; 1: IP hash; 2: weighted round-robin scheduling
        /// </summary>
        [JsonProperty("LoadBalance")]
        public long? LoadBalance{ get; set; }

        /// <summary>
        /// To be deprecated, can be left blank. Whether to enable grayscale: 0 indicates not to enable grayscale.
        /// </summary>
        [JsonProperty("IsGray")]
        public long? IsGray{ get; set; }

        /// <summary>
        /// Instance type of the domain name
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// Port information, which can be obtained through the DescribeDomains API
        /// </summary>
        [JsonProperty("Ports")]
        public SpartaProtectionPort[] Ports{ get; set; }

        /// <summary>
        /// Whether to enable persistent connection. 0: non-persistent connection; 1: persistent connection
        /// </summary>
        [JsonProperty("IsKeepAlive")]
        public string IsKeepAlive{ get; set; }

        /// <summary>
        /// To be deprecated. Currently, set this parameter to 0. Anycast IP type switch. 0: common IP; 1: Anycast IP
        /// </summary>
        [JsonProperty("Anycast")]
        public long? Anycast{ get; set; }

        /// <summary>
        /// Weight of each IP in the upstream IP List, corresponding to SrcList. Required only when UpstreamType is 0, and SrcList contains multiple IPs, and LoadBalance is 2; otherwise, fill in [ ].
        /// </summary>
        [JsonProperty("Weights")]
        public long?[] Weights{ get; set; }

        /// <summary>
        /// Whether to enable proactive health detection. 0: disable; 1: enable
        /// </summary>
        [JsonProperty("ActiveCheck")]
        public long? ActiveCheck{ get; set; }

        /// <summary>
        /// TLS version information
        /// </summary>
        [JsonProperty("TLSVersion")]
        public long? TLSVersion{ get; set; }

        /// <summary>
        /// Cipher suite information
        /// </summary>
        [JsonProperty("Ciphers")]
        public long?[] Ciphers{ get; set; }

        /// <summary>
        /// Cipher suite template. 0: default template (no selection); 1: general template; 2: secure template; 3: custom template
        /// </summary>
        [JsonProperty("CipherTemplate")]
        public long? CipherTemplate{ get; set; }

        /// <summary>
        /// Read timeout between WAF and upstream server, 300s by default.
        /// </summary>
        [JsonProperty("ProxyReadTimeout")]
        public long? ProxyReadTimeout{ get; set; }

        /// <summary>
        /// WAF and origin server write timeout, 300s by default.
        /// </summary>
        [JsonProperty("ProxySendTimeout")]
        public long? ProxySendTimeout{ get; set; }

        /// <summary>
        /// SNI type when proxy to upstream.
        /// 0: Disable SNI and do not configure server_name in client_hello.
        /// 1: Enable SNI. server_name in client_hello is the protected domain name.
        /// 2: Enable SNI. SNI is the origin server domain name when proxy to upstream by domain.
        /// 3: Enable SNI. SNI is the custom domain name.
        /// </summary>
        [JsonProperty("SniType")]
        public long? SniType{ get; set; }

        /// <summary>
        /// When SniType=3, this parameter is required, indicating a custom SNI;
        /// </summary>
        [JsonProperty("SniHost")]
        public string SniHost{ get; set; }

        /// <summary>
        /// IsCdn=3 required for this parameter, indicates custom header
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// Whether to enable XFF reset. 0: disable; 1: enable
        /// </summary>
        [JsonProperty("XFFReset")]
        public long? XFFReset{ get; set; }

        /// <summary>
        /// Domain name remarks
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// Custom upstream host. The default value is a null string, indicating that the protected domain name is used as the upstream host.
        /// </summary>
        [JsonProperty("UpstreamHost")]
        public string UpstreamHost{ get; set; }

        /// <summary>
        /// Whether to enable caching. 0: disable; 1: enable.
        /// </summary>
        [JsonProperty("ProxyBuffer")]
        public long? ProxyBuffer{ get; set; }

        /// <summary>
        /// 0: Disable probe test; 1: Enable probe test. The probe test is enabled by default.
        /// </summary>
        [JsonProperty("ProbeStatus")]
        public long? ProbeStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "Cert", this.Cert);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "SSLId", this.SSLId);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamSimple(map, prefix + "UpstreamScheme", this.UpstreamScheme);
            this.SetParamSimple(map, prefix + "HttpsUpstreamPort", this.HttpsUpstreamPort);
            this.SetParamSimple(map, prefix + "HttpsRewrite", this.HttpsRewrite);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamSimple(map, prefix + "UpstreamDomain", this.UpstreamDomain);
            this.SetParamArraySimple(map, prefix + "SrcList.", this.SrcList);
            this.SetParamSimple(map, prefix + "IsHttp2", this.IsHttp2);
            this.SetParamSimple(map, prefix + "IsWebsocket", this.IsWebsocket);
            this.SetParamSimple(map, prefix + "LoadBalance", this.LoadBalance);
            this.SetParamSimple(map, prefix + "IsGray", this.IsGray);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "IsKeepAlive", this.IsKeepAlive);
            this.SetParamSimple(map, prefix + "Anycast", this.Anycast);
            this.SetParamArraySimple(map, prefix + "Weights.", this.Weights);
            this.SetParamSimple(map, prefix + "ActiveCheck", this.ActiveCheck);
            this.SetParamSimple(map, prefix + "TLSVersion", this.TLSVersion);
            this.SetParamArraySimple(map, prefix + "Ciphers.", this.Ciphers);
            this.SetParamSimple(map, prefix + "CipherTemplate", this.CipherTemplate);
            this.SetParamSimple(map, prefix + "ProxyReadTimeout", this.ProxyReadTimeout);
            this.SetParamSimple(map, prefix + "ProxySendTimeout", this.ProxySendTimeout);
            this.SetParamSimple(map, prefix + "SniType", this.SniType);
            this.SetParamSimple(map, prefix + "SniHost", this.SniHost);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "XFFReset", this.XFFReset);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "UpstreamHost", this.UpstreamHost);
            this.SetParamSimple(map, prefix + "ProxyBuffer", this.ProxyBuffer);
            this.SetParamSimple(map, prefix + "ProbeStatus", this.ProbeStatus);
        }
    }
}

