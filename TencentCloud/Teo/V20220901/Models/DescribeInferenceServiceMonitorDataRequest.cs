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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInferenceServiceMonitorDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Inference service ID. You can input up to 10 inference service IDs.</p>
        /// </summary>
        [JsonProperty("ServiceIds")]
        public string[] ServiceIds{ get; set; }

        /// <summary>
        /// <p>Metric list. A maximum of 10 metrics are supported. Valid values: <li>cpu_usage_average: average CPU usage rate, unit: %, metric type: Float;</li><li>cpu_usage_max: maximum CPU usage rate, unit: %, metric type: Float;</li><li>gpu_usage_average: average GPU usage rate, unit: %, metric type: Float;</li><li>gpu_usage_max: maximum GPU usage rate, unit: %, metric type: Float;</li><li>instance_num_average: average number of instances, unit: count, metric type: Float;</li><li>instance_num_max: maximum number of instances, unit: count, metric type: Float;</li><li>gpu_memory_usage_max: maximum GPU VRAM usage rate, unit: %, metric type: Float;</li><li>memory_usage_average: average memory usage rate, unit: %, metric type: Float;</li><li>memory_usage_max: maximum memory usage rate, unit: %, metric type: Float;</li></p>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// <p>Start time.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time. The query time range (<code>EndTime - StartTime</code>) must be less than or equal to 30 days.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Query time granularity. Valid values:</p><li>min: 1 minute, supporting queries within 1 day;</li><li>5min: 5 minutes, supporting queries within 7 days;</li><li>hour: 1 hour, supporting queries within 30 days;</li><li>day: 1 day, supporting queries within 30 days;</li>If this parameter is not input, the granularity will be automatically calculated based on the interval between the start time and end time. Specifically, data will be queried with a granularity of min, 5min, hour, and day respectively when the period is no more than 2 hours, no more than 2 days, no more than 7 days, and over 7 days.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "ServiceIds.", this.ServiceIds);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
        }
    }
}

