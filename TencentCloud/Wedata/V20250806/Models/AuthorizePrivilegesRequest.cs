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

    public class AuthorizePrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// Resource array.
        /// ResourceType: originates from the ResourceType returned by the GetGrantPrivilegesSTD API in the TCCATALOG module, and change to capitalize the first letter, such as METALAKE corresponding to METALAKE.
        /// ResourceUri depends on ResourceType. fixed as default for Metalake. use the three-segment format of catalog for other categories, such as.
        /// -Metalake, fixed as default.
        /// -Catalog. specifies the catalogName.
        /// -Schema. valid values: catalogName.SchemaName.
        /// -Table, in the format of catalogName.SchemaName.TableName.
        /// </summary>
        [JsonProperty("Resources")]
        public PrivilegeResource[] Resources{ get; set; }

        /// <summary>
        /// Authorization entity array. specifies the SubjectType and corresponding SubjectValue value rules.
        /// -User.
        /// -User id obtained from DescribeTenantUserList.
        /// -Project.
        /// -ProjectId from the DescribeUserProjects request parameters structure.
        /// -Role (project-level role).
        /// -First call DescribeUserProjects to obtain the project ID (ProjectId), then call DescribeRoleList to get the role ID (RoleId), and combine them as $ProjectId.$ProjectId.RoleId, for example "3085649716411588608.308335260274237440".
        /// -GlobalRole (platform-level role).
        /// -AllAccountUsers all users.
        /// -Another ID, taken from RoleId in DescribeTenantRole.
        /// </summary>
        [JsonProperty("Subjects")]
        public Subject[] Subjects{ get; set; }

        /// <summary>
        /// Permission point, comes from the NAME in various Privileges returned by the GetGrantPrivilegesSTD API in the TCCATALOG module.
        /// </summary>
        [JsonProperty("Privileges")]
        public PrivilegeInfo[] Privileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamArrayObj(map, prefix + "Subjects.", this.Subjects);
            this.SetParamArrayObj(map, prefix + "Privileges.", this.Privileges);
        }
    }
}

