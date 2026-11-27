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
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Task status.</p><p>Valid values:</p><ul><li>init: queuing</li><li>running: running</li><li>finished: completed</li><li>failed: failed</li><li>stopping: stopping</li><li>stopped: stopped</li></ul>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// <p>Task creation time</p>
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// <p>Task end time</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>Total number of files</p>
        /// </summary>
        [JsonProperty("FileTotalCount")]
        public ulong? FileTotalCount{ get; set; }

        /// <summary>
        /// <p>Number of files processed successfully</p>
        /// </summary>
        [JsonProperty("FileSuccessedCount")]
        public ulong? FileSuccessedCount{ get; set; }

        /// <summary>
        /// <p>Number of files that have failed</p>
        /// </summary>
        [JsonProperty("FileFailedCount")]
        public ulong? FileFailedCount{ get; set; }

        /// <summary>
        /// <p>File size, in bytes</p>
        /// </summary>
        [JsonProperty("FileTotalSize")]
        public ulong? FileTotalSize{ get; set; }

        /// <summary>
        /// <p>Size of processed files, in bytes</p>
        /// </summary>
        [JsonProperty("FileSuccessedSize")]
        public ulong? FileSuccessedSize{ get; set; }

        /// <summary>
        /// <p>Size of failed files, in bytes</p>
        /// </summary>
        [JsonProperty("FileFailedSize")]
        public ulong? FileFailedSize{ get; set; }

        /// <summary>
        /// <p>Total file list.</p>
        /// </summary>
        [JsonProperty("FileTotalList")]
        public string FileTotalList{ get; set; }

        /// <summary>
        /// <p>List of successful files.</p>
        /// </summary>
        [JsonProperty("FileSuccessedList")]
        public string FileSuccessedList{ get; set; }

        /// <summary>
        /// <p>List of failed files.</p>
        /// </summary>
        [JsonProperty("FileFailedList")]
        public string FileFailedList{ get; set; }

        /// <summary>
        /// <p>FileSystemId</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>Task name.</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Task path.</p>
        /// </summary>
        [JsonProperty("TaskPath")]
        public string TaskPath{ get; set; }

        /// <summary>
        /// <p>Task type. archive: an archiving task. restore: a retrieval task.</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Data flow Id.</p>
        /// </summary>
        [JsonProperty("DataFlowId")]
        public string DataFlowId{ get; set; }

        /// <summary>
        /// <p>Whether to overwrite files with the same name in CFS Turbo and external storage.</p><p>true: Overwrite.</p><p>false: Do not overwrite (and hot storage data will not be released).<br>If this parameter is left empty, the default value is false.</p>
        /// </summary>
        [JsonProperty("IsOverwrite")]
        public bool? IsOverwrite{ get; set; }

        /// <summary>
        /// <p>Path of the data manifest file. Each line in the manifest file is the full path of a file to be processed. All paths (including the manifest file path and the paths of files to be processed in each line of the manifest file) must start with /cfs and point to existing files in the CFS file system. This parameter and TaskPath are alternative. <br>Example:</p><ul><li>If the CFS root directory / is mounted and the manifest file is located at lists/archive_list.txt under the mount path, set this parameter to /cfs/lists/archive_list.txt.</li><li>If the CFS subdirectory /subdir is mounted and the manifest file is located at lists/archive_list.txt under the mount path, set this parameter to /cfs/subdir/lists/archive_list.txt.</li></ul>
        /// </summary>
        [JsonProperty("ListPath")]
        public string ListPath{ get; set; }


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
            this.SetParamSimple(map, prefix + "ListPath", this.ListPath);
        }
    }
}

