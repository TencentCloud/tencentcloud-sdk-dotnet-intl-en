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

    public class BackupPlan : AbstractModel
    {
        
        /// <summary>
        /// Backup cycle
        /// </summary>
        [JsonProperty("BackupPeriod")]
        public string BackupPeriod{ get; set; }

        /// <summary>
        /// Specifies the data backup retention duration in days.
        /// </summary>
        [JsonProperty("BaseBackupRetentionPeriod")]
        public ulong? BaseBackupRetentionPeriod{ get; set; }

        /// <summary>
        /// The earliest time to start a backup
        /// </summary>
        [JsonProperty("MinBackupStartTime")]
        public string MinBackupStartTime{ get; set; }

        /// <summary>
        /// The latest time to start a backup
        /// </summary>
        [JsonProperty("MaxBackupStartTime")]
        public string MaxBackupStartTime{ get; set; }

        /// <summary>
        /// Backup plan ID.
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// Specifies the custom name of the backup plan.
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// Specifies the log backup retention period in days.
        /// </summary>
        [JsonProperty("LogBackupRetentionPeriod")]
        public ulong? LogBackupRetentionPeriod{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Last modification time.
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// Backup plan type. valid values: default (created by system), custom.
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// Backup cycle type. valid values: week, month.
        /// </summary>
        [JsonProperty("BackupPeriodType")]
        public string BackupPeriodType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupPeriod", this.BackupPeriod);
            this.SetParamSimple(map, prefix + "BaseBackupRetentionPeriod", this.BaseBackupRetentionPeriod);
            this.SetParamSimple(map, prefix + "MinBackupStartTime", this.MinBackupStartTime);
            this.SetParamSimple(map, prefix + "MaxBackupStartTime", this.MaxBackupStartTime);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "LogBackupRetentionPeriod", this.LogBackupRetentionPeriod);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "BackupPeriodType", this.BackupPeriodType);
        }
    }
}

