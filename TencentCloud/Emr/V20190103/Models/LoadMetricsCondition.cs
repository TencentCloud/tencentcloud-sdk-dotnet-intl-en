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

    public class LoadMetricsCondition : AbstractModel
    {
        
        /// <summary>
        /// Rule statistics cycle. Options include 1 min, 3 min, and 5 min.
        /// </summary>
        [JsonProperty("StatisticPeriod")]
        public long? StatisticPeriod{ get; set; }

        /// <summary>
        /// Trigger count. Scaling begins only after it has been triggered continuously more than TriggerThreshold times.
        /// </summary>
        [JsonProperty("TriggerThreshold")]
        public long? TriggerThreshold{ get; set; }

        /// <summary>
        /// Scaling load metric.
        /// </summary>
        [JsonProperty("LoadMetrics")]
        public string LoadMetrics{ get; set; }

        /// <summary>
        /// Rule metadata record ID.
        /// </summary>
        [JsonProperty("MetricId")]
        public long? MetricId{ get; set; }

        /// <summary>
        /// Trigger condition.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Conditions")]
        public TriggerCondition[] Conditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatisticPeriod", this.StatisticPeriod);
            this.SetParamSimple(map, prefix + "TriggerThreshold", this.TriggerThreshold);
            this.SetParamSimple(map, prefix + "LoadMetrics", this.LoadMetrics);
            this.SetParamSimple(map, prefix + "MetricId", this.MetricId);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
        }
    }
}

