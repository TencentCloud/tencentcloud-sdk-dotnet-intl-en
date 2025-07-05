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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RansomDefenseBackup : AbstractModel
    {
        
        /// <summary>
        /// Backup time
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }

        /// <summary>
        /// Ransom Status: 0 - No Alarm, 1 - Alarm Present
        /// </summary>
        [JsonProperty("EventStatus")]
        public ulong? EventStatus{ get; set; }

        /// <summary>
        /// Backup Status: 0 - Backing up, 1 - Normal, 2, 3 - Failed, 4 - Snapshot expired, 9 - Snapshot deleted
        /// </summary>
        [JsonProperty("BackupStatus")]
        public ulong? BackupStatus{ get; set; }

        /// <summary>
        /// Number of backup disk
        /// </summary>
        [JsonProperty("DiskCount")]
        public ulong? DiskCount{ get; set; }

        /// <summary>
        /// Hard Disk Information, separated by semicolons (;).
        /// </summary>
        [JsonProperty("Disks")]
        public string Disks{ get; set; }

        /// <summary>
        /// Snapshot List, separated by semicolons (;)
        /// </summary>
        [JsonProperty("SnapshotIds")]
        public string SnapshotIds{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// Policy Status: 0 Disabled, 1 Enabled, 9 Deleted
        /// </summary>
        [JsonProperty("StrategyStatus")]
        public ulong? StrategyStatus{ get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "EventStatus", this.EventStatus);
            this.SetParamSimple(map, prefix + "BackupStatus", this.BackupStatus);
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "Disks", this.Disks);
            this.SetParamSimple(map, prefix + "SnapshotIds", this.SnapshotIds);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "StrategyStatus", this.StrategyStatus);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
        }
    }
}

