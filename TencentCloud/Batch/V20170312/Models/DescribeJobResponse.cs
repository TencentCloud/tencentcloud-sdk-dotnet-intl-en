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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobResponse : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// Information of availability zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Instance priority
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Instance state
        /// </summary>
        [JsonProperty("JobState")]
        public string JobState{ get; set; }

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
        /// Task view information
        /// </summary>
        [JsonProperty("TaskSet")]
        public TaskView[] TaskSet{ get; set; }

        /// <summary>
        /// Information of the dependency among tasks
        /// </summary>
        [JsonProperty("DependenceSet")]
        public Dependence[] DependenceSet{ get; set; }

        /// <summary>
        /// Task statistical metrics
        /// </summary>
        [JsonProperty("TaskMetrics")]
        public TaskMetrics TaskMetrics{ get; set; }

        /// <summary>
        /// Task instance statistical metrics
        /// </summary>
        [JsonProperty("TaskInstanceMetrics")]
        public TaskInstanceMetrics TaskInstanceMetrics{ get; set; }

        /// <summary>
        /// Instance failure reason
        /// </summary>
        [JsonProperty("StateReason")]
        public string StateReason{ get; set; }

        /// <summary>
        /// Tag list bound to the job.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NextAction")]
        public string NextAction{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "JobState", this.JobState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "TaskSet.", this.TaskSet);
            this.SetParamArrayObj(map, prefix + "DependenceSet.", this.DependenceSet);
            this.SetParamObj(map, prefix + "TaskMetrics.", this.TaskMetrics);
            this.SetParamObj(map, prefix + "TaskInstanceMetrics.", this.TaskInstanceMetrics);
            this.SetParamSimple(map, prefix + "StateReason", this.StateReason);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NextAction", this.NextAction);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

