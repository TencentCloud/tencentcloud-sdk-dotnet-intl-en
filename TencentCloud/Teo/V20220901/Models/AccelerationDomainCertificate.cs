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

    public class AccelerationDomainCertificate : AbstractModel
    {
        
        /// <summary>
        /// The server certificate configuration mode has the following valid values: <ul><li>disable: do not configure a server certificate.</li> <li>eofreecert: apply for a free certificate through automatic verification and deploy it. for verification methods, see: [supported verification methods for free certificate applications](https://www.tencentcloud.comom/document/product/1552/90437?from_cn_redirect=1). - in NS or DNSPod hosting access mode, only the automatic verification method is supported for free certificate applications. - if the free certificate application fails, it will cause deployment failure. you can obtain the reason for the failure through the <a href='https://www.tencentcloud.comom/document/product/1552/124806?from_cn_redirect=1'>check free certificate application result</a> api.</li> <li>eofreecert_manual: deploy a free certificate applied through DNS delegation verification or file verification. before deploying the free certificate, you need to trigger the <a href='https://www.tencentcloud.comom/document/product/1552/124807?from_cn_redirect=1'>apply for free certificate</a> API to apply for a free certificate. once the application is successful, you can deploy the free certificate using this enumeration value.</li> <ul><li>note: when deploying a free certificate, ensure that a successfully applied free certificate already exists. you can check whether a successfully applied free certificate exists through the <a href='https://www.tencentcloud.comom/document/product/1552/124806?from_cn_redirect=1'>check free certificate application result</a> api.</li> </ul> <li>sslcert: configure an SSL managed server-side certificate.</li></ul>.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// List of server certificates. The relevant certificates are deployed on the entrance side of the EO.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("List")]
        public CertificateInfo[] List{ get; set; }

        /// <summary>
        /// In the edge mutual authentication scenario, this field represents the client's CA certificate, which is deployed inside the EO node and used for EO node authentication of the client certificate.
        /// </summary>
        [JsonProperty("ClientCertInfo")]
        public MutualTLS ClientCertInfo{ get; set; }

        /// <summary>
        /// Specifies whether to enable or disable origin-pull mutual authentication and origin certificate verification. the certificate for origin-pull mutual authentication is carried during EO node origin-pull, and the origin server can choose to validate this certificate to ensure the request originates from a trusted EO node. when origin certificate verification is enabled, the certificate configuration is used for the EO node to verify whether the origin certificate is trustworthy.
        /// </summary>
        [JsonProperty("UpstreamCertInfo")]
        public UpstreamCertInfo UpstreamCertInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamObj(map, prefix + "ClientCertInfo.", this.ClientCertInfo);
            this.SetParamObj(map, prefix + "UpstreamCertInfo.", this.UpstreamCertInfo);
        }
    }
}

