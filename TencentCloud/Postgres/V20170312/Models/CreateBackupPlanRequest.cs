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

    public class CreateBackupPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. obtain through the api [DescribeDBInstances](https://www.tencentcloud.com/document/product/409/16773?lang=en).
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// Specifies the name of the backup plan.
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// Specifies the schedule type of the backup created. currently only support month.
        /// </summary>
        [JsonProperty("BackupPeriodType")]
        public string BackupPeriodType{ get; set; }

        /// <summary>
        /// Backup date. example: enable backup on the 2nd of every month.
        /// </summary>
        [JsonProperty("BackupPeriod")]
        public string[] BackupPeriod{ get; set; }

        /// <summary>
        /// Specifies the backup start time. if not passed, it follows the default backup plan.
        /// </summary>
        [JsonProperty("MinBackupStartTime")]
        public string MinBackupStartTime{ get; set; }

        /// <summary>
        /// Backup end time. follows the default plan if not specified.
        /// </summary>
        [JsonProperty("MaxBackupStartTime")]
        public string MaxBackupStartTime{ get; set; }

        /// <summary>
        /// Specifies the data backup retention duration in days. value range: [0,30000).
        /// BackupPeriodType defaults to 7 when set to week and 31 when set to month.
        /// </summary>
        [JsonProperty("BaseBackupRetentionPeriod")]
        public ulong? BaseBackupRetentionPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "BackupPeriodType", this.BackupPeriodType);
            this.SetParamArraySimple(map, prefix + "BackupPeriod.", this.BackupPeriod);
            this.SetParamSimple(map, prefix + "MinBackupStartTime", this.MinBackupStartTime);
            this.SetParamSimple(map, prefix + "MaxBackupStartTime", this.MaxBackupStartTime);
            this.SetParamSimple(map, prefix + "BaseBackupRetentionPeriod", this.BaseBackupRetentionPeriod);
        }
    }
}

