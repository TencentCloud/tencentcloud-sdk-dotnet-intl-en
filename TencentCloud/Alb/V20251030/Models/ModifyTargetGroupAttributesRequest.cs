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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTargetGroupAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to preview this request.</p><ul><li><strong>false</strong> (default): Send a normal request to directly modify the target group.</li><li><strong>true</strong>: Send a preview request to check whether the parameters, format, and service limits for modifying the target group meet the requirements.</li></ul>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>Health check configuration.</p>
        /// </summary>
        [JsonProperty("HealthCheckConfig")]
        public HealthCheckConfig HealthCheckConfig{ get; set; }

        /// <summary>
        /// <p>Whether to enable long connections.</p>
        /// </summary>
        [JsonProperty("KeepaliveEnabled")]
        public bool? KeepaliveEnabled{ get; set; }

        /// <summary>
        /// <p>Scheduling algorithm. Values:</p><ul><li><strong>wrr</strong>: weighted polling. Real servers are selected by weight. The higher the weight, the more chances a server stands to be polled.</li><li><strong>wlc</strong>: number of weighted least connections. When weight values of different real servers are the same, the server with fewer current connections stands more chances to be polled.</li></ul>
        /// </summary>
        [JsonProperty("SchedulerAlgorithm")]
        public string SchedulerAlgorithm{ get; set; }

        /// <summary>
        /// <p>Session persistence configuration.</p>
        /// </summary>
        [JsonProperty("StickySessionConfig")]
        public StickySessionConfig StickySessionConfig{ get; set; }

        /// <summary>
        /// <p>Target group ID, format: lbtg- followed by 8 alphanumeric characters.</p>
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// <p>Target group name. It can contain 1–255 characters, consisting of digits, upper- and lower-case letters, Chinese characters, half-width periods (.), underscores (_), and dashes (-). If no target group name is specified, the ID is used as the target group name by default.</p>
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamObj(map, prefix + "HealthCheckConfig.", this.HealthCheckConfig);
            this.SetParamSimple(map, prefix + "KeepaliveEnabled", this.KeepaliveEnabled);
            this.SetParamSimple(map, prefix + "SchedulerAlgorithm", this.SchedulerAlgorithm);
            this.SetParamObj(map, prefix + "StickySessionConfig.", this.StickySessionConfig);
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
        }
    }
}

