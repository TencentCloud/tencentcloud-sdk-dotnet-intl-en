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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimeOutStrategyInfo : AbstractModel
    {
        
        /// <summary>
        /// Timeout Alarm Configuration
        /// 
        /// Expected Execution Duration Timeout - The actual runtime exceeds the estimated execution duration.
        /// 
        /// Expected Completion Time Timeout - The task has not completed by the estimated completion time.
        /// 
        /// Expected Scheduling Wait Timeout - The waiting time in the scheduling queue exceeds the estimated wait time.
        /// 
        /// Cycle-Incomplete Timeout - The task was expected to complete within its scheduled cycle but did not.
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// Timeout Value Configuration Type
        /// 
        /// 1: Fixed value (specified manually)
        /// 
        /// 2: Average value (calculated automatically)
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Timeout Specified Value (hours) - The timeout threshold in hours. Default is 1.
        /// </summary>
        [JsonProperty("Hour")]
        public ulong? Hour{ get; set; }

        /// <summary>
        /// Timeout Specified Value (minutes) - The timeout threshold in minutes. Default is 1.
        /// </summary>
        [JsonProperty("Min")]
        public long? Min{ get; set; }

        /// <summary>
        /// The time zone configuration corresponding to the timeout, such as UTC+7, defaults to UTC+8.
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
        }
    }
}

