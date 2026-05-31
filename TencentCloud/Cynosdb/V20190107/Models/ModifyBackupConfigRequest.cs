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

    public class ModifyBackupConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Indicates the full backup start time, [0-24*3600]. For example, 0:00, 1:00, and 2:00 are 0, 3600, and 7200 respectively.</p>
        /// </summary>
        [JsonProperty("BackupTimeBeg")]
        public ulong? BackupTimeBeg{ get; set; }

        /// <summary>
        /// <p>Indicates the full backup end time, [0-24*3600]. For example, 0:00, 1:00, and 2:00 are 0, 3600, and 7200 respectively.</p>
        /// </summary>
        [JsonProperty("BackupTimeEnd")]
        public ulong? BackupTimeEnd{ get; set; }

        /// <summary>
        /// <p>Indicates the backup retention period in seconds. Backups will be cleaned up longer than this time. Seven days is represented as 3600<em>24</em>7=604800. The maximum value is 158112000.</p>
        /// </summary>
        [JsonProperty("ReserveDuration")]
        public ulong? ReserveDuration{ get; set; }

        /// <summary>
        /// <p>This parameter currently does not support modification and is not required. Backup frequency is an array of length 7, corresponding to Monday to Sunday backup method, full-full backup, increment-incremental backup.</p>
        /// </summary>
        [JsonProperty("BackupFreq")]
        public string[] BackupFreq{ get; set; }

        /// <summary>
        /// <p>This parameter currently does not support modification. No need to specify.</p>
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// <p>Logical backup configuration</p>
        /// </summary>
        [JsonProperty("LogicBackupConfig")]
        public LogicBackupConfigInfo LogicBackupConfig{ get; set; }

        /// <summary>
        /// <p>Whether to delete automatic logical backup</p>
        /// </summary>
        [JsonProperty("DeleteAutoLogicBackup")]
        public bool? DeleteAutoLogicBackup{ get; set; }

        /// <summary>
        /// <p>Second-level snapshot backup parameter</p>
        /// </summary>
        [JsonProperty("SnapshotSecondaryBackupConfig")]
        public SnapshotBackupConfig SnapshotSecondaryBackupConfig{ get; set; }

        /// <summary>
        /// <p>Sparse backup configuration</p>
        /// </summary>
        [JsonProperty("SparseBackupConfig")]
        public SparseBackupConfig SparseBackupConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "BackupTimeBeg", this.BackupTimeBeg);
            this.SetParamSimple(map, prefix + "BackupTimeEnd", this.BackupTimeEnd);
            this.SetParamSimple(map, prefix + "ReserveDuration", this.ReserveDuration);
            this.SetParamArraySimple(map, prefix + "BackupFreq.", this.BackupFreq);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamObj(map, prefix + "LogicBackupConfig.", this.LogicBackupConfig);
            this.SetParamSimple(map, prefix + "DeleteAutoLogicBackup", this.DeleteAutoLogicBackup);
            this.SetParamObj(map, prefix + "SnapshotSecondaryBackupConfig.", this.SnapshotSecondaryBackupConfig);
            this.SetParamObj(map, prefix + "SparseBackupConfig.", this.SparseBackupConfig);
        }
    }
}

