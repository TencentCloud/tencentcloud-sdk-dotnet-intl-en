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

    public class ListFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace id</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Parent directory. If left blank, the root node is queried by default.</p>
        /// </summary>
        [JsonProperty("Parent")]
        public FolderLocator Parent{ get; set; }

        /// <summary>
        /// <p>Filter by file type</p>
        /// </summary>
        [JsonProperty("FileTypes")]
        public string[] FileTypes{ get; set; }

        /// <summary>
        /// <p>Fuzzy matching by file name</p>
        /// </summary>
        [JsonProperty("NameKeyword")]
        public string NameKeyword{ get; set; }

        /// <summary>
        /// <p>Filter by owner UIN. Multiple values are OR-related</p>
        /// </summary>
        [JsonProperty("OwnerUserUins")]
        public string[] OwnerUserUins{ get; set; }

        /// <summary>
        /// <p>Whether to list folders only. Default false.</p>
        /// </summary>
        [JsonProperty("OnlyFolder")]
        public bool? OnlyFolder{ get; set; }

        /// <summary>
        /// <p>Sorting field list, for example, creation time [{Name: 'CreateTime', Direction: 'DESC'}], file name [{Name: 'Name', Direction: 'ASC'}]</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }

        /// <summary>
        /// <p>Page number. Default value: 1. Minimum value: 1.</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>Entries per page. Default: 10. Minimum value: 10. Maximum value: 100</p><p>Value range: [10, 100]</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamObj(map, prefix + "Parent.", this.Parent);
            this.SetParamArraySimple(map, prefix + "FileTypes.", this.FileTypes);
            this.SetParamSimple(map, prefix + "NameKeyword", this.NameKeyword);
            this.SetParamArraySimple(map, prefix + "OwnerUserUins.", this.OwnerUserUins);
            this.SetParamSimple(map, prefix + "OnlyFolder", this.OnlyFolder);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

