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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// **Project ID**.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Filter criteria for instance planned scheduling time.
        /// Specifies the start time for filtering. the time format is yyyy-MM-dd HH:MM:ss.
        /// </summary>
        [JsonProperty("ScheduleTimeFrom")]
        public string ScheduleTimeFrom{ get; set; }

        /// <summary>
        /// Filter criteria for instance planned scheduling time.
        /// Filter expiration time. the time format is yyyy-MM-dd HH:MM:ss.
        /// </summary>
        [JsonProperty("ScheduleTimeTo")]
        public string ScheduleTimeTo{ get; set; }

        /// <summary>
        /// Page number, integer.
        /// Use in conjunction with pageSize and cannot be less than 1. the default value is 1.
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// Number of items per page, integer.
        /// Use in conjunction with pageNumber and should not exceed 200. default value: 10.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Sorting field for query results.
        /// 
        /// -SCHEDULE_DATE indicates sorting based on the planned scheduling time.
        /// -START_TIME indicates sorting by the instance's start execution time.
        /// -END_TIME indicates sorting based on the instance execution end time.
        /// -COST_TIME indicates sorting based on instance execution duration.
        /// </summary>
        [JsonProperty("SortColumn")]
        public string SortColumn{ get; set; }

        /// <summary>
        /// Instance sorting order.
        /// 
        /// - ASC 
        /// - DESC
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// Instance type.
        /// 
        /// -0 indicates Replenished Instance.
        /// -1 indicates Periodic Instance.
        /// -2 indicates Non-Periodic instance.
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// Instance execution status.
        /// Support filtering multiple items with an "or" relationship between conditions.
        /// 
        /// -[0] Indicates waiting for event.
        /// -[12] indicates waiting for upstream.
        /// -[6, 7, 9, 10, 18] indicates awaiting execution.
        /// -[1, 19, 22] indicate running.
        /// -[21] indicates skipping running.
        /// -[3] indicates retry on failure.
        /// -[8, 4, 5, 13] indicates a failure.
        /// -[2] indicates a success.
        /// </summary>
        [JsonProperty("InstanceStateList")]
        public ulong?[] InstanceStateList{ get; set; }

        /// <summary>
        /// **Task type Id** specifies the identifier for the task type.
        /// 
        /// -Supports filtering multiple items with an or relationship between conditions.
        /// -You can use the DescribeAllTaskType API to obtain all task types supported by the project.
        /// </summary>
        [JsonProperty("TaskTypeIdList")]
        public ulong?[] TaskTypeIdList{ get; set; }

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
        /// </summary>
        [JsonProperty("TaskCycleList")]
        public string[] TaskCycleList{ get; set; }

        /// <summary>
        /// Task name or task ID.
        /// Supports fuzzy search filtering. multiple items are separated by english commas.
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// Task owner.
        /// Support filtering multiple items with an or relationship between conditions.
        /// </summary>
        [JsonProperty("InChargeList")]
        public string[] InChargeList{ get; set; }

        /// <summary>
        /// File to which the task belongs.
        /// Supports filtering multiple conditions with an or relationship between them.
        /// The FindAllFolder API can be used to obtain the folder list under a project.
        /// </summary>
        [JsonProperty("TaskFolderIdList")]
        public string[] TaskFolderIdList{ get; set; }

        /// <summary>
        /// **Associated workflow of the task**.
        /// Supports filtering multiple conditions with an or relationship between them.
        /// The workflow list under a project can be obtained through the DescribeOpsWorkflows api.
        /// </summary>
        [JsonProperty("WorkflowIdList")]
        public string[] WorkflowIdList{ get; set; }

        /// <summary>
        /// Execution resource group Id.
        /// Supports filtering multiple conditions with an or relationship between them.
        /// The scheduling resource group list under the project can be obtained through the DescribeNormalSchedulerExecutorGroups api.
        /// The DescribeNormalIntegrationExecutorGroups API can be used to obtain the list of all integration resource groups under a project.
        /// </summary>
        [JsonProperty("ExecutorGroupIdList")]
        public string[] ExecutorGroupIdList{ get; set; }

        /// <summary>
        /// Instance execution start time filter criteria.
        /// Specifies the start time for filtering. the time format is yyyy-MM-dd HH:MM:ss.
        /// </summary>
        [JsonProperty("StartTimeFrom")]
        public string StartTimeFrom{ get; set; }

        /// <summary>
        /// Instance execution start time filter criteria.
        /// Filter expiration time. the time format is yyyy-MM-dd HH:MM:ss.
        /// </summary>
        [JsonProperty("StartTimeTo")]
        public string StartTimeTo{ get; set; }

        /// <summary>
        /// Time zone.
        /// Time zone. specifies the time zone. the default value is UTC+8.
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ScheduleTimeFrom", this.ScheduleTimeFrom);
            this.SetParamSimple(map, prefix + "ScheduleTimeTo", this.ScheduleTimeTo);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SortColumn", this.SortColumn);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArraySimple(map, prefix + "InstanceStateList.", this.InstanceStateList);
            this.SetParamArraySimple(map, prefix + "TaskTypeIdList.", this.TaskTypeIdList);
            this.SetParamArraySimple(map, prefix + "TaskCycleList.", this.TaskCycleList);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArraySimple(map, prefix + "InChargeList.", this.InChargeList);
            this.SetParamArraySimple(map, prefix + "TaskFolderIdList.", this.TaskFolderIdList);
            this.SetParamArraySimple(map, prefix + "WorkflowIdList.", this.WorkflowIdList);
            this.SetParamArraySimple(map, prefix + "ExecutorGroupIdList.", this.ExecutorGroupIdList);
            this.SetParamSimple(map, prefix + "StartTimeFrom", this.StartTimeFrom);
            this.SetParamSimple(map, prefix + "StartTimeTo", this.StartTimeTo);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
        }
    }
}

