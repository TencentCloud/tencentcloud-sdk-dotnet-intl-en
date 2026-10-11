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

    public class GetWorkflowRsp : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Workflow basic info</p>
        /// </summary>
        [JsonProperty("BaseInfo")]
        public WorkflowBaseInfoDetail BaseInfo{ get; set; }

        /// <summary>
        /// <p>Workflow scheduling configuration.</p>
        /// </summary>
        [JsonProperty("Trigger")]
        public WorkflowTriggerConfiguration[] Trigger{ get; set; }

        /// <summary>
        /// <p>Workflow parameter list. The parameter name is required and can only contain digits, upper- and lower-case letters, spaces, .$@#!%^&amp;*()-_+=&gt;</p>
        /// </summary>
        [JsonProperty("ParamList")]
        public ParamInfo[] ParamList{ get; set; }

        /// <summary>
        /// <p>Tag name is required and can only contain digits, upper- and lower-case letters, spaces, .$@#!%^&amp;*()-_+=&gt;</p>
        /// </summary>
        [JsonProperty("LabelList")]
        public LabelBrief[] LabelList{ get; set; }

        /// <summary>
        /// <p>Workflow alert configuration.</p>
        /// </summary>
        [JsonProperty("Alarm")]
        public AlarmBrief Alarm{ get; set; }

        /// <summary>
        /// <p>Monitoring metrics configuration</p>
        /// </summary>
        [JsonProperty("MonitorMetric")]
        public MonitorMetricBrief MonitorMetric{ get; set; }

        /// <summary>
        /// <p>Workflow advanced setting.</p>
        /// </summary>
        [JsonProperty("AdvanceConfig")]
        public WorkflowAdvanceConfig AdvanceConfig{ get; set; }

        /// <summary>
        /// <p>Workflow task list</p>
        /// </summary>
        [JsonProperty("TaskList")]
        public WorkflowTask[] TaskList{ get; set; }

        /// <summary>
        /// <p>Unique ID of the Bundle bound to the workflow. It is empty if not bound.</p>
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// <p>Bundle information.</p>
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }

        /// <summary>
        /// <p>Git configuration ID.</p>
        /// </summary>
        [JsonProperty("GitConfigId")]
        public string GitConfigId{ get; set; }

        /// <summary>
        /// <p>Git branch information.</p>
        /// </summary>
        [JsonProperty("GitBranch")]
        public string GitBranch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamObj(map, prefix + "BaseInfo.", this.BaseInfo);
            this.SetParamArrayObj(map, prefix + "Trigger.", this.Trigger);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamArrayObj(map, prefix + "LabelList.", this.LabelList);
            this.SetParamObj(map, prefix + "Alarm.", this.Alarm);
            this.SetParamObj(map, prefix + "MonitorMetric.", this.MonitorMetric);
            this.SetParamObj(map, prefix + "AdvanceConfig.", this.AdvanceConfig);
            this.SetParamArrayObj(map, prefix + "TaskList.", this.TaskList);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
            this.SetParamSimple(map, prefix + "GitConfigId", this.GitConfigId);
            this.SetParamSimple(map, prefix + "GitBranch", this.GitBranch);
        }
    }
}

