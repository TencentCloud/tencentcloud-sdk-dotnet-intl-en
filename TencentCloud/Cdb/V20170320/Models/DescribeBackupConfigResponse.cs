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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// Earliest start time point of automatic backup, such as 2 (for 2:00 AM). (This field has been disused. You are recommended to use the `BackupTimeWindow` field)
        /// </summary>
        [JsonProperty("StartTimeMin")]
        public long? StartTimeMin{ get; set; }

        /// <summary>
        /// Latest start time point of automatic backup, such as 6 (for 6:00 AM). (This field has been disused. You are recommended to use the `BackupTimeWindow` field)
        /// </summary>
        [JsonProperty("StartTimeMax")]
        public long? StartTimeMax{ get; set; }

        /// <summary>
        /// Backup file retention period in days.
        /// </summary>
        [JsonProperty("BackupExpireDays")]
        public long? BackupExpireDays{ get; set; }

        /// <summary>
        /// Backup mode. Value range: physical, logical
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// Binlog file retention period in days.
        /// </summary>
        [JsonProperty("BinlogExpireDays")]
        public long? BinlogExpireDays{ get; set; }

        /// <summary>
        /// Time window for automatic instance backup.
        /// </summary>
        [JsonProperty("BackupTimeWindow")]
        public CommonTimeWindow BackupTimeWindow{ get; set; }

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
            this.SetParamSimple(map, prefix + "StartTimeMin", this.StartTimeMin);
            this.SetParamSimple(map, prefix + "StartTimeMax", this.StartTimeMax);
            this.SetParamSimple(map, prefix + "BackupExpireDays", this.BackupExpireDays);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BinlogExpireDays", this.BinlogExpireDays);
            this.SetParamObj(map, prefix + "BackupTimeWindow.", this.BackupTimeWindow);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

