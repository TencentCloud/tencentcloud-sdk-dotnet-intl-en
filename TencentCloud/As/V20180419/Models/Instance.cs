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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Auto scaling group ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Launch configuration ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// Launch configuration name
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// Lifecycle status. valid values are as follows:.
        /// <Li>IN_SERVICE: running</li>.
        /// <Li>CREATING: specifies the instance is being created.</li>.
        /// <Li>CREATION_FAILED: creation failed.</li>.
        /// <Li>`TERMINATING`: the instance is being terminated.</li>.
        /// <Li>`TERMINATION_FAILED`: the instance fails to be terminated.</li>.
        /// <Li>ATTACHING: binding</li>.
        /// <Li>`ATTACH_FAILED`: the instance fails to be bound.</li>.
        /// <Li>DETACHING: specifies the unbinding is in progress.</li>.
        /// <Li>`DETACH_FAILED`: the instance fails to be unbound.</li>.
        /// <Li>`ATTACHING_LB`: binding to lb</li>.
        /// <Li>DETACHING_LB: the lb is being unbound.</li>.
        /// <Li>`MODIFYING_LB`: the lb is being modified.</li>.
        /// <Li>`STARTING`: the instance is being started up.</li>.
        /// <Li>`START_FAILED`: the instance fails to be started up.</li>.
        /// <Li>`STOPPING`: the instance is being shut down.</li>.
        /// <Li>`STOP_FAILED`: the instance fails to be shut down.</li>.
        /// <Li>`STOPPED`: the instance is shut down.</li>.
        /// <Li>`IN_LAUNCHING_HOOK`: the lifecycle hook is being scaled out.</li>.
        /// <Li>`IN_TERMINATING_HOOK`: the lifecycle hook is being scaled in.</li>.
        /// </summary>
        [JsonProperty("LifeCycleState")]
        public string LifeCycleState{ get; set; }

        /// <summary>
        /// Health status. valid values are as follows:.
        /// <Li>HEALTHY: the instance is in Healthy status.</li>.
        /// <Li>UNHEALTHY: instance ping unreachable</li>.
        /// <Li>CLB_UNHEALTHY: the instance port listened by clb is unhealthy</li>.
        /// </summary>
        [JsonProperty("HealthStatus")]
        public string HealthStatus{ get; set; }

        /// <summary>
        /// Whether to add scale-in protection
        /// </summary>
        [JsonProperty("ProtectedFromScaleIn")]
        public bool? ProtectedFromScaleIn{ get; set; }

        /// <summary>
        /// Availability zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Creation type. Value range: AUTO_CREATION, MANUAL_ATTACHING.
        /// </summary>
        [JsonProperty("CreationType")]
        public string CreationType{ get; set; }

        /// <summary>
        /// Instance join time is displayed in a format that conforms to the ISO8601 standard and uses UTC time.
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// Instance type
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Version number
        /// </summary>
        [JsonProperty("VersionNumber")]
        public long? VersionNumber{ get; set; }

        /// <summary>
        /// Auto scaling group name
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// Preheat status. valid values are as follows:.
        /// <Li>WAITING_ENTER_WARMUP: specifies the instance is waiting to enter preheating.</li>.
        /// <Li>`NO_NEED_WARMUP`: warming up is not required.</li>.
        /// <Li>IN_WARMUP: preheating.</li>.
        /// <Li>AFTER_WARMUP: indicates the preheating is completed.</li>.
        /// </summary>
        [JsonProperty("WarmupStatus")]
        public string WarmupStatus{ get; set; }

        /// <summary>
        /// Placement group ID. Only one can be specified.
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamSimple(map, prefix + "LifeCycleState", this.LifeCycleState);
            this.SetParamSimple(map, prefix + "HealthStatus", this.HealthStatus);
            this.SetParamSimple(map, prefix + "ProtectedFromScaleIn", this.ProtectedFromScaleIn);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreationType", this.CreationType);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "VersionNumber", this.VersionNumber);
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "WarmupStatus", this.WarmupStatus);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
        }
    }
}

