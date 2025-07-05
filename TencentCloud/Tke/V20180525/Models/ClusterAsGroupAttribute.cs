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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterAsGroupAttribute : AbstractModel
    {
        
        /// <summary>
        /// Scaling group ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Whether it is enabled
        /// </summary>
        [JsonProperty("AutoScalingGroupEnabled")]
        public bool? AutoScalingGroupEnabled{ get; set; }

        /// <summary>
        /// Maximum and minimum number of pods in a scaling group
        /// </summary>
        [JsonProperty("AutoScalingGroupRange")]
        public AutoScalingGroupRange AutoScalingGroupRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupEnabled", this.AutoScalingGroupEnabled);
            this.SetParamObj(map, prefix + "AutoScalingGroupRange.", this.AutoScalingGroupRange);
        }
    }
}

