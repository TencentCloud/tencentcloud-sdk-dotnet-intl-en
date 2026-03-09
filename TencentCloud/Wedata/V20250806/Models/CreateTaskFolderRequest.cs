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

    public class CreateTaskFolderRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Absolute path of the parent folder, such as /abc/de. if it is the root directory, pass /.
        /// </summary>
        [JsonProperty("ParentTaskFolderPath")]
        public string ParentTaskFolderPath{ get; set; }

        /// <summary>
        /// Folder name to be created.
        /// </summary>
        [JsonProperty("TaskFolderName")]
        public string TaskFolderName{ get; set; }

        /// <summary>
        /// Task folder type.
        /// 
        /// | task folder type parameter | task folder type interface corresponding name |.
        /// | ---------------- | ------------------------ |
        /// ETL | integration task.
        /// | EMR              | EMR                      |
        /// | DLC              | DLC                      |
        /// | SETATS           | SETATS                   |
        /// | TDSQL            | TDSQL                    |
        /// | TCHOUSE          | TCHOUSE                  |
        /// GENERAL.
        /// TI_ONE | ti-one machine learning.
        /// ACROSS_WORKFLOWS | cross-workflow.
        /// </summary>
        [JsonProperty("TaskFolderType")]
        public string TaskFolderType{ get; set; }

        /// <summary>
        /// Workflow ID.
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ParentTaskFolderPath", this.ParentTaskFolderPath);
            this.SetParamSimple(map, prefix + "TaskFolderName", this.TaskFolderName);
            this.SetParamSimple(map, prefix + "TaskFolderType", this.TaskFolderType);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
        }
    }
}

