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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// Specifies the project id.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// **Instance unique id**.
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// Folder ID.
        /// 
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// Specifies the folder name.
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// Workflow ID.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Workflow name.
        /// 
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// Task ID
        /// 
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task name.
        /// 
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Specifies the id corresponding to taskType.
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public long? TaskTypeId{ get; set; }

        /// <summary>
        /// Task type
        /// 
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Task Cycle Type
        /// 
        /// * ONEOFF_CYCLE: One-time
        /// 
        /// * YEAR_CYCLE: Yearly
        /// 
        /// * MONTH_CYCLE: Monthly
        /// 
        /// * WEEK_CYCLE: Weekly
        /// 
        /// * DAY_CYCLE: Daily
        /// 
        /// * HOUR_CYCLE: Hourly
        /// 
        /// * MINUTE_CYCLE: Minute-level
        /// 
        /// * CRONTAB_CYCLE: Crontab expression-based
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// Specifies the instance data time.
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// Instance status.
        /// -WAIT_EVENT: wait for event.
        /// -WAIT_UPSTREAM: waiting for upstream.
        /// - WAIT_RUN: awaiting execution.
        /// -RUNNING. specifies the running status.
        /// - SKIP_RUNNING: specifies whether to SKIP RUNNING.
        /// - FAILED_RETRY: RETRY on failure.
        /// -EXPIRED: indicates a failure.
        /// -COMPLETED: success.
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// Specifies the instance type.
        /// 
        /// -0 indicates the replenishment type.
        /// -Indicates a periodic instance.
        /// -2 indicates a non-periodic instance.
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// owner uin list.
        /// 
        /// </summary>
        [JsonProperty("OwnerUinList")]
        public string[] OwnerUinList{ get; set; }

        /// <summary>
        /// Cumulative running times.
        /// </summary>
        [JsonProperty("TotalRunNum")]
        public ulong? TotalRunNum{ get; set; }

        /// <summary>
        /// Retry count limit when execution fails each time.
        /// </summary>
        [JsonProperty("TryLimit")]
        public ulong? TryLimit{ get; set; }

        /// <summary>
        /// **Failure Retry Count** - The number of retry attempts after a failure. When the instance is triggered again through methods such as manual rerun or backfill, this counter is reset to 0 and starts counting again.
        /// </summary>
        [JsonProperty("Tries")]
        public ulong? Tries{ get; set; }

        /// <summary>
        /// Time spent, in milliseconds.
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Operation completion time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Scheduled dispatch time.
        /// </summary>
        [JsonProperty("SchedulerTime")]
        public string SchedulerTime{ get; set; }

        /// <summary>
        /// Latest update time of the instance. format: yyyy-MM-dd HH:MM:ss.
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// Execution resource group ID.
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// Resource group name.
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// Brief task failure information.
        /// </summary>
        [JsonProperty("JobErrorMsg")]
        public string JobErrorMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArraySimple(map, prefix + "OwnerUinList.", this.OwnerUinList);
            this.SetParamSimple(map, prefix + "TotalRunNum", this.TotalRunNum);
            this.SetParamSimple(map, prefix + "TryLimit", this.TryLimit);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SchedulerTime", this.SchedulerTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
            this.SetParamSimple(map, prefix + "JobErrorMsg", this.JobErrorMsg);
        }
    }
}

