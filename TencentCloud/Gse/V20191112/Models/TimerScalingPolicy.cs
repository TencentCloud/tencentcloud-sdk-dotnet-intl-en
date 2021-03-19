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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimerScalingPolicy : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of the policy. When it’s filled in, the policy will be updated.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimerId")]
        public string TimerId{ get; set; }

        /// <summary>
        /// Scheduled scaling policy name
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimerName")]
        public string TimerName{ get; set; }

        /// <summary>
        /// Scheduled scaling policy status. `0`: Undefined, `1`: Not started, 2: Activated, `3`: Stopped, `4`: Expired
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimerStatus")]
        public long? TimerStatus{ get; set; }

        /// <summary>
        /// The capacity configurations of the scheduled scaling policy
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimerFleetCapacity")]
        public TimerFleetCapacity TimerFleetCapacity{ get; set; }

        /// <summary>
        /// The recurrence pattern of auto-scaling
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimerConfiguration")]
        public TimerConfiguration TimerConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimerId", this.TimerId);
            this.SetParamSimple(map, prefix + "TimerName", this.TimerName);
            this.SetParamSimple(map, prefix + "TimerStatus", this.TimerStatus);
            this.SetParamObj(map, prefix + "TimerFleetCapacity.", this.TimerFleetCapacity);
            this.SetParamObj(map, prefix + "TimerConfiguration.", this.TimerConfiguration);
        }
    }
}

