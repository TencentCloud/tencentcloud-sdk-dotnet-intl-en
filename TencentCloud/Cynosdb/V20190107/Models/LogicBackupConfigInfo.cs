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
        /// Whether automatic logical backup is enabled.
        /// </summary>
        [JsonProperty("LogicBackupEnable")]
        public string LogicBackupEnable{ get; set; }

        /// <summary>
        /// Specifies the automatic logic backup start time.
        /// </summary>
        [JsonProperty("LogicBackupTimeBeg")]
        public ulong? LogicBackupTimeBeg{ get; set; }

        /// <summary>
        /// Specifies the termination time of automatic logical backup.
        /// </summary>
        [JsonProperty("LogicBackupTimeEnd")]
        public ulong? LogicBackupTimeEnd{ get; set; }

        /// <summary>
        /// Automatic logical backup retention time.
        /// Unit: seconds.
        /// </summary>
        [JsonProperty("LogicReserveDuration")]
        public ulong? LogicReserveDuration{ get; set; }

        /// <summary>
        /// Is cross-regional logical backup enabled?.
        /// Valid values: ON/OFF.
        /// </summary>
        [JsonProperty("LogicCrossRegionsEnable")]
        public string LogicCrossRegionsEnable{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LogicCrossRegions")]
        public string[] LogicCrossRegions{ get; set; }

        /// <summary>
        /// Backup delivery relationship
        /// </summary>
        [JsonProperty("AutoCopyVaults")]
        public CreateBackupVaultItem[] AutoCopyVaults{ get; set; }


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
        }
    }
}

