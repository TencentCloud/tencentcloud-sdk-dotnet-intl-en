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

    public class KillWorkflowRunRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace ID, which can be obtained through ListWorkspaces. Required.</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Workflow ID. You can obtain it through ListWorkflows. Required</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>List of workflow running IDs pending termination. You can obtain it through ListWorkflowRuns</p>
        /// </summary>
        [JsonProperty("WorkflowRunIds")]
        public string[] WorkflowRunIds{ get; set; }

        /// <summary>
        /// <p>Whether to terminate all running instances in the workflow that have not entered the final state. Optional. false by default.</p>
        /// </summary>
        [JsonProperty("KillAllRuns")]
        public bool? KillAllRuns{ get; set; }

        /// <summary>
        /// <p>Whether to terminate only the running that is in the Waiting (Pending) state. Optional. false by default</p>
        /// </summary>
        [JsonProperty("OnlyKillPendingRuns")]
        public bool? OnlyKillPendingRuns{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamArraySimple(map, prefix + "WorkflowRunIds.", this.WorkflowRunIds);
            this.SetParamSimple(map, prefix + "KillAllRuns", this.KillAllRuns);
            this.SetParamSimple(map, prefix + "OnlyKillPendingRuns", this.OnlyKillPendingRuns);
        }
    }
}

