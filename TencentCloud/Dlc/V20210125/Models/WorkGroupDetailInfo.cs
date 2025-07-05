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

    public class WorkGroupDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// Working group ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkGroupId")]
        public long? WorkGroupId{ get; set; }

        /// <summary>
        /// Working group name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkGroupName")]
        public string WorkGroupName{ get; set; }

        /// <summary>
        /// Types of information included. User: user information; DataAuth: data permissions; EngineAuth: engine permissions
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Collection of users bound to working groups
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserInfo")]
        public Users UserInfo{ get; set; }

        /// <summary>
        /// Collection of data permissions
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
        /// Working group description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkGroupDescription")]
        public string WorkGroupDescription{ get; set; }

        /// <summary>
        /// Collection of information about filtered rows
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RowFilterInfo")]
        public Policys RowFilterInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkGroupId", this.WorkGroupId);
            this.SetParamSimple(map, prefix + "WorkGroupName", this.WorkGroupName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamObj(map, prefix + "DataPolicyInfo.", this.DataPolicyInfo);
            this.SetParamObj(map, prefix + "EnginePolicyInfo.", this.EnginePolicyInfo);
            this.SetParamSimple(map, prefix + "WorkGroupDescription", this.WorkGroupDescription);
            this.SetParamObj(map, prefix + "RowFilterInfo.", this.RowFilterInfo);
        }
    }
}

