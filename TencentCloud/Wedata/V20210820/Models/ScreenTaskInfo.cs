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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScreenTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Statistical Indicator 0: All Instances, 1: Current Day, 2: Yesterday
        /// </summary>
        [JsonProperty("CountTag")]
        public ulong? CountTag{ get; set; }

        /// <summary>
        /// Total numberNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// RunningNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RunningNum")]
        public ulong? RunningNum{ get; set; }

        /// <summary>
        /// StoppingNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StoppingNum")]
        public ulong? StoppingNum{ get; set; }

        /// <summary>
        /// StoppedNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StoppedNum")]
        public ulong? StoppedNum{ get; set; }

        /// <summary>
        /// Pause
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FrozenNum")]
        public ulong? FrozenNum{ get; set; }

        /// <summary>
        /// Annual task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("YearNum")]
        public ulong? YearNum{ get; set; }

        /// <summary>
        /// Monthly task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MonthNum")]
        public ulong? MonthNum{ get; set; }

        /// <summary>
        /// Weekly task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WeekNum")]
        public ulong? WeekNum{ get; set; }

        /// <summary>
        /// Daily task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DayNum")]
        public ulong? DayNum{ get; set; }

        /// <summary>
        /// Hourly task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("HourNum")]
        public ulong? HourNum{ get; set; }

        /// <summary>
        /// Minute Task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MinuteNum")]
        public ulong? MinuteNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CountTag", this.CountTag);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "RunningNum", this.RunningNum);
            this.SetParamSimple(map, prefix + "StoppingNum", this.StoppingNum);
            this.SetParamSimple(map, prefix + "StoppedNum", this.StoppedNum);
            this.SetParamSimple(map, prefix + "FrozenNum", this.FrozenNum);
            this.SetParamSimple(map, prefix + "YearNum", this.YearNum);
            this.SetParamSimple(map, prefix + "MonthNum", this.MonthNum);
            this.SetParamSimple(map, prefix + "WeekNum", this.WeekNum);
            this.SetParamSimple(map, prefix + "DayNum", this.DayNum);
            this.SetParamSimple(map, prefix + "HourNum", this.HourNum);
            this.SetParamSimple(map, prefix + "MinuteNum", this.MinuteNum);
        }
    }
}

