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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoStrategy : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling threshold. Available values: 40, 50, 60, 70, 80, 90. Represents the CPU utilization reaches 40%, 50%, 60%, 70%, 80%, or 90% to trigger auto scaling in the background.
        /// </summary>
        [JsonProperty("ExpandThreshold")]
        public long? ExpandThreshold{ get; set; }

        /// <summary>
        /// CPU utilization threshold (percent value). Valid values: 10, 20, and 30. Automatic scale-in will be triggered when CPU utilization reaches the set threshold.
        /// </summary>
        [JsonProperty("ShrinkThreshold")]
        public long? ShrinkThreshold{ get; set; }

        /// <summary>
        /// Auto-scaling observation period, in minutes, available values 1, 3, 5, 10, 15, 30. The backend will judge scaling out according to the configured period.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpandPeriod")]
        [System.Obsolete]
        public long? ExpandPeriod{ get; set; }

        /// <summary>
        /// Automatic scaling down observation period, in minutes, available values 5, 10, 15, 30. The backend performs scale-in judgment according to the configured period.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShrinkPeriod")]
        [System.Obsolete]
        public long? ShrinkPeriod{ get; set; }

        /// <summary>
        /// Elastic scaling observation period (in seconds). Value is 15, 30, 45, 60, 180, 300, 600, 900, or 1800.
        /// </summary>
        [JsonProperty("ExpandSecondPeriod")]
        public long? ExpandSecondPeriod{ get; set; }

        /// <summary>
        /// Scale-down observation period (in seconds). Valid values: 300, 600, 900, 1800.
        /// </summary>
        [JsonProperty("ShrinkSecondPeriod")]
        public long? ShrinkSecondPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpandThreshold", this.ExpandThreshold);
            this.SetParamSimple(map, prefix + "ShrinkThreshold", this.ShrinkThreshold);
            this.SetParamSimple(map, prefix + "ExpandPeriod", this.ExpandPeriod);
            this.SetParamSimple(map, prefix + "ShrinkPeriod", this.ShrinkPeriod);
            this.SetParamSimple(map, prefix + "ExpandSecondPeriod", this.ExpandSecondPeriod);
            this.SetParamSimple(map, prefix + "ShrinkSecondPeriod", this.ShrinkSecondPeriod);
        }
    }
}

