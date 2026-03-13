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

    public class MigrationTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Migration task name
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Migration task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Migration type. Valid values: `0` (bucket) and `1` (list). Default value: `0`.
        /// </summary>
        [JsonProperty("MigrationType")]
        public ulong? MigrationType{ get; set; }

        /// <summary>
        /// Migration mode. Default value: `0` (full migration).
        /// </summary>
        [JsonProperty("MigrationMode")]
        public ulong? MigrationMode{ get; set; }

        /// <summary>
        /// Data source bucket name.
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// Source bucket region.
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// Data source bucket address.
        /// </summary>
        [JsonProperty("BucketAddress")]
        public string BucketAddress{ get; set; }

        /// <summary>
        /// Checklist address.
        /// </summary>
        [JsonProperty("ListAddress")]
        public string ListAddress{ get; set; }

        /// <summary>
        /// File system instance name.
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// File system instance ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// File system path
        /// </summary>
        [JsonProperty("FsPath")]
        public string FsPath{ get; set; }

        /// <summary>
        /// Overwrite policy for files with the same name. Valid values: `0` (retain the file with the latest modified time), `1` (overwrite); and `2` (not overwrite). Default value: `0`.
        /// </summary>
        [JsonProperty("CoverType")]
        public ulong? CoverType{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Completion/Termination time.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Migration status. 0: completed; 1: creating; 2: running; 3: terminating; 4: terminated; 5: creation failed; 6: running failure; 7: ending; 8: deleting; 9: waiting.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Number of files.
        /// </summary>
        [JsonProperty("FileTotalCount")]
        public ulong? FileTotalCount{ get; set; }

        /// <summary>
        /// Number of migrated files.
        /// </summary>
        [JsonProperty("FileMigratedCount")]
        public ulong? FileMigratedCount{ get; set; }

        /// <summary>
        /// Number of failed files in migration.
        /// </summary>
        [JsonProperty("FileFailedCount")]
        public ulong? FileFailedCount{ get; set; }

        /// <summary>
        /// File capacity, in Byte.
        /// </summary>
        [JsonProperty("FileTotalSize")]
        public long? FileTotalSize{ get; set; }

        /// <summary>
        /// Migrated file capacity in Byte.
        /// </summary>
        [JsonProperty("FileMigratedSize")]
        public long? FileMigratedSize{ get; set; }

        /// <summary>
        /// Capacity of failed migration files, in Byte.
        /// </summary>
        [JsonProperty("FileFailedSize")]
        public long? FileFailedSize{ get; set; }

        /// <summary>
        /// Total inventory.
        /// </summary>
        [JsonProperty("FileTotalList")]
        public string FileTotalList{ get; set; }

        /// <summary>
        /// File list completed.
        /// </summary>
        [JsonProperty("FileCompletedList")]
        public string FileCompletedList{ get; set; }

        /// <summary>
        /// Failed file list.
        /// </summary>
        [JsonProperty("FileFailedList")]
        public string FileFailedList{ get; set; }

        /// <summary>
        /// Source bucket path.
        /// </summary>
        [JsonProperty("BucketPath")]
        public string BucketPath{ get; set; }

        /// <summary>
        /// Migration direction. valid values: 0 (cos migration to file system), 1 (file system migration to cos). default is 0.
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "MigrationType", this.MigrationType);
            this.SetParamSimple(map, prefix + "MigrationMode", this.MigrationMode);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketAddress", this.BucketAddress);
            this.SetParamSimple(map, prefix + "ListAddress", this.ListAddress);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "FsPath", this.FsPath);
            this.SetParamSimple(map, prefix + "CoverType", this.CoverType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FileTotalCount", this.FileTotalCount);
            this.SetParamSimple(map, prefix + "FileMigratedCount", this.FileMigratedCount);
            this.SetParamSimple(map, prefix + "FileFailedCount", this.FileFailedCount);
            this.SetParamSimple(map, prefix + "FileTotalSize", this.FileTotalSize);
            this.SetParamSimple(map, prefix + "FileMigratedSize", this.FileMigratedSize);
            this.SetParamSimple(map, prefix + "FileFailedSize", this.FileFailedSize);
            this.SetParamSimple(map, prefix + "FileTotalList", this.FileTotalList);
            this.SetParamSimple(map, prefix + "FileCompletedList", this.FileCompletedList);
            this.SetParamSimple(map, prefix + "FileFailedList", this.FileFailedList);
            this.SetParamSimple(map, prefix + "BucketPath", this.BucketPath);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

