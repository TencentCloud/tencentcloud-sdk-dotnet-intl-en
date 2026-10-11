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

    public class ListWorkspaceUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Fuzzy matching between username or UIN</p>
        /// </summary>
        [JsonProperty("UserKeyword")]
        public string UserKeyword{ get; set; }

        /// <summary>
        /// <p>Role ID list, filter users associated with roles; can be obtained through the ListWorkspaceRoles API</p>
        /// </summary>
        [JsonProperty("RoleIds")]
        public string[] RoleIds{ get; set; }

        /// <summary>
        /// <p>User UIN list, precise filtering by UIN</p>
        /// </summary>
        [JsonProperty("UserUins")]
        public string[] UserUins{ get; set; }

        /// <summary>
        /// <p>Sorting field list, for example, [{Name: CreateTime, Direction: DESC}]; import one for single-field sorting. By default, sort in descending order by creation time.</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }

        /// <summary>
        /// <p>Page number. Default value: 1. Value range: starts from 1. Values less than 1 are handled as 1.</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>Entries per page. Default: 10. Value range: [1,100]. Out-of-bounds values automatically converge to the boundary value.</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>Extended information (empty for the first request; for pagination requests, carry the ExtendInfo from the response. Used for locating the next offset in scenarios such as consecutive pagination and item permission filtering)</p>
        /// </summary>
        [JsonProperty("ExtendInfo")]
        public string ExtendInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "UserKeyword", this.UserKeyword);
            this.SetParamArraySimple(map, prefix + "RoleIds.", this.RoleIds);
            this.SetParamArraySimple(map, prefix + "UserUins.", this.UserUins);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ExtendInfo", this.ExtendInfo);
        }
    }
}

