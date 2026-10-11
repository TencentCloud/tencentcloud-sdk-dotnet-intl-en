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

    public class TaskType : AbstractModel
    {
        
        /// <summary>
        /// <p>Task type: SQL: for executing SQL queries and data processing operations; DATA_INTEGRATION: for offline data access operations; NOTEBOOK: used to run Notebook scripts; RUN_WORKFLOW: for executing nested workflows; PYTHON: used to run Python scripts; RAY_JOB: used to run Ray jobs; DATA_QUALITY: for data quality monitoring; IF_ELSE: for conditional branch judgment; FOR_EACH: for loop traversal execution;</p>
        /// </summary>
        [JsonProperty("TaskTypeName")]
        public string TaskTypeName{ get; set; }

        /// <summary>
        /// <p>Notebook type extended information</p>
        /// </summary>
        [JsonProperty("Notebook")]
        [System.Obsolete]
        public TaskTypeNotebookExt Notebook{ get; set; }

        /// <summary>
        /// <p>List of task extended attributes. For details, see the description of TaskType.TaskPropertyList.</p>
        /// </summary>
        [JsonProperty("TaskTypePropertyList")]
        public TaskTypeProperty[] TaskTypePropertyList{ get; set; }

        /// <summary>
        /// <p>Runtime attribute list. For specific values, fill in reference to the TaskType.RuntimePropertyList description</p>
        /// </summary>
        [JsonProperty("RuntimePropertyList")]
        public TaskTypeProperty[] RuntimePropertyList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskTypeName", this.TaskTypeName);
            this.SetParamObj(map, prefix + "Notebook.", this.Notebook);
            this.SetParamArrayObj(map, prefix + "TaskTypePropertyList.", this.TaskTypePropertyList);
            this.SetParamArrayObj(map, prefix + "RuntimePropertyList.", this.RuntimePropertyList);
        }
    }
}

