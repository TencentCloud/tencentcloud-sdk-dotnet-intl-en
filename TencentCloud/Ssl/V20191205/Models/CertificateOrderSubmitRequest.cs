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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertificateOrderSubmitRequest : AbstractModel
    {
        
        /// <summary>
        /// Paid SSL certificate ID of materials to be submitted.	
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// Whether to delete automatic DNS validation: 0, do not delete; 1, delete; default is do not delete.
        /// </summary>
        [JsonProperty("DeleteDnsAutoRecord")]
        public ulong? DeleteDnsAutoRecord{ get; set; }

        /// <summary>
        /// Domain validation method of the certificate
        /// DNS: Manually add domain DNS validation. The user needs to manually add the verification value at the DNS service provider.
        /// FILE: Manual domain addition via FILE verification. Users are advised to manually add the specified path FILE to the root directory of the domain site for FILE verification. Either http or https access is sufficient. The domain site must be accessible by overseas certificate authorities. For the specific access allowlist, refer to the console page.
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "DeleteDnsAutoRecord", this.DeleteDnsAutoRecord);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
        }
    }
}

