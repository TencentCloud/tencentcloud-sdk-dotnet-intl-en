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

    public class CreateTaskNewRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Workflow ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// Task Name
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 26 offline synchronization,30 Python,31 PySpark,32 DLC,33 Impala,34 Hive SQL,35 Shell,36 Spark SQL,39 Spark,40 CDW PG,92 MapReduce.
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// Extended Attribute
        /// </summary>
        [JsonProperty("TaskExt")]
        public TaskExtInfo[] TaskExt{ get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Specifies the task instance initialization strategy
        /// </summary>
        [JsonProperty("InstanceInitStrategy")]
        public string InstanceInitStrategy{ get; set; }

        /// <summary>
        /// The horizontal axis of the canvas coordinate
        /// </summary>
        [JsonProperty("LeftCoordinate")]
        public float? LeftCoordinate{ get; set; }

        /// <summary>
        /// The vertical axis of the canvas coordinate
        /// </summary>
        [JsonProperty("TopCoordinate")]
        public float? TopCoordinate{ get; set; }

        /// <summary>
        /// Workflow Directory ID
        /// </summary>
        [JsonProperty("TaskFolderId")]
        public string TaskFolderId{ get; set; }

        /// <summary>
        /// Specifies the script content, base64 encoded
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// Code Template ID
        /// </summary>
        [JsonProperty("CodeTemplateId")]
        public string CodeTemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArrayObj(map, prefix + "TaskExt.", this.TaskExt);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "InstanceInitStrategy", this.InstanceInitStrategy);
            this.SetParamSimple(map, prefix + "LeftCoordinate", this.LeftCoordinate);
            this.SetParamSimple(map, prefix + "TopCoordinate", this.TopCoordinate);
            this.SetParamSimple(map, prefix + "TaskFolderId", this.TaskFolderId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "CodeTemplateId", this.CodeTemplateId);
        }
    }
}

