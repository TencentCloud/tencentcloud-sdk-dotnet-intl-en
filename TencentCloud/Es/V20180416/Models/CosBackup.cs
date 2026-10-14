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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosBackup : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to enable cos automatic backup</p>
        /// </summary>
        [JsonProperty("IsAutoBackup")]
        public bool? IsAutoBackup{ get; set; }

        /// <summary>
        /// <p>Automatic backup execution time (accurate to the hour), e.g. "22:00"</p>
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }

        /// <summary>
        /// <p>Backup snapshot prefix</p>
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// <p>0 (Tencent Cloud repository); 1 (customer repository)</p>
        /// </summary>
        [JsonProperty("EsRepositoryType")]
        public ulong? EsRepositoryType{ get; set; }

        /// <summary>
        /// <p>Managed snapshot repository name.</p>
        /// </summary>
        [JsonProperty("PaasEsRepository")]
        public string PaasEsRepository{ get; set; }

        /// <summary>
        /// <p>Customer snapshot repository name</p>
        /// </summary>
        [JsonProperty("UserEsRepository")]
        public string UserEsRepository{ get; set; }

        /// <summary>
        /// <p>cos storage folder directory</p>
        /// </summary>
        [JsonProperty("CosBasePath")]
        public string CosBasePath{ get; set; }

        /// <summary>
        /// <p>Snapshot storage cycle in days</p>
        /// </summary>
        [JsonProperty("StorageDuration")]
        public ulong? StorageDuration{ get; set; }

        /// <summary>
        /// <p>Auto backup frequency in hours.</p>
        /// </summary>
        [JsonProperty("AutoBackupInterval")]
        public ulong? AutoBackupInterval{ get; set; }

        /// <summary>
        /// <p>Backup lock. Valid values: 0 (not locked) and 1 (locked).</p>
        /// </summary>
        [JsonProperty("CosRetention")]
        public ulong? CosRetention{ get; set; }

        /// <summary>
        /// <p>Lock expiration date, such as 2022-12-10T08:34:48.000Z.</p>
        /// </summary>
        [JsonProperty("RetainUntilDate")]
        public string RetainUntilDate{ get; set; }

        /// <summary>
        /// <p>Lock grace period</p>
        /// </summary>
        [JsonProperty("RetentionGraceTime")]
        public ulong? RetentionGraceTime{ get; set; }

        /// <summary>
        /// <p>Cross-region backup. Valid values: 0 (disabled) and 1 (enabled).</p>
        /// </summary>
        [JsonProperty("RemoteCos")]
        public ulong? RemoteCos{ get; set; }

        /// <summary>
        /// <p>Region name for cross-regional backup, such as ap-guangzhou.</p>
        /// </summary>
        [JsonProperty("RemoteCosRegion")]
        public string RemoteCosRegion{ get; set; }

        /// <summary>
        /// <p>Policy name.</p>
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// <p>Backup index list. If left empty, it means to back up all indexes.</p>
        /// </summary>
        [JsonProperty("Indices")]
        public string Indices{ get; set; }

        /// <summary>
        /// <p>cos multi-AZ backup. 0: single AZ; 1: multi-AZ</p>
        /// </summary>
        [JsonProperty("MultiAz")]
        public ulong? MultiAz{ get; set; }

        /// <summary>
        /// <p>Maximum speed of write to the repository per node max_snapshot_bytes_per_sec, default 40m</p>
        /// </summary>
        [JsonProperty("MaxSnapshotPerSec")]
        public string MaxSnapshotPerSec{ get; set; }

        /// <summary>
        /// <p>Maximum speed of reading the repository per node max_restore_bytes_per_sec. Default is 40m before 710, and default unlimited from 710 onwards</p>
        /// </summary>
        [JsonProperty("MaxRestorePerSec")]
        public string MaxRestorePerSec{ get; set; }

        /// <summary>
        /// <p>Policy creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsAutoBackup", this.IsAutoBackup);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "EsRepositoryType", this.EsRepositoryType);
            this.SetParamSimple(map, prefix + "PaasEsRepository", this.PaasEsRepository);
            this.SetParamSimple(map, prefix + "UserEsRepository", this.UserEsRepository);
            this.SetParamSimple(map, prefix + "CosBasePath", this.CosBasePath);
            this.SetParamSimple(map, prefix + "StorageDuration", this.StorageDuration);
            this.SetParamSimple(map, prefix + "AutoBackupInterval", this.AutoBackupInterval);
            this.SetParamSimple(map, prefix + "CosRetention", this.CosRetention);
            this.SetParamSimple(map, prefix + "RetainUntilDate", this.RetainUntilDate);
            this.SetParamSimple(map, prefix + "RetentionGraceTime", this.RetentionGraceTime);
            this.SetParamSimple(map, prefix + "RemoteCos", this.RemoteCos);
            this.SetParamSimple(map, prefix + "RemoteCosRegion", this.RemoteCosRegion);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "Indices", this.Indices);
            this.SetParamSimple(map, prefix + "MultiAz", this.MultiAz);
            this.SetParamSimple(map, prefix + "MaxSnapshotPerSec", this.MaxSnapshotPerSec);
            this.SetParamSimple(map, prefix + "MaxRestorePerSec", this.MaxRestorePerSec);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

