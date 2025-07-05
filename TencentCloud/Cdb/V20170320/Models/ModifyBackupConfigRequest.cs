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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv. It is the same as the instance ID displayed on the TencentDB Console page.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Backup file retention period in days. Value range: 7-1830.
        /// </summary>
        [JsonProperty("ExpireDays")]
        public long? ExpireDays{ get; set; }

        /// <summary>
        /// (This parameter will be disused. The `BackupTimeWindow` parameter is recommended.) Backup time range in the format of 02:00-06:00, with the start time and end time on the hour. Valid values: 00:00-12:00, 02:00-06:00, 06:00-10:00, 10:00-14:00, 14:00-18:00, 18:00-22:00, 22:00-02:00.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Automatic backup mode. Only `physical` (physical cold backup) is supported
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// Binlog retention period in days. Value range: 7-1830. It can’t be greater than the retention period of backup files.
        /// </summary>
        [JsonProperty("BinlogExpireDays")]
        public long? BinlogExpireDays{ get; set; }

        /// <summary>
        /// Backup time window; for example, to set up backup between 10:00 and 14:00 on every Tuesday and Sunday, you should set this parameter as follows: {"Monday": "", "Tuesday": "10:00-14:00", "Wednesday": "", "Thursday": "", "Friday": "", "Saturday": "", "Sunday": "10:00-14:00"} (Note: You can set up backup on different days, but the backup time windows need to be the same. If this field is set, the `StartTime` field will be ignored)
        /// </summary>
        [JsonProperty("BackupTimeWindow")]
        public CommonTimeWindow BackupTimeWindow{ get; set; }

        /// <summary>
        /// Switch for periodic archive. Valid values: `off` (disable), `on` (enable). Default value:`off`. When you enable the periodic archive policy for the first time, you need to enter the `BackupPeriodSaveDays`, `BackupPeriodSaveInterval`, `BackupPeriodSaveCount`, and `StartBackupPeriodSaveDate` parameters; otherwise, the policy will not take effect.
        /// </summary>
        [JsonProperty("EnableBackupPeriodSave")]
        public string EnableBackupPeriodSave{ get; set; }

        /// <summary>
        /// Switch for long-term backup retention (This field can be ignored, for its feature hasn’t been launched). Valid values: `off` (disable), `on` (enable). Default value: `off`. Once enabled, the parameters (BackupPeriodSaveDays, BackupPeriodSaveInterval, and BackupPeriodSaveCount) will be invalid.
        /// </summary>
        [JsonProperty("EnableBackupPeriodLongTermSave")]
        public string EnableBackupPeriodLongTermSave{ get; set; }

        /// <summary>
        /// Maximum days of archive backup retention. Valid range: 90-3650. Default value: 1080.
        /// </summary>
        [JsonProperty("BackupPeriodSaveDays")]
        public long? BackupPeriodSaveDays{ get; set; }

        /// <summary>
        /// Archive backup retention period. Valid values: `weekly` (a week), `monthly` (a month), `quarterly` (a quarter), `yearly` (a year). Default value: `monthly`.
        /// </summary>
        [JsonProperty("BackupPeriodSaveInterval")]
        public string BackupPeriodSaveInterval{ get; set; }

        /// <summary>
        /// Number of archive backups. Minimum value: `1`, Maximum value: Number of non-archive backups in archive backup retention period. Default value: `1`.
        /// </summary>
        [JsonProperty("BackupPeriodSaveCount")]
        public long? BackupPeriodSaveCount{ get; set; }

        /// <summary>
        /// The start time in the format of yyyy-mm-dd HH:MM:SS, which is used to enable archive backup retention policy.
        /// </summary>
        [JsonProperty("StartBackupPeriodSaveDate")]
        public string StartBackupPeriodSaveDate{ get; set; }

        /// <summary>
        /// Whether to enable the archive backup. Valid values: `off` (disable), `on` (enable). Default value: `off`.
        /// </summary>
        [JsonProperty("EnableBackupArchive")]
        public string EnableBackupArchive{ get; set; }

        /// <summary>
        /// The period (in days) of how long a data backup is retained before being archived, which falls between 180 days and the number of days from the time it is created until it expires.
        /// </summary>
        [JsonProperty("BackupArchiveDays")]
        public long? BackupArchiveDays{ get; set; }

        /// <summary>
        /// The period (in days) of how long a log backup is retained before being archived, which falls between 180 days and the number of days from the time it is created until it expires.
        /// </summary>
        [JsonProperty("BinlogArchiveDays")]
        public long? BinlogArchiveDays{ get; set; }

        /// <summary>
        /// Whether to enable the archive backup of the log. Valid values: `off` (disable), `on` (enable). Default value: `off`.
        /// </summary>
        [JsonProperty("EnableBinlogArchive")]
        public string EnableBinlogArchive{ get; set; }

        /// <summary>
        /// Whether to enable the standard storage policy for data backup. Valid values: `off` (disable), `on` (enable). Default value: `off`.
        /// </summary>
        [JsonProperty("EnableBackupStandby")]
        public string EnableBackupStandby{ get; set; }

        /// <summary>
        /// The period (in days) of how long a data backup is retained before switching to standard storage, which falls between 30 days and the number of days from the time it is created until it expires. If the archive backup is enabled, this period cannot be greater than archive backup period.
        /// </summary>
        [JsonProperty("BackupStandbyDays")]
        public long? BackupStandbyDays{ get; set; }

        /// <summary>
        /// Whether to enable the standard storage policy for log backup. Valid values: `off` (disable), `on` (enable). Default value: `off`.
        /// </summary>
        [JsonProperty("EnableBinlogStandby")]
        public string EnableBinlogStandby{ get; set; }

        /// <summary>
        /// The period (in days) of how long a log backup is retained before switching to standard storage, which falls between 30 days and the number of days from the time it is created until it expires. If the archive backup is enabled, this period cannot be greater than archive backup period.
        /// </summary>
        [JsonProperty("BinlogStandbyDays")]
        public long? BinlogStandbyDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ExpireDays", this.ExpireDays);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BinlogExpireDays", this.BinlogExpireDays);
            this.SetParamObj(map, prefix + "BackupTimeWindow.", this.BackupTimeWindow);
            this.SetParamSimple(map, prefix + "EnableBackupPeriodSave", this.EnableBackupPeriodSave);
            this.SetParamSimple(map, prefix + "EnableBackupPeriodLongTermSave", this.EnableBackupPeriodLongTermSave);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveDays", this.BackupPeriodSaveDays);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveInterval", this.BackupPeriodSaveInterval);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveCount", this.BackupPeriodSaveCount);
            this.SetParamSimple(map, prefix + "StartBackupPeriodSaveDate", this.StartBackupPeriodSaveDate);
            this.SetParamSimple(map, prefix + "EnableBackupArchive", this.EnableBackupArchive);
            this.SetParamSimple(map, prefix + "BackupArchiveDays", this.BackupArchiveDays);
            this.SetParamSimple(map, prefix + "BinlogArchiveDays", this.BinlogArchiveDays);
            this.SetParamSimple(map, prefix + "EnableBinlogArchive", this.EnableBinlogArchive);
            this.SetParamSimple(map, prefix + "EnableBackupStandby", this.EnableBackupStandby);
            this.SetParamSimple(map, prefix + "BackupStandbyDays", this.BackupStandbyDays);
            this.SetParamSimple(map, prefix + "EnableBinlogStandby", this.EnableBinlogStandby);
            this.SetParamSimple(map, prefix + "BinlogStandbyDays", this.BinlogStandbyDays);
        }
    }
}

