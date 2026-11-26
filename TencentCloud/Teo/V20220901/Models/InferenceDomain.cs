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

    public class InferenceDomain : AbstractModel
    {
        
        /// <summary>
        /// <p>Domain name.</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Domain name status.</p><p>Enumeration values:</p><ul><li>Online: effective;</li><li>Process: deploying;</li><li>Offline: disabled;</li><li>Init: not applied, site to be activated;</li><li>Forbidden: domain name disabled.</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Authentication switch for inference task requests.</p><p>Enumeration values:</p><ul><li>Off: Disable authentication;</li><li>On: Enable authentication.</li></ul><p>Default value: On.</p>
        /// </summary>
        [JsonProperty("AuthSwitch")]
        public string AuthSwitch{ get; set; }

        /// <summary>
        /// <p>CNAME address.</p><p>To validate the CNAME configuration status of a domain, see the <a href="https://www.tencentcloud.com/document/api/1552/94491?from_cn_redirect=1"> CheckCnameStatus </a> api.</p>
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// <p>When the domain name needs to perform ownership verification to continue providing services, this object will carry the information required for the corresponding verification method.</p><p>To verify ownership, see the <a href="https://www.tencentcloud.com/document/api/1552/98879?from_cn_redirect=1"> VerifyOwnership </a> API.</p>
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }

        /// <summary>
        /// <p>Domain name certificate information.</p><p>To apply for a free certificate, see the <a href="https://www.tencentcloud.com/document/api/1552/124807?from_cn_redirect=1">ApplyFreeCertificate</a> API;<br>To check the free certificate application result, see the <a href="https://www.tencentcloud.com/document/api/1552/124806?from_cn_redirect=1">CheckFreeCertificateVerification</a> API;<br>To configure the domain name certificate, see the <a href="https://www.tencentcloud.com/document/api/1552/80764?from_cn_redirect=1">ModifyHostsCertificate</a> API.</p>
        /// </summary>
        [JsonProperty("Certificate")]
        public HostsCertificate Certificate{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Last modified.</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AuthSwitch", this.AuthSwitch);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

