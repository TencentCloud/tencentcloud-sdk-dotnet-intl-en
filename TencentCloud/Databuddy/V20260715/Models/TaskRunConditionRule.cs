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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskRunConditionRule : AbstractModel
    {
        
        /// <summary>
        /// <p>Upstream task ID</p>
        /// </summary>
        [JsonProperty("UpstreamTaskId")]
        public string UpstreamTaskId{ get; set; }

        /// <summary>
        /// <p>Upstream task name</p>
        /// </summary>
        [JsonProperty("UpstreamTaskName")]
        public string UpstreamTaskName{ get; set; }

        /// <summary>
        /// <p>Task run conditions<br>Supported status values: - SUCCESS: successful - FAILED: failed - UPSTREAM_FAILED: upstream failed - EXCLUDED: excluded from running</p>
        /// </summary>
        [JsonProperty("AllowedStates")]
        public string[] AllowedStates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UpstreamTaskId", this.UpstreamTaskId);
            this.SetParamSimple(map, prefix + "UpstreamTaskName", this.UpstreamTaskName);
            this.SetParamArraySimple(map, prefix + "AllowedStates.", this.AllowedStates);
        }
    }
}

