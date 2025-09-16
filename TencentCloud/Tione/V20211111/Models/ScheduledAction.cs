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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduledAction : AbstractModel
    {
        
        /// <summary>
        /// Whether to stop the service on schedule. Valid values: true and false. If the value is true, ScheduleStopTime is required. If the value is false, ScheduleStopTime does not take effect.
        /// </summary>
        [JsonProperty("ScheduleStop")]
        public bool? ScheduleStop{ get; set; }

        /// <summary>
        /// Time to execute the scheduled stop. Format: "2022-01-26T19:46:22+08:00".
        /// </summary>
        [JsonProperty("ScheduleStopTime")]
        public string ScheduleStopTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduleStop", this.ScheduleStop);
            this.SetParamSimple(map, prefix + "ScheduleStopTime", this.ScheduleStopTime);
        }
    }
}

