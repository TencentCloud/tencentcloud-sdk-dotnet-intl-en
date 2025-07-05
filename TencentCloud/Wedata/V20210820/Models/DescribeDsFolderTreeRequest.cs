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

    public class DescribeDsFolderTreeRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Whether to Pull at First Level true Yes 
        /// false No
        /// </summary>
        [JsonProperty("FirstLevelPull")]
        public bool? FirstLevelPull{ get; set; }

        /// <summary>
        /// Folder ID
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// Workflow ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Keyword Search
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// Whether to Include Workflow true Yes 
        /// false No
        /// </summary>
        [JsonProperty("IncludeWorkflow")]
        public bool? IncludeWorkflow{ get; set; }

        /// <summary>
        /// Whether to Include Tasks true Yes 
        /// false No
        /// </summary>
        [JsonProperty("IncludeTask")]
        public bool? IncludeTask{ get; set; }

        /// <summary>
        /// Does it include virtual tasks? This parameter is effective only when IncludeTask is true, default is true
        /// </summary>
        [JsonProperty("IncludeVirtualTask")]
        public bool? IncludeVirtualTask{ get; set; }

        /// <summary>
        /// Task directory ID
        /// </summary>
        [JsonProperty("TaskFolderId")]
        public string TaskFolderId{ get; set; }

        /// <summary>
        /// classification. Categorized Display  catalog. Directory Display
        /// </summary>
        [JsonProperty("DisplayType")]
        public string DisplayType{ get; set; }

        /// <summary>
        /// Does it include task directories? true means yes
        /// false No
        /// </summary>
        [JsonProperty("IncludeTaskFolder")]
        public bool? IncludeTaskFolder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "FirstLevelPull", this.FirstLevelPull);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "IncludeWorkflow", this.IncludeWorkflow);
            this.SetParamSimple(map, prefix + "IncludeTask", this.IncludeTask);
            this.SetParamSimple(map, prefix + "IncludeVirtualTask", this.IncludeVirtualTask);
            this.SetParamSimple(map, prefix + "TaskFolderId", this.TaskFolderId);
            this.SetParamSimple(map, prefix + "DisplayType", this.DisplayType);
            this.SetParamSimple(map, prefix + "IncludeTaskFolder", this.IncludeTaskFolder);
        }
    }
}

