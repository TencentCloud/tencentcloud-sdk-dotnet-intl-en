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

    public class ListTaskInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// **Project ID**. specifies the project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// **Page number. integer.**.
        /// Used in conjunction with pageSize and cannot be less than 1. default value: 1.
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// Specifies the number of items to display per page. default: 10. value range: 1-100.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Task name or task ID.
        /// Supports fuzzy search filtering. multiple values are separated by commas.
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// **Time zone** timeZone, specifies the time zone of the passed in time string. default UTC+8.
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// **Instance Type**
        /// 
        /// 0 - Backfill instance
        /// 
        /// 1 - Cyclic (scheduled) instance
        /// 
        /// 2 - Non-cyclic (non-scheduled) instance
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// **Instance Status**
        /// 
        /// WAIT_EVENT: Waiting for event
        /// 
        /// WAIT_UPSTREAM: Waiting for upstream
        /// 
        /// WAIT_RUN: Waiting to run
        /// 
        /// RUNNING: Running
        /// 
        /// SKIP_RUNNING: Skipped
        /// 
        /// FAILED_RETRY: Retrying after failure
        /// 
        /// EXPIRED: Failed
        /// 
        /// COMPLETED: Succeeded
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// Task type Id.
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public ulong? TaskTypeId{ get; set; }

        /// <summary>
        /// **Task Cycle Type**
        /// 
        /// ONEOFF_CYCLE: One-time
        /// 
        /// YEAR_CYCLE: Yearly
        /// 
        /// MONTH_CYCLE: Monthly
        /// 
        /// WEEK_CYCLE: Weekly
        /// 
        /// DAY_CYCLE: Daily
        /// 
        /// HOUR_CYCLE: Hourly
        /// 
        /// MINUTE_CYCLE: Minute-level
        /// 
        /// CRONTAB_CYCLE: Crontab expression-based
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// Task owner id.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Folder id
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// Workflow id of the task.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// **Execution resource group Id**.
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// **Instance Scheduled Time Filter Condition** specifies the filter start time in the time format yyyy-MM-dd HH:MM:ss.
        /// </summary>
        [JsonProperty("ScheduleTimeFrom")]
        public string ScheduleTimeFrom{ get; set; }

        /// <summary>
        /// **Instance Scheduled Time Filter Condition** specifies the cutoff time in the format of yyyy-MM-dd HH:MM:ss.
        /// </summary>
        [JsonProperty("ScheduleTimeTo")]
        public string ScheduleTimeTo{ get; set; }

        /// <summary>
        /// **Instance Execution Start Time Filter Condition** specifies the start time for filtering. time format: yyyy-MM-dd HH:MM:ss.
        /// </summary>
        [JsonProperty("StartTimeFrom")]
        public string StartTimeFrom{ get; set; }

        /// <summary>
        /// **Instance Execution Start Time Filter Condition**.
        /// Expiration time in yyyy-MM-dd HH:MM:ss format.
        /// </summary>
        [JsonProperty("StartTimeTo")]
        public string StartTimeTo{ get; set; }

        /// <summary>
        /// **Instance Last Update Time Filter Condition**.
        /// Expiration time in yyyy-MM-dd HH:MM:ss format.
        /// </summary>
        [JsonProperty("LastUpdateTimeFrom")]
        public string LastUpdateTimeFrom{ get; set; }

        /// <summary>
        /// **Instance Last Update Time Filter Condition**.
        /// Expiration time in yyyy-MM-dd HH:MM:ss format.
        /// </summary>
        [JsonProperty("LastUpdateTimeTo")]
        public string LastUpdateTimeTo{ get; set; }

        /// <summary>
        /// **Query Result Sorting Field**
        /// 
        /// SCHEDULE_DATE: Sort by scheduled execution time
        /// 
        /// START_TIME: Sort by actual execution start time
        /// 
        /// END_TIME: Sort by actual execution end time
        /// 
        /// COST_TIME: Sort by execution duration
        /// </summary>
        [JsonProperty("SortColumn")]
        public string SortColumn{ get; set; }

        /// <summary>
        /// **Instance Sorting Order**
        /// 
        /// - ASC 
        /// - DESC
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "ScheduleTimeFrom", this.ScheduleTimeFrom);
            this.SetParamSimple(map, prefix + "ScheduleTimeTo", this.ScheduleTimeTo);
            this.SetParamSimple(map, prefix + "StartTimeFrom", this.StartTimeFrom);
            this.SetParamSimple(map, prefix + "StartTimeTo", this.StartTimeTo);
            this.SetParamSimple(map, prefix + "LastUpdateTimeFrom", this.LastUpdateTimeFrom);
            this.SetParamSimple(map, prefix + "LastUpdateTimeTo", this.LastUpdateTimeTo);
            this.SetParamSimple(map, prefix + "SortColumn", this.SortColumn);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
        }
    }
}

