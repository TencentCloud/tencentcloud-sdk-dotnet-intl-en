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

    public class CreateTriggerWorkflowRunRequest : AbstractModel
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
        /// Custom running parameters. if empty or null, use the latest configuration of the workflow.
        /// </summary>
        [JsonProperty("AdvancedParams")]
        public SchedulingParameter[] AdvancedParams{ get; set; }

        /// <summary>
        /// This time, run the specified task ID set. if it is null or empty, run all.
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// Specified scheduling resource group id. uses the original resource group by default if left empty.
        /// </summary>
        [JsonProperty("SchedulingResourceGroupId")]
        public string SchedulingResourceGroupId{ get; set; }

        /// <summary>
        /// Specified integration resource group id. uses the original resource group if left empty.
        /// </summary>
        [JsonProperty("IntegrationResourceGroupId")]
        public string IntegrationResourceGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamArrayObj(map, prefix + "AdvancedParams.", this.AdvancedParams);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamSimple(map, prefix + "SchedulingResourceGroupId", this.SchedulingResourceGroupId);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroupId", this.IntegrationResourceGroupId);
        }
    }
}

