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

    public class RunWorkflowRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace ID, which can be obtained through ListWorkspaces. Required</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Workflow ID, which can be obtained through ListWorkflows. Required</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>Running type. Required. Value: 1 ordinary, 2 advanced running</p>
        /// </summary>
        [JsonProperty("RunType")]
        public long? RunType{ get; set; }

        /// <summary>
        /// <p>Custom running parameter filled in when the running type is advanced running</p>
        /// </summary>
        [JsonProperty("AdvancedParams")]
        public TaskSchedulingParameterBrief[] AdvancedParams{ get; set; }

        /// <summary>
        /// <p>This time, the specified task ID set needs to be run, which can be obtained through ListWorkflowTasks. If not passed, all tasks under the workflow run by default.</p>
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// <p>Idempotency token. Optional. Duplicate requests with the same token trigger only once</p>
        /// </summary>
        [JsonProperty("IdempotencyToken")]
        public string IdempotencyToken{ get; set; }

        /// <summary>
        /// <p>Scheduled dispatch time list configuration</p>
        /// </summary>
        [JsonProperty("ScheduledTimeConfig")]
        public ScheduledTimeConfig ScheduledTimeConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamArrayObj(map, prefix + "AdvancedParams.", this.AdvancedParams);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamSimple(map, prefix + "IdempotencyToken", this.IdempotencyToken);
            this.SetParamObj(map, prefix + "ScheduledTimeConfig.", this.ScheduledTimeConfig);
        }
    }
}

