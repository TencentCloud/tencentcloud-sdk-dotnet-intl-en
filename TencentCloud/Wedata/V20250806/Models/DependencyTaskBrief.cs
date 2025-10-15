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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DependencyTaskBrief : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Main dependency configuration. Valid values:
        /// 
        /// * CRONTAB
        /// * DAY
        /// * HOUR
        /// * LIST_DAY
        /// * LIST_HOUR
        /// * LIST_MINUTE
        /// * MINUTE
        /// * MONTH
        /// * RANGE_DAY
        /// * RANGE_HOUR
        /// * RANGE_MINUTE
        /// * WEEK
        /// * YEAR
        /// </summary>
        [JsonProperty("MainCyclicConfig")]
        public string MainCyclicConfig{ get; set; }

        /// <summary>
        /// Configures secondary dependencies.  Valid values:
        /// * ALL_DAY_OF_YEAR
        /// * ALL_MONTH_OF_YEAR
        /// * CURRENT
        /// * CURRENT_DAY
        /// * CURRENT_HOUR
        /// * CURRENT_MINUTE
        /// * CURRENT_MONTH
        /// * CURRENT_WEEK
        /// * CURRENT_YEAR
        /// * PREVIOUS_BEGIN_OF_MONTH
        /// * PREVIOUS_DAY
        /// * PREVIOUS_DAY_LATER_OFFSET_HOUR
        /// * PREVIOUS_DAY_LATER_OFFSET_MINUTE
        /// * PREVIOUS_END_OF_MONTH
        /// * PREVIOUS_FRIDAY
        /// * PREVIOUS_HOUR
        /// * PREVIOUS_HOUR_CYCLE
        /// * PREVIOUS_HOUR_LATER_OFFSET_MINUTE
        /// * PREVIOUS_MINUTE_CYCLE
        /// * PREVIOUS_MONTH
        /// * PREVIOUS_WEEK
        /// * PREVIOUS_WEEKEND
        /// * RECENT_DATE
        /// </summary>
        [JsonProperty("SubordinateCyclicConfig")]
        public string SubordinateCyclicConfig{ get; set; }

        /// <summary>
        /// Offset in Range/List Mode
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// Dependency Execution Policy
        /// </summary>
        [JsonProperty("DependencyStrategy")]
        public DependencyStrategyTask DependencyStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "MainCyclicConfig", this.MainCyclicConfig);
            this.SetParamSimple(map, prefix + "SubordinateCyclicConfig", this.SubordinateCyclicConfig);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamObj(map, prefix + "DependencyStrategy.", this.DependencyStrategy);
        }
    }
}

