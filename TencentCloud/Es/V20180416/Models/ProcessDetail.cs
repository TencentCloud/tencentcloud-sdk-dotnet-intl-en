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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of completed</p>
        /// </summary>
        [JsonProperty("Completed")]
        public long? Completed{ get; set; }

        /// <summary>
        /// <p>Remaining quantity</p>
        /// </summary>
        [JsonProperty("Remain")]
        public long? Remain{ get; set; }

        /// <summary>
        /// <p>Total quantity.</p>
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// <p>Task type:<br>60: Restart task<br>70: Shard migration task<br>80: Node configuration modification task</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// <p>Estimated remaining time</p><p>Unit: seconds</p>
        /// </summary>
        [JsonProperty("EstimatedTimeRemaining")]
        public long? EstimatedTimeRemaining{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Completed", this.Completed);
            this.SetParamSimple(map, prefix + "Remain", this.Remain);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "EstimatedTimeRemaining", this.EstimatedTimeRemaining);
        }
    }
}

