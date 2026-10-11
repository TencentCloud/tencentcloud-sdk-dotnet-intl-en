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

    public class InnerWorkflowTaskRun : AbstractModel
    {
        
        /// <summary>
        /// Current page
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// Page Size
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Total number of records
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Total pages
        /// </summary>
        [JsonProperty("TotalPageNumber")]
        public long? TotalPageNumber{ get; set; }

        /// <summary>
        /// Iteration run list
        /// </summary>
        [JsonProperty("Items")]
        public InnerWorkflowTaskRunIteration[] Items{ get; set; }

        /// <summary>
        /// Number of iterations.
        /// </summary>
        [JsonProperty("IterationCount")]
        public long? IterationCount{ get; set; }

        /// <summary>
        /// Number of failures
        /// </summary>
        [JsonProperty("FailureCount")]
        public long? FailureCount{ get; set; }

        /// <summary>
        /// Number of successes
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// Built-in workflow ID, which can be obtained through ListWorkflows
        /// </summary>
        [JsonProperty("InnerWorkflowId")]
        public string InnerWorkflowId{ get; set; }

        /// <summary>
        /// Built-in task ID, which can be obtained through ListWorkflowTasks.
        /// </summary>
        [JsonProperty("InnerTaskId")]
        public string InnerTaskId{ get; set; }

        /// <summary>
        /// Statistics on the number of built-in task running statuses (list of key-value pairs for instance business enums)
        /// </summary>
        [JsonProperty("InnerTaskRunBizEnumInfos")]
        public ScheduleBizEnumBrief[] InnerTaskRunBizEnumInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "TotalPageNumber", this.TotalPageNumber);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "IterationCount", this.IterationCount);
            this.SetParamSimple(map, prefix + "FailureCount", this.FailureCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "InnerWorkflowId", this.InnerWorkflowId);
            this.SetParamSimple(map, prefix + "InnerTaskId", this.InnerTaskId);
            this.SetParamArrayObj(map, prefix + "InnerTaskRunBizEnumInfos.", this.InnerTaskRunBizEnumInfos);
        }
    }
}

