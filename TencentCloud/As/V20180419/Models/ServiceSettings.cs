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

    public class ServiceSettings : AbstractModel
    {
        
        /// <summary>
        /// Enables unhealthy instance replacement. If this feature is enabled, AS will replace instances that are flagged as unhealthy by Cloud Monitor. If this parameter is not specified, the value will be False by default.
        /// </summary>
        [JsonProperty("ReplaceMonitorUnhealthy")]
        public bool? ReplaceMonitorUnhealthy{ get; set; }

        /// <summary>
        /// Valid values: 
        /// CLASSIC_SCALING: this is the typical scaling method, which creates and terminates instances to perform scaling operations. 
        /// WAKE_UP_STOPPED_SCALING: this scaling method first tries to start stopped instances. If the number of instances woken up is insufficient, the system creates new instances for scale-out. For scale-in, instances are terminated as in the typical method. You can use the StopAutoScalingInstances API to stop instances in the scaling group. Scale-out operations triggered by alarms will still create new instances.
        /// Default value: CLASSIC_SCALING
        /// </summary>
        [JsonProperty("ScalingMode")]
        public string ScalingMode{ get; set; }

        /// <summary>
        /// Enable unhealthy instance replacement. If this feature is enabled, AS will replace instances that are found unhealthy in the CLB health check. If this parameter is not specified, the default value `False` will be used.
        /// </summary>
        [JsonProperty("ReplaceLoadBalancerUnhealthy")]
        public bool? ReplaceLoadBalancerUnhealthy{ get; set; }

        /// <summary>
        /// Replacement mode of the unhealthy replacement service. valid values:.
        /// RECREATE: rebuild an instance to replace the unhealthy instance.
        /// RESET: performs a system reinstallation on unhealthy instances while keeping the data disk, private IP address, instance id, and other information unchanged. the instance login settings, hostname, enhanced services, and UserData remain consistent with the current launch configuration.
        /// Default value: RECREATE.
        /// </summary>
        [JsonProperty("ReplaceMode")]
        public string ReplaceMode{ get; set; }

        /// <summary>
        /// Automatic instance Tag update. the default value is False. if this feature is enabled, tags of running instances in a scaling group will be updated as well if the scaling group tags are updated. (this feature takes effect for Tag creation and editing but not Tag deletion.) the update does not take effect immediately due to certain latency.
        /// </summary>
        [JsonProperty("AutoUpdateInstanceTags")]
        public bool? AutoUpdateInstanceTags{ get; set; }

        /// <summary>
        /// Expected number of instances sync minimum and maximum value. default value is False. this parameter only takes effect in scenarios where the expected number is not passed in to modify scaling group api.
        /// <Li>True: when modifying the maximum or minimum value, if a conflict exists with the current expected value, synchronously adjust the expected value. for example, if the input minimum value is 2 while the current expected value is 1, the expected value will be synchronously adjusted to 2.</li>.
        /// <Li>False: if a conflict exists between the current expected value when modifying the maximum or minimum value, an error message indicates it is not allowed to be modified.</li>.
        /// </summary>
        [JsonProperty("DesiredCapacitySyncWithMaxMinSize")]
        public bool? DesiredCapacitySyncWithMaxMinSize{ get; set; }

        /// <summary>
        /// Scaling in unhealthy instances first. If enabled, preferentially selects unhealthy instances during scale in. Default value: False.
        /// </summary>
        [JsonProperty("PriorityScaleInUnhealthy")]
        public bool? PriorityScaleInUnhealthy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplaceMonitorUnhealthy", this.ReplaceMonitorUnhealthy);
            this.SetParamSimple(map, prefix + "ScalingMode", this.ScalingMode);
            this.SetParamSimple(map, prefix + "ReplaceLoadBalancerUnhealthy", this.ReplaceLoadBalancerUnhealthy);
            this.SetParamSimple(map, prefix + "ReplaceMode", this.ReplaceMode);
            this.SetParamSimple(map, prefix + "AutoUpdateInstanceTags", this.AutoUpdateInstanceTags);
            this.SetParamSimple(map, prefix + "DesiredCapacitySyncWithMaxMinSize", this.DesiredCapacitySyncWithMaxMinSize);
            this.SetParamSimple(map, prefix + "PriorityScaleInUnhealthy", this.PriorityScaleInUnhealthy);
        }
    }
}

