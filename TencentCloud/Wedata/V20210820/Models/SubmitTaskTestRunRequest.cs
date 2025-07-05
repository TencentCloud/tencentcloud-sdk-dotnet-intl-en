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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitTaskTestRunRequest : AbstractModel
    {
        
        /// <summary>
        /// taskId list
        /// </summary>
        [JsonProperty("TaskIds")]
        public string TaskIds{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Workflow ID
        /// </summary>
        [JsonProperty("WorkFlowId")]
        public string WorkFlowId{ get; set; }

        /// <summary>
        /// Workflow name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Workflow Task List
        /// </summary>
        [JsonProperty("Tasks")]
        public StageCloudApiRequest[] Tasks{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Runtime Parameters, JSON format of map
        /// </summary>
        [JsonProperty("RunParams")]
        public string RunParams{ get; set; }

        /// <summary>
        /// Script Content
        /// </summary>
        [JsonProperty("ScriptContent")]
        public string ScriptContent{ get; set; }

        /// <summary>
        /// Version number
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskIds", this.TaskIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkFlowId", this.WorkFlowId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RunParams", this.RunParams);
            this.SetParamSimple(map, prefix + "ScriptContent", this.ScriptContent);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
        }
    }
}

