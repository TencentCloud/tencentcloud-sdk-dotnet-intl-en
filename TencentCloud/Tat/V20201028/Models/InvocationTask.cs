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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvocationTask : AbstractModel
    {
        
        /// <summary>
        /// Execution activity ID.
        /// </summary>
        [JsonProperty("InvocationId")]
        public string InvocationId{ get; set; }

        /// <summary>
        /// Execution task ID.
        /// </summary>
        [JsonProperty("InvocationTaskId")]
        public string InvocationTaskId{ get; set; }

        /// <summary>
        /// Command ID.
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// Execution task status. valid values:.
        /// 
        /// -PENDING: waiting for distribution.
        /// -DELIVERING: distributing.
        /// -DELIVER_DELAYED: delivery delay.
        /// -DELIVER_FAILED: delivery fail.
        /// -START_FAILED: command start failed.
        /// - RUNNING: command RUNNING.
        /// -SUCCESS: command success.
        /// -FAILED: command execution failed, exit code not 0.
        /// -TIMEOUT: command timeout.
        /// -TASK_TIMEOUT: client no response.
        /// -Canceling.
        /// - CANCELLED: canceled (command canceled before startup).
        /// -TERMINATED: suspended (canceled during command execution).
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Execution result.
        /// </summary>
        [JsonProperty("TaskResult")]
        public TaskResult TaskResult{ get; set; }

        /// <summary>
        /// Task start time. format: YYYY-MM-DDThh:MM:ssZ.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task end time. format: YYYY-MM-DDThh:MM:ssZ.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Creation time. the format is YYYY-MM-DDThh:MM:ssZ.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Update time. the format is YYYY-MM-DDThh:MM:ssZ.
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// Command details of the execution task.
        /// </summary>
        [JsonProperty("CommandDocument")]
        public CommandDocument CommandDocument{ get; set; }

        /// <summary>
        /// Error message displayed when the execution task fails.
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// Invocation source.
        /// 
        /// -USER: originate from user invocation.
        /// -INVOKER: originate from scheduled execution.
        /// </summary>
        [JsonProperty("InvocationSource")]
        public string InvocationSource{ get; set; }

        /// <summary>
        /// Name of the executed command.
        /// </summary>
        [JsonProperty("CommandName")]
        public string CommandName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvocationId", this.InvocationId);
            this.SetParamSimple(map, prefix + "InvocationTaskId", this.InvocationTaskId);
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "TaskResult.", this.TaskResult);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamObj(map, prefix + "CommandDocument.", this.CommandDocument);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "InvocationSource", this.InvocationSource);
            this.SetParamSimple(map, prefix + "CommandName", this.CommandName);
        }
    }
}

