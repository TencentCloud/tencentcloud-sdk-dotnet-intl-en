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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// User information list.
        /// </summary>
        [JsonProperty("Users")]
        public string[] Users{ get; set; }

        /// <summary>
        /// User primary group. The CVM cluster is a required parameter, while the TKE cluster is optional.
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// User subgroup.
        /// </summary>
        [JsonProperty("Groups")]
        public string[] Groups{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Users.", this.Users);
            this.SetParamSimple(map, prefix + "UserGroup", this.UserGroup);
            this.SetParamArraySimple(map, prefix + "Groups.", this.Groups);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

