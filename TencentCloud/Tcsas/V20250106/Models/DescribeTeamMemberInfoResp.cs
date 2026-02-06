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

    public class DescribeTeamMemberInfoResp : AbstractModel
    {
        
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// User account
        /// </summary>
        [JsonProperty("UserAccount")]
        public string UserAccount{ get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Team ID
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// Team name
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }

        /// <summary>
        /// Specifies the team role name.
        /// </summary>
        [JsonProperty("TeamRoleName")]
        public string TeamRoleName{ get; set; }

        /// <summary>
        /// Specifies the team role ID.
        /// </summary>
        [JsonProperty("TeamRoleId")]
        public long? TeamRoleId{ get; set; }

        /// <summary>
        /// Whether it is editable
        /// </summary>
        [JsonProperty("CanEdit")]
        public bool? CanEdit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserAccount", this.UserAccount);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "TeamName", this.TeamName);
            this.SetParamSimple(map, prefix + "TeamRoleName", this.TeamRoleName);
            this.SetParamSimple(map, prefix + "TeamRoleId", this.TeamRoleId);
            this.SetParamSimple(map, prefix + "CanEdit", this.CanEdit);
        }
    }
}

