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

    public class WorkflowTaskNodeBrief : AbstractModel
    {
        
        /// <summary>
        /// <p>Workflow ID</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Task name.</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Task Type Name. For details, see the TaskTypeName field description in the data structure TaskType.</p>
        /// </summary>
        [JsonProperty("TaskTypeName")]
        public string TaskTypeName{ get; set; }

        /// <summary>
        /// <p>Task dependency list.</p>
        /// </summary>
        [JsonProperty("DependOnList")]
        public DependOnBrief[] DependOnList{ get; set; }

        /// <summary>
        /// <p>Task resource group ID.</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>Task resource group name.</p>
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// <p>Task X coordinate</p>
        /// </summary>
        [JsonProperty("LeftCoordinate")]
        public float? LeftCoordinate{ get; set; }

        /// <summary>
        /// <p>Task Y-axis coordinate</p>
        /// </summary>
        [JsonProperty("TopCoordinate")]
        public float? TopCoordinate{ get; set; }

        /// <summary>
        /// <p>Task retry policy</p>
        /// </summary>
        [JsonProperty("TaskRetryStrategy")]
        public TaskRetryStrategy TaskRetryStrategy{ get; set; }

        /// <summary>
        /// <p>Task dependency run conditions</p><p>ALL_SUCCESS: All successful: All upstream dependency tasks have been executed and succeeded<br>ONE_SUCCESS: At least one successful: At least one upstream dependency task succeeded<br>NONE_FAILED: No failure currently: No dependency task failed, and at least one dependency task is running<br>ALL_DONE: All completed: All upstream dependency tasks have been executed and completed (regardless of success or failure)<br>ONE_FAILED: At least one failed: At least one upstream dependency task failed<br>ALL_FAILED: All failed: All upstream dependency tasks failed<br>ALL_DONE_AT_LEAST_ONE_SUCCESS: All upstream completed and at least one successful: When all upstream dependency tasks reach a final state, a dependency check is performed. If at least one succeeded, the dependency check passes; otherwise, the run is skipped<br>ALL_SKIPPED: All upstream completed, no skipped run: When all upstream dependency tasks reach a final state, a dependency check is performed. If all upstream states are successful, failed, or upstream failed state, the dependency check passes; otherwise, the run is skipped<br>ONE_DONE: At least one completed: Once at least one upstream task is completed, a dependency check is performed, and the dependency check passes; otherwise, it keeps waiting for upstream<br>ALL_DONE_NONE_FAILED_AT_LEAST_ONE_SUCCESS: All upstream completed, none failed, at least one successful: When all upstream dependency tasks reach a final state, a dependency check is performed. If no upstream task failed and at least one succeeded, the dependency check passes; otherwise, the run is skipped<br>NONE_SKIPPED: All upstream completed, no skipped run: When all upstream dependency tasks reach a final state, a dependency check is performed. If all upstream states are successful, failed, or upstream failed state, the dependency check passes; otherwise, the run is skipped<br>ALL_DONE_AT_LEAST_ONE_FAILED: All upstream completed and at least one failed: When all upstream dependency tasks reach a final state, a dependency check is performed. If at least one failed, the dependency check passes; otherwise, the run is skipped<br>ADVANCED: Configured when the run condition is in advanced mode</p>
        /// </summary>
        [JsonProperty("DependOnRunCondition")]
        public string DependOnRunCondition{ get; set; }

        /// <summary>
        /// <p>Advanced dependency configuration</p>
        /// </summary>
        [JsonProperty("AdvancedDependencyConfig")]
        public AdvancedDependencyConfig AdvancedDependencyConfig{ get; set; }

        /// <summary>
        /// <p>Built-in workflow task node</p>
        /// </summary>
        [JsonProperty("InnerTask")]
        public WorkflowTaskNodeBrief InnerTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskTypeName", this.TaskTypeName);
            this.SetParamArrayObj(map, prefix + "DependOnList.", this.DependOnList);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamSimple(map, prefix + "LeftCoordinate", this.LeftCoordinate);
            this.SetParamSimple(map, prefix + "TopCoordinate", this.TopCoordinate);
            this.SetParamObj(map, prefix + "TaskRetryStrategy.", this.TaskRetryStrategy);
            this.SetParamSimple(map, prefix + "DependOnRunCondition", this.DependOnRunCondition);
            this.SetParamObj(map, prefix + "AdvancedDependencyConfig.", this.AdvancedDependencyConfig);
            this.SetParamObj(map, prefix + "InnerTask.", this.InnerTask);
        }
    }
}

