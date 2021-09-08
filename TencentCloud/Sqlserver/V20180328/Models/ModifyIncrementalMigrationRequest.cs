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

    public class ModifyIncrementalMigrationRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of imported target instance
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Backup import task ID, which is returned through the API CreateBackupMigration
        /// </summary>
        [JsonProperty("BackupMigrationId")]
        public string BackupMigrationId{ get; set; }

        /// <summary>
        /// Incremental backup import task ID, which is returned through the `CreateIncrementalMigration` API.
        /// </summary>
        [JsonProperty("IncrementalMigrationId")]
        public string IncrementalMigrationId{ get; set; }

        /// <summary>
        /// Whether to restore backups. Valid values: `NO`, `YES`. If this parameter is not specified, current settings will be applied.
        /// </summary>
        [JsonProperty("IsRecovery")]
        public string IsRecovery{ get; set; }

        /// <summary>
        /// If the UploadType is COS_URL, fill in URL here. If the UploadType is COS_UPLOAD, fill in the name of the backup file here. Only 1 backup file is supported, but a backup file can involve multiple databases.
        /// </summary>
        [JsonProperty("BackupFiles")]
        public string[] BackupFiles{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupMigrationId", this.BackupMigrationId);
            this.SetParamSimple(map, prefix + "IncrementalMigrationId", this.IncrementalMigrationId);
            this.SetParamSimple(map, prefix + "IsRecovery", this.IsRecovery);
            this.SetParamArraySimple(map, prefix + "BackupFiles.", this.BackupFiles);
        }
    }
}

