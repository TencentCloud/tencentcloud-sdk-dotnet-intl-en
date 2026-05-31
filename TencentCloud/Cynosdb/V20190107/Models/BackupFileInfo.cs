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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupFileInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Snapshot file ID, abandoned, please use BackupId</p>
        /// </summary>
        [JsonProperty("SnapshotId")]
        public ulong? SnapshotId{ get; set; }

        /// <summary>
        /// <p>Backup file name</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>Backup file size</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

        /// <summary>
        /// <p>Backup start time.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Backup completion time.</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>Backup type: snapshot, snapshot backup; logic, logical backup</p>
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// <p>Backup method: auto, automatic backup; manual, manual backup</p>
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// <p>Backup file status: success: backup successful; fail: backup failed; creating: backup file being created; deleting: backup file deleting</p>
        /// </summary>
        [JsonProperty("BackupStatus")]
        public string BackupStatus{ get; set; }

        /// <summary>
        /// <p>Backup file time</p>
        /// </summary>
        [JsonProperty("SnapshotTime")]
        public string SnapshotTime{ get; set; }

        /// <summary>
        /// <p>Backup ID</p>
        /// </summary>
        [JsonProperty("BackupId")]
        public long? BackupId{ get; set; }

        /// <summary>
        /// <p>Snapshot type. Value range: full, full; increment, incremental</p>
        /// </summary>
        [JsonProperty("SnapShotType")]
        public string SnapShotType{ get; set; }

        /// <summary>
        /// <p>Backup file remark</p>
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// <p>Delivery status</p>
        /// </summary>
        [JsonProperty("CopyStatus")]
        public string CopyStatus{ get; set; }

        /// <summary>
        /// <p>Key id</p>
        /// </summary>
        [JsonProperty("EncryptKeyId")]
        public string EncryptKeyId{ get; set; }

        /// <summary>
        /// <p>Key region</p>
        /// </summary>
        [JsonProperty("EncryptRegion")]
        public string EncryptRegion{ get; set; }

        /// <summary>
        /// <p>Safe info</p>
        /// </summary>
        [JsonProperty("VaultInfos")]
        public VaultInfo[] VaultInfos{ get; set; }

        /// <summary>
        /// <p>Backup cycle policy</p>
        /// </summary>
        [JsonProperty("BackupPeriodStrategy")]
        public string BackupPeriodStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupStatus", this.BackupStatus);
            this.SetParamSimple(map, prefix + "SnapshotTime", this.SnapshotTime);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "SnapShotType", this.SnapShotType);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "CopyStatus", this.CopyStatus);
            this.SetParamSimple(map, prefix + "EncryptKeyId", this.EncryptKeyId);
            this.SetParamSimple(map, prefix + "EncryptRegion", this.EncryptRegion);
            this.SetParamArrayObj(map, prefix + "VaultInfos.", this.VaultInfos);
            this.SetParamSimple(map, prefix + "BackupPeriodStrategy", this.BackupPeriodStrategy);
        }
    }
}

