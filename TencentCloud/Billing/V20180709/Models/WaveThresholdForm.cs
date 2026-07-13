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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaveThresholdForm : AbstractModel
    {
        
        /// <summary>
        /// ACTUAL actual amount, FORECAST forecast amount
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WarnType")]
        public string WarnType{ get; set; }

        /// <summary>
        /// Fluctuation threshold (equal to or greater than 0)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Threshold")]
        public string Threshold{ get; set; }

        /// <summary>
        /// Alarm type: chain period-over-period, yoy year-over-year, fix fixed value
        /// Supported types: day-on-day comparison chain day, day-on-day comparison chain weekday, year-on-year comparison by month yoy day, daily fixed value fix day, month-on-month comparison chain month, fixed monthly value fix month
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// Alarm dimension: day, month, weekday
        /// Supported types: day-on-day comparison chain day, day-on-day comparison chain weekday, year-on-year comparison by month yoy day, daily fixed value fix day, month-on-month comparison chain month, fixed monthly value fix month
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WarnType", this.WarnType);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
        }
    }
}

