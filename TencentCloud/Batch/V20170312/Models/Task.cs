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

    public class Task : AbstractModel
    {
        
        /// <summary>
        /// Application information
        /// </summary>
        [JsonProperty("Application")]
        public Application Application{ get; set; }

        /// <summary>
        /// Task name, which should be unique within a job
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Number of running task instances
        /// </summary>
        [JsonProperty("TaskInstanceNum")]
        public ulong? TaskInstanceNum{ get; set; }

        /// <summary>
        /// Compute environment information. One (and only one) parameter must be specified for ComputeEnv and EnvId.
        /// </summary>
        [JsonProperty("ComputeEnv")]
        public AnonymousComputeEnv ComputeEnv{ get; set; }

        /// <summary>
        /// Compute environment ID. One (and only one) parameter must be specified for ComputeEnv and EnvId.
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// Redirection information
        /// </summary>
        [JsonProperty("RedirectInfo")]
        public RedirectInfo RedirectInfo{ get; set; }

        /// <summary>
        /// Local redirection information
        /// </summary>
        [JsonProperty("RedirectLocalInfo")]
        public RedirectLocalInfo RedirectLocalInfo{ get; set; }

        /// <summary>
        /// Input mapping
        /// </summary>
        [JsonProperty("InputMappings")]
        public InputMapping[] InputMappings{ get; set; }

        /// <summary>
        /// Output mapping
        /// </summary>
        [JsonProperty("OutputMappings")]
        public OutputMapping[] OutputMappings{ get; set; }

        /// <summary>
        /// Output mapping configuration
        /// </summary>
        [JsonProperty("OutputMappingConfigs")]
        public OutputMappingConfig[] OutputMappingConfigs{ get; set; }

        /// <summary>
        /// Custom environment variable
        /// </summary>
        [JsonProperty("EnvVars")]
        public EnvVar[] EnvVars{ get; set; }

        /// <summary>
        /// Authorization information
        /// </summary>
        [JsonProperty("Authentications")]
        public Authentication[] Authentications{ get; set; }

        /// <summary>
        /// The processing method after the TaskInstance fails; Value range: `TERMINATE` (default), `INTERRUPT`, `FAST_INTERRUPT`.
        /// </summary>
        [JsonProperty("FailedAction")]
        public string FailedAction{ get; set; }

        /// <summary>
        /// The maximum number of retries after the task fails. Range: 0 - 5. Default value: 0
        /// </summary>
        [JsonProperty("MaxRetryCount")]
        public ulong? MaxRetryCount{ get; set; }

        /// <summary>
        /// Timeout period of the task in seconds. Defaults value: 86400
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// The maximum number of concurrent tasks. Range: 0 - 200000. There is no limit by default.
        /// </summary>
        [JsonProperty("MaxConcurrentNum")]
        public ulong? MaxConcurrentNum{ get; set; }

        /// <summary>
        /// Restarts the compute node after the task is completed. This is suitable for specifying the compute environment for task execution.
        /// </summary>
        [JsonProperty("RestartComputeNode")]
        public bool? RestartComputeNode{ get; set; }

        /// <summary>
        /// Maximum number of retry attempts after failing to create computing resources such as the CVM in the task launch process. Default: `0`; Maximum: `100`.
        /// </summary>
        [JsonProperty("ResourceMaxRetryCount")]
        public ulong? ResourceMaxRetryCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Application.", this.Application);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskInstanceNum", this.TaskInstanceNum);
            this.SetParamObj(map, prefix + "ComputeEnv.", this.ComputeEnv);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamObj(map, prefix + "RedirectInfo.", this.RedirectInfo);
            this.SetParamObj(map, prefix + "RedirectLocalInfo.", this.RedirectLocalInfo);
            this.SetParamArrayObj(map, prefix + "InputMappings.", this.InputMappings);
            this.SetParamArrayObj(map, prefix + "OutputMappings.", this.OutputMappings);
            this.SetParamArrayObj(map, prefix + "OutputMappingConfigs.", this.OutputMappingConfigs);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamArrayObj(map, prefix + "Authentications.", this.Authentications);
            this.SetParamSimple(map, prefix + "FailedAction", this.FailedAction);
            this.SetParamSimple(map, prefix + "MaxRetryCount", this.MaxRetryCount);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "MaxConcurrentNum", this.MaxConcurrentNum);
            this.SetParamSimple(map, prefix + "RestartComputeNode", this.RestartComputeNode);
            this.SetParamSimple(map, prefix + "ResourceMaxRetryCount", this.ResourceMaxRetryCount);
        }
    }
}

