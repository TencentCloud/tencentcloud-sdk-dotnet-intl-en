/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplaceMonitorUnhealthy", this.ReplaceMonitorUnhealthy);
            this.SetParamSimple(map, prefix + "ScalingMode", this.ScalingMode);
        }
    }
}

