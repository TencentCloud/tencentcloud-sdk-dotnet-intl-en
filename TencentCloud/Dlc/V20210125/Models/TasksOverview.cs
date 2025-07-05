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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TasksOverview : AbstractModel
    {
        
        /// <summary>
        /// The number of tasks in queue.
        /// </summary>
        [JsonProperty("TaskQueuedCount")]
        public long? TaskQueuedCount{ get; set; }

        /// <summary>
        /// The number of initialized tasks.
        /// </summary>
        [JsonProperty("TaskInitCount")]
        public long? TaskInitCount{ get; set; }

        /// <summary>
        /// The number of tasks in progress.
        /// </summary>
        [JsonProperty("TaskRunningCount")]
        public long? TaskRunningCount{ get; set; }

        /// <summary>
        /// The total number of tasks in this time range.
        /// </summary>
        [JsonProperty("TotalTaskCount")]
        public long? TotalTaskCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskQueuedCount", this.TaskQueuedCount);
            this.SetParamSimple(map, prefix + "TaskInitCount", this.TaskInitCount);
            this.SetParamSimple(map, prefix + "TaskRunningCount", this.TaskRunningCount);
            this.SetParamSimple(map, prefix + "TotalTaskCount", this.TotalTaskCount);
        }
    }
}

