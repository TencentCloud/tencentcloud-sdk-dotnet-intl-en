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

    public class OrgMembersAuthPolicy : AbstractModel
    {
        
        /// <summary>
        /// Identity ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdentityId")]
        public long? IdentityId{ get; set; }

        /// <summary>
        /// Role name of an identity.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdentityRoleName")]
        public string IdentityRoleName{ get; set; }

        /// <summary>
        /// Role alias of an identity.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdentityRoleAliasName")]
        public string IdentityRoleAliasName{ get; set; }

        /// <summary>
        /// Creation time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Member access policy ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// Member access policy name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Member UIN.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// Member name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemberName")]
        public string MemberName{ get; set; }

        /// <summary>
        /// Sub-account UIN or user group ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgSubAccountUin")]
        public long? OrgSubAccountUin{ get; set; }

        /// <summary>
        /// Sub-account name or user group name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgSubAccountName")]
        public string OrgSubAccountName{ get; set; }

        /// <summary>
        /// Binding type. 1: sub-account; 2: user group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindType")]
        public ulong? BindType{ get; set; }

        /// <summary>
        /// Member information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Members")]
        public MemberMainInfo[] Members{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdentityId", this.IdentityId);
            this.SetParamSimple(map, prefix + "IdentityRoleName", this.IdentityRoleName);
            this.SetParamSimple(map, prefix + "IdentityRoleAliasName", this.IdentityRoleAliasName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "MemberName", this.MemberName);
            this.SetParamSimple(map, prefix + "OrgSubAccountUin", this.OrgSubAccountUin);
            this.SetParamSimple(map, prefix + "OrgSubAccountName", this.OrgSubAccountName);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
            this.SetParamArrayObj(map, prefix + "Members.", this.Members);
        }
    }
}

