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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUserRequest : AbstractModel
    {
        
        /// <summary>
        /// Sub-user UIN that needs to be granted permissions. It can be checked through the upper right corner of Tencent Cloud Console → Account Information → Account ID.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// User description, which can make it easy to identify different users.
        /// </summary>
        [JsonProperty("UserDescription")]
        public string UserDescription{ get; set; }

        /// <summary>
        /// Collections of permissions bound to users
        /// </summary>
        [JsonProperty("PolicySet")]
        public Policy[] PolicySet{ get; set; }

        /// <summary>
        /// Types of users. ADMIN: administrators; COMMON: general users. When the type of user is administrator, the collections of permissions and bound working groups cannot be set. Administrators own all the permissions by default. If the parameter is not filled in, it will be COMMON by default.
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// Collection of IDs of working groups bound to users
        /// </summary>
        [JsonProperty("WorkGroupIds")]
        public long?[] WorkGroupIds{ get; set; }

        /// <summary>
        /// User alias, and its characters are less than 50.
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserDescription", this.UserDescription);
            this.SetParamArrayObj(map, prefix + "PolicySet.", this.PolicySet);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamArraySimple(map, prefix + "WorkGroupIds.", this.WorkGroupIds);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
        }
    }
}

