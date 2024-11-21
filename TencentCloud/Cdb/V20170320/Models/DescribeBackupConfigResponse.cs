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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// Earliest start time point of automatic backup, such as 2 (for 2:00 AM). (This field has been disused. You are recommended to use the `BackupTimeWindow` field)
        /// </summary>
        [JsonProperty("StartTimeMin")]
        public long? StartTimeMin{ get; set; }

        /// <summary>
        /// Latest start time point of automatic backup, such as 6 (for 6:00 AM). (This field has been disused. You are recommended to use the `BackupTimeWindow` field)
        /// </summary>
        [JsonProperty("StartTimeMax")]
        public long? StartTimeMax{ get; set; }

        /// <summary>
        /// Backup file retention period in days.
        /// </summary>
        [JsonProperty("BackupExpireDays")]
        public long? BackupExpireDays{ get; set; }

        /// <summary>
        /// Backup mode. Value range: physical, logical
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// Binlog file retention period in days.
        /// </summary>
        [JsonProperty("BinlogExpireDays")]
        public long? BinlogExpireDays{ get; set; }

        /// <summary>
        /// Time window for automatic instance backup.
        /// </summary>
        [JsonProperty("BackupTimeWindow")]
        public CommonTimeWindow BackupTimeWindow{ get; set; }

        /// <summary>
        /// Switch for archive backup retention. Valid values: `off` (disable), `on` (enable). Default value:`off`.
        /// </summary>
        [JsonProperty("EnableBackupPeriodSave")]
        public string EnableBackupPeriodSave{ get; set; }

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
        /// The start time in the format: yyyy-mm-dd HH:MM:SS, which is used to enable archive backup retention policy.
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
        /// Whether to enable the archive backup of logs. Valid values: `off` (disable), `on` (enable). Default value: `off`.
        /// </summary>
        [JsonProperty("EnableBinlogArchive")]
        public string EnableBinlogArchive{ get; set; }

        /// <summary>
        /// The period (in days) of how long a log backup is retained before being archived, which falls between 180 days and the number of days from the time it is created until it expires.
        /// </summary>
        [JsonProperty("BinlogArchiveDays")]
        public long? BinlogArchiveDays{ get; set; }

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
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeMin", this.StartTimeMin);
            this.SetParamSimple(map, prefix + "StartTimeMax", this.StartTimeMax);
            this.SetParamSimple(map, prefix + "BackupExpireDays", this.BackupExpireDays);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BinlogExpireDays", this.BinlogExpireDays);
            this.SetParamObj(map, prefix + "BackupTimeWindow.", this.BackupTimeWindow);
            this.SetParamSimple(map, prefix + "EnableBackupPeriodSave", this.EnableBackupPeriodSave);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveDays", this.BackupPeriodSaveDays);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveInterval", this.BackupPeriodSaveInterval);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveCount", this.BackupPeriodSaveCount);
            this.SetParamSimple(map, prefix + "StartBackupPeriodSaveDate", this.StartBackupPeriodSaveDate);
            this.SetParamSimple(map, prefix + "EnableBackupArchive", this.EnableBackupArchive);
            this.SetParamSimple(map, prefix + "BackupArchiveDays", this.BackupArchiveDays);
            this.SetParamSimple(map, prefix + "EnableBinlogArchive", this.EnableBinlogArchive);
            this.SetParamSimple(map, prefix + "BinlogArchiveDays", this.BinlogArchiveDays);
            this.SetParamSimple(map, prefix + "EnableBackupStandby", this.EnableBackupStandby);
            this.SetParamSimple(map, prefix + "BackupStandbyDays", this.BackupStandbyDays);
            this.SetParamSimple(map, prefix + "EnableBinlogStandby", this.EnableBinlogStandby);
            this.SetParamSimple(map, prefix + "BinlogStandbyDays", this.BinlogStandbyDays);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

