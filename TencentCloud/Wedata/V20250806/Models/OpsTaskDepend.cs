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

    public class OpsTaskDepend : AbstractModel
    {
        
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
        /// Workflow id.
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
        /// Project ID.
        /// 
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Project name.
        /// 
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

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
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public ulong? TaskTypeId{ get; set; }

        /// <summary>
        /// Task type description.
        /// -20 : universal data synchronization.
        ///  - 25 :  ETLTaskType
        ///  - 26 :  ETLTaskType
        ///  - 30 :  python
        ///  - 31 :  pyspark
        ///  - 34 :  hivesql
        ///  - 35 :  shell
        ///  - 36 :  sparksql
        ///  - 21 :  jdbcsql
        ///  - 32 :  dlc
        ///  - 33 :  ImpalaTaskType
        ///  - 40 :  CDWTaskType
        ///  - 41 :  kettle
        ///  - 42 :  TCHouse-X
        ///  - 43 :  TCHouse-X SQL
        ///  - 46 :  dlcsparkTaskType
        ///  - 47 :  TiOneMachineLearningTaskType
        ///  - 48 :  Trino
        ///  - 50 :  DLCPyspark
        ///  - 23 :  TencentDistributedSQL
        ///  - 39 :  spark
        ///  - 92 :  MRTaskType
        ///  - 38 :  ShellScript
        ///  - 70 :  HiveSQLScrip
        /// -130: specifies the branch.
        /// -131: specifies the merge.
        /// -132: specifies the Notebook explore.
        /// -133: specifies the SSH node.
        ///  - 134 :  StarRocks
        ///  - 137 :  For-each
        /// -10000: common custom business.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskTypeDesc")]
        public string TaskTypeDesc{ get; set; }

        /// <summary>
        /// Folder name.
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// Folder ID
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// Latest submission time.
        /// </summary>
        [JsonProperty("FirstSubmitTime")]
        public string FirstSubmitTime{ get; set; }

        /// <summary>
        /// First running time
        /// 
        /// </summary>
        [JsonProperty("FirstRunTime")]
        public string FirstRunTime{ get; set; }

        /// <summary>
        /// Describes the scheduling plan display description information.
        /// </summary>
        [JsonProperty("ScheduleDesc")]
        public string ScheduleDesc{ get; set; }

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
        /// Specifies the person in charge.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Execution start time. format: HH:mm, for example 00:00.
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// Execution end time. format: HH:mm, for example 23:59.
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "TaskTypeDesc", this.TaskTypeDesc);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "FirstSubmitTime", this.FirstSubmitTime);
            this.SetParamSimple(map, prefix + "FirstRunTime", this.FirstRunTime);
            this.SetParamSimple(map, prefix + "ScheduleDesc", this.ScheduleDesc);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
        }
    }
}

