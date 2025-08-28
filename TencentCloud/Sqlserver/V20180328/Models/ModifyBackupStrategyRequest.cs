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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Backup type. Valid values: `weekly` (when length(BackupDay) <=7 && length(BackupDay) >=2), `daily` (when length(BackupDay)=1). Default value: `daily`.
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// Backup time. Value range: an integer from 0 to 23.
        /// </summary>
        [JsonProperty("BackupTime")]
        public ulong? BackupTime{ get; set; }

        /// <summary>
        /// Backup interval in days when the `BackupType` is `daily`. Valid value: 1.
        /// </summary>
        [JsonProperty("BackupDay")]
        public ulong? BackupDay{ get; set; }

        /// <summary>
        /// Backup mode. Valid values: `master_pkg` (archive the backup files of the primary node), `master_no_pkg` (do not archive the backup files of the primary node), `slave_pkg` (archive the backup files of the replica node), `slave_no_pkg` (do not archive the backup files of the replica node). Backup files of the replica node are supported only when Always On disaster recovery is enabled.
        /// </summary>
        [JsonProperty("BackupModel")]
        public string BackupModel{ get; set; }

        /// <summary>
        /// The days of the week on which backup will be performed when "BackupType" is `weekly`. If data backup retention period is less than 7 days, the values will be 1-7, indicating that backup will be performed everyday by default; if data backup retention period is greater than or equal to 7 days, the values will be at least any two days, indicating that backup will be performed at least twice in a week by default.
        /// </summary>
        [JsonProperty("BackupCycle")]
        public ulong?[] BackupCycle{ get; set; }

        /// <summary>
        /// Data (log) backup retention period. Value range: 3-1830 days, default value: 7 days.
        /// </summary>
        [JsonProperty("BackupSaveDays")]
        public ulong? BackupSaveDays{ get; set; }

        /// <summary>
        /// Archive backup status. Valid values: `enable` (enabled); `disable` (disabled). Default value: `disable`.
        /// </summary>
        [JsonProperty("RegularBackupEnable")]
        public string RegularBackupEnable{ get; set; }

        /// <summary>
        /// Archive backup retention days. Value range: 90-3650 days. Default value: 365 days.
        /// </summary>
        [JsonProperty("RegularBackupSaveDays")]
        public ulong? RegularBackupSaveDays{ get; set; }

        /// <summary>
        /// Archive backup policy. Valid values: `years` (yearly); `quarters (quarterly); `months` (monthly); Default value: `months`.
        /// </summary>
        [JsonProperty("RegularBackupStrategy")]
        public string RegularBackupStrategy{ get; set; }

        /// <summary>
        /// The number of retained archive backups. Default value: `1`.
        /// </summary>
        [JsonProperty("RegularBackupCounts")]
        public ulong? RegularBackupCounts{ get; set; }

        /// <summary>
        /// Archive backup start date in YYYY-MM-DD format, which is the current time by default.
        /// </summary>
        [JsonProperty("RegularBackupStartTime")]
        public string RegularBackupStartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "BackupDay", this.BackupDay);
            this.SetParamSimple(map, prefix + "BackupModel", this.BackupModel);
            this.SetParamArraySimple(map, prefix + "BackupCycle.", this.BackupCycle);
            this.SetParamSimple(map, prefix + "BackupSaveDays", this.BackupSaveDays);
            this.SetParamSimple(map, prefix + "RegularBackupEnable", this.RegularBackupEnable);
            this.SetParamSimple(map, prefix + "RegularBackupSaveDays", this.RegularBackupSaveDays);
            this.SetParamSimple(map, prefix + "RegularBackupStrategy", this.RegularBackupStrategy);
            this.SetParamSimple(map, prefix + "RegularBackupCounts", this.RegularBackupCounts);
            this.SetParamSimple(map, prefix + "RegularBackupStartTime", this.RegularBackupStartTime);
        }
    }
}

