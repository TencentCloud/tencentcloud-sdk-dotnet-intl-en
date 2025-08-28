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

    public class DescribeRegularBackupPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Scheduled backup retention days, in the range of [90 - 3650]. The default value is 365.
        /// </summary>
        [JsonProperty("RegularBackupSaveDays")]
        public ulong? RegularBackupSaveDays{ get; set; }

        /// <summary>
        /// Scheduled backup policy. years - annually; quarters - quarterly; months - monthly. The default value is months.
        /// </summary>
        [JsonProperty("RegularBackupStrategy")]
        public string RegularBackupStrategy{ get; set; }

        /// <summary>
        /// Number of retained scheduled backups. The default value is 1.
        /// </summary>
        [JsonProperty("RegularBackupCounts")]
        public ulong? RegularBackupCounts{ get; set; }

        /// <summary>
        /// Scheduled backup start date, in the format of YYYY-MM-DD. The current date is used by default.
        /// </summary>
        [JsonProperty("RegularBackupStartTime")]
        public string RegularBackupStartTime{ get; set; }

        /// <summary>
        /// Regular backup cycle.
        /// </summary>
        [JsonProperty("BackupCycle")]
        public ulong?[] BackupCycle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RegularBackupSaveDays", this.RegularBackupSaveDays);
            this.SetParamSimple(map, prefix + "RegularBackupStrategy", this.RegularBackupStrategy);
            this.SetParamSimple(map, prefix + "RegularBackupCounts", this.RegularBackupCounts);
            this.SetParamSimple(map, prefix + "RegularBackupStartTime", this.RegularBackupStartTime);
            this.SetParamArraySimple(map, prefix + "BackupCycle.", this.BackupCycle);
        }
    }
}

