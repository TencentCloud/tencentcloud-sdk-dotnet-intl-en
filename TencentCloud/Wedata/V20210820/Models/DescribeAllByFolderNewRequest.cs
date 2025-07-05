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

    public class DescribeAllByFolderNewRequest : AbstractModel
    {
        
        /// <summary>
        /// Folder Attributes
        /// </summary>
        [JsonProperty("Folder")]
        public FolderOpsDto Folder{ get; set; }

        /// <summary>
        /// Workflow List
        /// </summary>
        [JsonProperty("Workflows")]
        public WorkflowCanvasOpsDto[] Workflows{ get; set; }

        /// <summary>
        /// Target File ID
        /// </summary>
        [JsonProperty("TargetFolderId")]
        public string TargetFolderId{ get; set; }

        /// <summary>
        /// Keyword
        /// </summary>
        [JsonProperty("KeyWords")]
        public string KeyWords{ get; set; }

        /// <summary>
        /// Parent File ID
        /// </summary>
        [JsonProperty("ParentsFolderId")]
        public string ParentsFolderId{ get; set; }

        /// <summary>
        /// Pull Folder List
        /// </summary>
        [JsonProperty("IsAddWorkflow")]
        public string IsAddWorkflow{ get; set; }

        /// <summary>
        /// Task Status
        /// </summary>
        [JsonProperty("TaskStates")]
        public string[] TaskStates{ get; set; }

        /// <summary>
        /// Search type
        /// </summary>
        [JsonProperty("FindType")]
        public string FindType{ get; set; }

        /// <summary>
        /// Access type
        /// </summary>
        [JsonProperty("OptType")]
        public string OptType{ get; set; }

        /// <summary>
        /// Operator Name
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// Operator ID
        /// </summary>
        [JsonProperty("OperatorId")]
        public string OperatorId{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Project Identifier
        /// </summary>
        [JsonProperty("ProjectIdent")]
        public string ProjectIdent{ get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// Index Page Number
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// Page size
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Total Data
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Basic Request Information
        /// </summary>
        [JsonProperty("RequestBaseInfo")]
        public ProjectBaseInfoOpsRequest RequestBaseInfo{ get; set; }

        /// <summary>
        /// Whether to Calculate Total
        /// </summary>
        [JsonProperty("IsCount")]
        public bool? IsCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Folder.", this.Folder);
            this.SetParamArrayObj(map, prefix + "Workflows.", this.Workflows);
            this.SetParamSimple(map, prefix + "TargetFolderId", this.TargetFolderId);
            this.SetParamSimple(map, prefix + "KeyWords", this.KeyWords);
            this.SetParamSimple(map, prefix + "ParentsFolderId", this.ParentsFolderId);
            this.SetParamSimple(map, prefix + "IsAddWorkflow", this.IsAddWorkflow);
            this.SetParamArraySimple(map, prefix + "TaskStates.", this.TaskStates);
            this.SetParamSimple(map, prefix + "FindType", this.FindType);
            this.SetParamSimple(map, prefix + "OptType", this.OptType);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "OperatorId", this.OperatorId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamObj(map, prefix + "RequestBaseInfo.", this.RequestBaseInfo);
            this.SetParamSimple(map, prefix + "IsCount", this.IsCount);
        }
    }
}

