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
        /// Mode for configuring the server certificate. Valid values: <ul><li>disable: Do not configure a server certificate.</li> <li>eofreecert: Apply for a free certificate through automatic verification and deploy it. For details on the verification method, see [Supported Verification Methods for Free Certificate Application](https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1). - In NS or DNSPod hosting access mode, free certificates can only be applied for through automatic verification. - If the free certificate application fails, the certificate deployment will fail. You can obtain the failure reason through the <a href = 'https://www.tencentcloud.com/document/product/1552/124806?from_cn_redirect=1'>Check Free Certificate Application Result</a> API.</li><li>eofreecert_manual: Deploy a free certificate applied for through DNS delegated verification or file verification. Before deploying a free certificate, you need to trigger the <a href = 'https://www.tencentcloud.com/document/product/1552/124807?from_cn_redirect=1'>Apply for Free Certificate</a> API to apply for a free certificate. After the free certificate application succeeds, you can use this enumeration value to deploy the free certificate.</li> <ul><li>Note: When deploying a free certificate, ensure that a successfully applied free certificate already exists. You can check whether a successfully applied free certificate already exists through the <a href = 'https://www.tencentcloud.com/document/product/1552/124806?from_cn_redirect=1'>Check Free Certificate Application Result</a> API.</li> </ul> <li>sslcert: Configure an SSL managed server certificate.</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// List of server certificates. The related certificates are deployed at the EO entry side.
        /// </summary>
        [JsonProperty("List")]
        public CertificateInfo[] List{ get; set; }

        /// <summary>
        /// In the edge mutual authentication scenario, this field represents the client's CA certificate, which is deployed inside the EO node and used for EO node authentication of the client certificate.
        /// </summary>
        [JsonProperty("ClientCertInfo")]
        public MutualTLS ClientCertInfo{ get; set; }

        /// <summary>
        /// Used to enable or disable origin-pull mutual authentication and origin certificate verification. The certificate for origin-pull mutual authentication is carried during EO origin-pull. The origin server can choose to verify this certificate to ensure the request originates from a trusted EO node. When origin certificate verification is enabled, the certificate configuration is used for EO nodes to verify whether the origin certificate is trustworthy.
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

