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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DlcExpiredSnapshotsInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable snapshot expiration governance: enable, none
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExpiredSnapshotsEnable")]
        public string ExpiredSnapshotsEnable{ get; set; }

        /// <summary>
        /// Name of the engine used to run snapshot expiration governance
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// Number of recent snapshots to retain
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RetainLast")]
        public ulong? RetainLast{ get; set; }

        /// <summary>
        /// Snapshots expired before specified days
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BeforeDays")]
        public ulong? BeforeDays{ get; set; }

        /// <summary>
        /// Number of parallel processes for cleaning up expired snapshots
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MaxConcurrentDeletes")]
        public ulong? MaxConcurrentDeletes{ get; set; }

        /// <summary>
        /// Snapshot expiration governance run cycle, unit: minutes
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IntervalMin")]
        public ulong? IntervalMin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpiredSnapshotsEnable", this.ExpiredSnapshotsEnable);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "RetainLast", this.RetainLast);
            this.SetParamSimple(map, prefix + "BeforeDays", this.BeforeDays);
            this.SetParamSimple(map, prefix + "MaxConcurrentDeletes", this.MaxConcurrentDeletes);
            this.SetParamSimple(map, prefix + "IntervalMin", this.IntervalMin);
        }
    }
}

