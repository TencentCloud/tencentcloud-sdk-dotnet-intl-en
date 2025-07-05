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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamingStatistics : AbstractModel
    {
        
        /// <summary>
        /// Task start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Number of data receivers
        /// </summary>
        [JsonProperty("Receivers")]
        public long? Receivers{ get; set; }

        /// <summary>
        /// Number of receivers in service
        /// </summary>
        [JsonProperty("NumActiveReceivers")]
        public long? NumActiveReceivers{ get; set; }

        /// <summary>
        /// Number of inactive receivers
        /// </summary>
        [JsonProperty("NumInactiveReceivers")]
        public long? NumInactiveReceivers{ get; set; }

        /// <summary>
        /// Number of running batches
        /// </summary>
        [JsonProperty("NumActiveBatches")]
        public long? NumActiveBatches{ get; set; }

        /// <summary>
        /// Number of batches to be processed
        /// </summary>
        [JsonProperty("NumRetainedCompletedBatches")]
        public long? NumRetainedCompletedBatches{ get; set; }

        /// <summary>
        /// Number of completed batches
        /// </summary>
        [JsonProperty("NumTotalCompletedBatches")]
        public long? NumTotalCompletedBatches{ get; set; }

        /// <summary>
        /// Average input speed
        /// </summary>
        [JsonProperty("AverageInputRate")]
        public float? AverageInputRate{ get; set; }

        /// <summary>
        /// Average queue time
        /// </summary>
        [JsonProperty("AverageSchedulingDelay")]
        public float? AverageSchedulingDelay{ get; set; }

        /// <summary>
        /// Average processing time
        /// </summary>
        [JsonProperty("AverageProcessingTime")]
        public float? AverageProcessingTime{ get; set; }

        /// <summary>
        /// Average latency
        /// </summary>
        [JsonProperty("AverageTotalDelay")]
        public float? AverageTotalDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Receivers", this.Receivers);
            this.SetParamSimple(map, prefix + "NumActiveReceivers", this.NumActiveReceivers);
            this.SetParamSimple(map, prefix + "NumInactiveReceivers", this.NumInactiveReceivers);
            this.SetParamSimple(map, prefix + "NumActiveBatches", this.NumActiveBatches);
            this.SetParamSimple(map, prefix + "NumRetainedCompletedBatches", this.NumRetainedCompletedBatches);
            this.SetParamSimple(map, prefix + "NumTotalCompletedBatches", this.NumTotalCompletedBatches);
            this.SetParamSimple(map, prefix + "AverageInputRate", this.AverageInputRate);
            this.SetParamSimple(map, prefix + "AverageSchedulingDelay", this.AverageSchedulingDelay);
            this.SetParamSimple(map, prefix + "AverageProcessingTime", this.AverageProcessingTime);
            this.SetParamSimple(map, prefix + "AverageTotalDelay", this.AverageTotalDelay);
        }
    }
}

