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

namespace TencentCloud.Tcmpp.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTeamRequest : AbstractModel
    {
        
        /// <summary>
        /// Team name
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }

        /// <summary>
        /// Administrator name
        /// </summary>
        [JsonProperty("AdminUserId")]
        public string AdminUserId{ get; set; }

        /// <summary>
        /// Permission assigned to the team. 1: Mini program; 2: Application (only one of these types is supported)
        /// </summary>
        [JsonProperty("TeamRoleTypeList")]
        public long?[] TeamRoleTypeList{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Platform ID, required for API call
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// Associated team ID
        /// </summary>
        [JsonProperty("RelatedTeamId")]
        public string RelatedTeamId{ get; set; }


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
        }
    }
}

