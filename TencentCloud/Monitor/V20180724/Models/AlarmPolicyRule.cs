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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmPolicyRule : AbstractModel
    {
        
        /// <summary>
        /// Metric name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// Statistical period in seconds
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Operator
        /// intelligent = intelligent detection without threshold
        /// eq = equal to
        /// ge = greater than or equal to
        /// gt = greater than
        /// le = less than or equal to
        /// lt = less than
        /// ne = not equal to
        /// day_increase = daily increase
        /// day_decrease = daily decrease
        /// day_wave = daily fluctuation
        /// week_increase = weekly increase
        /// week_decrease = weekly decrease
        /// week_wave = weekly fluctuation
        /// cycle_increase = periodical increase
        /// cycle_decrease = periodical decrease
        /// cycle_wave = periodical fluctuation
        /// re = regex match
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Threshold
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Number of cycles for continuous notification. Valid values: 1 (1 cycle), 2 (2 cycles), and so on.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContinuePeriod")]
        public long? ContinuePeriod{ get; set; }

        /// <summary>
        /// Alarm interval in seconds. Valid values: 0 (do not repeat), 300 (alarm once every 5 minutes), 600 (alarm once every 10 minutes), 900 (alarm once every 15 minutes), 1800 (alarm once every 30 minutes), 3600 (alarm once every hour), 7200 (alarm once every 2 hours), 10800 (alarm once every 3 hours), 21600 (alarm once every 6 hours),  43200 (alarm once every 12 hours), 86400 (alarm once every day)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NoticeFrequency")]
        public long? NoticeFrequency{ get; set; }

        /// <summary>
        /// Whether the alarm frequency increases exponentially. Valid values: 0 (no), 1 (yes)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsPowerNotice")]
        public long? IsPowerNotice{ get; set; }

        /// <summary>
        /// Filter condition for one single trigger rule
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Filter")]
        public AlarmPolicyFilter Filter{ get; set; }

        /// <summary>
        /// Metric display name, which is used in the output parameter
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Unit, which is used in the output parameter
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// Trigger condition type. Valid values: STATIC (static threshold), DYNAMIC (dynamic threshold)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ContinuePeriod", this.ContinuePeriod);
            this.SetParamSimple(map, prefix + "NoticeFrequency", this.NoticeFrequency);
            this.SetParamSimple(map, prefix + "IsPowerNotice", this.IsPowerNotice);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
        }
    }
}

