/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceVO : AbstractModel
    {
        
        /// <summary>
        /// Unique identifier of an instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// Project ID.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Folder ID.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// Folder name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// Workflow ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Workflow name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// Responsible person list.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InChargeList")]
        public string[] InChargeList{ get; set; }

        /// <summary>
        /// Task ID
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task Name
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Task type
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskType")]
        public TaskTypeOpsDto TaskType{ get; set; }

        /// <summary>
        /// Task cycle type.
        /// Supports filtering multiple conditions with an or relationship between them.
        /// * O: ONEOFF_CYCLE
        /// * Y: YEAR_CYCLE
        /// * M: MONTH_CYCLE
        /// * W: WEEK_CYCLE
        /// * D: DAY_CYCLE
        /// * H: HOUR_CYCLE
        /// * I: MINUTE_CYCLE
        /// * C: CRONTAB_CYCLE
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskCycleType")]
        public string TaskCycleType{ get; set; }

        /// <summary>
        /// Standard data time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// Specifies the limit on the number of retries issued each time a running failure occurs.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TryLimit")]
        public ulong? TryLimit{ get; set; }

        /// <summary>
        /// Number of retries after failure.
        /// Will be reset to 0 and then recounted when triggered for execution by once again manually rerunning or using a supplementary entry instance and other methods.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tries")]
        public ulong? Tries{ get; set; }

        /// <summary>
        /// Cumulative running times.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalRunNum")]
        public ulong? TotalRunNum{ get; set; }

        /// <summary>
        /// Instance type.
        /// 
        /// -0 indicates the supplementary entry type.
        /// -1 indicates a periodic instance.
        /// -2 indicates a non-periodic instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// Indicates the status of an instance.
        /// 
        /// -Indicates waiting for event.
        /// -[12] indicates waiting for upstream.
        /// -[6, 7, 9, 10, 18] indicates awaiting execution.
        /// -[1, 19, 22]: running.
        /// -[21] indicates skipping running.
        /// -[3] indicates retry on failure.
        /// -[8, 4, 5, 13] indicates a failure.
        /// -[2] indicates a success.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceState")]
        public ulong? InstanceState{ get; set; }

        /// <summary>
        /// Start time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Operation completion time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Time spent.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CostTime")]
        public string CostTime{ get; set; }

        /// <summary>
        /// Planned scheduling time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SchedulerTime")]
        public string SchedulerTime{ get; set; }

        /// <summary>
        /// Execution resource group ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// Resource group name
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamArraySimple(map, prefix + "InChargeList.", this.InChargeList);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamObj(map, prefix + "TaskType.", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskCycleType", this.TaskCycleType);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "TryLimit", this.TryLimit);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamSimple(map, prefix + "TotalRunNum", this.TotalRunNum);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "SchedulerTime", this.SchedulerTime);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
        }
    }
}

