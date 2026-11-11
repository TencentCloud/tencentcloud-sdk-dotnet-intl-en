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
        /// <p>Specifies the instance ID. Example: crs-xjhsdj****. Log in to the <a href="https://console.cloud.tencent.com/redis">Redis console</a> and copy the instance ID in the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Set the automatic backup cycle. It can be set to Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, or Sunday. This parameter cannot be modified for the moment.</p>
        /// </summary>
        [JsonProperty("WeekDays")]
        public string[] WeekDays{ get; set; }

        /// <summary>
        /// <p>Backup time period. It can be set to every full hour. Format: 00:00-01:00, 01:00-02:00...... 23:00-00:00.</p>
        /// </summary>
        [JsonProperty("TimePeriod")]
        public string TimePeriod{ get; set; }

        /// <summary>
        /// <p>Automatic backup type. Currently, it can only be configured as: 1, scheduled backup.</p>
        /// </summary>
        [JsonProperty("AutoBackupType")]
        public long? AutoBackupType{ get; set; }

        /// <summary>
        /// <p>Number of days to save full backup files. Only support setting to 7, unit: days. For a longer period, please <a href="https://console.cloud.tencent.com/workorder/category">submit a ticket</a> to apply.</p>
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

