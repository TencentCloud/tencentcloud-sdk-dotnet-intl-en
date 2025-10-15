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

    public class DependencyStrategyTask : AbstractModel
    {
        
        /// <summary>
        /// Wait upstream task instance policy: EXECUTING (execute); WAITING (wait).
        /// </summary>
        [JsonProperty("PollingNullStrategy")]
        public string PollingNullStrategy{ get; set; }

        /// <summary>
        /// This field is required only when PollingNullStrategy is set to EXECUTING.
        /// Type: List
        /// 
        /// NOT_EXIST (default) - In cases where minute depends on minute / hour depends on hour, the parent instance does not fall within the scheduling time range of the downstream instance.
        /// 
        /// PARENT_EXPIRED - The parent instance failed.
        /// 
        /// PARENT_TIMEOUT - The parent instance timed out.
        /// 
        /// If any of the above conditions are met, the dependency check for that parent task instance is considered satisfied. In all other cases, the system must wait for the parent instance.
        /// </summary>
        [JsonProperty("TaskDependencyExecutingStrategies")]
        public string[] TaskDependencyExecutingStrategies{ get; set; }

        /// <summary>
        /// This field is required only when TaskDependencyExecutingStrategies includes PARENT_TIMEOUT.
        /// Specifies the timeout duration (in minutes) for the downstream task's dependency on the parent instance execution.
        /// </summary>
        [JsonProperty("TaskDependencyExecutingTimeoutValue")]
        public long? TaskDependencyExecutingTimeoutValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PollingNullStrategy", this.PollingNullStrategy);
            this.SetParamArraySimple(map, prefix + "TaskDependencyExecutingStrategies.", this.TaskDependencyExecutingStrategies);
            this.SetParamSimple(map, prefix + "TaskDependencyExecutingTimeoutValue", this.TaskDependencyExecutingTimeoutValue);
        }
    }
}

