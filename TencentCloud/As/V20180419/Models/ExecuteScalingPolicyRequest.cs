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

    public class ExecuteScalingPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Alarm-based scaling policy ID
        /// </summary>
        [JsonProperty("AutoScalingPolicyId")]
        public string AutoScalingPolicyId{ get; set; }

        /// <summary>
        /// Whether to check if the auto scaling group is in the cooldown period. Default value: false
        /// </summary>
        [JsonProperty("HonorCooldown")]
        public bool? HonorCooldown{ get; set; }

        /// <summary>
        /// Source that triggers the scaling policy. Valid values: API and CLOUD_MONITOR. Default value: API. The value `CLOUD_MONITOR` is specific to the Cloud Monitor service.
        /// </summary>
        [JsonProperty("TriggerSource")]
        public string TriggerSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingPolicyId", this.AutoScalingPolicyId);
            this.SetParamSimple(map, prefix + "HonorCooldown", this.HonorCooldown);
            this.SetParamSimple(map, prefix + "TriggerSource", this.TriggerSource);
        }
    }
}

