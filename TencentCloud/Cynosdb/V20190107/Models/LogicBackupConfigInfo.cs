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

    public class LogicBackupConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether automatic logical backup is enabled</p>
        /// </summary>
        [JsonProperty("LogicBackupEnable")]
        public string LogicBackupEnable{ get; set; }

        /// <summary>
        /// <p>Automatic logic backup start time</p>
        /// </summary>
        [JsonProperty("LogicBackupTimeBeg")]
        public ulong? LogicBackupTimeBeg{ get; set; }

        /// <summary>
        /// <p>Automated logic backup end time</p>
        /// </summary>
        [JsonProperty("LogicBackupTimeEnd")]
        public ulong? LogicBackupTimeEnd{ get; set; }

        /// <summary>
        /// <p>Automatic logical backup retention time<br>Unit: second</p>
        /// </summary>
        [JsonProperty("LogicReserveDuration")]
        public ulong? LogicReserveDuration{ get; set; }

        /// <summary>
        /// <p>Whether cross-regional logical backup is enabled<br>Available values: ON/OFF</p>
        /// </summary>
        [JsonProperty("LogicCrossRegionsEnable")]
        public string LogicCrossRegionsEnable{ get; set; }

        /// <summary>
        /// <p>Cross-regional logic backup</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogicCrossRegions")]
        public string[] LogicCrossRegions{ get; set; }

        /// <summary>
        /// <p>Backup delivery relationship</p>
        /// </summary>
        [JsonProperty("AutoCopyVaults")]
        public CreateBackupVaultItem[] AutoCopyVaults{ get; set; }

        /// <summary>
        /// <p>Day</p><p>Unit: Cross-regional logical backup retention time</p>
        /// </summary>
        [JsonProperty("LogicCrossRegionSaveDays")]
        public long? LogicCrossRegionSaveDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogicBackupEnable", this.LogicBackupEnable);
            this.SetParamSimple(map, prefix + "LogicBackupTimeBeg", this.LogicBackupTimeBeg);
            this.SetParamSimple(map, prefix + "LogicBackupTimeEnd", this.LogicBackupTimeEnd);
            this.SetParamSimple(map, prefix + "LogicReserveDuration", this.LogicReserveDuration);
            this.SetParamSimple(map, prefix + "LogicCrossRegionsEnable", this.LogicCrossRegionsEnable);
            this.SetParamArraySimple(map, prefix + "LogicCrossRegions.", this.LogicCrossRegions);
            this.SetParamArrayObj(map, prefix + "AutoCopyVaults.", this.AutoCopyVaults);
            this.SetParamSimple(map, prefix + "LogicCrossRegionSaveDays", this.LogicCrossRegionSaveDays);
        }
    }
}

