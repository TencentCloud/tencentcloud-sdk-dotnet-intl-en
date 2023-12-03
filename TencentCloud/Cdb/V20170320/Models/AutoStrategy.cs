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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoStrategy : AbstractModel
    {
        
        /// <summary>
        /// CPU utilization threshold (percent value). Valid values: 70, 80, and 90. Automatic scale-out will be triggered when CPU utilization reaches the set threshold.
        /// </summary>
        [JsonProperty("ExpandThreshold")]
        public long? ExpandThreshold{ get; set; }

        /// <summary>
        /// Interval, in seconds. Valid values: 1, 3, 5, 10, 15, and 30. The system backend determines whether automatic scale-out is required at the set interval.
        /// </summary>
        [JsonProperty("ExpandPeriod")]
        public long? ExpandPeriod{ get; set; }

        /// <summary>
        /// CPU utilization threshold (percent value). Valid values: 10, 20, and 30. Automatic scale-in will be triggered when CPU utilization reaches the set threshold.
        /// </summary>
        [JsonProperty("ShrinkThreshold")]
        public long? ShrinkThreshold{ get; set; }

        /// <summary>
        /// Interval, in seconds. Valid values: 5, 10, 15, and 30. The system backend determines whether automatic scale-in is required at the set interval.
        /// </summary>
        [JsonProperty("ShrinkPeriod")]
        public long? ShrinkPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpandThreshold", this.ExpandThreshold);
            this.SetParamSimple(map, prefix + "ExpandPeriod", this.ExpandPeriod);
            this.SetParamSimple(map, prefix + "ShrinkThreshold", this.ShrinkThreshold);
            this.SetParamSimple(map, prefix + "ShrinkPeriod", this.ShrinkPeriod);
        }
    }
}

