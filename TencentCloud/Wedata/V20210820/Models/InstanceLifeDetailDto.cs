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

    public class InstanceLifeDetailDto : AbstractModel
    {
        
        /// <summary>
        /// Indicates the status of an instance.
        /// -[0] Indicates waiting for event.
        /// -[12] indicates waiting for upstream.
        /// -[6, 7, 9, 10, 18] indicates awaiting execution.
        /// -[1, 19, 22]  indicate running.
        /// -[21] skip running.
        /// -[3] indicates retry on failure.
        /// -[8, 4, 5, 13] indicates a failure.
        /// -[2] indicates a success.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Start Time of the State
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Instance lifecycle phase status.
        /// 
        /// -WAIT_UPSTREAM indicates waiting for an event or upstream status.
        /// -WAIT_RUN indicates waiting for running status.
        /// -RUNNING indicates the running state.
        /// -COMPLETE indicates terminal state - completed.
        /// -FAILED indicates terminal state - retry after failure.
        /// -EXPIRED indicates terminal state - failure.
        /// -SKIP_RUNNING indicates terminal state - a branch skipped by the upstream branch node.
        /// -HISTORY indicates compatibility with historical instances before march 30, 2024. no need to pay attention to this enumeration type for instances afterward.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DetailState")]
        public string DetailState{ get; set; }

        /// <summary>
        /// End Time of the State
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "DetailState", this.DetailState);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

