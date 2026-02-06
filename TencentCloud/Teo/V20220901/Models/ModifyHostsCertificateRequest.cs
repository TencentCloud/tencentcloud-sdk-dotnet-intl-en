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

    public class ModifyHostsCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the site.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Domain names that you need to modify the certificate configuration
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// Configures the server certificate mode. valid values:.
        /// 
        /// - disable: without configuring server certificate.
        /// - eofreecert: specifies to apply for a free certificate through automatic validation and deploy it. for verification methods, see [free certificate application supported verification methods](https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1).
        ///     - In ns or DNSPod hosting access mode, free certificates can only be applied for via automatic validation.
        ///     - When a free certificate application fails, it can cause deployment failure. you can obtain the failure reason through the <a href = 'https://www.tencentcloud.com/document/product/1552/124806?from_cn_redirect=1)'>check free certificate application result</a> .
        /// - eofreecert_manual: specifies the deployment of free certificates applied through DNS delegation verification or file verification. before deploying a free certificate, you need to trigger the [apply for free certificate](https://www.tencentcloud.com/document/product/1552/124807?from_cn_redirect=1)) api to apply for a free certificate. once the application is successful, you can use this enumeration value to deploy the free certificate.
        /// Note: when deploying a free certificate, ensure a successful application for a free certificate already exists. you can check whether a successful application for a free certificate already exists through the <a href = 'https://www.tencentcloud.com/document/product/1552/124806?from_cn_redirect=1)'>check free certificate application result</a> api.
        /// - sslcert: specifies the configuration of the managed service side certificate.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// SSL certificate configuration. This parameter is effective only when the mode is sslcert. You only need to provide the CertId of the corresponding certificate. You can check the CertId from the [SSL Certificate List](https://console.cloud.tencent.com/ssl).
        /// </summary>
        [JsonProperty("ServerCertInfo")]
        public ServerCertInfo[] ServerCertInfo{ get; set; }

        /// <summary>
        /// Whether the certificate is managed by EdgeOne. Values:
        /// <li>`none`: Not managed by EdgeOne</li>
        /// <li>`apply`: Managed by EdgeOne</li>
        /// Default value: `none`.
        /// </summary>
        [JsonProperty("ApplyType")]
        [System.Obsolete]
        public string ApplyType{ get; set; }

        /// <summary>
        /// In the mutual authentication scenario, this field represents the client's CA certificate, which is deployed inside the EO node and used for the client to authenticate the EO node. By default, it is disabled. If it is left blank, it indicates retaining the original configuration.
        /// </summary>
        [JsonProperty("ClientCertInfo")]
        public MutualTLS ClientCertInfo{ get; set; }

        /// <summary>
        /// Specifies the certificate carried during EO node origin-pull for origin-pull mutual authentication handshake, off by default. leave blank to indicate retaining the original configuration. this configuration is currently in closed beta testing for the allowlist feature. if you need to use it, please contact us (https://www.tencentcloud.com/online?from_cn_redirect=1-service).
        /// </summary>
        [JsonProperty("UpstreamCertInfo")]
        public UpstreamCertInfo UpstreamCertInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "ServerCertInfo.", this.ServerCertInfo);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
            this.SetParamObj(map, prefix + "ClientCertInfo.", this.ClientCertInfo);
            this.SetParamObj(map, prefix + "UpstreamCertInfo.", this.UpstreamCertInfo);
        }
    }
}

