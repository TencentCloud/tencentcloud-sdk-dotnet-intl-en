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
        /// Lifecycle status. Valid values:<br>
        /// <li>`IN_SERVICE`: The instance is running.
        /// <li>`CREATING`: The instance is being created.
        /// <li>`CREATION_FAILED`: The instance fails to be created.
        /// <li>`TERMINATING`: The instance is being terminated.
        /// <li>`TERMINATION_FAILED`: The instance fails to be terminated.
        /// <li>`ATTACHING`: The instance is being bound.
        /// <li>`ATTACH_FAILED`: The instance fails to be bound.
        /// <li>`DETACHING`: The instance is being unbound.
        /// <li>`DETACH_FAILED`: The instance fails to be unbound.
        /// <li>`ATTACHING_LB`: The LB is being bound.
        /// <li>DETACHING_LB: The LB is being unbound.
        /// <li>`MODIFYING_LB`: The LB is being modified.
        /// <li>`STARTING`: The instance is being started up.
        /// <li>`START_FAILED`: The instance fails to be started up.
        /// <li>`STOPPING`: The instance is being shut down.
        /// <li>`STOP_FAILED`: The instance fails to be shut down.
        /// <li>`STOPPED`: The instance is shut down.
        /// <li>`IN_LAUNCHING_HOOK`: The lifecycle hook is being scaled out.
        /// <li>`IN_TERMINATING_HOOK`: The lifecycle hook is being scaled in.
        /// </summary>
        [JsonProperty("LifeCycleState")]
        public string LifeCycleState{ get; set; }

        /// <summary>
        /// Health status. Value range: HEALTHY, UNHEALTHY
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
        /// Instance addition time
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
        /// Warming up status. Valid values:
        /// <li>`WAITING_ENTER_WARMUP`: The instance is waiting to be warmed up.
        /// <li>`NO_NEED_WARMUP`: Warming up is not required.
        /// <li>`IN_WARMUP`: The instance is being warmed up.
        /// <li>`AFTER_WARMUP`: Warming up is completed.
        /// </summary>
        [JsonProperty("WarmupStatus")]
        public string WarmupStatus{ get; set; }

        /// <summary>
        /// Placement group ID. Only one is allowed.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
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

