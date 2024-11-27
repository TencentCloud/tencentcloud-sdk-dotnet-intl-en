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

    public class DomainsPartInfo : AbstractModel
    {
        
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Unique domain name ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// Unique instance ID of the domain name
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance type of the domain name
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// Instance name of the domain name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Certificate
        /// </summary>
        [JsonProperty("Cert")]
        public string Cert{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Status of the rule engine and AI engine
        /// 1: initial status. Interception for the rule engine and disabled for the AI engine.
        /// 10: observation for the rule engine and disabled for the AI engine
        /// 11: observation for both the rule engine and AI engine
        /// 12: observation for the rule engine and interception for the AI engine
        /// 20: interception for the rule engine and disabled for the AI engine
        /// 21: interception for the rule engine and observation for the AI engine
        /// 22: interception for both the rule engine and AI engine
        /// </summary>
        [JsonProperty("Engine")]
        public ulong? Engine{ get; set; }

        /// <summary>
        /// Whether to enable forced redirection from HTTP to HTTPS
        /// 0: do not force redirection
        /// 1: enable forced redirection
        /// </summary>
        [JsonProperty("HttpsRewrite")]
        public ulong? HttpsRewrite{ get; set; }

        /// <summary>
        /// HTTPS origin-pull port
        /// </summary>
        [JsonProperty("HttpsUpstreamPort")]
        public string HttpsUpstreamPort{ get; set; }

        /// <summary>
        /// Whether a layer-7 proxy service is deployed before WAF
        /// 0: No proxy service deployed
        /// 1: Proxy service deployed, and WAF will use XFF to obtain the client IP address
        /// 2: Proxy service deployed and WAF will use remote_addr to obtain the client IP address
        /// 3: Proxy service deployed and WAF will use the custom header in ip_headers to obtain the client IP address
        /// </summary>
        [JsonProperty("IsCdn")]
        public ulong? IsCdn{ get; set; }

        /// <summary>
        /// This parameter has been deprecated.
        /// </summary>
        [JsonProperty("IsGray")]
        public ulong? IsGray{ get; set; }

        /// <summary>
        /// Whether to enable HTTP2. You should enable HTTPS as well.
        /// 0: disable
        /// 1: enable
        /// </summary>
        [JsonProperty("IsHttp2")]
        public ulong? IsHttp2{ get; set; }

        /// <summary>
        /// Whether to enable support for WebSocket
        /// 0: disable
        /// 1: enable
        /// </summary>
        [JsonProperty("IsWebsocket")]
        public ulong? IsWebsocket{ get; set; }

        /// <summary>
        /// Load balancing policy for origin-pull
        /// 0: round-robin
        /// 1: IP hash
        /// 2: weighted round-robin
        /// </summary>
        [JsonProperty("LoadBalance")]
        public ulong? LoadBalance{ get; set; }

        /// <summary>
        /// Protection mode
        /// 0: observation mode
        /// 1: interception mode
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// Private key of the self-owned certificate
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// When CertType is 2, this parameter must be filled, indicating the certificate ID hosted on Tencent Cloud's SSL platform
        /// </summary>
        [JsonProperty("SSLId")]
        public string SSLId{ get; set; }

        /// <summary>
        /// Origin domain when domain is back to source. When UpstreamType=1, this field needs to be filled
        /// </summary>
        [JsonProperty("UpstreamDomain")]
        public string UpstreamDomain{ get; set; }

        /// <summary>
        /// Origin-pull type
        /// 0: origin-pull via IP address
        /// 1: origin-pull via domain name
        /// </summary>
        [JsonProperty("UpstreamType")]
        public ulong? UpstreamType{ get; set; }

        /// <summary>
        /// Origin IP list when IP is back to source. When UpstreamType=0, this field is required
        /// </summary>
        [JsonProperty("SrcList")]
        public string[] SrcList{ get; set; }

        /// <summary>
        ///  Domain name port configuration
        /// </summary>
        [JsonProperty("Ports")]
        public PortInfo[] Ports{ get; set; }

        /// <summary>
        /// Certificate type
        /// 0: no certificate, with only the HTTP listening port configured
        /// 1: self-owned certificate
        /// 2: managed certificate
        /// </summary>
        [JsonProperty("CertType")]
        public ulong? CertType{ get; set; }

        /// <summary>
        /// Origin-pull protocol for HTTPS when the service is configured with an HTTPS port
        /// http: Use the HTTP protocol for origin-pull. It is used together with HttpsUpstreamPort.
        /// https: Use the HTTPS protocol for origin-pull.
        /// </summary>
        [JsonProperty("UpstreamScheme")]
        public string UpstreamScheme{ get; set; }

        /// <summary>
        /// Whether to enable access logging
        /// 0: disable
        /// 1: enable
        /// </summary>
        [JsonProperty("Cls")]
        public ulong? Cls{ get; set; }

        /// <summary>
        /// CNAME record for accessing a domain name protected by SaaS WAF
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// Whether to enable persistent connection
        /// 0: non-persistent connection
        /// 1: persistent connection
        /// </summary>
        [JsonProperty("IsKeepAlive")]
        public ulong? IsKeepAlive{ get; set; }

        /// <summary>
        /// Whether to enable proactive health check
        /// 0: disable
        /// 1: enable
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActiveCheck")]
        public ulong? ActiveCheck{ get; set; }

        /// <summary>
        /// TLS version information
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TLSVersion")]
        public long? TLSVersion{ get; set; }

        /// <summary>
        /// Custom encryption suite list. When CipherTemplate is 3, this field is required, indicating the custom encryption suite, value obtained through DescribeCiphersDetail API.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ciphers")]
        public long?[] Ciphers{ get; set; }

        /// <summary>
        /// Cipher suite template
        /// 0: default template
        /// 1: general template
        /// 2: security template
        /// 3: custom template
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CipherTemplate")]
        public long? CipherTemplate{ get; set; }

        /// <summary>
        /// Read timeout between WAF and origin server, 300s by default.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyReadTimeout")]
        public long? ProxyReadTimeout{ get; set; }

        /// <summary>
        /// WAF and origin server write timeout, 300s by default.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxySendTimeout")]
        public long? ProxySendTimeout{ get; set; }

        /// <summary>
        /// SNI type during WAF origin-pull
        /// 0: Disable SNI and do not configure server_name in client_hello.
        /// 1: Enable SNI. server_name in client_hello is a protected domain name.
        /// 2: Enable SNI. SNI is the origin server domain name during the domain name origin-pull.
        /// 3: Enable SNI. SNI is a custom domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SniType")]
        public long? SniType{ get; set; }

        /// <summary>
        /// When SniType=3, this parameter is required, indicating a custom SNI;
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SniHost")]
        public string SniHost{ get; set; }

        /// <summary>
        /// Weight of the IP address for origin-pull
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Weights")]
        public string[] Weights{ get; set; }

        /// <summary>
        /// IsCdn=3 indicates custom header
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// Whether to enable XFF reset
        /// 0: disable
        /// 1: enable
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("XFFReset")]
        public long? XFFReset{ get; set; }

        /// <summary>
        /// Domain name remarks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// Custom origin-pull host. The default value is a null string, indicating that a protected domain name is used as the origin-pull host.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpstreamHost")]
        public string UpstreamHost{ get; set; }

        /// <summary>
        /// Protection rule
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Whether to enable caching. 0: disable; 1: enable.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyBuffer")]
        public long? ProxyBuffer{ get; set; }

        /// <summary>
        /// Whether to enable SM. 0: do not enable SM; 1: add support for SM based on the existing TLS option; 2: enable SM and support only SM client access.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GmType")]
        public long? GmType{ get; set; }

        /// <summary>
        /// SM certificate type. 0: no SM certificate is available; 1: the certificate is a self-owned SM certificate; 2: the certificate is a managed SM certificate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GmCertType")]
        public long? GmCertType{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the certificate chain of the self-owned SM certificate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GmCert")]
        public string GmCert{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the private key of the self-owned SM certificate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GmPrivateKey")]
        public string GmPrivateKey{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the encryption certificate of the self-owned SM certificate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GmEncCert")]
        public string GmEncCert{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the private key of the encryption certificate for the self-owned SM certificate.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GmEncPrivateKey")]
        public string GmEncPrivateKey{ get; set; }

        /// <summary>
        /// When GmCertType is 2, this parameter needs to be set, indicating the ID of the certificate managed by the Tencent Cloud SSL platform.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GmSSLId")]
        public string GmSSLId{ get; set; }

        /// <summary>
        /// Domain name tag.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Cert", this.Cert);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "HttpsRewrite", this.HttpsRewrite);
            this.SetParamSimple(map, prefix + "HttpsUpstreamPort", this.HttpsUpstreamPort);
            this.SetParamSimple(map, prefix + "IsCdn", this.IsCdn);
            this.SetParamSimple(map, prefix + "IsGray", this.IsGray);
            this.SetParamSimple(map, prefix + "IsHttp2", this.IsHttp2);
            this.SetParamSimple(map, prefix + "IsWebsocket", this.IsWebsocket);
            this.SetParamSimple(map, prefix + "LoadBalance", this.LoadBalance);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "SSLId", this.SSLId);
            this.SetParamSimple(map, prefix + "UpstreamDomain", this.UpstreamDomain);
            this.SetParamSimple(map, prefix + "UpstreamType", this.UpstreamType);
            this.SetParamArraySimple(map, prefix + "SrcList.", this.SrcList);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "UpstreamScheme", this.UpstreamScheme);
            this.SetParamSimple(map, prefix + "Cls", this.Cls);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "IsKeepAlive", this.IsKeepAlive);
            this.SetParamSimple(map, prefix + "ActiveCheck", this.ActiveCheck);
            this.SetParamSimple(map, prefix + "TLSVersion", this.TLSVersion);
            this.SetParamArraySimple(map, prefix + "Ciphers.", this.Ciphers);
            this.SetParamSimple(map, prefix + "CipherTemplate", this.CipherTemplate);
            this.SetParamSimple(map, prefix + "ProxyReadTimeout", this.ProxyReadTimeout);
            this.SetParamSimple(map, prefix + "ProxySendTimeout", this.ProxySendTimeout);
            this.SetParamSimple(map, prefix + "SniType", this.SniType);
            this.SetParamSimple(map, prefix + "SniHost", this.SniHost);
            this.SetParamArraySimple(map, prefix + "Weights.", this.Weights);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "XFFReset", this.XFFReset);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "UpstreamHost", this.UpstreamHost);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ProxyBuffer", this.ProxyBuffer);
            this.SetParamSimple(map, prefix + "GmType", this.GmType);
            this.SetParamSimple(map, prefix + "GmCertType", this.GmCertType);
            this.SetParamSimple(map, prefix + "GmCert", this.GmCert);
            this.SetParamSimple(map, prefix + "GmPrivateKey", this.GmPrivateKey);
            this.SetParamSimple(map, prefix + "GmEncCert", this.GmEncCert);
            this.SetParamSimple(map, prefix + "GmEncPrivateKey", this.GmEncPrivateKey);
            this.SetParamSimple(map, prefix + "GmSSLId", this.GmSSLId);
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
        }
    }
}

