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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceAutoScalingConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Minimum number of instances. When a scaling policy is configured and the policy is in the valid period, it will not take effect.</p>
        /// </summary>
        [JsonProperty("MinInstanceCount")]
        public long? MinInstanceCount{ get; set; }

        /// <summary>
        /// <p>Auto Scaling policy list. Supports up to 5 policies.</p>
        /// </summary>
        [JsonProperty("ScalingPolicies")]
        public InferenceScalingPolicy[] ScalingPolicies{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinInstanceCount", this.MinInstanceCount);
            this.SetParamArrayObj(map, prefix + "ScalingPolicies.", this.ScalingPolicies);
        }
    }
}

