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

    public class CreateTargetGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Target Group Type. Value:</p><ul><li><strong>Instance</strong> (default): Cvm server type or Eni type.</li></ul>
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// <p>VPC ID.</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Whether to preview this request.</p><ul><li><strong>false</strong> (default): Send a normal request to directly create a target group.</li><li><strong>true</strong>: Send a preview request to check whether the parameters, format, and service limits for target group creation meet the requirements.</li></ul>
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
        /// <p>Backend service protocol type. Values:</p><ul><li><strong>HTTP</strong> (default): supports binding HTTP and HTTPS listeners</li><li><strong>HTTPS</strong>: supports binding HTTPS listeners</li><li><strong>GRPC</strong>: supports binding HTTPS listeners</li><li><strong>GRPCS</strong>: supports binding HTTPS listeners</li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>Scheduling algorithm. Value:</p><ul><li><strong>wrr</strong> (default): weighted polling. Backend servers are selected by weight. The higher the weight, the more likely the server is to be polled.</li><li><strong>wlc</strong>: weighted least connections. When different backend servers have the same weight, the server with fewer current connections is more likely to be polled.</li></ul>
        /// </summary>
        [JsonProperty("SchedulerAlgorithm")]
        public string SchedulerAlgorithm{ get; set; }

        /// <summary>
        /// <p>Session persistence configuration.</p>
        /// </summary>
        [JsonProperty("StickySessionConfig")]
        public StickySessionConfig StickySessionConfig{ get; set; }

        /// <summary>
        /// <p>Tag.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>Target group name, defaulting to the target group ID. It is <strong>1-255</strong> characters long and can contain digits, upper- and lower-case letters, Chinese characters, half-width periods (.), underscores (_), and dashes (-).</p>
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamObj(map, prefix + "HealthCheckConfig.", this.HealthCheckConfig);
            this.SetParamSimple(map, prefix + "KeepaliveEnabled", this.KeepaliveEnabled);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SchedulerAlgorithm", this.SchedulerAlgorithm);
            this.SetParamObj(map, prefix + "StickySessionConfig.", this.StickySessionConfig);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
        }
    }
}

