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

    public class ModifyBackupPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. obtain through the api [DescribeDBInstances](https://www.tencentcloud.com/document/api/409/16773?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

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
        /// Backup retention period in days. Value range: 7-1830
        /// </summary>
        [JsonProperty("BaseBackupRetentionPeriod")]
        public ulong? BaseBackupRetentionPeriod{ get; set; }

        /// <summary>
        /// Instance backup period. if by week, format is lowercase english word of week and set at least two days for backup. if by month, format is digits such as ["1","2"].
        /// </summary>
        [JsonProperty("BackupPeriod")]
        public string[] BackupPeriod{ get; set; }

        /// <summary>
        /// Instance log backup retention duration, with a value range of 7-1830 and a unit of day
        /// </summary>
        [JsonProperty("LogBackupRetentionPeriod")]
        public ulong? LogBackupRetentionPeriod{ get; set; }

        /// <summary>
        /// Backup plan ID. specifies which backup plan to modify. if left empty, the default backup plan will be modified.
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// Specifies the name of the backup plan to modify.
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "MinBackupStartTime", this.MinBackupStartTime);
            this.SetParamSimple(map, prefix + "MaxBackupStartTime", this.MaxBackupStartTime);
            this.SetParamSimple(map, prefix + "BaseBackupRetentionPeriod", this.BaseBackupRetentionPeriod);
            this.SetParamArraySimple(map, prefix + "BackupPeriod.", this.BackupPeriod);
            this.SetParamSimple(map, prefix + "LogBackupRetentionPeriod", this.LogBackupRetentionPeriod);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
        }
    }
}

