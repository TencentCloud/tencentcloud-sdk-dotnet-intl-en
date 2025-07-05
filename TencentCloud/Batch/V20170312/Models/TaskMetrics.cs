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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskMetrics : AbstractModel
    {
        
        /// <summary>
        /// Number of submitted tasks
        /// </summary>
        [JsonProperty("SubmittedCount")]
        public long? SubmittedCount{ get; set; }

        /// <summary>
        /// Number of pending tasks
        /// </summary>
        [JsonProperty("PendingCount")]
        public long? PendingCount{ get; set; }

        /// <summary>
        /// Number of Runnable tasks
        /// </summary>
        [JsonProperty("RunnableCount")]
        public long? RunnableCount{ get; set; }

        /// <summary>
        /// Number of starting tasks
        /// </summary>
        [JsonProperty("StartingCount")]
        public long? StartingCount{ get; set; }

        /// <summary>
        /// Number of running tasks
        /// </summary>
        [JsonProperty("RunningCount")]
        public long? RunningCount{ get; set; }

        /// <summary>
        /// Number of successful tasks
        /// </summary>
        [JsonProperty("SucceedCount")]
        public long? SucceedCount{ get; set; }

        /// <summary>
        /// Number of failed and interrupted tasks
        /// </summary>
        [JsonProperty("FailedInterruptedCount")]
        public long? FailedInterruptedCount{ get; set; }

        /// <summary>
        /// Failed count
        /// </summary>
        [JsonProperty("FailedCount")]
        public long? FailedCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubmittedCount", this.SubmittedCount);
            this.SetParamSimple(map, prefix + "PendingCount", this.PendingCount);
            this.SetParamSimple(map, prefix + "RunnableCount", this.RunnableCount);
            this.SetParamSimple(map, prefix + "StartingCount", this.StartingCount);
            this.SetParamSimple(map, prefix + "RunningCount", this.RunningCount);
            this.SetParamSimple(map, prefix + "SucceedCount", this.SucceedCount);
            this.SetParamSimple(map, prefix + "FailedInterruptedCount", this.FailedInterruptedCount);
            this.SetParamSimple(map, prefix + "FailedCount", this.FailedCount);
        }
    }
}

