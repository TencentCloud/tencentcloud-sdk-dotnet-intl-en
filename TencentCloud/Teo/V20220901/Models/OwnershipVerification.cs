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

    public class OwnershipVerification : AbstractModel
    {
        
        /// <summary>
        /// Information required for CNAME and domainless access when using DNS resolution verification. For details, see [Site/Domain Ownership Verification].
        /// ](https://www.tencentcloud.com/document/product/1552/70789?from_cn_redirect=1#7af6ecf8-afca-4e35-8811-b5797ed1bde5).
        /// </summary>
        [JsonProperty("DnsVerification")]
        public DnsVerification DnsVerification{ get; set; }

        /// <summary>
        /// CNAME, when there is no domain name access, the information required for file verification is used. For details, see [Site/Domain Ownership Verification
        /// ](https://www.tencentcloud.com/document/product/1552/70789?from_cn_redirect=1#7af6ecf8-afca-4e35-8811-b5797ed1bde5).
        /// </summary>
        [JsonProperty("FileVerification")]
        public FileVerification FileVerification{ get; set; }

        /// <summary>
        /// Information required for access via NS and switching DNS servers. For details, see [Modify DNS Server](https://www.tencentcloud.com/document/product/1552/90452?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("NsVerification")]
        public NsVerification NsVerification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DnsVerification.", this.DnsVerification);
            this.SetParamObj(map, prefix + "FileVerification.", this.FileVerification);
            this.SetParamObj(map, prefix + "NsVerification.", this.NsVerification);
        }
    }
}

