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

    public class InferenceScheduledScalingPolicy : AbstractModel
    {
        
        /// <summary>
        /// Scheduled scaling action list. Fill in at least 1, supports up to 10.
        /// </summary>
        [JsonProperty("ScheduledActions")]
        public InferenceScheduledScalingAction[] ScheduledActions{ get; set; }

        /// <summary>
        /// Validity period range, for description of whether the scheduled scaling policy is permanently valid or valid only within a specified date range.
        /// </summary>
        [JsonProperty("EffectiveRange")]
        public InferenceScheduledScalingEffectiveRange EffectiveRange{ get; set; }

        /// <summary>
        /// Time zone, using [IANA time zone](https://www.iana.org/time-zones) to identify the trigger time in ScheduledActions, such as UTC, Asia/Shanghai, America/New_York, Europe/London, Asia/Kolkata. UTC is used by default if not specified.
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ScheduledActions.", this.ScheduledActions);
            this.SetParamObj(map, prefix + "EffectiveRange.", this.EffectiveRange);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

