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

    public class CreateTeamRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Team name.</p>
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }

        /// <summary>
        /// <p>Administrator name.</p>
        /// </summary>
        [JsonProperty("AdminUserId")]
        public string AdminUserId{ get; set; }

        /// <summary>
        /// <p>Team role type. Valid values: 1: Mini program; 2: Superapp (only one type is currently supported).</p>
        /// </summary>
        [JsonProperty("TeamRoleTypeList")]
        public long?[] TeamRoleTypeList{ get; set; }

        /// <summary>
        /// <p>Remarks.</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Platform ID, required for API call.</p>
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// <p>Associated team ID.</p>
        /// </summary>
        [JsonProperty("RelatedTeamId")]
        public string RelatedTeamId{ get; set; }

        /// <summary>
        /// <p>Team expiration time as a Unix timestamp in seconds. 0 indicates no expiration. This parameter takes effect only when creating a mini program team.</p>
        /// </summary>
        [JsonProperty("ExpiryTime")]
        public long? ExpiryTime{ get; set; }

        /// <summary>
        /// <p>Administrator user IDs.</p>
        /// </summary>
        [JsonProperty("AdminUserIds")]
        public string[] AdminUserIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamName", this.TeamName);
            this.SetParamSimple(map, prefix + "AdminUserId", this.AdminUserId);
            this.SetParamArraySimple(map, prefix + "TeamRoleTypeList.", this.TeamRoleTypeList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "RelatedTeamId", this.RelatedTeamId);
            this.SetParamSimple(map, prefix + "ExpiryTime", this.ExpiryTime);
            this.SetParamArraySimple(map, prefix + "AdminUserIds.", this.AdminUserIds);
        }
    }
}

