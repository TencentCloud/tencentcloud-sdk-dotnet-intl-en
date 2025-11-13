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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimingSettingsResp : AbstractModel
    {
        
        /// <summary>
        /// Event trigger type
        /// </summary>
        [JsonProperty("StartType")]
        public string StartType{ get; set; }

        /// <summary>
        /// Not empty if `StartType` is `FIXED_TIME`
        /// UTC time, such as `2020-01-01T12:00:00Z`
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// This parameter cannot be empty if `EventType` is `TIMED_RECORD`.
        /// It indicates the start time for recording in UTC format (e.g., `2020-01-01T12:00:00Z`) and must be at least 1 minute later than the current time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// This parameter cannot be empty if `EventType` is `TIMED_RECORD`.
        /// It indicates the end time for recording in UTC format (e.g., `2020-01-01T12:00:00Z`) and must be at least 1 minute later than the start time for recording.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Effective only when StartType is FIXED_PTS, with a range of 1-8589934592
        /// </summary>
        [JsonProperty("PTS")]
        public ulong? PTS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartType", this.StartType);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PTS", this.PTS);
        }
    }
}

