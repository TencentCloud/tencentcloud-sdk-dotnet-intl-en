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

    public class ListWorkspacesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace ID exact match</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Fuzzy matching by workspace name</p>
        /// </summary>
        [JsonProperty("WorkspaceKeyword")]
        public string WorkspaceKeyword{ get; set; }

        /// <summary>
        /// <p>Workspace status filtering (multiple selection): 0=not specified 1=creating 2=creation failure 3=operating normally 4=deleted</p>
        /// </summary>
        [JsonProperty("StatusList")]
        public long?[] StatusList{ get; set; }

        /// <summary>
        /// <p>Multi-field sorting, for example, [{Name: 'CreateTime', Direction: 'Desc'}]; import one for single-field sorting. Default: in descending order by creation time.</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }

        /// <summary>
        /// <p>Page number. Value range: starts from 1. Default value: 1.</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>Size per page. Default: 10. Minimum: 10. Maximum: 100</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>Workspace region filtering (multiple selection), for example, ap-guangzhou</p>
        /// </summary>
        [JsonProperty("WorkspaceRegion")]
        public string[] WorkspaceRegion{ get; set; }

        /// <summary>
        /// <p>Creator UIN filter (multi-option)</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string[] Creator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkspaceKeyword", this.WorkspaceKeyword);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "WorkspaceRegion.", this.WorkspaceRegion);
            this.SetParamArraySimple(map, prefix + "Creator.", this.Creator);
        }
    }
}

