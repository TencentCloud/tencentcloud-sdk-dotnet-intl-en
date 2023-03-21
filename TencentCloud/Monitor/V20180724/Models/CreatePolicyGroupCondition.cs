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

    public class CreatePolicyGroupCondition : AbstractModel
    {
        
        /// <summary>
        /// Metric ID.
        /// </summary>
        [JsonProperty("MetricId")]
        public long? MetricId{ get; set; }

        /// <summary>
        /// Alarm sending and converging type. The value 0 indicates that alarms are sent consecutively. The value 1 indicates that alarms are sent exponentially.
        /// </summary>
        [JsonProperty("AlarmNotifyType")]
        public long? AlarmNotifyType{ get; set; }

        /// <summary>
        /// Alarm sending period in seconds. The value <0 indicates that no alarm will be triggered. The value 0 indicates that an alarm is triggered only once. The value >0 indicates that an alarm is triggered at the interval of triggerTime.
        /// </summary>
        [JsonProperty("AlarmNotifyPeriod")]
        public long? AlarmNotifyPeriod{ get; set; }

        /// <summary>
        /// Comparative type. The value 1 indicates greater than. The value 2 indicates greater than or equal to. The value 3 indicates smaller than. The value 4 indicates smaller than or equal to. The value 5 indicates equal to. The value 6 indicates not equal to. This parameter is optional if a default comparative type is configured for the metric.
        /// </summary>
        [JsonProperty("CalcType")]
        public long? CalcType{ get; set; }

        /// <summary>
        /// Comparative value. This parameter is optional if the metric has no requirement.
        /// </summary>
        [JsonProperty("CalcValue")]
        public float? CalcValue{ get; set; }

        /// <summary>
        /// Data aggregation period in seconds. This parameter is optional if the metric has a default value.
        /// </summary>
        [JsonProperty("CalcPeriod")]
        public long? CalcPeriod{ get; set; }

        /// <summary>
        /// Number of consecutive periods after which an alarm will be triggered.
        /// </summary>
        [JsonProperty("ContinuePeriod")]
        public long? ContinuePeriod{ get; set; }

        /// <summary>
        /// If a metric is created based on a template, the `RuleId` of the metric in the template must be passed in.
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricId", this.MetricId);
            this.SetParamSimple(map, prefix + "AlarmNotifyType", this.AlarmNotifyType);
            this.SetParamSimple(map, prefix + "AlarmNotifyPeriod", this.AlarmNotifyPeriod);
            this.SetParamSimple(map, prefix + "CalcType", this.CalcType);
            this.SetParamSimple(map, prefix + "CalcValue", this.CalcValue);
            this.SetParamSimple(map, prefix + "CalcPeriod", this.CalcPeriod);
            this.SetParamSimple(map, prefix + "ContinuePeriod", this.ContinuePeriod);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

