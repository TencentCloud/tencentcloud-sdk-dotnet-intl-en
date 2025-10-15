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

    public class RerunTaskInstancesAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Instance id list. obtain from ListInstances.
        /// </summary>
        [JsonProperty("InstanceKeyList")]
        public string[] InstanceKeyList{ get; set; }

        /// <summary>
        /// Rerun type. valid values: 1 (self), 3 (child), 2 (self and child). default: 1.
        /// </summary>
        [JsonProperty("RerunType")]
        public string RerunType{ get; set; }

        /// <summary>
        /// Whether to check upstream tasks: ALL (ALL), MAKE_SCOPE (select), NONE (do not check). default is NONE.
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }

        /// <summary>
        /// Downstream Instance Scope
        /// 
        /// * WORKFLOW: Within the current workflow (default)
        /// 
        /// * PROJECT: Within the current project
        /// 
        /// * ALL: Across all projects with cross-workflow dependencies
        /// </summary>
        [JsonProperty("SonRangeType")]
        public string SonRangeType{ get; set; }

        /// <summary>
        /// Specifies whether to ignore event monitoring when rerunning.
        /// </summary>
        [JsonProperty("SkipEventListening")]
        public bool? SkipEventListening{ get; set; }

        /// <summary>
        /// Specifies the degree of concurrency for a custom instance run. if not configured, use the existing self-dependent task.
        /// </summary>
        [JsonProperty("RedefineParallelNum")]
        public long? RedefineParallelNum{ get; set; }

        /// <summary>
        /// Custom workflow self-dependency. valid values: yes (enable), no (disable). if not configured, use the existing workflow self-dependency.
        /// </summary>
        [JsonProperty("RedefineSelfWorkflowDependency")]
        public string RedefineSelfWorkflowDependency{ get; set; }

        /// <summary>
        /// Rerun instance custom parameter.
        /// </summary>
        [JsonProperty("RedefineParamList")]
        public KVMap RedefineParamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "InstanceKeyList.", this.InstanceKeyList);
            this.SetParamSimple(map, prefix + "RerunType", this.RerunType);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
            this.SetParamSimple(map, prefix + "SonRangeType", this.SonRangeType);
            this.SetParamSimple(map, prefix + "SkipEventListening", this.SkipEventListening);
            this.SetParamSimple(map, prefix + "RedefineParallelNum", this.RedefineParallelNum);
            this.SetParamSimple(map, prefix + "RedefineSelfWorkflowDependency", this.RedefineSelfWorkflowDependency);
            this.SetParamObj(map, prefix + "RedefineParamList.", this.RedefineParamList);
        }
    }
}

