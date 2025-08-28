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

    public class ModifyCrossBackupStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// Cross-region backup switch (data backup & log backup). enable - enabled; disable - disabled.
        /// </summary>
        [JsonProperty("CrossBackupEnabled")]
        public string CrossBackupEnabled{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance ID list.
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// Retention days for cross-region backups. Value range: 7-1830. The default value is 7.
        /// </summary>
        [JsonProperty("CrossBackupSaveDays")]
        public ulong? CrossBackupSaveDays{ get; set; }

        /// <summary>
        /// Target region ID for cross-region backups, with a maximum of two and a minimum of one.
        /// </summary>
        [JsonProperty("CrossBackupRegion")]
        public string[] CrossBackupRegion{ get; set; }

        /// <summary>
        /// Whether to clean up cross-region backups (data backups & log backups) immediately. This parameter is only valid when the value of BackupEnabled is disabled. 1 - yes; 0 - no. The default value is 0.
        /// </summary>
        [JsonProperty("CleanUpCrossBackup")]
        public ulong? CleanUpCrossBackup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CrossBackupEnabled", this.CrossBackupEnabled);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "CrossBackupSaveDays", this.CrossBackupSaveDays);
            this.SetParamArraySimple(map, prefix + "CrossBackupRegion.", this.CrossBackupRegion);
            this.SetParamSimple(map, prefix + "CleanUpCrossBackup", this.CleanUpCrossBackup);
        }
    }
}

