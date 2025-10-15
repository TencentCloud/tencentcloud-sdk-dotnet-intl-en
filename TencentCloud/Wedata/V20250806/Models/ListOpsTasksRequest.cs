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

    public class ListOpsTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// 		
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Pagination size.
        /// </summary>
        [JsonProperty("PageSize")]
        public string PageSize{ get; set; }

        /// <summary>
        /// Page number
        /// </summary>
        [JsonProperty("PageNumber")]
        public string PageNumber{ get; set; }

        /// <summary>
        /// Task type Id. 
        /// -20: common data sync.
        ///  - 25:ETLTaskType
        ///  - 26:ETLTaskType
        ///  - 30:python
        ///  - 31:pyspark
        ///  - 34:HiveSQLTaskType
        ///  - 35:shell
        ///  - 36:SparkSQLTaskType
        ///  - 21:JDBCSQLTaskType
        ///  - 32:DLCTaskType
        ///  - 33:ImpalaTaskType
        ///  - 40:CDWTaskType
        ///  - 41:kettle
        ///  - 46:DLCSparkTaskType
        /// -47: TiOne machine learning.
        ///  - 48:TrinoTaskType
        ///  - 50:DLCPyspark39:spark
        ///  - 92:mr
        /// -38: shell script.
        /// -70: hivesql script.
        /// -1000: common custom business.
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public string TaskTypeId{ get; set; }

        /// <summary>
        /// Workflow ID.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Workflow name.
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// Owner id.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Folder ID
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// Data source ID.
        /// </summary>
        [JsonProperty("SourceServiceId")]
        public string SourceServiceId{ get; set; }

        /// <summary>
        /// Target data source id.
        /// </summary>
        [JsonProperty("TargetServiceId")]
        public string TargetServiceId{ get; set; }

        /// <summary>
        /// Executor Group ID
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// Task Cycle Type:
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
        /// Task Status
        /// 
        /// -Y: Running
        /// 
        /// -F: Stopped
        /// 
        /// -O: Frozen
        /// 
        /// -T: Stopping
        /// 
        /// -INVALID: Invalid
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Time zone. defaults to UTC+8.
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "SourceServiceId", this.SourceServiceId);
            this.SetParamSimple(map, prefix + "TargetServiceId", this.TargetServiceId);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

