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

    public class ListWorkflowsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace ID, which can be obtained through ListWorkspaces. Required</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Page number. Value range: starts from 1. Optional. Default value: 1.</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>Size per page. Optional. Default: 10. Value range: [10, 200]</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>Workflow name keyword for fuzzy matching of WorkflowName. Optional, single value</p>
        /// </summary>
        [JsonProperty("WorkflowNameKeyword")]
        public string WorkflowNameKeyword{ get; set; }

        /// <summary>
        /// <p>Workflow name, exact match. Optional, multiple selection (OR relationship between multiple values)</p>
        /// </summary>
        [JsonProperty("WorkflowNames")]
        public string[] WorkflowNames{ get; set; }

        /// <summary>
        /// <p>Workflow ID. Exact match. Optional. Multiple selection (OR relationship between multiple values)</p>
        /// </summary>
        [JsonProperty("WorkflowIds")]
        public string[] WorkflowIds{ get; set; }

        /// <summary>
        /// <p>Workflow runner UIN, exact match. Optional, multiple selection (OR relationship between multiple values)</p>
        /// </summary>
        [JsonProperty("RunUserUins")]
        public string[] RunUserUins{ get; set; }

        /// <summary>
        /// <p>Tag name ID. Exact match. You can obtain it via tag-related APIs. Optional. Multiple selection (multiple values are in an OR relationship with each other)</p>
        /// </summary>
        [JsonProperty("LabelKeyIds")]
        public string[] LabelKeyIds{ get; set; }

        /// <summary>
        /// <p>Tag value ID, exact match, obtainable through the tag-related API. Optional, multiple selection (multiple values are in an OR relationship with each other)</p>
        /// </summary>
        [JsonProperty("LabelValueIds")]
        public string[] LabelValueIds{ get; set; }

        /// <summary>
        /// <p>Quick filter type. Optional, single value</p><p>Align with the legacy Cloud API (wedata/2025-10-10) document example values:</p><ul><li>MY_FAVORITE: collected by me</li><li>MY_OWNER: I am responsible</li><li>MY_AUTHORITY: I have permission</li><li>WorkflowId: support filtering by multiple workflow IDs</li></ul><p>Backend implementation status quo: currently only MY_FAVORITE takes effect (set favoriteUserUin to filter the current user's favorites). MY_OWNER / MY_AUTHORITY are not yet implemented at the Service layer, and the input will be ignored (returned as full results).</p>
        /// </summary>
        [JsonProperty("QuickSelectionType")]
        public string QuickSelectionType{ get; set; }

        /// <summary>
        /// <p>Sorting criteria. The priority of multiple criteria is indicated by their sequence in the array. Optional.<br>Sortable field allowlist: CreateTime</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "WorkflowNameKeyword", this.WorkflowNameKeyword);
            this.SetParamArraySimple(map, prefix + "WorkflowNames.", this.WorkflowNames);
            this.SetParamArraySimple(map, prefix + "WorkflowIds.", this.WorkflowIds);
            this.SetParamArraySimple(map, prefix + "RunUserUins.", this.RunUserUins);
            this.SetParamArraySimple(map, prefix + "LabelKeyIds.", this.LabelKeyIds);
            this.SetParamArraySimple(map, prefix + "LabelValueIds.", this.LabelValueIds);
            this.SetParamSimple(map, prefix + "QuickSelectionType", this.QuickSelectionType);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
        }
    }
}

