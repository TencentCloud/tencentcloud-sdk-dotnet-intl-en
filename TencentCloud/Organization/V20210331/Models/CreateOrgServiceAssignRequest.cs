/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class CreateOrgServiceAssignRequest : AbstractModel
    {
        
        /// <summary>
        /// Uin list of the delegated admins, including up to 20 items.
        /// </summary>
        [JsonProperty("MemberUins")]
        public long?[] MemberUins{ get; set; }

        /// <summary>
        /// Organization service ID, which can be obtained through [ListOrganizationService](https://intl.cloud.tencent.com/document/product/850/109561?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ServiceId")]
        public ulong? ServiceId{ get; set; }

        /// <summary>
        /// Management scope of the delegated admin. Valid values: 1 (all members), 2 (partial members). Default value: 1.
        /// </summary>
        [JsonProperty("ManagementScope")]
        public ulong? ManagementScope{ get; set; }

        /// <summary>
        /// Uin list of the managed members. This parameter is valid when ManagementScope is 2.
        /// </summary>
        [JsonProperty("ManagementScopeUins")]
        public long?[] ManagementScopeUins{ get; set; }

        /// <summary>
        /// ID list of the managed departments. This parameter is valid when ManagementScope is 2.
        /// </summary>
        [JsonProperty("ManagementScopeNodeIds")]
        public long?[] ManagementScopeNodeIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberUins.", this.MemberUins);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ManagementScope", this.ManagementScope);
            this.SetParamArraySimple(map, prefix + "ManagementScopeUins.", this.ManagementScopeUins);
            this.SetParamArraySimple(map, prefix + "ManagementScopeNodeIds.", this.ManagementScopeNodeIds);
        }
    }
}

