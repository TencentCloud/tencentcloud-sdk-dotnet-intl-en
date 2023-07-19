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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAutoBackupConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// This parameter is retained due to compatibility and can be ignored.
        /// </summary>
        [JsonProperty("AutoBackupType")]
        public long? AutoBackupType{ get; set; }

        /// <summary>
        /// Backup cycle, which will be daily by default. Valid values: `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday`.
        /// </summary>
        [JsonProperty("WeekDays")]
        public string[] WeekDays{ get; set; }

        /// <summary>
        /// Time period for backup task initialization
        /// </summary>
        [JsonProperty("TimePeriod")]
        public string TimePeriod{ get; set; }

        /// <summary>
        /// Retention time of full backup files in days.  Default value: `7`.  To retain the files for more days, [submit a ticket](https://console.cloud.tencent.com/workorder/category) for application.
        /// </summary>
        [JsonProperty("BackupStorageDays")]
        public long? BackupStorageDays{ get; set; }

        /// <summary>
        /// This parameter has been disused.
        /// </summary>
        [JsonProperty("BinlogStorageDays")]
        public long? BinlogStorageDays{ get; set; }

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
            this.SetParamSimple(map, prefix + "AutoBackupType", this.AutoBackupType);
            this.SetParamArraySimple(map, prefix + "WeekDays.", this.WeekDays);
            this.SetParamSimple(map, prefix + "TimePeriod", this.TimePeriod);
            this.SetParamSimple(map, prefix + "BackupStorageDays", this.BackupStorageDays);
            this.SetParamSimple(map, prefix + "BinlogStorageDays", this.BinlogStorageDays);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

