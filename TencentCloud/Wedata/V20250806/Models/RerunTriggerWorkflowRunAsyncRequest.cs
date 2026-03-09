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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RerunTriggerWorkflowRunAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Workflow ID.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Running ID of the workflow.
        /// </summary>
        [JsonProperty("WorkflowExecutionId")]
        public string WorkflowExecutionId{ get; set; }

        /// <summary>
        /// Running mode: ordinary running defaults to all parameters: 1, advanced execution selectable task scope and running parameters: 2.
        /// </summary>
        [JsonProperty("ExecuteType")]
        public string ExecuteType{ get; set; }

        /// <summary>
        /// Custom running parameters filled in when the running type is advanced execution.
        /// </summary>
        [JsonProperty("AdvancedParams")]
        public SchedulingParameter[] AdvancedParams{ get; set; }

        /// <summary>
        /// Advanced execution in mode requires the specified task ID set this time.
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// Specify a scheduling resource group. uses the original scheduling resource group in the default configurations when left empty.
        /// </summary>
        [JsonProperty("SchedulingResourceGroup")]
        public string SchedulingResourceGroup{ get; set; }

        /// <summary>
        /// Specify the integration resource group. uses the original integration resource group in configurations by default when empty.
        /// </summary>
        [JsonProperty("IntegrationResourceGroup")]
        public string IntegrationResourceGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowExecutionId", this.WorkflowExecutionId);
            this.SetParamSimple(map, prefix + "ExecuteType", this.ExecuteType);
            this.SetParamArrayObj(map, prefix + "AdvancedParams.", this.AdvancedParams);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamSimple(map, prefix + "SchedulingResourceGroup", this.SchedulingResourceGroup);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroup", this.IntegrationResourceGroup);
        }
    }
}

