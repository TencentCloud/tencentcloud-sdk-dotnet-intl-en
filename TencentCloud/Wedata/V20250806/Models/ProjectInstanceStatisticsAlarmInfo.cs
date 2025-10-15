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

    public class ProjectInstanceStatisticsAlarmInfo : AbstractModel
    {
        
        /// <summary>
        /// Alarm type
        /// 
        /// projectFailureInstanceUpwardFluctuationAlarm: specifies the upward fluctuation alert for failed instances.
        /// 
        /// projectSuccessInstanceDownwardFluctuationAlarm: specifies the downward fluctuation alert for successful instances.
        /// </summary>
        [JsonProperty("AlarmType")]
        public string AlarmType{ get; set; }

        /// <summary>
        /// Alarm threshold for the downward fluctuation ratio of the number of successful instances.
        /// Alarm threshold for the upward fluctuation ratio of the number of failed instances.
        /// </summary>
        [JsonProperty("InstanceThresholdCountPercent")]
        public ulong? InstanceThresholdCountPercent{ get; set; }

        /// <summary>
        /// Cumulative instance number fluctuation threshold.
        /// </summary>
        [JsonProperty("InstanceThresholdCount")]
        public ulong? InstanceThresholdCount{ get; set; }

        /// <summary>
        /// Stability threshold count (debounce configuration statistical cycle count).
        /// </summary>
        [JsonProperty("StabilizeThreshold")]
        public ulong? StabilizeThreshold{ get; set; }

        /// <summary>
        /// Stability statistical cycle (anti-shake configuration statistical cycle count).
        /// </summary>
        [JsonProperty("StabilizeStatisticsCycle")]
        public ulong? StabilizeStatisticsCycle{ get; set; }

        /// <summary>
        /// Specifies whether to use cumulative calculation. valid values: false (consecutive), true (cumulative).
        /// </summary>
        [JsonProperty("IsCumulant")]
        public bool? IsCumulant{ get; set; }

        /// <summary>
        /// Cumulative number of instances for the current day.
        /// Specifies the downward fluctuation of failed instance count on the day.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "InstanceThresholdCountPercent", this.InstanceThresholdCountPercent);
            this.SetParamSimple(map, prefix + "InstanceThresholdCount", this.InstanceThresholdCount);
            this.SetParamSimple(map, prefix + "StabilizeThreshold", this.StabilizeThreshold);
            this.SetParamSimple(map, prefix + "StabilizeStatisticsCycle", this.StabilizeStatisticsCycle);
            this.SetParamSimple(map, prefix + "IsCumulant", this.IsCumulant);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
        }
    }
}

