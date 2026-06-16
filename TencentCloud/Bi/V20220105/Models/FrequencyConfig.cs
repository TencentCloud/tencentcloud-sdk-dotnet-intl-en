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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FrequencyConfig : AbstractModel
    {
        
        /// <summary>
        /// Cycle
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// Date
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Dates")]
        public long?[] Dates{ get; set; }

        /// <summary>
        /// Time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Interval
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntervalTime")]
        public ulong? IntervalTime{ get; set; }

        /// <summary>
        /// 1:SECOND,2:MINUTE,3:HOUR,4:DAY
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntervalTimeUnit")]
        public ulong? IntervalTimeUnit{ get; set; }

        /// <summary>
        /// hourly list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Hours")]
        public long?[] Hours{ get; set; }

        /// <summary>
        /// Minute list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Minute")]
        public long?[] Minute{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamArraySimple(map, prefix + "Dates.", this.Dates);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "IntervalTimeUnit", this.IntervalTimeUnit);
            this.SetParamArraySimple(map, prefix + "Hours.", this.Hours);
            this.SetParamArraySimple(map, prefix + "Minute.", this.Minute);
        }
    }
}

