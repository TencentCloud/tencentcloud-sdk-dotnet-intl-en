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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeDBInstanceMajorVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// Target kernel version number, where upgradeable target kernel version numbers can be acquired through API DescribeDBVersions.
        /// </summary>
        [JsonProperty("TargetDBKernelVersion")]
        public string TargetDBKernelVersion{ get; set; }

        /// <summary>
        /// Whether it is verification mode: if UpgradeCheck is True, it means only kernel version compatibility check will be conducted, without actual upgrade operations, and there will be no affect on the original instance. The check results can be viewed through the upgrade logs.
        /// </summary>
        [JsonProperty("UpgradeCheck")]
        public bool? UpgradeCheck{ get; set; }

        /// <summary>
        /// Pre-upgrade backup option: True means a full backup is required before upgrade, and False means a full backup is not required before upgrade. If there is an existing backup set that can restore the instance to its pre-upgrade state, False can be selected; otherwise, True should be specified. This parameter is invalid when UpgradeCheck is True.
        /// </summary>
        [JsonProperty("BackupBeforeUpgrade")]
        public bool? BackupBeforeUpgrade{ get; set; }

        /// <summary>
        /// Statistics collection option, which is used to run ANALYZE on the primary instance to update system statistics after the upgrade. Valid values include:
        /// 0: No statistics collection required;
        /// 1: Collect statistics before instance recovery write;
        /// 3: Collect statistics after instance recovery write.
        /// This parameter is invalid when UpgradeCheck is True.
        /// </summary>
        [JsonProperty("StatisticsRefreshOption")]
        public long? StatisticsRefreshOption{ get; set; }

        /// <summary>
        /// Plugin upgrade option. pg_upgrade does not upgrade any plugins, and "ALTER EXTENSION UPDATE" needs to be executed on the database where the plugins were created after the upgrade. When initiating a major version upgrade of an instance, you can specify whether the upgrade task automatically upgrades the plugin version before/after the instance recovery write. Valid values include:
        /// 0: No automatic plugin upgrade required;
        /// 1: Upgrade plugins before recovery write;
        /// 2: Upgrade plugins after recovery write.
        /// This parameter is invalid when UpgradeCheck is True.
        /// </summary>
        [JsonProperty("ExtensionUpgradeOption")]
        public long? ExtensionUpgradeOption{ get; set; }

        /// <summary>
        /// Upgrade time option. During the upgrade process, there will be a period when the instance is read-only, and there will be a second-level flash disconnection. When initiating an upgrade, you need to choose the time window for this impact. Valid values include:
        /// 0: Execute automatically, no specific time window required;
        /// 1: Specify the time window for this upgrade task, which is set via UpgradeTimeBegin and UpgradeTimeEnd parameters;
        /// 2: Execute during the instance operation and maintenance time window.
        /// This parameter is invalid when UpgradeCheck is True.
        /// </summary>
        [JsonProperty("UpgradeTimeOption")]
        public long? UpgradeTimeOption{ get; set; }

        /// <summary>
        /// Upgrade window start time, and the time format is HH:MM:SS, for example: 01:00:00. This parameter is valid when UpgradeTimeOption is set to `1`.
        /// This parameter is invalid when UpgradeCheck is True.
        /// </summary>
        [JsonProperty("UpgradeTimeBegin")]
        public string UpgradeTimeBegin{ get; set; }

        /// <summary>
        /// Upgrade window end time, and the time format is HH:MM:SS, for example: 2:00:00 AM. This parameter is valid when UpgradeTimeOption is set to `1`.
        /// This parameter is invalid when UpgradeCheck is True.
        /// </summary>
        [JsonProperty("UpgradeTimeEnd")]
        public string UpgradeTimeEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "TargetDBKernelVersion", this.TargetDBKernelVersion);
            this.SetParamSimple(map, prefix + "UpgradeCheck", this.UpgradeCheck);
            this.SetParamSimple(map, prefix + "BackupBeforeUpgrade", this.BackupBeforeUpgrade);
            this.SetParamSimple(map, prefix + "StatisticsRefreshOption", this.StatisticsRefreshOption);
            this.SetParamSimple(map, prefix + "ExtensionUpgradeOption", this.ExtensionUpgradeOption);
            this.SetParamSimple(map, prefix + "UpgradeTimeOption", this.UpgradeTimeOption);
            this.SetParamSimple(map, prefix + "UpgradeTimeBegin", this.UpgradeTimeBegin);
            this.SetParamSimple(map, prefix + "UpgradeTimeEnd", this.UpgradeTimeEnd);
        }
    }
}

