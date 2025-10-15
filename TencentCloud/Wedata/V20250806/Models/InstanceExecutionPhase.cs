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

    public class InstanceExecutionPhase : AbstractModel
    {
        
        /// <summary>
        /// Start time of the state.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// **Instance lifecycle phase status**.
        /// 
        /// -WAIT_UPSTREAM indicates the wait event/upstream status.
        /// -WAIT_RUN indicates the waiting for running status.
        /// -RUNNING indicates the running state.
        /// -COMPLETE indicates the final state of completion.
        /// - FAILED indicates the final state - retry on failure.
        /// -EXPIRED indicates the final state - failure.
        /// -SKIP_RUNNING indicates the branch skipped by the upstream branch node in the final state.
        /// -HISTORY indicates compatibility with historical instances before 2024-03-30. no need to pay attention to this enum afterward.
        /// </summary>
        [JsonProperty("DetailState")]
        public string DetailState{ get; set; }

        /// <summary>
        /// End time of the state.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "DetailState", this.DetailState);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

