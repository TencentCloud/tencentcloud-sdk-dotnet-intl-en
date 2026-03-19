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

    public class OrganizationServiceAssignMember : AbstractModel
    {
        
        /// <summary>
        /// Organization service ID.
        /// </summary>
        [JsonProperty("ServiceId")]
        public ulong? ServiceId{ get; set; }

        /// <summary>
        /// Organization service product name.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Uin of the delegated admin.
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// Delegated administrator name.
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }

        /// <summary>
        /// Activation status. Valid values: 0: not applicable to the service; 1: activated; 2: not activated.
        /// </summary>
        [JsonProperty("UsageStatus")]
        public ulong? UsageStatus{ get; set; }

        /// <summary>
        /// Delegation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Management scope of the delegated administrator. Valid values: 1: all members; 2 some members.
        /// </summary>
        [JsonProperty("ManagementScope")]
        public ulong? ManagementScope{ get; set; }

        /// <summary>
        /// UIN list of the managed members. This parameter is valid when the value of ManagementScope is 2.
        /// </summary>
        [JsonProperty("ManagementScopeMembers")]
        public MemberMainInfo[] ManagementScopeMembers{ get; set; }

        /// <summary>
        /// ID list of the departments under management. This parameter is valid when the value of ManagementScope is 2.
        /// </summary>
        [JsonProperty("ManagementScopeNodes")]
        public NodeMainInfo[] ManagementScopeNodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
            this.SetParamSimple(map, prefix + "UsageStatus", this.UsageStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ManagementScope", this.ManagementScope);
            this.SetParamArrayObj(map, prefix + "ManagementScopeMembers.", this.ManagementScopeMembers);
            this.SetParamArrayObj(map, prefix + "ManagementScopeNodes.", this.ManagementScopeNodes);
        }
    }
}

