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

    public class CreateZoneResponse : AbstractModel
    {
        
        /// <summary>
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Site ownership verification information. After the site is created, you need to complete the ownership verification before the site can serve normally.
        /// 
        /// If `Type=partial`, add TXT records to your DNS provider or add files to the root DNS server, and then call [VerifyOwnership]() to complete verification. For more information, see [Ownership Verification](https://intl.cloud.tencent.com/document/product/1552/70789?from_cn_redirect=1).
        /// 
        /// If `Type = full`, switch the DNS server as instructed by [Modifying DNS Server](https://intl.cloud.tencent.com/document/product/1552/90452?from_cn_redirect=1). Then call [VerifyOwnership]() to check the result.
        /// 
        /// If `Type = noDomainAccess`, leave it blank. No action is required.
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

