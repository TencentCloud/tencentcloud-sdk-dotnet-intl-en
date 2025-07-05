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

    public class UserProvisioning : AbstractModel
    {
        
        /// <summary>
        /// CAM user synchronization status. Valid values:
        /// 
        /// Enabled: CAM user synchronization is enabled.
        /// Disabled: CAM user synchronization is disabled.
        /// </summary>
        [JsonProperty("UserProvisioningId")]
        public string UserProvisioningId{ get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// CAM user synchronization status. Valid values:
        /// 
        /// Enabled: CAM user synchronization is enabled.
        /// Disabled: CAM user synchronization is disabled.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Identity ID for the CAM user synchronization. Valid values:
        /// When the PrincipalType value is Group, it is the CIC user group ID (g-********).
        /// When the PrincipalType value is User, it is the CIC user ID (u-********).
        /// </summary>
        [JsonProperty("PrincipalId")]
        public string PrincipalId{ get; set; }

        /// <summary>
        /// Identity name for the CAM user synchronization. Valid values:When the PrincipalType value is Group, it is the CIC user group name.
        /// When the PrincipalType value is User, it is the CIC user name.
        /// </summary>
        [JsonProperty("PrincipalName")]
        public string PrincipalName{ get; set; }

        /// <summary>
        /// Identity type for the CAM user synchronization. Valid values:
        /// 
        /// User: indicates that the identity for the CAM user synchronization is a CIC user.
        /// Group: indicates that the identity for the CAM user synchronization is a CIC user group.
        /// </summary>
        [JsonProperty("PrincipalType")]
        public string PrincipalType{ get; set; }

        /// <summary>
        /// UIN of the target account of the Tencent Cloud Organization.
        /// </summary>
        [JsonProperty("TargetUin")]
        public long? TargetUin{ get; set; }

        /// <summary>
        /// Name of the target account of the Tencent Cloud Organization.
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// Conflict policy. It indicates the handling policy for existence of a user with the same username when CIC users are synchronized to CAM. Valid values: KeepBoth: Keep both, that is, add the _cic suffix to the CIC user's username and then try to create a CAM user with the username when CIC users are synchronized to CAM and a user with the same username already exists in CAM; TakeOver: Replace, that is, directly replace the existing CAM user with the synchronized CIC user when CIC users are synchronized to CAM and a user with the same username already exists in CAM.
        /// </summary>
        [JsonProperty("DuplicationStrategy")]
        public string DuplicationStrategy{ get; set; }

        /// <summary>
        /// Deletion policy. It indicates the handling policy for CAM users already synchronized when the CAM user synchronization is deleted. Valid values: Delete: Delete the CAM users already synchronized from CIC to CAM when the CAM user synchronization is deleted; Keep: Keep the CAM users already synchronized from CIC to CAM when the CAM user synchronization is deleted.
        /// </summary>
        [JsonProperty("DeletionStrategy")]
        public string DeletionStrategy{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Type of the synchronized target account of the Tencent Cloud Organization. ManagerUin: admin account; MemberUin: member account.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserProvisioningId", this.UserProvisioningId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PrincipalId", this.PrincipalId);
            this.SetParamSimple(map, prefix + "PrincipalName", this.PrincipalName);
            this.SetParamSimple(map, prefix + "PrincipalType", this.PrincipalType);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "DuplicationStrategy", this.DuplicationStrategy);
            this.SetParamSimple(map, prefix + "DeletionStrategy", this.DeletionStrategy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
        }
    }
}

