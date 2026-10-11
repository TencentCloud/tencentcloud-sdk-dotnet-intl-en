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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkspaceUserInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>User UIN.</p>
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// <p>Username.</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>Nickname</p>
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// <p>List of characters.</p>
        /// </summary>
        [JsonProperty("Roles")]
        public RoleBasicInfo[] Roles{ get; set; }

        /// <summary>
        /// <p>User source. group: user group, user: user</p>
        /// </summary>
        [JsonProperty("UserSource")]
        public string UserSource{ get; set; }

        /// <summary>
        /// <p>Creation time. Millisecond timestamp</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Update time. Millisecond timestamp</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Root account or not</p>
        /// </summary>
        [JsonProperty("IsOwner")]
        public bool? IsOwner{ get; set; }

        /// <summary>
        /// <p>0: general user 1: entraId user</p>
        /// </summary>
        [JsonProperty("UserTag")]
        public long? UserTag{ get; set; }

        /// <summary>
        /// <p>Whether the sub-account has admin permission</p>
        /// </summary>
        [JsonProperty("IsAdmin")]
        public bool? IsAdmin{ get; set; }

        /// <summary>
        /// <p>Tags after merge (directly bound to user + inherited from user group)</p>
        /// </summary>
        [JsonProperty("Tags")]
        public UserTagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamArrayObj(map, prefix + "Roles.", this.Roles);
            this.SetParamSimple(map, prefix + "UserSource", this.UserSource);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsOwner", this.IsOwner);
            this.SetParamSimple(map, prefix + "UserTag", this.UserTag);
            this.SetParamSimple(map, prefix + "IsAdmin", this.IsAdmin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

