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

    public class ApplyFreeCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Target domain name for free certificate application.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Verification methods for applying for a free certificate. For detailed verification method descriptions, see [Free Certificate Application Method Documentation](https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1). Valid values:
        /// <li>http_challenge: HTTP access file validation mode, which gets file information by accessing the specified URL of the domain over HTTP to complete the free certificate application verification;</li>
        /// <li>dns_challenge: DNS delegation verification method, which completes free certificate application verification by adding a designated host record to point to EdgeOne.</li>
        /// Note: After triggering this API, you need to complete the verification content configuration based on the returned verification information. Once configured, you also need to verify through the <a href = 'https://www.tencentcloud.com/document/product/1552/124806?from_cn_redirect=1'>Check Free Certificate Application Result</a> API. After verification passes, the application succeeds. Once the free certificate application is successful, you can call the <a href = 'https://www.tencentcloud.com/document/product/1552/80764?from_cn_redirect=1'>Configure Domain Name Certificate</a> API to deploy the free certificate for the current domain name.
        /// </summary>
        [JsonProperty("VerificationMethod")]
        public string VerificationMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "VerificationMethod", this.VerificationMethod);
        }
    }
}

