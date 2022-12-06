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

    public class DetachLoadBalancersRequest : AbstractModel
    {
        
        /// <summary>
        /// Scaling group ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// List of classic CLB IDs. Up to 20 IDs are allowed. `LoadBalancerIds` and `ForwardLoadBalancerIdentifications` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// List of application CLB IDs. Up to 100 IDs are allowed. `LoadBalancerIds` and `ForwardLoadBalancerIdentifications` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("ForwardLoadBalancerIdentifications")]
        public ForwardLoadBalancerIdentification[] ForwardLoadBalancerIdentifications{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamArrayObj(map, prefix + "ForwardLoadBalancerIdentifications.", this.ForwardLoadBalancerIdentifications);
        }
    }
}

