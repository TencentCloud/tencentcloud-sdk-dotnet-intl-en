/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DescribeDBInstancesAttributeResponse : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Archive backup status. Valid values: `enable` (enabled), `disable` (disabled)
        /// </summary>
        [JsonProperty("RegularBackupEnable")]
        public string RegularBackupEnable{ get; set; }

        /// <summary>
        /// Archive backup retention period: [90-3650] days
        /// </summary>
        [JsonProperty("RegularBackupSaveDays")]
        public ulong? RegularBackupSaveDays{ get; set; }

        /// <summary>
        /// Archive backup policy. Valid values: `years` (yearly); `quarters (quarterly); `months` (monthly).
        /// </summary>
        [JsonProperty("RegularBackupStrategy")]
        public string RegularBackupStrategy{ get; set; }

        /// <summary>
        /// The number of retained archive backups
        /// </summary>
        [JsonProperty("RegularBackupCounts")]
        public ulong? RegularBackupCounts{ get; set; }

        /// <summary>
        /// Archive backup start date in YYYY-MM-DD format, which is the current time by default.
        /// </summary>
        [JsonProperty("RegularBackupStartTime")]
        public string RegularBackupStartTime{ get; set; }

        /// <summary>
        /// Block process threshold in milliseconds
        /// </summary>
        [JsonProperty("BlockedThreshold")]
        public long? BlockedThreshold{ get; set; }

        /// <summary>
        /// Retention period for the files of slow SQL, blocking, deadlock, and extended events.
        /// </summary>
        [JsonProperty("EventSaveDays")]
        public long? EventSaveDays{ get; set; }

        /// <summary>
        /// TDE u200dconfiguration
        /// </summary>
        [JsonProperty("TDEConfig")]
        public TDEConfigAttribute TDEConfig{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RegularBackupEnable", this.RegularBackupEnable);
            this.SetParamSimple(map, prefix + "RegularBackupSaveDays", this.RegularBackupSaveDays);
            this.SetParamSimple(map, prefix + "RegularBackupStrategy", this.RegularBackupStrategy);
            this.SetParamSimple(map, prefix + "RegularBackupCounts", this.RegularBackupCounts);
            this.SetParamSimple(map, prefix + "RegularBackupStartTime", this.RegularBackupStartTime);
            this.SetParamSimple(map, prefix + "BlockedThreshold", this.BlockedThreshold);
            this.SetParamSimple(map, prefix + "EventSaveDays", this.EventSaveDays);
            this.SetParamObj(map, prefix + "TDEConfig.", this.TDEConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

