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

    public class ListWorkspaceGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Batch query by user group ID; user group ID can be obtained through the ListWorkspaceGroups API</p>
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// <p>Fuzzy matching by user group name</p>
        /// </summary>
        [JsonProperty("GroupKeyword")]
        public string GroupKeyword{ get; set; }

        /// <summary>
        /// <p>Used to filter user groups associated with roles; can be obtained through the ListWorkspaceRoles API</p>
        /// </summary>
        [JsonProperty("RoleIds")]
        public string[] RoleIds{ get; set; }

        /// <summary>
        /// <p>Multi-field sorting, for example, [{Name: 'CreateTime', Direction: 'Desc'}]; import one for single-field sorting. By default, sort in descending order by creation time.</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }

        /// <summary>
        /// <p>Page number. Value range: starts from 1. Default value: 1. Values less than 1 are handled as 1.</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>Size per page. Default: 10. Value range: [1,100]. Out-of-bounds values automatically converge to the boundary value.</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>User group type filter criteria. The value is a string form of an enumerated numeric value: "0" = console system type (including all users), "1" = console custom type, "2" = workspace system type (including all workspace users), "3" = workspace custom type.</p>
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "GroupKeyword", this.GroupKeyword);
            this.SetParamArraySimple(map, prefix + "RoleIds.", this.RoleIds);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
        }
    }
}

