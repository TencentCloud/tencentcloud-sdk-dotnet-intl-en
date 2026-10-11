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

    public class WorkflowRun : AbstractModel
    {
        
        /// <summary>
        /// <p>Root account ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Workflow name</p>
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// <p>Workflow ID</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>Workflow running ID</p>
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// <p>Workspace ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Trigger mode: Scheduler, ManualTrigger, Event (for reference, see SchedulerTriggerType)</p>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>Start time in milliseconds.</p>
        /// </summary>
        [JsonProperty("RunStartTime")]
        public string RunStartTime{ get; set; }

        /// <summary>
        /// <p>Start time of the pending state, unit: timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("PendingStartTime")]
        public string PendingStartTime{ get; set; }

        /// <summary>
        /// <p>queue status start time, unit: timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("QueueStartTime")]
        public string QueueStartTime{ get; set; }

        /// <summary>
        /// <p>Running end time, unit: timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("RunEndTime")]
        public string RunEndTime{ get; set; }

        /// <summary>
        /// <p>End time. It has a value when running enters the end state. Unit: timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Running time, unit: seconds</p>
        /// </summary>
        [JsonProperty("RunCostTime")]
        public string RunCostTime{ get; set; }

        /// <summary>
        /// <p>Concurrency queue time, in seconds</p>
        /// </summary>
        [JsonProperty("QueueCostTime")]
        public string QueueCostTime{ get; set; }

        /// <summary>
        /// <p>Time spent waiting for resources, in seconds</p>
        /// </summary>
        [JsonProperty("PendingCostTime")]
        public string PendingCostTime{ get; set; }

        /// <summary>
        /// <p>RUNNING state. CREATE("initialization"), QUEUED("Waiting"), PENDING("preparing"), RUNNING("RUNNING"), SKIPPED("skip RUNNING"), SUCCESS("successful"), FAILED("failure"), TERMINATING("TERMINATING"), TERMINATED("termination"), CANCELLED("manual termination"), etc.</p>
        /// </summary>
        [JsonProperty("RunState")]
        public string RunState{ get; set; }

        /// <summary>
        /// <p>Computational resource (resource group ID set of the task)</p>
        /// </summary>
        [JsonProperty("ResourceGroupIds")]
        public string[] ResourceGroupIds{ get; set; }

        /// <summary>
        /// <p>Running user UIN</p>
        /// </summary>
        [JsonProperty("RunUserUin")]
        public string RunUserUin{ get; set; }

        /// <summary>
        /// <p>Username for operation</p>
        /// </summary>
        [JsonProperty("RunUserName")]
        public string RunUserName{ get; set; }

        /// <summary>
        /// <p>Error code</p>
        /// </summary>
        [JsonProperty("ErrorCodeString")]
        public string ErrorCodeString{ get; set; }

        /// <summary>
        /// <p>Running parameter</p>
        /// </summary>
        [JsonProperty("WorkflowParams")]
        public string WorkflowParams{ get; set; }

        /// <summary>
        /// <p>Workflow version ID</p>
        /// </summary>
        [JsonProperty("WorkflowVersionId")]
        public string WorkflowVersionId{ get; set; }

        /// <summary>
        /// <p>Whether rerunning is supported for the current workflow</p>
        /// </summary>
        [JsonProperty("SupportRerun")]
        public bool? SupportRerun{ get; set; }

        /// <summary>
        /// <p>Workflow run creation time. Unit: millisecond timestamp</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Number of reruns.</p>
        /// </summary>
        [JsonProperty("RerunTimes")]
        public long? RerunTimes{ get; set; }

        /// <summary>
        /// <p>Task scope in operation, Task ID list</p>
        /// </summary>
        [JsonProperty("SelectedTaskIds")]
        public string[] SelectedTaskIds{ get; set; }

        /// <summary>
        /// <p>Resource group information list.</p>
        /// </summary>
        [JsonProperty("ResourceGroupInfoList")]
        public ResourceGroupInfo[] ResourceGroupInfoList{ get; set; }

        /// <summary>
        /// <p>Tag list.</p>
        /// </summary>
        [JsonProperty("LabelList")]
        public LabelBrief[] LabelList{ get; set; }

        /// <summary>
        /// <p>Parent workflow running ID [unique to nested workflow triggers]</p>
        /// </summary>
        [JsonProperty("ParentWorkflowRunId")]
        public string ParentWorkflowRunId{ get; set; }

        /// <summary>
        /// <p>Parent workflow task running ID [unique to nested workflow triggers]</p>
        /// </summary>
        [JsonProperty("ParentWorkflowTaskRunId")]
        public string ParentWorkflowTaskRunId{ get; set; }

        /// <summary>
        /// <p>Parent workflow task run name [exclusive to nested workflow triggers]</p>
        /// </summary>
        [JsonProperty("ParentWorkflowTaskRunName")]
        public string ParentWorkflowTaskRunName{ get; set; }

        /// <summary>
        /// <p>Authorization permission type<br>PERMISSION_TYPE_UNSPECIFIED: unspecified permission<br>MANAGE: management permission, including all operation permissions<br>RUN: execution permission, executable entity<br>VIEW: view permission, viewable entity content</p>
        /// </summary>
        [JsonProperty("Permission")]
        public string Permission{ get; set; }

        /// <summary>
        /// <p>Parameters filled in by the user during advanced execution of the workflow</p>
        /// </summary>
        [JsonProperty("AdvancedParameters")]
        public AdvancedParameter[] AdvancedParameters{ get; set; }

        /// <summary>
        /// <p>Scheduled dispatch time</p><p>Parameter format: timestamp in milliseconds (UTC)</p>
        /// </summary>
        [JsonProperty("ScheduledTime")]
        public string ScheduledTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "RunStartTime", this.RunStartTime);
            this.SetParamSimple(map, prefix + "PendingStartTime", this.PendingStartTime);
            this.SetParamSimple(map, prefix + "QueueStartTime", this.QueueStartTime);
            this.SetParamSimple(map, prefix + "RunEndTime", this.RunEndTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RunCostTime", this.RunCostTime);
            this.SetParamSimple(map, prefix + "QueueCostTime", this.QueueCostTime);
            this.SetParamSimple(map, prefix + "PendingCostTime", this.PendingCostTime);
            this.SetParamSimple(map, prefix + "RunState", this.RunState);
            this.SetParamArraySimple(map, prefix + "ResourceGroupIds.", this.ResourceGroupIds);
            this.SetParamSimple(map, prefix + "RunUserUin", this.RunUserUin);
            this.SetParamSimple(map, prefix + "RunUserName", this.RunUserName);
            this.SetParamSimple(map, prefix + "ErrorCodeString", this.ErrorCodeString);
            this.SetParamSimple(map, prefix + "WorkflowParams", this.WorkflowParams);
            this.SetParamSimple(map, prefix + "WorkflowVersionId", this.WorkflowVersionId);
            this.SetParamSimple(map, prefix + "SupportRerun", this.SupportRerun);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RerunTimes", this.RerunTimes);
            this.SetParamArraySimple(map, prefix + "SelectedTaskIds.", this.SelectedTaskIds);
            this.SetParamArrayObj(map, prefix + "ResourceGroupInfoList.", this.ResourceGroupInfoList);
            this.SetParamArrayObj(map, prefix + "LabelList.", this.LabelList);
            this.SetParamSimple(map, prefix + "ParentWorkflowRunId", this.ParentWorkflowRunId);
            this.SetParamSimple(map, prefix + "ParentWorkflowTaskRunId", this.ParentWorkflowTaskRunId);
            this.SetParamSimple(map, prefix + "ParentWorkflowTaskRunName", this.ParentWorkflowTaskRunName);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamArrayObj(map, prefix + "AdvancedParameters.", this.AdvancedParameters);
            this.SetParamSimple(map, prefix + "ScheduledTime", this.ScheduledTime);
        }
    }
}

