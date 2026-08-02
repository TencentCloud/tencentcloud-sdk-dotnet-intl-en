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

    public class BackupConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>System automation time</p>
        /// </summary>
        [JsonProperty("BackupCustomAutoTime")]
        public bool? BackupCustomAutoTime{ get; set; }

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
        /// <p>This parameter currently does not support modification and is not required. Backup frequency is an array of length 7, corresponding to the backup method from Sunday to Saturday, full-full backup, increment-incremental backup.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupWeekDays")]
        public string[] BackupWeekDays{ get; set; }

        /// <summary>
        /// <p>Interval</p>
        /// </summary>
        [JsonProperty("BackupIntervalTime")]
        public long? BackupIntervalTime{ get; set; }

        /// <summary>
        /// <p>Indicates the backup retention period in seconds. Backups will be cleaned up longer than this time. 7 days means 3600*24*7=604800. The maximum value is 158112000.</p>
        /// </summary>
        [JsonProperty("ReserveDuration")]
        public ulong? ReserveDuration{ get; set; }

        /// <summary>
        /// <p>Cross-region backup enabled<br>yes-Enable<br>no-Disable</p>
        /// </summary>
        [JsonProperty("CrossRegionsEnable")]
        public string CrossRegionsEnable{ get; set; }

        /// <summary>
        /// <p>Cross-regional backup region</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CrossRegions")]
        public string[] CrossRegions{ get; set; }

        /// <summary>
        /// <p>Cross-region backup retention period</p><p>Unit: Day</p>
        /// </summary>
        [JsonProperty("CrossRegionSaveDays")]
        public long? CrossRegionSaveDays{ get; set; }

        /// <summary>
        /// <p>Automatic data backup trigger policy, periodically: automatic periodic backup, frequent: high frequency backup</p>
        /// </summary>
        [JsonProperty("BackupTriggerStrategy")]
        public string BackupTriggerStrategy{ get; set; }

        /// <summary>
        /// <p>Backup delivery relationship</p>
        /// </summary>
        [JsonProperty("AutoCopyVaults")]
        public CreateBackupVaultItem[] AutoCopyVaults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupCustomAutoTime", this.BackupCustomAutoTime);
            this.SetParamSimple(map, prefix + "BackupTimeBeg", this.BackupTimeBeg);
            this.SetParamSimple(map, prefix + "BackupTimeEnd", this.BackupTimeEnd);
            this.SetParamArraySimple(map, prefix + "BackupWeekDays.", this.BackupWeekDays);
            this.SetParamSimple(map, prefix + "BackupIntervalTime", this.BackupIntervalTime);
            this.SetParamSimple(map, prefix + "ReserveDuration", this.ReserveDuration);
            this.SetParamSimple(map, prefix + "CrossRegionsEnable", this.CrossRegionsEnable);
            this.SetParamArraySimple(map, prefix + "CrossRegions.", this.CrossRegions);
            this.SetParamSimple(map, prefix + "CrossRegionSaveDays", this.CrossRegionSaveDays);
            this.SetParamSimple(map, prefix + "BackupTriggerStrategy", this.BackupTriggerStrategy);
            this.SetParamArrayObj(map, prefix + "AutoCopyVaults.", this.AutoCopyVaults);
        }
    }
}

