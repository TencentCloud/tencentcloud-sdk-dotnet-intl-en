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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// User ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Types of returned information. Group: returned information about the working group where the current user is; DataAuth: returned information about the current user's data permission; EngineAuth: returned information about the current user's engine permission
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Types of users. ADMIN: administrators; COMMON: general users
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// User description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserDescription")]
        public string UserDescription{ get; set; }

        /// <summary>
        /// Collection of data permission information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataPolicyInfo")]
        public Policys DataPolicyInfo{ get; set; }

        /// <summary>
        /// Collection of engine permissions
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnginePolicyInfo")]
        public Policys EnginePolicyInfo{ get; set; }

        /// <summary>
        /// Information about collections of working groups bound to the user
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkGroupInfo")]
        public WorkGroups WorkGroupInfo{ get; set; }

        /// <summary>
        /// User alias
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }

        /// <summary>
        /// Collection of filtered rows
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RowFilterInfo")]
        public Policys RowFilterInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "UserDescription", this.UserDescription);
            this.SetParamObj(map, prefix + "DataPolicyInfo.", this.DataPolicyInfo);
            this.SetParamObj(map, prefix + "EnginePolicyInfo.", this.EnginePolicyInfo);
            this.SetParamObj(map, prefix + "WorkGroupInfo.", this.WorkGroupInfo);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
            this.SetParamObj(map, prefix + "RowFilterInfo.", this.RowFilterInfo);
        }
    }
}

