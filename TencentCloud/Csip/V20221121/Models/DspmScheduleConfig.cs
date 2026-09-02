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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmScheduleConfig : AbstractModel
    {
        
        /// <summary>
        /// Scheduling type: daily, weekly, monthly
        /// </summary>
        [JsonProperty("ScheduleType")]
        public string ScheduleType{ get; set; }

        /// <summary>
        /// If not passed, the day is used for daily scheduling. For weekly scheduling configuration (day of the week (1=Monday, ..., 7=Sunday)), for monthly scheduling configuration (day of the month (1-31)).
        /// </summary>
        [JsonProperty("Day")]
        public ulong? Day{ get; set; }

        /// <summary>
        /// Scheduling time configuration
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Time zone. Default: UTC+8 (Asia/Shanghai)
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamSimple(map, prefix + "Day", this.Day);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

