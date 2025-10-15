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

    public class TaskBaseAttribute : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Specifies the task type ID.
        /// 
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
        /// Workflow ID.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Last save version number.
        /// </summary>
        [JsonProperty("TaskLatestVersionNo")]
        public string TaskLatestVersionNo{ get; set; }

        /// <summary>
        /// Last submit version number.
        /// </summary>
        [JsonProperty("TaskLatestSubmitVersionNo")]
        public string TaskLatestSubmitVersionNo{ get; set; }

        /// <summary>
        /// Workflow name.
        /// 
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// Task Status:
        /// 
        /// * N: New
        /// * Y: Scheduling
        /// * F: Offline
        /// * O: Paused
        /// * T: Offlining (in the process of being taken offline)
        /// * INVALID: Invalid
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Latest submission status of the task. Specifies whether it has been submitted: true/false.
        /// </summary>
        [JsonProperty("Submit")]
        public bool? Submit{ get; set; }

        /// <summary>
        /// Task creation time. example: 2022-02-12 11:13:41.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last update time. example: 2025-08-13 16:34:06.
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// Last Updated By (Name).
        /// </summary>
        [JsonProperty("LastUpdateUserName")]
        public string LastUpdateUserName{ get; set; }

        /// <summary>
        /// Last operation time.
        /// </summary>
        [JsonProperty("LastOpsTime")]
        public string LastOpsTime{ get; set; }

        /// <summary>
        /// Last operator name.
        /// </summary>
        [JsonProperty("LastOpsUserName")]
        public string LastOpsUserName{ get; set; }

        /// <summary>
        /// Task owner ID.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Task description
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// Last Updated User ID
        /// </summary>
        [JsonProperty("UpdateUserUin")]
        public string UpdateUserUin{ get; set; }

        /// <summary>
        /// Created By User ID
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskLatestVersionNo", this.TaskLatestVersionNo);
            this.SetParamSimple(map, prefix + "TaskLatestSubmitVersionNo", this.TaskLatestSubmitVersionNo);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Submit", this.Submit);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "LastUpdateUserName", this.LastUpdateUserName);
            this.SetParamSimple(map, prefix + "LastOpsTime", this.LastOpsTime);
            this.SetParamSimple(map, prefix + "LastOpsUserName", this.LastOpsUserName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "UpdateUserUin", this.UpdateUserUin);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
        }
    }
}

