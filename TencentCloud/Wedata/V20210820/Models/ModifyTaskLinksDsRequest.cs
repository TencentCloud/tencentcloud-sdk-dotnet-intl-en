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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTaskLinksDsRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Parent Task ID
        /// </summary>
        [JsonProperty("TaskFrom")]
        public string TaskFrom{ get; set; }

        /// <summary>
        /// Subtask ID
        /// </summary>
        [JsonProperty("TaskTo")]
        public string TaskTo{ get; set; }

        /// <summary>
        /// Subtask Workflow
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Parent task Workflow
        /// </summary>
        [JsonProperty("RealFromWorkflowId")]
        public string RealFromWorkflowId{ get; set; }

        /// <summary>
        /// Request source, WEB frontend; CLIENT CLIENT.
        /// </summary>
        [JsonProperty("RequestFromSource")]
        public string RequestFromSource{ get; set; }

        /// <summary>
        /// Dependency relationship between parent and child tasks.
        /// Enable all instances that normally depend on the parent task.
        ///     normal_all(1),
        /// normal dependent on parent task first one.
        /// Specifies the normal dependent on parent task, which is the last one (3).
        /// Valid values: normal, any one of dependent on parent tasks (4).
        /// normal dependent on parent task a specified one.
        /// self-Dependency, cannot use.
        /// 
        /// Invalid dependent parent task for all instances. enable (forward dependency for tomorrow).
        ///     non_normal_all_forward(11),
        /// non-normal dependent on parent task. first one forward (12).
        /// non-normal dependent on parent task, last one.
        /// Not normal, dependent on parent task, any one.
        /// Specifies a non-normal task that depends on the parent task and designates one.
        /// 
        /// Specifies that all instances dependent on a non-normal parent task are enabled (backward dependency on yesterday).
        ///     non_normal_all_backward(21),
        /// non-normal dependent on parent task. first one backward (22).
        /// Not normal dependent on parent task last one backward.
        /// non-normal dependent on parent task, any one.
        /// Specifies a non-normal task that depends on the parent task.
        /// </summary>
        [JsonProperty("LinkDependencyType")]
        public string LinkDependencyType{ get; set; }

        /// <summary>
        /// Additional attribute information such as branch node and merge node information.
        /// </summary>
        [JsonProperty("LinkExt")]
        public string LinkExt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskFrom", this.TaskFrom);
            this.SetParamSimple(map, prefix + "TaskTo", this.TaskTo);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "RealFromWorkflowId", this.RealFromWorkflowId);
            this.SetParamSimple(map, prefix + "RequestFromSource", this.RequestFromSource);
            this.SetParamSimple(map, prefix + "LinkDependencyType", this.LinkDependencyType);
            this.SetParamSimple(map, prefix + "LinkExt", this.LinkExt);
        }
    }
}

