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

    public class ListWorkflowRunsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace ID, which can be obtained through ListWorkspaces. Required.</p>
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
        /// <p>Workflow ID, exact match. Optional, single value</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>Workflow name keyword for fuzzy matching of WorkflowName. Optional, single value</p>
        /// </summary>
        [JsonProperty("WorkflowNameKeyword")]
        public string WorkflowNameKeyword{ get; set; }

        /// <summary>
        /// <p>Lower bound for the running creation time, range match (CreateTime &gt;= this value), unit: timestamp in milliseconds.<br>Optional, single value, corresponding to the output parameter WorkflowRun.CreateTime</p>
        /// </summary>
        [JsonProperty("CreateStartTime")]
        public string CreateStartTime{ get; set; }

        /// <summary>
        /// <p>Upper bound for the running creation time, range match (CreateTime &lt;= this value), unit: timestamp in milliseconds.<br>Optional, single value, corresponding to the output parameter WorkflowRun.CreateTime</p>
        /// </summary>
        [JsonProperty("CreateEndTime")]
        public string CreateEndTime{ get; set; }

        /// <summary>
        /// <p>RUNNING state. Exact matching. Optional. Multiple selection (multiple values are in OR relationship with each other). RUNNING state. CREATE("initialization"), QUEUED("Waiting"), PENDING("preparing"), RUNNING("RUNNING"), SKIPPED("skip RUNNING"), SUCCESS("successful"), FAILED("failure"), TERMINATING("TERMINATING"), TERMINATED("termination"), CANCELLED("manual termination"), etc.</p>
        /// </summary>
        [JsonProperty("RunStates")]
        public string[] RunStates{ get; set; }

        /// <summary>
        /// <p>Error code, exact match. Optional, multiple selection (OR relationship between multiple values)</p>
        /// </summary>
        [JsonProperty("ErrorCodeStrings")]
        public string[] ErrorCodeStrings{ get; set; }

        /// <summary>
        /// <p>Operator UIN, exact match. Optional, multiple selection (OR relationship between multiple values)</p>
        /// </summary>
        [JsonProperty("RunUserUins")]
        public string[] RunUserUins{ get; set; }

        /// <summary>
        /// <p>Tag name ID, exact match, obtainable through tag-related APIs. Optional, multiple selection (multiple values are in an OR relationship with each other)</p>
        /// </summary>
        [JsonProperty("LabelKeyIds")]
        public string[] LabelKeyIds{ get; set; }

        /// <summary>
        /// <p>Tag value ID. Exact match. It can be obtained through the tag-related API. Optional. Multiple selection (multiple values are in OR relationship with each other)</p>
        /// </summary>
        [JsonProperty("LabelValueIds")]
        public string[] LabelValueIds{ get; set; }

        /// <summary>
        /// <p>Sorting conditions. The priority of multiple conditions is indicated by the array order. Optional. Default: CreateTime Desc.<br>Sortable field allowlist: CreateTime, EndTime, RunCostTime</p>
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
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowNameKeyword", this.WorkflowNameKeyword);
            this.SetParamSimple(map, prefix + "CreateStartTime", this.CreateStartTime);
            this.SetParamSimple(map, prefix + "CreateEndTime", this.CreateEndTime);
            this.SetParamArraySimple(map, prefix + "RunStates.", this.RunStates);
            this.SetParamArraySimple(map, prefix + "ErrorCodeStrings.", this.ErrorCodeStrings);
            this.SetParamArraySimple(map, prefix + "RunUserUins.", this.RunUserUins);
            this.SetParamArraySimple(map, prefix + "LabelKeyIds.", this.LabelKeyIds);
            this.SetParamArraySimple(map, prefix + "LabelValueIds.", this.LabelValueIds);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
        }
    }
}

