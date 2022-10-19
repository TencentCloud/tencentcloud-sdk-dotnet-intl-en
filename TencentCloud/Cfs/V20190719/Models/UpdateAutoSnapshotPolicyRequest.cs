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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAutoSnapshotPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Snapshot policy ID
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// Snapshot policy name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// The day of the week on which to regularly back up the snapshot
        /// </summary>
        [JsonProperty("DayOfWeek")]
        public string DayOfWeek{ get; set; }

        /// <summary>
        /// The hour of a day at which to regularly back up the snapshot
        /// </summary>
        [JsonProperty("Hour")]
        public string Hour{ get; set; }

        /// <summary>
        /// Snapshot retention period
        /// </summary>
        [JsonProperty("AliveDays")]
        public ulong? AliveDays{ get; set; }

        /// <summary>
        /// Whether to activate the scheduled snapshot feature
        /// </summary>
        [JsonProperty("IsActivated")]
        public ulong? IsActivated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "DayOfWeek", this.DayOfWeek);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
            this.SetParamSimple(map, prefix + "AliveDays", this.AliveDays);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
        }
    }
}

