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

    public class DescribeTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// Job ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Task name
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Task status
        /// </summary>
        [JsonProperty("TaskState")]
        public string TaskState{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// End time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Total number of task instances
        /// </summary>
        [JsonProperty("TaskInstanceTotalCount")]
        public long? TaskInstanceTotalCount{ get; set; }

        /// <summary>
        /// Task instance information
        /// </summary>
        [JsonProperty("TaskInstanceSet")]
        public TaskInstanceView[] TaskInstanceSet{ get; set; }

        /// <summary>
        /// Task instance statistical metrics
        /// </summary>
        [JsonProperty("TaskInstanceMetrics")]
        public TaskInstanceMetrics TaskInstanceMetrics{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskState", this.TaskState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskInstanceTotalCount", this.TaskInstanceTotalCount);
            this.SetParamArrayObj(map, prefix + "TaskInstanceSet.", this.TaskInstanceSet);
            this.SetParamObj(map, prefix + "TaskInstanceMetrics.", this.TaskInstanceMetrics);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

