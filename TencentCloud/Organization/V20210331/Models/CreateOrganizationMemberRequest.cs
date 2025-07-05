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

    public class CreateOrganizationMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// Member name, which can contain up to 25 letters, digits, and symbols `+@&._[]-:,`.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Relationship policy. Valid value: `Financial`.
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// Member Finanace Authorization. Valid values: 1: View Bills. 2: View Balance.  4: Consolidate Bills. 5: Invoice. 6: Inherit Offer. 7: Pay On Behalf. 8: Cost Explorer. 9: Budget Management.  1, 2 and 7 are required.
        /// </summary>
        [JsonProperty("PermissionIds")]
        public ulong?[] PermissionIds{ get; set; }

        /// <summary>
        /// Node ID of the member's department, which can be obtained through [DescribeOrganizationNodes](https://intl.cloud.tencent.com/document/product/850/82926?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("NodeId")]
        public long? NodeId{ get; set; }

        /// <summary>
        /// Account name, which can contain up to 25 letters, digits, and symbols `+@&._[]-:,`.
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Member creation record ID, which is required during retry upon creation exception.
        /// </summary>
        [JsonProperty("RecordId")]
        public long? RecordId{ get; set; }

        /// <summary>
        /// Payer UIN, which is required during paying for a member.
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }

        /// <summary>
        /// List of member access identity IDs, which can be obtained through the `ListOrganizationIdentity` API. `1` indicates supported, which is the default value.
        /// </summary>
        [JsonProperty("IdentityRoleID")]
        public ulong?[] IdentityRoleID{ get; set; }

        /// <summary>
        /// Verified entity relationship ID, which is required during creating members for different entities.
        /// </summary>
        [JsonProperty("AuthRelationId")]
        public long? AuthRelationId{ get; set; }

        /// <summary>
        /// Member tag list, with a maximum of 10.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamArraySimple(map, prefix + "PermissionIds.", this.PermissionIds);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "PayUin", this.PayUin);
            this.SetParamArraySimple(map, prefix + "IdentityRoleID.", this.IdentityRoleID);
            this.SetParamSimple(map, prefix + "AuthRelationId", this.AuthRelationId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

