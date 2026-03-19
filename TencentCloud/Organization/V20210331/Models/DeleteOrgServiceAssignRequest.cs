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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteOrgServiceAssignRequest : AbstractModel
    {
        
        /// <summary>
        /// Uin of the delegated admin.
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// Group service ID. either this or group service product identifier is required. can be obtained through ListOrganizationService (https://www.tencentcloud.com/document/product/850/109561?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ServiceId")]
        public ulong? ServiceId{ get; set; }

        /// <summary>
        /// Group service product identifier. either this or group service ID is required. can be obtained through ListOrganizationService (https://www.tencentcloud.com/document/product/850/109561?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

