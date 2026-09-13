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

    public class DescribeTeamDetailResp : AbstractModel
    {
        
        /// <summary>
        /// <p>Team name.</p>
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }

        /// <summary>
        /// <p>Team role type. Valid values: 1: Mini program team; 2: Superapp team.</p>
        /// </summary>
        [JsonProperty("TeamRoleType")]
        public long? TeamRoleType{ get; set; }

        /// <summary>
        /// <p>Administrator account.</p>
        /// </summary>
        [JsonProperty("AdminUserAccount")]
        public string AdminUserAccount{ get; set; }

        /// <summary>
        /// <p>Creator.</p>
        /// </summary>
        [JsonProperty("CreateUser")]
        public string CreateUser{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Number of team members.</p>
        /// </summary>
        [JsonProperty("MemberCount")]
        public long? MemberCount{ get; set; }

        /// <summary>
        /// <p>Number of bound mini program teams.</p>
        /// </summary>
        [JsonProperty("BindMiniTeamCount")]
        public long? BindMiniTeamCount{ get; set; }

        /// <summary>
        /// <p>Team name.</p>
        /// </summary>
        [JsonProperty("BindTeamName")]
        public string BindTeamName{ get; set; }

        /// <summary>
        /// <p>Team registration link.</p>
        /// </summary>
        [JsonProperty("RegisterLink")]
        public string RegisterLink{ get; set; }

        /// <summary>
        /// <p>Superapp name. Only returned for querying details of mini program teams.</p>
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

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
        /// <p>Administrator name.</p>
        /// </summary>
        [JsonProperty("AdminUserName")]
        public string AdminUserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamName", this.TeamName);
            this.SetParamSimple(map, prefix + "TeamRoleType", this.TeamRoleType);
            this.SetParamSimple(map, prefix + "AdminUserAccount", this.AdminUserAccount);
            this.SetParamSimple(map, prefix + "CreateUser", this.CreateUser);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MemberCount", this.MemberCount);
            this.SetParamSimple(map, prefix + "BindMiniTeamCount", this.BindMiniTeamCount);
            this.SetParamSimple(map, prefix + "BindTeamName", this.BindTeamName);
            this.SetParamSimple(map, prefix + "RegisterLink", this.RegisterLink);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AdminUserName", this.AdminUserName);
        }
    }
}

