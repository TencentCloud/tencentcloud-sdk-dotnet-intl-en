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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAutoSnapshotPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Snapshot repeat time point. value range: 0-23 hr.
        /// </summary>
        [JsonProperty("Hour")]
        public string Hour{ get; set; }

        /// <summary>
        /// Policy name, limited to 64 characters, only supports input of chinese, letters, numbers, _, or -.
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Snapshot repeat date, monday to sunday. 1 represents monday, 7 represents sunday. choose one from three: DayOfMonth, IntervalDays.
        /// </summary>
        [JsonProperty("DayOfWeek")]
        public string DayOfWeek{ get; set; }

        /// <summary>
        /// Specifies the snapshot retention duration in days. the default value is 0 (permanent).
        /// </summary>
        [JsonProperty("AliveDays")]
        public ulong? AliveDays{ get; set; }

        /// <summary>
        /// Snapshot monthly recurrence, select a day from the 1st to the 31st of each month, and a snapshot will be automatically created on that day. for example, 1 represents the 1st. choose one of the three: DayOfWeek, IntervalDays.
        /// </summary>
        [JsonProperty("DayOfMonth")]
        public string DayOfMonth{ get; set; }

        /// <summary>
        /// Interval days. choose one of the three with DayOfWeek and DayOfMonth.
        /// </summary>
        [JsonProperty("IntervalDays")]
        public ulong? IntervalDays{ get; set; }

        /// <summary>
        /// Snapshot policy tag.
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfo[] ResourceTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "DayOfWeek", this.DayOfWeek);
            this.SetParamSimple(map, prefix + "AliveDays", this.AliveDays);
            this.SetParamSimple(map, prefix + "DayOfMonth", this.DayOfMonth);
            this.SetParamSimple(map, prefix + "IntervalDays", this.IntervalDays);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
        }
    }
}

