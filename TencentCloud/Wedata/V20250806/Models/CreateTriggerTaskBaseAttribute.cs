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

    public class CreateTriggerTaskBaseAttribute : AbstractModel
    {
        
        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Task type ID:.
        /// * 26:OfflineSynchronization
        /// * 30:Python
        /// * 32:DLC SQL
        /// * 35:Shell
        /// * 38:Shell Form Mode
        /// * 46:DLC Spark
        /// * 50:DLC PySpark
        /// * 130:Branch Node
        /// * 131:Merged Node
        /// * 132:Notebook
        /// * 133:SSH
        /// * 137:For-each
        /// * 139:DLC Spark Streaming
        /// * 140:Run Workflow
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public string TaskTypeId{ get; set; }

        /// <summary>
        /// Workflow ID.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Task owner ID, defaults to the current user.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Task description
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// Task folder path.
        /// 
        /// Note:.
        /// -Do not fill in the task node type in the path. for example, in a workflow named wf01, under the "common" category, if you want to create a new shell task under the tf_01 folder in this classification, just fill in /tf_01.
        /// -If the tf_01 folder does not exist, first create this folder (use the CreateTaskFolder api) for the operation to succeed.
        /// </summary>
        [JsonProperty("TaskFolderPath")]
        public string TaskFolderPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskFolderPath", this.TaskFolderPath);
        }
    }
}

