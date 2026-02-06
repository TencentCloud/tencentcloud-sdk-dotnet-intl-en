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
        /// Specifies the target domain name for free certificate application.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Specifies the verification method for applying for a free certificate. for detailed verification methods, refer to the [free certificate application documentation](https://www.tencentcloud.com/document/product/1552/90437?from_cn_redirect=1). valid values:.
        /// <li>http_challenge: specifies the file validation mode for http access. verifies by getting file information from the specified URL of the access domain to complete free certificate application.</li>
        /// <li>dns_challenge: specifies the dns delegation verification method. verifies the free certificate application by adding the designated host record pointing to EdgeOne.</li>
        /// 
        /// Note: after triggering this api, you need to complete the verification content configuration based on the returned verification information. once configured, you must also verify by calling the <a href = 'https://www.tencentcloud.com/document/product/1552/124806?from_cn_redirect=1'>check free certificate application result</a> api. after verification passes, the application succeeds. once the application is successful, you can call the <a href = 'https://www.tencentcloud.com/document/product/1552/80764?from_cn_redirect=1'>configure domain name certificate</a> API to deploy a free certificate for the current domain name.
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

