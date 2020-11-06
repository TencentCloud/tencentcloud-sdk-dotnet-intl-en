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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskDetail : AbstractModel
    {
        
        /// <summary>
        /// Error code.
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// ID of an instance task.
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// Instance task progress.
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// Instance task status. Valid values:
        /// "UNDEFINED" - undefined;
        /// "INITIAL" - initializing;
        /// "RUNNING" - running;
        /// "SUCCEED" - succeeded;
        /// "FAILED" - failed;
        /// "KILLED" - terminated;
        /// "REMOVED" - deleted;
        /// "PAUSED" - paused.
        /// "WAITING" - waiting (which can be canceled)
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// Instance task type. Valid values:
        /// "ROLLBACK" - rolling back a database;
        /// "SQL OPERATION" - performing an SQL operation;
        /// "IMPORT DATA" - importing data;
        /// "MODIFY PARAM" - setting a parameter;
        /// "INITIAL" - initializing a TencentDB instance;
        /// "REBOOT" - restarting a TencentDB instance;
        /// "OPEN GTID" - enabling GTID of a TencentDB instance;
        /// "UPGRADE RO" - upgrading a read-only instance;
        /// "BATCH ROLLBACK" - rolling back databases in batches;
        /// "UPGRADE MASTER" - upgrading a primary instance;
        /// "DROP TABLES" - dropping a TencentDB table;
        /// "SWITCH DR TO MASTER" - promoting a disaster recovery instance.
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Instance task start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Instance task end time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// ID of an instance associated with a task.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Async task request ID.
        /// </summary>
        [JsonProperty("AsyncRequestId")]
        public string AsyncRequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "AsyncRequestId", this.AsyncRequestId);
        }
    }
}

