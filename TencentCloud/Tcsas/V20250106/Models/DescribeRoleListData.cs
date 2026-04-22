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

    public class DescribeRoleListData : AbstractModel
    {
        
        /// <summary>
        /// Role ID
        /// </summary>
        [JsonProperty("RoleId")]
        public long? RoleId{ get; set; }

        /// <summary>
        /// Role name.
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// Team name
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Role type 1-preset role 2-custom role.
        /// </summary>
        [JsonProperty("RoleType")]
        public long? RoleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "TeamName", this.TeamName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RoleType", this.RoleType);
        }
    }
}

