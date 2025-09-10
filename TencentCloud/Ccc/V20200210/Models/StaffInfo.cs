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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StaffInfo : AbstractModel
    {
        
        /// <summary>
        /// Agent name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Agent email.
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }

        /// <summary>
        /// Agent phone number.
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// Agent nickname.
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// Agent id.
        /// </summary>
        [JsonProperty("StaffNumber")]
        public string StaffNumber{ get; set; }

        /// <summary>
        /// User role ID. if a user is bound to multiple roles, RoleIdList takes precedence.
        /// </summary>
        [JsonProperty("RoleId")]
        [System.Obsolete]
        public ulong? RoleId{ get; set; }

        /// <summary>
        /// User role id list.
        /// </summary>
        [JsonProperty("RoleIdList")]
        [System.Obsolete]
        public ulong? RoleIdList{ get; set; }

        /// <summary>
        /// Specifies the user role id list.
        /// </summary>
        [JsonProperty("RoleList")]
        public ulong?[] RoleList{ get; set; }

        /// <summary>
        /// Affiliated skill group list.
        /// </summary>
        [JsonProperty("SkillGroupList")]
        public SkillGroupItem[] SkillGroupList{ get; set; }

        /// <summary>
        /// Last modification time.
        /// </summary>
        [JsonProperty("LastModifyTimestamp")]
        public long? LastModifyTimestamp{ get; set; }

        /// <summary>
        /// Agent extension number (starting with 1 to 8, 4 - 6 digits).
        /// </summary>
        [JsonProperty("ExtensionNumber")]
        public string ExtensionNumber{ get; set; }

        /// <summary>
        /// Call forwarding configuration.
        /// </summary>
        [JsonProperty("ForwardingConfig")]
        public ForwardingConfig ForwardingConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "StaffNumber", this.StaffNumber);
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "RoleIdList", this.RoleIdList);
            this.SetParamArraySimple(map, prefix + "RoleList.", this.RoleList);
            this.SetParamArrayObj(map, prefix + "SkillGroupList.", this.SkillGroupList);
            this.SetParamSimple(map, prefix + "LastModifyTimestamp", this.LastModifyTimestamp);
            this.SetParamSimple(map, prefix + "ExtensionNumber", this.ExtensionNumber);
            this.SetParamObj(map, prefix + "ForwardingConfig.", this.ForwardingConfig);
        }
    }
}

