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

    public class WorkflowTaskRun : AbstractModel
    {
        
        /// <summary>
        /// <p>Task name.</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Task running ID</p>
        /// </summary>
        [JsonProperty("WorkflowTaskRunId")]
        public string WorkflowTaskRunId{ get; set; }

        /// <summary>
        /// <p>Running state, for example, CREATE("initialize"), QUEUED("Waiting"), PENDING("preparing"), RUNNING("running"), SKIPPED("skip running"), SUCCESS("success"), FAILED("failure"), TERMINATING("terminating"), TERMINATED("termination"), CANCELLED("manual termination")</p>
        /// </summary>
        [JsonProperty("RunState")]
        public string RunState{ get; set; }

        /// <summary>
        /// <p>Workspace ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Workflow ID</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>Workflow running ID</p>
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Task Type Name. For details, see the description of the TaskTypeName field in the TaskType data structure.</p>
        /// </summary>
        [JsonProperty("TaskTypeName")]
        public string TaskTypeName{ get; set; }

        /// <summary>
        /// <p>Task version ID.</p>
        /// </summary>
        [JsonProperty("TaskVersionId")]
        public string TaskVersionId{ get; set; }

        /// <summary>
        /// <p>Trigger type</p><p>Enumeration values:</p><ul><li>Manual: manual triggering</li><li>Scheduler: scheduling trigger</li></ul>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>Associated resource group ID</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>Error code</p>
        /// </summary>
        [JsonProperty("ErrorCodeString")]
        public string ErrorCodeString{ get; set; }

        /// <summary>
        /// <p>Running user UIN</p>
        /// </summary>
        [JsonProperty("RunUserUin")]
        public string RunUserUin{ get; set; }

        /// <summary>
        /// <p>Username for operation</p>
        /// </summary>
        [JsonProperty("RunUserName")]
        public string RunUserName{ get; set; }

        /// <summary>
        /// <p>Creator UIN</p>
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// <p>Execution platform execution ID</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>Creation time. Unit: millisecond timestamp</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Last update time. Unit: timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Dependency task completion time, unit: timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("DependenceFinishedTime")]
        public string DependenceFinishedTime{ get; set; }

        /// <summary>
        /// <p>Start time in milliseconds.</p>
        /// </summary>
        [JsonProperty("RunStartTime")]
        public string RunStartTime{ get; set; }

        /// <summary>
        /// <p>Running end time, unit: timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("RunEndTime")]
        public string RunEndTime{ get; set; }

        /// <summary>
        /// <p>Running time, unit: seconds</p>
        /// </summary>
        [JsonProperty("RunCostTime")]
        public string RunCostTime{ get; set; }

        /// <summary>
        /// <p>Waiting duration (waiting duration from dependency readiness to start), unit: second</p>
        /// </summary>
        [JsonProperty("WaitTime")]
        public string WaitTime{ get; set; }

        /// <summary>
        /// <p>Execution platform time, unit: timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("IssueTime")]
        public string IssueTime{ get; set; }

        /// <summary>
        /// <p>Time zone</p>
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// <p>Task ID list that it depends on. Reserved field, temporarily returns []</p><p>Reserved field, temporarily returns []</p>
        /// </summary>
        [JsonProperty("DependOnList")]
        public string[] DependOnList{ get; set; }

        /// <summary>
        /// <p>Running parameter</p>
        /// </summary>
        [JsonProperty("RunParams")]
        public string RunParams{ get; set; }

        /// <summary>
        /// <p>Task extension information, including script path</p>
        /// </summary>
        [JsonProperty("TaskTypeExtensions")]
        public string TaskTypeExtensions{ get; set; }

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
        /// <p>Number of retries. 0 indicates the first run.</p>
        /// </summary>
        [JsonProperty("RetryTimes")]
        public long? RetryTimes{ get; set; }

        /// <summary>
        /// <p>Workflow name</p>
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// <p>Number of reruns.</p>
        /// </summary>
        [JsonProperty("RerunTimes")]
        public long? RerunTimes{ get; set; }

        /// <summary>
        /// <p>Whether it is the most recent run</p>
        /// </summary>
        [JsonProperty("IsLatestRun")]
        public bool? IsLatestRun{ get; set; }

        /// <summary>
        /// <p>Resource group information list.</p>
        /// </summary>
        [JsonProperty("ResourceGroupInfoList")]
        public ResourceGroupInfo[] ResourceGroupInfoList{ get; set; }

        /// <summary>
        /// <p>Execution result</p>
        /// </summary>
        [JsonProperty("RunResult")]
        public string RunResult{ get; set; }

        /// <summary>
        /// <p>Task dependency run conditions</p><p>ALL_SUCCESS: All successful: All upstream dependency tasks have been executed and succeeded<br>ONE_SUCCESS: At least one successful: At least one upstream dependency task succeeded<br>NONE_FAILED: No failure currently: No dependency task failed, and at least one dependency task is running<br>ALL_DONE: All completed: All upstream dependency tasks have been executed and completed (regardless of success or failure)<br>ONE_FAILED: At least one failed: At least one upstream dependency task failed<br>ALL_FAILED: All failed: All upstream dependency tasks failed<br>ALL_DONE_AT_LEAST_ONE_SUCCESS: All upstream completed and at least one successful: When all upstream dependency tasks reach a final state, a dependency check is performed. If at least one succeeded, the dependency check passes; otherwise, the run is skipped<br>ALL_SKIPPED: All upstream completed, no skipped runs: When all upstream dependency tasks reach a final state, a dependency check is performed. If all upstream states are success, failure, or upstream failed state, the dependency check passes; otherwise, the run is skipped<br>ONE_DONE: At least one completed: Once any upstream task is completed, a dependency check is performed, and the dependency check passes; otherwise, it keeps waiting for upstream<br>ALL_DONE_NONE_FAILED_AT_LEAST_ONE_SUCCESS: All upstream completed, none failed, at least one successful: When all upstream dependency tasks reach a final state, a dependency check is performed. If no upstream task failed and at least one succeeded, the dependency check passes; otherwise, the run is skipped<br>NONE_SKIPPED: All upstream completed, no skipped runs: When all upstream dependency tasks reach a final state, a dependency check is performed. If all upstream states are success, failure, or upstream failed state, the dependency check passes; otherwise, the run is skipped<br>ALL_DONE_AT_LEAST_ONE_FAILED: All upstream completed and at least one failed: When all upstream dependency tasks reach a final state, a dependency check is performed. If at least one failed, the dependency check passes; otherwise, the run is skipped<br>ADVANCED: Configured when the run condition is in advanced mode</p>
        /// </summary>
        [JsonProperty("DependOnRunCondition")]
        public string DependOnRunCondition{ get; set; }

        /// <summary>
        /// <p>Advanced dependency configuration</p>
        /// </summary>
        [JsonProperty("AdvancedDependencyConfig")]
        public AdvancedDependencyConfig AdvancedDependencyConfig{ get; set; }

        /// <summary>
        /// <p>Built-in workflow task information</p>
        /// </summary>
        [JsonProperty("InnerTask")]
        public InnerWorkflowTaskBrief InnerTask{ get; set; }

        /// <summary>
        /// <p>Scheduled dispatch time</p><p>Parameter format: timestamp in milliseconds, UTC</p>
        /// </summary>
        [JsonProperty("ScheduledTime")]
        public string ScheduledTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "WorkflowTaskRunId", this.WorkflowTaskRunId);
            this.SetParamSimple(map, prefix + "RunState", this.RunState);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskTypeName", this.TaskTypeName);
            this.SetParamSimple(map, prefix + "TaskVersionId", this.TaskVersionId);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ErrorCodeString", this.ErrorCodeString);
            this.SetParamSimple(map, prefix + "RunUserUin", this.RunUserUin);
            this.SetParamSimple(map, prefix + "RunUserName", this.RunUserName);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DependenceFinishedTime", this.DependenceFinishedTime);
            this.SetParamSimple(map, prefix + "RunStartTime", this.RunStartTime);
            this.SetParamSimple(map, prefix + "RunEndTime", this.RunEndTime);
            this.SetParamSimple(map, prefix + "RunCostTime", this.RunCostTime);
            this.SetParamSimple(map, prefix + "WaitTime", this.WaitTime);
            this.SetParamSimple(map, prefix + "IssueTime", this.IssueTime);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArraySimple(map, prefix + "DependOnList.", this.DependOnList);
            this.SetParamSimple(map, prefix + "RunParams", this.RunParams);
            this.SetParamSimple(map, prefix + "TaskTypeExtensions", this.TaskTypeExtensions);
            this.SetParamSimple(map, prefix + "LeftCoordinate", this.LeftCoordinate);
            this.SetParamSimple(map, prefix + "TopCoordinate", this.TopCoordinate);
            this.SetParamSimple(map, prefix + "RetryTimes", this.RetryTimes);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "RerunTimes", this.RerunTimes);
            this.SetParamSimple(map, prefix + "IsLatestRun", this.IsLatestRun);
            this.SetParamArrayObj(map, prefix + "ResourceGroupInfoList.", this.ResourceGroupInfoList);
            this.SetParamSimple(map, prefix + "RunResult", this.RunResult);
            this.SetParamSimple(map, prefix + "DependOnRunCondition", this.DependOnRunCondition);
            this.SetParamObj(map, prefix + "AdvancedDependencyConfig.", this.AdvancedDependencyConfig);
            this.SetParamObj(map, prefix + "InnerTask.", this.InnerTask);
            this.SetParamSimple(map, prefix + "ScheduledTime", this.ScheduledTime);
        }
    }
}

