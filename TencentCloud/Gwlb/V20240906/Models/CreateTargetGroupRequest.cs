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

namespace TencentCloud.Gwlb.V20240906.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTargetGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Target group name, limited to 60 characters.
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// VPCID attribute of target group. If this parameter is left blank, the default VPC will be used.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Default port of the target group, which can be used when servers are added later. Either 'Port' or 'TargetGroupInstances.N.port' must be filled in.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Real server bound to a target group
        /// </summary>
        [JsonProperty("TargetGroupInstances")]
        public TargetGroupInstance[] TargetGroupInstances{ get; set; }

        /// <summary>
        /// GWLB target group protocol.
        /// - TENCENT_GENEVE: GENEVE standard protocol
        /// 
        /// - AWS_GENEVE: GENEVE compatibility protocol (a ticket is required for allowlisting)
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Health check settings.
        /// </summary>
        [JsonProperty("HealthCheck")]
        public TargetGroupHealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// Load balancing algorithm.
        /// - IP_HASH_3_ELASTIC: elastic hashing
        /// </summary>
        [JsonProperty("ScheduleAlgorithm")]
        public string ScheduleAlgorithm{ get; set; }

        /// <summary>
        /// Whether "All Dead, All Alive" is supported. It is supported by default.
        /// </summary>
        [JsonProperty("AllDeadToAlive")]
        public bool? AllDeadToAlive{ get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// Traffic Distribution Mode
        /// <ul>
        /// <li>STATELESS: Stateless</li>
        /// <li>STATEFUL: Stateful</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ForwardingMode")]
        public string ForwardingMode{ get; set; }

        /// <summary>
        /// <p>Switch for unbinding backend services in the rescheduling function. When enabled, unbinding backend services will trigger rescheduling.</p>
        /// </summary>
        [JsonProperty("RescheduleUnbindRs")]
        public bool? RescheduleUnbindRs{ get; set; }

        /// <summary>
        /// <p>The time to enable rescheduling after unbinding RS, configurable from 0s to 3600s, with a default value of 0s</p>
        /// </summary>
        [JsonProperty("RescheduleUnbindRsStartTime")]
        public long? RescheduleUnbindRsStartTime{ get; set; }

        /// <summary>
        /// <p>Switch for backend service health detection exception in the rescheduling function. When enabled, abnormal health checks of backend services will trigger rescheduling.</p>
        /// </summary>
        [JsonProperty("RescheduleUnhealthy")]
        public bool? RescheduleUnhealthy{ get; set; }

        /// <summary>
        /// <p>The waiting time to enable rescheduling after abnormal health detection of backend services, configurable from 0s to 3600s, default is 0s</p>
        /// </summary>
        [JsonProperty("RescheduleUnhealthyStartTime")]
        public long? RescheduleUnhealthyStartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArrayObj(map, prefix + "TargetGroupInstances.", this.TargetGroupInstances);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "ScheduleAlgorithm", this.ScheduleAlgorithm);
            this.SetParamSimple(map, prefix + "AllDeadToAlive", this.AllDeadToAlive);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ForwardingMode", this.ForwardingMode);
            this.SetParamSimple(map, prefix + "RescheduleUnbindRs", this.RescheduleUnbindRs);
            this.SetParamSimple(map, prefix + "RescheduleUnbindRsStartTime", this.RescheduleUnbindRsStartTime);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthy", this.RescheduleUnhealthy);
            this.SetParamSimple(map, prefix + "RescheduleUnhealthyStartTime", this.RescheduleUnhealthyStartTime);
        }
    }
}

