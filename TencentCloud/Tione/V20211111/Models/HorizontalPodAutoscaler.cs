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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HorizontalPodAutoscaler : AbstractModel
    {
        
        /// <summary>
        /// Minimum number of instances.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinReplicas")]
        public long? MinReplicas{ get; set; }

        /// <summary>
        /// Maximum number of instances.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxReplicas")]
        public long? MaxReplicas{ get; set; }

        /// <summary>
        /// Supported."gpu-util": GPU utilization; value range: 10-100. "cpu-util": CPU utilization; value range: 10-100. "memory-util": memory utilization; value range: 10-100. "service-qps": the QPS value of single instances; value range: 1-5000."concurrency-util": the number of concurrent requests of single instances. Value range: 1-100000.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HpaMetrics")]
        public Option[] HpaMetrics{ get; set; }

        /// <summary>
        /// Scale-out cooldown period, in seconds.
        /// </summary>
        [JsonProperty("ScaleUpStabilizationWindowSeconds")]
        public long? ScaleUpStabilizationWindowSeconds{ get; set; }

        /// <summary>
        /// Scale-in cooldown period, in seconds.
        /// </summary>
        [JsonProperty("ScaleDownStabilizationWindowSeconds")]
        public long? ScaleDownStabilizationWindowSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinReplicas", this.MinReplicas);
            this.SetParamSimple(map, prefix + "MaxReplicas", this.MaxReplicas);
            this.SetParamArrayObj(map, prefix + "HpaMetrics.", this.HpaMetrics);
            this.SetParamSimple(map, prefix + "ScaleUpStabilizationWindowSeconds", this.ScaleUpStabilizationWindowSeconds);
            this.SetParamSimple(map, prefix + "ScaleDownStabilizationWindowSeconds", this.ScaleDownStabilizationWindowSeconds);
        }
    }
}

