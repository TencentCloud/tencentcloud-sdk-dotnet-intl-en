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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpstreamHealthCheckConfig : AbstractModel
    {
        
        /// <summary>
        /// Enable active health check
        /// </summary>
        [JsonProperty("EnableActiveHealthCheck")]
        public bool? EnableActiveHealthCheck{ get; set; }

        /// <summary>
        /// Active health check configuration
        /// </summary>
        [JsonProperty("ActiveHealthCheck")]
        public KongActiveHealthCheck ActiveHealthCheck{ get; set; }

        /// <summary>
        /// Enable passive health check
        /// </summary>
        [JsonProperty("EnablePassiveHealthCheck")]
        public bool? EnablePassiveHealthCheck{ get; set; }

        /// <summary>
        /// Passive health check configuration
        /// </summary>
        [JsonProperty("PassiveHealthCheck")]
        public KongPassiveHealthCheck PassiveHealthCheck{ get; set; }

        /// <summary>
        /// Consecutive health threshold, unit: times
        /// </summary>
        [JsonProperty("Successes")]
        public ulong? Successes{ get; set; }

        /// <summary>
        /// Continuous anomaly threshold, unit: times	
        /// </summary>
        [JsonProperty("Failures")]
        public ulong? Failures{ get; set; }

        /// <summary>
        /// Timeout threshold, unit: times
        /// </summary>
        [JsonProperty("Timeouts")]
        public ulong? Timeouts{ get; set; }

        /// <summary>
        /// Healthy HTTP status code
        /// </summary>
        [JsonProperty("HealthyHttpStatuses")]
        public ulong?[] HealthyHttpStatuses{ get; set; }

        /// <summary>
        /// abnormal HTTP status code
        /// </summary>
        [JsonProperty("UnhealthyHttpStatuses")]
        public ulong?[] UnhealthyHttpStatuses{ get; set; }

        /// <summary>
        /// Health check monitoring blocks nodes with a weight of 0 in reported data
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IgnoreZeroWeightNodes")]
        [System.Obsolete]
        public bool? IgnoreZeroWeightNodes{ get; set; }

        /// <summary>
        /// Health check supports nodes with support weights of 0
        /// </summary>
        [JsonProperty("ZeroWeightHeathCheck")]
        public bool? ZeroWeightHeathCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableActiveHealthCheck", this.EnableActiveHealthCheck);
            this.SetParamObj(map, prefix + "ActiveHealthCheck.", this.ActiveHealthCheck);
            this.SetParamSimple(map, prefix + "EnablePassiveHealthCheck", this.EnablePassiveHealthCheck);
            this.SetParamObj(map, prefix + "PassiveHealthCheck.", this.PassiveHealthCheck);
            this.SetParamSimple(map, prefix + "Successes", this.Successes);
            this.SetParamSimple(map, prefix + "Failures", this.Failures);
            this.SetParamSimple(map, prefix + "Timeouts", this.Timeouts);
            this.SetParamArraySimple(map, prefix + "HealthyHttpStatuses.", this.HealthyHttpStatuses);
            this.SetParamArraySimple(map, prefix + "UnhealthyHttpStatuses.", this.UnhealthyHttpStatuses);
            this.SetParamSimple(map, prefix + "IgnoreZeroWeightNodes", this.IgnoreZeroWeightNodes);
            this.SetParamSimple(map, prefix + "ZeroWeightHeathCheck", this.ZeroWeightHeathCheck);
        }
    }
}

