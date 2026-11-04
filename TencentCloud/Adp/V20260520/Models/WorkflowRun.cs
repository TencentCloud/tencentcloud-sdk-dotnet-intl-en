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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowRun : AbstractModel
    {
        
        /// <summary>
        /// Basic information of the workflow running instance
        /// </summary>
        [JsonProperty("WorkflowRunSummary")]
        public WorkflowRunSummary WorkflowRunSummary{ get; set; }

        /// <summary>
        /// Workflow run instance output information
        /// </summary>
        [JsonProperty("WorkflowRunOutput")]
        public WorkflowRunOutput WorkflowRunOutput{ get; set; }

        /// <summary>
        /// Workflow run instance metadata
        /// </summary>
        [JsonProperty("WorkflowRunMetadata")]
        public WorkflowRunMetadata WorkflowRunMetadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "WorkflowRunSummary.", this.WorkflowRunSummary);
            this.SetParamObj(map, prefix + "WorkflowRunOutput.", this.WorkflowRunOutput);
            this.SetParamObj(map, prefix + "WorkflowRunMetadata.", this.WorkflowRunMetadata);
        }
    }
}

