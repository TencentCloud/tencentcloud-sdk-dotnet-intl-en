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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonTimeWindow : AbstractModel
    {
        
        /// <summary>
        /// Time window on Monday in the format of 02:00-06:00
        /// </summary>
        [JsonProperty("Monday")]
        public string Monday{ get; set; }

        /// <summary>
        /// Time window on Tuesday in the format of 02:00-06:00
        /// </summary>
        [JsonProperty("Tuesday")]
        public string Tuesday{ get; set; }

        /// <summary>
        /// Time window on Wednesday in the format of 02:00-06:00
        /// </summary>
        [JsonProperty("Wednesday")]
        public string Wednesday{ get; set; }

        /// <summary>
        /// Time window on Thursday in the format of 02:00-06:00
        /// </summary>
        [JsonProperty("Thursday")]
        public string Thursday{ get; set; }

        /// <summary>
        /// Time window on Friday in the format of 02:00-06:00
        /// </summary>
        [JsonProperty("Friday")]
        public string Friday{ get; set; }

        /// <summary>
        /// Time window on Saturday in the format of 02:00-06:00
        /// </summary>
        [JsonProperty("Saturday")]
        public string Saturday{ get; set; }

        /// <summary>
        /// Time window on Sunday in the format of 02:00-06:00
        /// </summary>
        [JsonProperty("Sunday")]
        public string Sunday{ get; set; }

        /// <summary>
        /// Non-archive backup retention policy. Valid values: `weekly` (back up by week), monthly (back up by month), default value: `weekly`.
        /// </summary>
        [JsonProperty("BackupPeriodStrategy")]
        public string BackupPeriodStrategy{ get; set; }

        /// <summary>
        /// If `BackupPeriodStrategy` is `monthly`, you need to pass in the specific backup dates. The time interval between any two adjacent dates cannot exceed 2 days, for example, [1,4,7,9,11,14,17,19,22,25,28,30,31].
        /// </summary>
        [JsonProperty("Days")]
        public long?[] Days{ get; set; }

        /// <summary>
        /// Backup time by month in the format of 02:00–06:00, which is required when `BackupPeriodStrategy` is `monthly`.
        /// </summary>
        [JsonProperty("BackupPeriodTime")]
        public string BackupPeriodTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Monday", this.Monday);
            this.SetParamSimple(map, prefix + "Tuesday", this.Tuesday);
            this.SetParamSimple(map, prefix + "Wednesday", this.Wednesday);
            this.SetParamSimple(map, prefix + "Thursday", this.Thursday);
            this.SetParamSimple(map, prefix + "Friday", this.Friday);
            this.SetParamSimple(map, prefix + "Saturday", this.Saturday);
            this.SetParamSimple(map, prefix + "Sunday", this.Sunday);
            this.SetParamSimple(map, prefix + "BackupPeriodStrategy", this.BackupPeriodStrategy);
            this.SetParamArraySimple(map, prefix + "Days.", this.Days);
            this.SetParamSimple(map, prefix + "BackupPeriodTime", this.BackupPeriodTime);
        }
    }
}

