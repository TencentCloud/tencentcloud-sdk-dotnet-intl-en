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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorMetricItem : AbstractModel
    {
        
        /// <summary>
        /// Monitoring Metric Types. There are three types: 1. RUN_DURATION (running time) 2. WAIT_DURATION (waiting duration) 3. COMPLETION_TIME (completion time)
        /// </summary>
        [JsonProperty("MetricType")]
        public string MetricType{ get; set; }

        /// <summary>
        /// Alarm threshold in milliseconds. For COMPLETION_TIME: calculated from 00:00 of the current day.
        /// </summary>
        [JsonProperty("WarningThreshold")]
        public string WarningThreshold{ get; set; }

        /// <summary>
        /// Timeout threshold in milliseconds. For COMPLETION_TIME, it is calculated from 00:00 of the current day.
        /// </summary>
        [JsonProperty("TimeoutThreshold")]
        public string TimeoutThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamSimple(map, prefix + "WarningThreshold", this.WarningThreshold);
            this.SetParamSimple(map, prefix + "TimeoutThreshold", this.TimeoutThreshold);
        }
    }
}

