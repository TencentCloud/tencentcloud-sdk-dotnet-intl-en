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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAutoBackupConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of a specified instance,  such as  "crs-xjhsdj****" Log in to the [Redis console](https://console.cloud.tencent.com/redis) and copy the instance ID in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Automatic backup cycle. Valid values: `Monday`, `Tuesday`, `Wednesday`, `Thursday`, `Friday`, `Saturday`, `Sunday`. This parameter currently cannot be modified.
        /// </summary>
        [JsonProperty("WeekDays")]
        public string[] WeekDays{ get; set; }

        /// <summary>
        /// Automatic backup time in the format of 00:00-01:00, 01:00-02:00... 23:00-00:00.
        /// </summary>
        [JsonProperty("TimePeriod")]
        public string TimePeriod{ get; set; }

        /// <summary>
        /// Automatic backup type.  Valid value:  `1` (scheduled backup).
        /// </summary>
        [JsonProperty("AutoBackupType")]
        public long? AutoBackupType{ get; set; }

        /// <summary>
        /// Specifies the retention days of full backup files. unit: day.
        /// </summary>
        [JsonProperty("BackupStorageDays")]
        public long? BackupStorageDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "WeekDays.", this.WeekDays);
            this.SetParamSimple(map, prefix + "TimePeriod", this.TimePeriod);
            this.SetParamSimple(map, prefix + "AutoBackupType", this.AutoBackupType);
            this.SetParamSimple(map, prefix + "BackupStorageDays", this.BackupStorageDays);
        }
    }
}

