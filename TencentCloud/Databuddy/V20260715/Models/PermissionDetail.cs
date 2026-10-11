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

    public class PermissionDetail : AbstractModel
    {
        
        /// <summary>
        /// Permission list of the current user for this entity.
        /// </summary>
        [JsonProperty("Permissions")]
        public string[] Permissions{ get; set; }

        /// <summary>
        /// Permission information of the catalog on the workspace (optional). Value: WORKSPACE_READONLY (read-only) or WORKSPACE_READWRITE (read-write).
        /// </summary>
        [JsonProperty("CatalogWorkspacePrivilege")]
        public string CatalogWorkspacePrivilege{ get; set; }

        /// <summary>
        /// Total deny permission list (user deny ∪ role deny ∪ inherited deny, deduplicated and excluded from Permissions)
        /// </summary>
        [JsonProperty("DenyPrivilegeList")]
        public string[] DenyPrivilegeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Permissions.", this.Permissions);
            this.SetParamSimple(map, prefix + "CatalogWorkspacePrivilege", this.CatalogWorkspacePrivilege);
            this.SetParamArraySimple(map, prefix + "DenyPrivilegeList.", this.DenyPrivilegeList);
        }
    }
}

