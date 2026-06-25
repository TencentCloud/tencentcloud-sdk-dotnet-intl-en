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
        /// Whether to enable auto-backup to COS
        /// </summary>
        [JsonProperty("IsAutoBackup")]
        public bool? IsAutoBackup{ get; set; }

        /// <summary>
        /// Auto-backup time (accurate down to the hour), such as "22:00"
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }

        /// <summary>
        /// Backup snapshot prefix.
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// Valid values: 0 (Tencent Cloud repository) and 1 (customer repository).
        /// </summary>
        [JsonProperty("EsRepositoryType")]
        public ulong? EsRepositoryType{ get; set; }

        /// <summary>
        /// Managed snapshot repository name.
        /// </summary>
        [JsonProperty("PaasEsRepository")]
        public string PaasEsRepository{ get; set; }

        /// <summary>
        /// Customer snapshot repository name.
        /// </summary>
        [JsonProperty("UserEsRepository")]
        public string UserEsRepository{ get; set; }

        /// <summary>
        /// COS storage folder directory.
        /// </summary>
        [JsonProperty("CosBasePath")]
        public string CosBasePath{ get; set; }

        /// <summary>
        /// Snapshot storage cycle in days.
        /// </summary>
        [JsonProperty("StorageDuration")]
        public ulong? StorageDuration{ get; set; }

        /// <summary>
        /// Auto backup frequency in hours.
        /// </summary>
        [JsonProperty("AutoBackupInterval")]
        public ulong? AutoBackupInterval{ get; set; }

        /// <summary>
        /// Backup lock. Valid values: 0 (not locked) and 1 (locked).
        /// </summary>
        [JsonProperty("CosRetention")]
        public ulong? CosRetention{ get; set; }

        /// <summary>
        /// Lock expiration date, such as 2022-12-10T08:34:48.000Z.
        /// </summary>
        [JsonProperty("RetainUntilDate")]
        public string RetainUntilDate{ get; set; }

        /// <summary>
        /// Lock grace period.
        /// </summary>
        [JsonProperty("RetentionGraceTime")]
        public ulong? RetentionGraceTime{ get; set; }

        /// <summary>
        /// Cross-region backup. Valid values: 0 (disabled) and 1 (enabled).
        /// </summary>
        [JsonProperty("RemoteCos")]
        public ulong? RemoteCos{ get; set; }

        /// <summary>
        /// Region name for cross-region backup, such as ap-guangzhou.
        /// </summary>
        [JsonProperty("RemoteCosRegion")]
        public string RemoteCosRegion{ get; set; }

        /// <summary>
        /// Policy name.
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// Backup index list. If left empty, it means to back up all indexes.
        /// </summary>
        [JsonProperty("Indices")]
        public string Indices{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MultiAz")]
        public ulong? MultiAz{ get; set; }

        /// <summary>
        /// Policy creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


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
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

