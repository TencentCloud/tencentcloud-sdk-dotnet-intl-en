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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaseRole : AbstractModel
    {
        
        /// <summary>
        /// Role id.
        /// </summary>
        [JsonProperty("RoleId")]
        public string RoleId{ get; set; }

        /// <summary>
        /// Role name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// Role nickname.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// Description
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Role type divides into System, Tenant, Project, Commercial.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoleType")]
        public string RoleType{ get; set; }

        /// <summary>
        /// System preset.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SystemDefault")]
        public bool? SystemDefault{ get; set; }

        /// <summary>
        /// Custom parameter.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// Specifies member statistics.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemberCount")]
        public long? MemberCount{ get; set; }

        /// <summary>
        /// Permission
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Privileges")]
        public RolePrivilege[] Privileges{ get; set; }

        /// <summary>
        /// Operator.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Operator")]
        public BaseUser Operator{ get; set; }

        /// <summary>
        /// Operation time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OperateTime")]
        public ulong? OperateTime{ get; set; }

        /// <summary>
        /// Creation time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Creation time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTimeStr")]
        public string CreateTimeStr{ get; set; }

        /// <summary>
        /// Update time.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTimeStr")]
        public string UpdateTimeStr{ get; set; }

        /// <summary>
        /// Project ID
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Update time.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Creator
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RoleType", this.RoleType);
            this.SetParamSimple(map, prefix + "SystemDefault", this.SystemDefault);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamSimple(map, prefix + "MemberCount", this.MemberCount);
            this.SetParamArrayObj(map, prefix + "Privileges.", this.Privileges);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "OperateTime", this.OperateTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CreateTimeStr", this.CreateTimeStr);
            this.SetParamSimple(map, prefix + "UpdateTimeStr", this.UpdateTimeStr);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
        }
    }
}

