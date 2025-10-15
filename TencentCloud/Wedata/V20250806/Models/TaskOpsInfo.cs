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

    public class TaskOpsInfo : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Owner id
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Task Status
        /// 
        /// -N: New
        /// 
        /// -Y: Scheduling
        /// 
        /// -F: Offline
        /// 
        /// -O: Paused
        /// 
        /// -T: Offlining
        /// 
        /// -INVALID: Invalid
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Folder ID
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// Folder name.
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// Workflow id.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Workflow name.
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Project name.
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Specifies the name of the updater.
        /// </summary>
        [JsonProperty("UpdateUserUin")]
        public string UpdateUserUin{ get; set; }

        /// <summary>
        /// Task type Id.
        /// * 21:JDBC SQL
        /// * 23:TDSQL-PostgreSQL
        /// * 26:OfflineSynchronization
        /// * 30:Python
        /// * 31:PySpark
        /// * 33:Impala
        /// * 34:Hive SQL
        /// * 35:Shell
        /// * 36:Spark SQL
        /// * 38:Shell Form Mode
        /// * 39:Spark
        /// * 40:TCHouse-P
        /// * 41:Kettle
        /// * 42:Tchouse-X
        /// * 43:TCHouse-X SQL
        /// * 46:DLC Spark
        /// * 47:TiOne
        /// * 48:Trino
        /// * 50:DLC PySpark
        /// * 92:MapReduce
        /// * 130:Branch Node
        /// * 131:Merged Node
        /// * 132:Notebook
        /// * 133:SSH
        /// * 134:StarRocks
        /// * 137:For-each
        /// * 138:Setats SQL
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public ulong? TaskTypeId{ get; set; }

        /// <summary>
        /// Task type description.
        /// -Universal data synchronization.
        ///  - ETLTaskType
        ///  - ETLTaskType
        ///  - python
        ///  - pyspark
        ///  - HiveSQLTaskType
        ///  - shell
        ///  - SparkSQLTaskType
        ///  - JDBCSQLTaskType
        ///  - DLCTaskType
        ///  - ImpalaTaskType
        ///  - CDWTaskType
        ///  - kettle
        ///  - DLCSparkTaskType
        /// -TiOne machine learning.
        ///  - TrinoTaskType
        ///  - DLCPyspark
        ///  - spark
        ///  - mr
        /// -Specifies the shell script.
        /// -hivesql script.
        /// -Specifies common custom business.
        /// </summary>
        [JsonProperty("TaskTypeDesc")]
        public string TaskTypeDesc{ get; set; }

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
        /// Resource group ID
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// Scheduling description.
        /// </summary>
        [JsonProperty("ScheduleDesc")]
        public string ScheduleDesc{ get; set; }

        /// <summary>
        /// Resource group name.
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// Latest scheduling submission time.
        /// </summary>
        [JsonProperty("LastSchedulerCommitTime")]
        public string LastSchedulerCommitTime{ get; set; }

        /// <summary>
        /// First execution time.
        /// </summary>
        [JsonProperty("FirstRunTime")]
        public string FirstRunTime{ get; set; }

        /// <summary>
        /// Most recent submission time.
        /// </summary>
        [JsonProperty("FirstSubmitTime")]
        public string FirstSubmitTime{ get; set; }

        /// <summary>
        /// Creation time.
        /// 
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Latest update time.
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "UpdateUserUin", this.UpdateUserUin);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "TaskTypeDesc", this.TaskTypeDesc);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "ScheduleDesc", this.ScheduleDesc);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
            this.SetParamSimple(map, prefix + "LastSchedulerCommitTime", this.LastSchedulerCommitTime);
            this.SetParamSimple(map, prefix + "FirstRunTime", this.FirstRunTime);
            this.SetParamSimple(map, prefix + "FirstSubmitTime", this.FirstSubmitTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
        }
    }
}

