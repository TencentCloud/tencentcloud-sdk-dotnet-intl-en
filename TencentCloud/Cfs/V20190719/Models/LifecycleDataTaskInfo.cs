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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifecycleDataTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task status.
        /// init: pending.
        /// running: executing, finished: completed.
        /// failed: failure.
        /// Stopping: stopping, stopped: stopped.
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// Task creation time
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// Task end time.
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// Total files.
        /// </summary>
        [JsonProperty("FileTotalCount")]
        public ulong? FileTotalCount{ get; set; }

        /// <summary>
        /// Number of successfully processed files.
        /// </summary>
        [JsonProperty("FileSuccessedCount")]
        public ulong? FileSuccessedCount{ get; set; }

        /// <summary>
        /// Number of failed files.
        /// </summary>
        [JsonProperty("FileFailedCount")]
        public ulong? FileFailedCount{ get; set; }

        /// <summary>
        /// File capacity, in Byte.
        /// 
        /// </summary>
        [JsonProperty("FileTotalSize")]
        public ulong? FileTotalSize{ get; set; }

        /// <summary>
        /// Processed file capacity, in Byte.
        /// 
        /// </summary>
        [JsonProperty("FileSuccessedSize")]
        public ulong? FileSuccessedSize{ get; set; }

        /// <summary>
        /// Capacity of processed failed files, in Byte.
        /// </summary>
        [JsonProperty("FileFailedSize")]
        public ulong? FileFailedSize{ get; set; }

        /// <summary>
        /// Total file list.
        /// </summary>
        [JsonProperty("FileTotalList")]
        public string FileTotalList{ get; set; }

        /// <summary>
        /// List of successful files.
        /// </summary>
        [JsonProperty("FileSuccessedList")]
        public string FileSuccessedList{ get; set; }

        /// <summary>
        /// List of failed files.
        /// </summary>
        [JsonProperty("FileFailedList")]
        public string FileFailedList{ get; set; }

        /// <summary>
        /// FileSystemId
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Task path.
        /// </summary>
        [JsonProperty("TaskPath")]
        public string TaskPath{ get; set; }

        /// <summary>
        /// Task type, archive: indicates settlement task, restore: indicates pull task.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Data flow Id.
        /// </summary>
        [JsonProperty("DataFlowId")]
        public string DataFlowId{ get; set; }

        /// <summary>
        /// When a file in CFSTurbo and an external storage have the same name, whether to overwrite.
        /// 
        /// Override.
        /// 
        /// false: not overwrite (at the same time, it does not release hot data storage).
        /// Default false when empty.
        /// </summary>
        [JsonProperty("IsOverwrite")]
        public bool? IsOverwrite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "FileTotalCount", this.FileTotalCount);
            this.SetParamSimple(map, prefix + "FileSuccessedCount", this.FileSuccessedCount);
            this.SetParamSimple(map, prefix + "FileFailedCount", this.FileFailedCount);
            this.SetParamSimple(map, prefix + "FileTotalSize", this.FileTotalSize);
            this.SetParamSimple(map, prefix + "FileSuccessedSize", this.FileSuccessedSize);
            this.SetParamSimple(map, prefix + "FileFailedSize", this.FileFailedSize);
            this.SetParamSimple(map, prefix + "FileTotalList", this.FileTotalList);
            this.SetParamSimple(map, prefix + "FileSuccessedList", this.FileSuccessedList);
            this.SetParamSimple(map, prefix + "FileFailedList", this.FileFailedList);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskPath", this.TaskPath);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DataFlowId", this.DataFlowId);
            this.SetParamSimple(map, prefix + "IsOverwrite", this.IsOverwrite);
        }
    }
}

