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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RepeatStrategy : AbstractModel
    {
        
        /// <summary>
        /// The valid values DAY, DOW, DOM, and NONE respectively indicate repetition by day, repetition by week, repetition by month, and one-time execution. This parameter is required.
        /// </summary>
        [JsonProperty("RepeatType")]
        public string RepeatType{ get; set; }

        /// <summary>
        /// Daily repetition rule, which is effective when RepeatType is set to DAY
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DayRepeat")]
        public DayRepeatStrategy DayRepeat{ get; set; }

        /// <summary>
        /// Weekly repetition rule, effective when RepeatType is DOW
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WeekRepeat")]
        public WeekRepeatStrategy WeekRepeat{ get; set; }

        /// <summary>
        /// Monthly repetition rule, valid when RepeatType is DOM
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MonthRepeat")]
        public MonthRepeatStrategy MonthRepeat{ get; set; }

        /// <summary>
        /// One-time execution rule, valid when RepeatType is NONE
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NotRepeat")]
        public NotRepeatStrategy NotRepeat{ get; set; }

        /// <summary>
        /// Rule expiration time. After this time is due, the rule will be automatically set to the status "suspended". The format is "2020-07-23 00:00:00". It is required.
        /// </summary>
        [JsonProperty("Expire")]
        public string Expire{ get; set; }

        /// <summary>
        /// Periodic rule start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepeatType", this.RepeatType);
            this.SetParamObj(map, prefix + "DayRepeat.", this.DayRepeat);
            this.SetParamObj(map, prefix + "WeekRepeat.", this.WeekRepeat);
            this.SetParamObj(map, prefix + "MonthRepeat.", this.MonthRepeat);
            this.SetParamObj(map, prefix + "NotRepeat.", this.NotRepeat);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

