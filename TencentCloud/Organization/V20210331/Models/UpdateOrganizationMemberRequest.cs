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

    public class UpdateOrganizationMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// Member UIN.
        /// </summary>
        [JsonProperty("MemberUin")]
        public ulong? MemberUin{ get; set; }

        /// <summary>
        /// Member name, which contains up to 25 characters, including English letters, digits, and symbols `+@&._[]-:,`.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Remarks, which contain up to 40 characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Relationship policy type. When PolicyType is not empty, PermissionIds cannot be empty. Value: Financial.
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// List of member financial permission IDs. When PermissionIds is not empty, PolicyType cannot be empty.
        /// Valid values: 1: View bills. 2: View balance. 3: Allocate funds. 4: Consolidate bills. 5: Issue invoices. 6: Inherit discounts. 7: Pay on behalf. 8: Analyze costs. 1 and 2 are required by default.
        /// </summary>
        [JsonProperty("PermissionIds")]
        public ulong?[] PermissionIds{ get; set; }

        /// <summary>
        /// Whether to allow members to exit an organization. Valid values: Allow: permitted, Denied: not permitted.
        /// </summary>
        [JsonProperty("IsAllowQuit")]
        public string IsAllowQuit{ get; set; }

        /// <summary>
        /// Payer UIN, which is required when pay-on-behalf mode is used in member financial permission. The value is the principal administrator UIN of the corresponding member.
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamArraySimple(map, prefix + "PermissionIds.", this.PermissionIds);
            this.SetParamSimple(map, prefix + "IsAllowQuit", this.IsAllowQuit);
            this.SetParamSimple(map, prefix + "PayUin", this.PayUin);
        }
    }
}

