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

    public class TaskDependDto : AbstractModel
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
        /// Task Status:
        /// 
        /// * N: New
        /// 
        /// * Y: Scheduling
        /// 
        /// * F: Offline
        /// 
        /// * O: Paused
        /// 
        /// * T: Offlining (in the process of being taken offline)
        /// 
        /// I* NVALID: Invalid
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Task type id.
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
        /// -130: branch.
        /// -131: merge.
        /// -132: Notebook 
        /// -133: SSH node.
        ///  - 134 :  StarRocks
        ///  - 137 :  For-each
        /// -10000 : custom business common.
        /// </summary>
        [JsonProperty("TaskTypeDesc")]
        public string TaskTypeDesc{ get; set; }

        /// <summary>
        /// Specifies scheduling plan display description information.
        /// </summary>
        [JsonProperty("ScheduleDesc")]
        public string ScheduleDesc{ get; set; }

        /// <summary>
        /// Task start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task end time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Delay time.
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// Cycle Type, Default: D
        /// Supported types:
        /// * O: One-time
        /// 
        /// * Y: Yearly
        /// 
        /// * M: Monthly
        /// 
        /// * W: Weekly
        /// 
        /// * D: Daily
        /// 
        /// * H: Hourly
        /// 
        /// * I: Minute
        /// 
        /// * C: Crontab expression type
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// Owner ID
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Elastic cycle configuration.
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// Initialization strategy for scheduling.
        /// </summary>
        [JsonProperty("InitStrategy")]
        public string InitStrategy{ get; set; }

        /// <summary>
        /// crontab expression.
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }


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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "TaskTypeDesc", this.TaskTypeDesc);
            this.SetParamSimple(map, prefix + "ScheduleDesc", this.ScheduleDesc);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "TaskAction", this.TaskAction);
            this.SetParamSimple(map, prefix + "InitStrategy", this.InitStrategy);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
        }
    }
}

