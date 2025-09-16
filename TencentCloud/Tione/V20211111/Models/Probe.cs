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

    public class Probe : AbstractModel
    {
        
        /// <summary>
        /// Probe action.
        /// </summary>
        [JsonProperty("ProbeAction")]
        public ProbeAction ProbeAction{ get; set; }

        /// <summary>
        /// Delay in waiting for a service startup.
        /// </summary>
        [JsonProperty("InitialDelaySeconds")]
        public long? InitialDelaySeconds{ get; set; }

        /// <summary>
        /// Polling check interval.
        /// </summary>
        [JsonProperty("PeriodSeconds")]
        public long? PeriodSeconds{ get; set; }

        /// <summary>
        /// Check timeout duration.
        /// </summary>
        [JsonProperty("TimeoutSeconds")]
        public long? TimeoutSeconds{ get; set; }

        /// <summary>
        /// Number of acknowledged failed detections.
        /// </summary>
        [JsonProperty("FailureThreshold")]
        public long? FailureThreshold{ get; set; }

        /// <summary>
        /// Number of acknowledged successful detections. The default values for readiness, liveness, and startup statuses are 3, 1, and 1.
        /// </summary>
        [JsonProperty("SuccessThreshold")]
        public long? SuccessThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ProbeAction.", this.ProbeAction);
            this.SetParamSimple(map, prefix + "InitialDelaySeconds", this.InitialDelaySeconds);
            this.SetParamSimple(map, prefix + "PeriodSeconds", this.PeriodSeconds);
            this.SetParamSimple(map, prefix + "TimeoutSeconds", this.TimeoutSeconds);
            this.SetParamSimple(map, prefix + "FailureThreshold", this.FailureThreshold);
            this.SetParamSimple(map, prefix + "SuccessThreshold", this.SuccessThreshold);
        }
    }
}

