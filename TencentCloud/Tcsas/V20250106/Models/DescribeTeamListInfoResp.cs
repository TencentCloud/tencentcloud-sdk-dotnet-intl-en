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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTeamListInfoResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Team ID.</p>
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// <p>Team name.</p>
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }

        /// <summary>
        /// <p>Admin user ID.</p>
        /// </summary>
        [JsonProperty("AdminUserId")]
        public string AdminUserId{ get; set; }

        /// <summary>
        /// <p>Admin account.</p>
        /// </summary>
        [JsonProperty("AdminUserAccount")]
        public string AdminUserAccount{ get; set; }

        /// <summary>
        /// <p>Admin username.</p>
        /// </summary>
        [JsonProperty("AdminUserName")]
        public string AdminUserName{ get; set; }

        /// <summary>
        /// <p>Number of team members.</p>
        /// </summary>
        [JsonProperty("MemberCount")]
        public long? MemberCount{ get; set; }

        /// <summary>
        /// <p>Team registration link.</p>
        /// </summary>
        [JsonProperty("RegisterLink")]
        public string RegisterLink{ get; set; }

        /// <summary>
        /// <p>Team role types.</p>
        /// </summary>
        [JsonProperty("TeamRoleTypeList")]
        public long?[] TeamRoleTypeList{ get; set; }

        /// <summary>
        /// <p>Associated team ID.</p>
        /// </summary>
        [JsonProperty("RelatedTeamId")]
        public long? RelatedTeamId{ get; set; }

        /// <summary>
        /// <p>Team expiration time. 0 indicates no expiration.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// <p>Team status. Valid values: 1: Active; 2: Disabled; 3: Expired.</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Information of multiple team admin users.</p>
        /// </summary>
        [JsonProperty("AdminUsers")]
        public TeamAdminUserInfo[] AdminUsers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "TeamName", this.TeamName);
            this.SetParamSimple(map, prefix + "AdminUserId", this.AdminUserId);
            this.SetParamSimple(map, prefix + "AdminUserAccount", this.AdminUserAccount);
            this.SetParamSimple(map, prefix + "AdminUserName", this.AdminUserName);
            this.SetParamSimple(map, prefix + "MemberCount", this.MemberCount);
            this.SetParamSimple(map, prefix + "RegisterLink", this.RegisterLink);
            this.SetParamArraySimple(map, prefix + "TeamRoleTypeList.", this.TeamRoleTypeList);
            this.SetParamSimple(map, prefix + "RelatedTeamId", this.RelatedTeamId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "AdminUsers.", this.AdminUsers);
        }
    }
}

