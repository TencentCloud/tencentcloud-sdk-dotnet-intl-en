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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserRoleProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// User ID.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Role ID list.
        /// </summary>
        [JsonProperty("RoleIdList")]
        public long?[] RoleIdList{ get; set; }

        /// <summary>
        /// Mailbox.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// WeCom app user ID.
        /// </summary>
        [JsonProperty("AppUserId")]
        public string AppUserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArraySimple(map, prefix + "RoleIdList.", this.RoleIdList);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "AppUserId", this.AppUserId);
        }
    }
}

