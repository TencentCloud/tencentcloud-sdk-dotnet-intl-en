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

    public class Job : AbstractModel
    {
        
        /// <summary>
        /// Job information
        /// </summary>
        [JsonProperty("Tasks")]
        public Task[] Tasks{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// Instance description
        /// </summary>
        [JsonProperty("JobDescription")]
        public string JobDescription{ get; set; }

        /// <summary>
        /// Instance priority. Tasks (Task) and task instances (TaskInstance) inherit the priority of the instance
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// Dependency information
        /// </summary>
        [JsonProperty("Dependences")]
        public Dependence[] Dependences{ get; set; }

        /// <summary>
        /// Notification information
        /// </summary>
        [JsonProperty("Notifications")]
        public Notification[] Notifications{ get; set; }

        /// <summary>
        /// This is the dependency of the subsequent task on the previous task if there is a dependent relationship between them. Value range: PRE_TASK_SUCCEED, PRE_TASK_AT_LEAST_PARTLY_SUCCEED, PRE_TASK_FINISHED. Default value: PRE_TASK_SUCCEED.
        /// </summary>
        [JsonProperty("TaskExecutionDependOn")]
        public string TaskExecutionDependOn{ get; set; }

        /// <summary>
        /// Indicates which policy will be used in case that CVM instance creation fails. Value range: FAILED, RUNNABLE. FAILED indicates that the CVM instance creation failure will be processed as an execution failure, while RUNNABLE indicates that the failure will be processed as "keep waiting". Default value: FAILED. StateIfCreateCvmFailed is not valid for submitted jobs for which a compute environment is specified.
        /// </summary>
        [JsonProperty("StateIfCreateCvmFailed")]
        public string StateIfCreateCvmFailed{ get; set; }

        /// <summary>
        /// Tag list. By setting this parameter, you can bind tags to a job. Each job supports up to 10 tags.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "JobDescription", this.JobDescription);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamArrayObj(map, prefix + "Dependences.", this.Dependences);
            this.SetParamArrayObj(map, prefix + "Notifications.", this.Notifications);
            this.SetParamSimple(map, prefix + "TaskExecutionDependOn", this.TaskExecutionDependOn);
            this.SetParamSimple(map, prefix + "StateIfCreateCvmFailed", this.StateIfCreateCvmFailed);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

