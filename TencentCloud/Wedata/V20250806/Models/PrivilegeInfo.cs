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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PrivilegeInfo : AbstractModel
    {
        
        /// <summary>
        /// Permission name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Display name of the permission.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// Permission description.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Whether read permission.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsRead")]
        public bool? IsRead{ get; set; }

        /// <summary>
        /// Whether it is a management permission.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsManage")]
        public bool? IsManage{ get; set; }

        /// <summary>
        /// Checks whether the permission is available. used when checking permissions.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Granted")]
        public bool? Granted{ get; set; }

        /// <summary>
        /// Specifies the resource it inherits from. used when querying permission details.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InheritedObject")]
        public PrivilegeResource InheritedObject{ get; set; }

        /// <summary>
        /// Not inheritable, used when querying permission details.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Inherited")]
        public bool? Inherited{ get; set; }

        /// <summary>
        /// Whether edit permission.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsEdit")]
        public bool? IsEdit{ get; set; }

        /// <summary>
        /// Whether metadata permissions (displayed on the front-end).
        /// </summary>
        [JsonProperty("IsMetaDataPermission")]
        public bool? IsMetaDataPermission{ get; set; }

        /// <summary>
        /// CatalogID (deprecated).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CatalogID")]
        public string CatalogID{ get; set; }

        /// <summary>
        /// catalog name (deprecated).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// Space ID (deprecated).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkSpaceID")]
        public string WorkSpaceID{ get; set; }

        /// <summary>
        /// Space name (deprecated).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkSpaceName")]
        public string WorkSpaceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsRead", this.IsRead);
            this.SetParamSimple(map, prefix + "IsManage", this.IsManage);
            this.SetParamSimple(map, prefix + "Granted", this.Granted);
            this.SetParamObj(map, prefix + "InheritedObject.", this.InheritedObject);
            this.SetParamSimple(map, prefix + "Inherited", this.Inherited);
            this.SetParamSimple(map, prefix + "IsEdit", this.IsEdit);
            this.SetParamSimple(map, prefix + "IsMetaDataPermission", this.IsMetaDataPermission);
            this.SetParamSimple(map, prefix + "CatalogID", this.CatalogID);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "WorkSpaceID", this.WorkSpaceID);
            this.SetParamSimple(map, prefix + "WorkSpaceName", this.WorkSpaceName);
        }
    }
}

