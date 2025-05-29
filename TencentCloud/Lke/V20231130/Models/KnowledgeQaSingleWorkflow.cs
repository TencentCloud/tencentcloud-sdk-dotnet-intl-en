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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KnowledgeQaSingleWorkflow : AbstractModel
    {
        
        /// <summary>
        /// Workflow ID.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Workflow name.
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// Workflow description.
        /// </summary>
        [JsonProperty("WorkflowDesc")]
        public string WorkflowDesc{ get; set; }

        /// <summary>
        /// Workflow status, publishing status (UNPUBLISHED; PUBLISHING; PUBLISHED; FAIL).
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Whether to enable workflow.
        /// </summary>
        [JsonProperty("IsEnable")]
        public bool? IsEnable{ get; set; }

        /// <summary>
        /// Whether to enable asynchronous call of the workflow.
        /// </summary>
        [JsonProperty("AsyncWorkflow")]
        public bool? AsyncWorkflow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "WorkflowDesc", this.WorkflowDesc);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsEnable", this.IsEnable);
            this.SetParamSimple(map, prefix + "AsyncWorkflow", this.AsyncWorkflow);
        }
    }
}

