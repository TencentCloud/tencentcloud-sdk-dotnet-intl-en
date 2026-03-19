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

    public class OrgMember : AbstractModel
    {
        
        /// <summary>
        /// Member UIN.
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// Member name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Member type. Invite: invited, Create: created.
        /// </summary>
        [JsonProperty("MemberType")]
        public string MemberType{ get; set; }

        /// <summary>
        /// Relationship policy type.
        /// </summary>
        [JsonProperty("OrgPolicyType")]
        public string OrgPolicyType{ get; set; }

        /// <summary>
        /// Relational policy name.
        /// </summary>
        [JsonProperty("OrgPolicyName")]
        public string OrgPolicyName{ get; set; }

        /// <summary>
        /// Relationship policy permission.
        /// </summary>
        [JsonProperty("OrgPermission")]
        public OrgPermission[] OrgPermission{ get; set; }

        /// <summary>
        /// Node ID.
        /// </summary>
        [JsonProperty("NodeId")]
        public long? NodeId{ get; set; }

        /// <summary>
        /// Node name.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update date
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Whether to allow a member to exit. Valid values: Allow, Denied.
        /// </summary>
        [JsonProperty("IsAllowQuit")]
        public string IsAllowQuit{ get; set; }

        /// <summary>
        /// Proxy payer UIN.
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }

        /// <summary>
        /// Proxy payer name.
        /// </summary>
        [JsonProperty("PayName")]
        public string PayName{ get; set; }

        /// <summary>
        /// Admin identity.
        /// </summary>
        [JsonProperty("OrgIdentity")]
        public MemberIdentity[] OrgIdentity{ get; set; }

        /// <summary>
        /// Security information binding status  Unbound: Unbound, to be activated: Valid, binding succeeded: Success, binding Failed: Failed.
        /// </summary>
        [JsonProperty("BindStatus")]
        public string BindStatus{ get; set; }

        /// <summary>
        /// Member's permission status. Valid values: Confirmed, UnConfirmed.
        /// </summary>
        [JsonProperty("PermissionStatus")]
        public string PermissionStatus{ get; set; }

        /// <summary>
        /// Member tag list.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Tencent cloud nickname.
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MemberType", this.MemberType);
            this.SetParamSimple(map, prefix + "OrgPolicyType", this.OrgPolicyType);
            this.SetParamSimple(map, prefix + "OrgPolicyName", this.OrgPolicyName);
            this.SetParamArrayObj(map, prefix + "OrgPermission.", this.OrgPermission);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsAllowQuit", this.IsAllowQuit);
            this.SetParamSimple(map, prefix + "PayUin", this.PayUin);
            this.SetParamSimple(map, prefix + "PayName", this.PayName);
            this.SetParamArrayObj(map, prefix + "OrgIdentity.", this.OrgIdentity);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "PermissionStatus", this.PermissionStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
        }
    }
}

