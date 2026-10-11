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

    public class UpdateConsoleGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>User group ID, which can be obtained through the ListConsoleGroups API</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>Modification Flag: USER_GROUP_OPER_TYPE_ADD_USER(1)=add member, USER_GROUP_OPER_TYPE_DELETE_USER(2)=delete member, USER_GROUP_OPER_TYPE_BASIC_INFO(3)=basic information (alias and description)</p>
        /// </summary>
        [JsonProperty("OperType")]
        public long? OperType{ get; set; }

        /// <summary>
        /// <p>User group name</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>User group alias.</p>
        /// </summary>
        [JsonProperty("GroupNickname")]
        public string GroupNickname{ get; set; }

        /// <summary>
        /// <p>User group description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Member UIN list (used when OperType is add/delete member), up to 100 at a time</p>
        /// </summary>
        [JsonProperty("UserUins")]
        public string[] UserUins{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "OperType", this.OperType);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupNickname", this.GroupNickname);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "UserUins.", this.UserUins);
        }
    }
}

