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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddSpartaProtectionRequest : AbstractModel
    {
        
        /// <summary>
        /// Domain requiring protection
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Certificate type
        /// 0: no certificate, with only the HTTP listening port configured
        /// 1: self-owned certificate
        /// 2: managed certificate
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// Whether a layer-7 proxy service is deployed before WAF
        /// 0: No proxy service deployed
        /// 1: Proxy service deployed, and WAF will use XFF to obtain the client IP address
        /// 2: Proxy service deployed and WAF will use remote_addr to obtain the client IP address
        /// 3: Proxy service deployed, and WAF will use a custom header in ip_headers to obtain the client IP address
        /// </summary>
        [JsonProperty("IsCdn")]
        public long? IsCdn{ get; set; }

        /// <summary>
        /// Upstream type
        /// 0: proxy to upstream by IP address
        /// 1: proxy to upstream by domain name
        /// </summary>
        [JsonProperty("UpstreamType")]
        public long? UpstreamType{ get; set; }

        /// <summary>
        /// Whether to enable websocket
        /// 0: disable
        /// 1: enable
        /// </summary>
        [JsonProperty("IsWebsocket")]
        public long? IsWebsocket{ get; set; }

        /// <summary>
        /// Load balancing policy for upstream
        /// 0: round-robin
        /// 1: IP hash
        /// 2: weighted round-robin
        /// </summary>
        [JsonProperty("LoadBalance")]
        public string LoadBalance{ get; set; }

        /// <summary>
        /// Service port list configuration
        /// NginxServerId: fill in '0' in this function
        /// Port: listening port number
        /// Protocol: port protocol
        /// UpstreamPort: same as Port
        /// UpstreamProtocol: same as Protocol
        /// </summary>
        [JsonProperty("Ports")]
        public PortItem[] Ports{ get; set; }

        /// <summary>
        /// (Required) Whether to enable persistent connection
        /// 0: non-persistent connection
        /// 1: persistent connection
        /// </summary>
        [JsonProperty("IsKeepAlive")]
        public string IsKeepAlive{ get; set; }

        /// <summary>
        /// (Required) Instance ID of the domain name
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

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
        /// To be deprecated, not required. WAF resource ID.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// When IsCdn is 3, this parameter is required, indicating a custom header.
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// Upstream protocol for HTTPS when the service is configured with an HTTPS port
        /// http: Use the HTTP protocol for upstream. It is used together with HttpsUpstreamPort.
        /// https: Use the HTTPS protocol for upstream.
        /// </summary>
        [JsonProperty("UpstreamScheme")]
        public string UpstreamScheme{ get; set; }

        /// <summary>
        /// HTTPS upstream port, required only when UpstreamScheme is http
        /// </summary>
        [JsonProperty("HttpsUpstreamPort")]
        public string HttpsUpstreamPort{ get; set; }

        /// <summary>
        /// To be deprecated, can be left blank. Whether to enable grayscale: 0 indicates not to enable grayscale.
        /// </summary>
        [JsonProperty("IsGray")]
        public long? IsGray{ get; set; }

        /// <summary>
        /// To be deprecated, can be left blank. Grayscale area.
        /// </summary>
        [JsonProperty("GrayAreas")]
        public string[] GrayAreas{ get; set; }

        /// <summary>
        /// (Required) Whether to enable forced redirection from HTTP to HTTPS
        /// 0: do not force redirect
        /// 1: enable forced redirect
        /// </summary>
        [JsonProperty("HttpsRewrite")]
        public long? HttpsRewrite{ get; set; }

        /// <summary>
        /// Upstream domain when proxy to upstream by domain. When UpstreamType=1, this field needs to be filled
        /// </summary>
        [JsonProperty("UpstreamDomain")]
        public string UpstreamDomain{ get; set; }

        /// <summary>
        /// Upstream IP list when IP is back to source. When UpstreamType=0, this field is required
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        /// (Required) Whether to enable HTTP2. You should enable HTTPS as well.
        /// 0: disable
        /// 1: enable
        /// </summary>
        [JsonProperty("IsHttp2")]
        public long? IsHttp2{ get; set; }

        /// <summary>
        /// WAF instance type. This parameter will be deprecated in later versions and is not required in the current version.
        /// sparta-waf: SaaS WAF
        /// clb-waf: CLB WAF
        /// cdn-waf: web protection capability on CDN
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// To be deprecated, currently just fill in 0. Anycast IP type switch: 0 Ordinary IP, 1 Anycast IP
        /// </summary>
        [JsonProperty("Anycast")]
        public long? Anycast{ get; set; }

        /// <summary>
        /// Weight of each IP in the back-to-source IP List, corresponding to SrcList. Required only when UpstreamType is 0, and SrcList contains multiple IPs, and LoadBalance is 2; otherwise, fill in [ ].
        /// </summary>
        [JsonProperty("Weights")]
        public long?[] Weights{ get; set; }

        /// <summary>
        /// (Required) Whether to enable active health check
        /// 0: disable
        /// 1: enable
        /// </summary>
        [JsonProperty("ActiveCheck")]
        public long? ActiveCheck{ get; set; }

        /// <summary>
        /// TLS version information
        /// </summary>
        [JsonProperty("TLSVersion")]
        public long? TLSVersion{ get; set; }

        /// <summary>
        /// (Required) Cipher suite template
        /// 0: default template
        /// 1: general template
        /// 2: security template
        /// 3: custom template
        /// </summary>
        [JsonProperty("CipherTemplate")]
        public long? CipherTemplate{ get; set; }

        /// <summary>
        /// Custom encryption suite list. When CipherTemplate is 3, this field is required, indicating the custom encryption suite, value obtained through DescribeCiphersDetail API.
        /// </summary>
        [JsonProperty("Ciphers")]
        public long?[] Ciphers{ get; set; }

        /// <summary>
        /// Read timeout between WAF and upstream server, 300s by default.
        /// </summary>
        [JsonProperty("ProxyReadTimeout")]
        public long? ProxyReadTimeout{ get; set; }

        /// <summary>
        /// WAF and upstream server write timeout, 300s by default.
        /// </summary>
        [JsonProperty("ProxySendTimeout")]
        public long? ProxySendTimeout{ get; set; }

        /// <summary>
        /// SNI type during WAF sending request to upstream
        /// 0: Disable SNI and do not configure server_name in client_hello.
        /// 1: Enable SNI. server_name in client_hello is a protected domain name.
        /// 2: Enable SNI. SNI is the origin server domain name during the domain name origin-pull.
        /// 3: Enable SNI. SNI is a custom domain name.
        /// </summary>
        [JsonProperty("SniType")]
        public long? SniType{ get; set; }

        /// <summary>
        /// When SniType=3, this parameter is required, indicating a custom SNI;
        /// </summary>
        [JsonProperty("SniHost")]
        public string SniHost{ get; set; }

        /// <summary>
        /// Whether to enable XFF reset. 0: disable; 1: enable.
        /// </summary>
        [JsonProperty("XFFReset")]
        public long? XFFReset{ get; set; }

        /// <summary>
        /// Domain name remarks
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// Custom upstream host. The default value is an empty string, indicating that  protected domain is used as the upstream host.
        /// </summary>
        [JsonProperty("UpstreamHost")]
        public string UpstreamHost{ get; set; }

        /// <summary>
        /// Whether to enable caching. 0: disable; 1: enable.
        /// </summary>
        [JsonProperty("ProxyBuffer")]
        public long? ProxyBuffer{ get; set; }

        /// <summary>
        /// Whether to enable the test. 0: disable; 1: enable. The test is enabled by default.
        /// </summary>
        [JsonProperty("ProbeStatus")]
        public long? ProbeStatus{ get; set; }

        /// <summary>
        /// Whether to enable SM. 0: do not enable SM; 1: add support for SM based on the existing TLS option; 2: enable SM and support only SM client access.
        /// </summary>
        [JsonProperty("GmType")]
        public long? GmType{ get; set; }

        /// <summary>
        /// SM certificate type. 0: no SM certificate is available; 1: the certificate is a self-owned SM certificate; 2: the certificate is a managed SM certificate.
        /// </summary>
        [JsonProperty("GmCertType")]
        public long? GmCertType{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the certificate chain of the self-owned SM certificate.
        /// </summary>
        [JsonProperty("GmCert")]
        public string GmCert{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the private key of the self-owned SM certificate.
        /// </summary>
        [JsonProperty("GmPrivateKey")]
        public string GmPrivateKey{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the encryption certificate of the self-owned SM certificate.
        /// </summary>
        [JsonProperty("GmEncCert")]
        public string GmEncCert{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the private key of the encryption certificate for the self-owned SM certificate.
        /// </summary>
        [JsonProperty("GmEncPrivateKey")]
        public string GmEncPrivateKey{ get; set; }

        /// <summary>
        /// When GmCertType is 2, this parameter needs to be set, indicating the ID of the certificate managed by the Tencent Cloud SSL platform.
        /// </summary>
        [JsonProperty("GmSSLId")]
        public string GmSSLId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamSimple(map, prefix + "IsWebsocket", this.IsWebsocket);
            this.SetParamSimple(map, prefix + "LoadBalance", this.LoadBalance);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "IsKeepAlive", this.IsKeepAlive);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "Cert", this.Cert);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "SSLId", this.SSLId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "UpstreamScheme", this.UpstreamScheme);
            this.SetParamSimple(map, prefix + "HttpsUpstreamPort", this.HttpsUpstreamPort);
            this.SetParamSimple(map, prefix + "IsGray", this.IsGray);
            this.SetParamArraySimple(map, prefix + "GrayAreas.", this.GrayAreas);
            this.SetParamSimple(map, prefix + "HttpsRewrite", this.HttpsRewrite);
            this.SetParamSimple(map, prefix + "UpstreamDomain", this.UpstreamDomain);
            this.SetParamArraySimple(map, prefix + "SrcList.", this.SrcList);
            this.SetParamSimple(map, prefix + "IsHttp2", this.IsHttp2);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Anycast", this.Anycast);
            this.SetParamArraySimple(map, prefix + "Weights.", this.Weights);
            this.SetParamSimple(map, prefix + "ActiveCheck", this.ActiveCheck);
            this.SetParamSimple(map, prefix + "TLSVersion", this.TLSVersion);
            this.SetParamSimple(map, prefix + "CipherTemplate", this.CipherTemplate);
            this.SetParamArraySimple(map, prefix + "Ciphers.", this.Ciphers);
            this.SetParamSimple(map, prefix + "ProxyReadTimeout", this.ProxyReadTimeout);
            this.SetParamSimple(map, prefix + "ProxySendTimeout", this.ProxySendTimeout);
            this.SetParamSimple(map, prefix + "SniType", this.SniType);
            this.SetParamSimple(map, prefix + "SniHost", this.SniHost);
            this.SetParamSimple(map, prefix + "XFFReset", this.XFFReset);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "UpstreamHost", this.UpstreamHost);
            this.SetParamSimple(map, prefix + "ProxyBuffer", this.ProxyBuffer);
            this.SetParamSimple(map, prefix + "ProbeStatus", this.ProbeStatus);
            this.SetParamSimple(map, prefix + "GmType", this.GmType);
            this.SetParamSimple(map, prefix + "GmCertType", this.GmCertType);
            this.SetParamSimple(map, prefix + "GmCert", this.GmCert);
            this.SetParamSimple(map, prefix + "GmPrivateKey", this.GmPrivateKey);
            this.SetParamSimple(map, prefix + "GmEncCert", this.GmEncCert);
            this.SetParamSimple(map, prefix + "GmEncPrivateKey", this.GmEncPrivateKey);
            this.SetParamSimple(map, prefix + "GmSSLId", this.GmSSLId);
        }
    }
}

