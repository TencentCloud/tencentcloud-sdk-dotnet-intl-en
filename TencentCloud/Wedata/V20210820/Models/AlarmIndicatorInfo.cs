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

    public class AlarmIndicatorInfo : AbstractModel
    {
        
        /// <summary>
        /// Metric ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Alert Metrics, 0 for task failure, 1 for task execution timeout, 2 for task stop, 3 for task pause, 4 read speed, 5 write speed, 6 read throughput, 7 write throughput, 8 dirty data byte count, 9 number of dirty data entries, 10 task exception, 11 task detection anomaly, 12 restart times, 13 task delay, 14 number of restarts within the last 20 minutes, 15 transmission delay, 16 business delay, 50 offline package CPU usage rate, 51 offline package memory usage rate, 52 offline package parallelism utilization, 53 number of instances queued for offline packages, 54 real-time package resource utilization, 55 number of tasks running in real-time packages
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmIndicator")]
        public ulong? AlarmIndicator{ get; set; }

        /// <summary>
        /// Alert Metric Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmIndicatorDesc")]
        public string AlarmIndicatorDesc{ get; set; }

        /// <summary>
        /// Metric Threshold, 1 for the first run failure of an offline task, 2 for all retries failed of an offline task
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// Estimated timeout duration, minute level
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EstimatedTime")]
        public ulong? EstimatedTime{ get; set; }

        /// <summary>
        /// Alert threshold operator, 1 Greater than, 2 Less than
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Operator")]
        public ulong? Operator{ get; set; }

        /// <summary>
        /// Alert metric threshold unit: ms (milliseconds), s (seconds), min (minutes)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmIndicatorUnit")]
        public string AlarmIndicatorUnit{ get; set; }

        /// <summary>
        /// Alert Interval
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Alert interval unit: hour, minute, day
        /// </summary>
        [JsonProperty("DurationUnit")]
        public string DurationUnit{ get; set; }

        /// <summary>
        /// Maximum number of alerts within a cycle
        /// </summary>
        [JsonProperty("MaxTimes")]
        public long? MaxTimes{ get; set; }

        /// <summary>
        /// Metric Threshold
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Threshold")]
        public float? Threshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AlarmIndicator", this.AlarmIndicator);
            this.SetParamSimple(map, prefix + "AlarmIndicatorDesc", this.AlarmIndicatorDesc);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "EstimatedTime", this.EstimatedTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "AlarmIndicatorUnit", this.AlarmIndicatorUnit);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "DurationUnit", this.DurationUnit);
            this.SetParamSimple(map, prefix + "MaxTimes", this.MaxTimes);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
        }
    }
}

