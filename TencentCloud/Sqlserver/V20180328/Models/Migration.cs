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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Migration : AbstractModel
    {
        
        /// <summary>
        /// Backup import task ID or incremental import task ID
        /// </summary>
        [JsonProperty("MigrationId")]
        public string MigrationId{ get; set; }

        /// <summary>
        /// Backup import task name. For an incremental import task, this field will be left empty.
        /// Note: this field may return ‘null’, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MigrationName")]
        public string MigrationName{ get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// ID of migrated target instance
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Migration task restoration type
        /// </summary>
        [JsonProperty("RecoveryType")]
        public string RecoveryType{ get; set; }

        /// <summary>
        /// Backup user upload type. COS_URL: the backup is stored in user’s Cloud Object Storage, with URL provided. COS_UPLOAD: the backup is stored in the application’s Cloud Object Storage and needs to be uploaded by the user.
        /// </summary>
        [JsonProperty("UploadType")]
        public string UploadType{ get; set; }

        /// <summary>
        /// Backup file list, which is determined by UploadType. If the upload type is COS_URL, URL will be saved. If the upload type is COS_UPLOAD, the backup name will be saved.
        /// </summary>
        [JsonProperty("BackupFiles")]
        public string[] BackupFiles{ get; set; }

        /// <summary>
        /// Migration task status. Valid values: `2` (Creation completed), `7` (Importing full backups), `8` (Waiting for incremental backups), `9` (Import success), `10` (Import failure), `12` (Importing incremental backups).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Migration task creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Migration task start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Migration task end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// More information
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Migration detail
        /// </summary>
        [JsonProperty("Detail")]
        public MigrationDetail Detail{ get; set; }

        /// <summary>
        /// Operation allowed in the current status
        /// </summary>
        [JsonProperty("Action")]
        public MigrationAction Action{ get; set; }

        /// <summary>
        /// Whether this is the final restoration. For a full import task, this field will be left empty.
        /// Note: this field may return ‘null’, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsRecovery")]
        public string IsRecovery{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MigrationId", this.MigrationId);
            this.SetParamSimple(map, prefix + "MigrationName", this.MigrationName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RecoveryType", this.RecoveryType);
            this.SetParamSimple(map, prefix + "UploadType", this.UploadType);
            this.SetParamArraySimple(map, prefix + "BackupFiles.", this.BackupFiles);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "Detail.", this.Detail);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamSimple(map, prefix + "IsRecovery", this.IsRecovery);
        }
    }
}

