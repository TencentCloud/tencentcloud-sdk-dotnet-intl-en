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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>Category path (including category ID, category ID path from the root node, and category name path)</p>
        /// </summary>
        [JsonProperty("CategoryPath")]
        public CategoryPath CategoryPath{ get; set; }

        /// <summary>
        /// <p>Document ID</p>
        /// </summary>
        [JsonProperty("DocId")]
        public string DocId{ get; set; }

        /// <summary>
        /// <p>Knowledge effective scope (aggregate application scope + tag condition)</p>
        /// </summary>
        [JsonProperty("KnowledgeScope")]
        public KnowledgeScope KnowledgeScope{ get; set; }

        /// <summary>
        /// <p>Lifecycle information.</p>
        /// </summary>
        [JsonProperty("Lifecycle")]
        public DocLifecycle Lifecycle{ get; set; }

        /// <summary>
        /// <p>Meta information.</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public DocMetadata Metadata{ get; set; }

        /// <summary>
        /// <p>Operator information (aggregate modifier + operation permission)</p>
        /// </summary>
        [JsonProperty("OperatorInfo")]
        public DocOperator OperatorInfo{ get; set; }

        /// <summary>
        /// <p>Task status information</p>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public DocTaskStatus TaskStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CategoryPath.", this.CategoryPath);
            this.SetParamSimple(map, prefix + "DocId", this.DocId);
            this.SetParamObj(map, prefix + "KnowledgeScope.", this.KnowledgeScope);
            this.SetParamObj(map, prefix + "Lifecycle.", this.Lifecycle);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamObj(map, prefix + "OperatorInfo.", this.OperatorInfo);
            this.SetParamObj(map, prefix + "TaskStatus.", this.TaskStatus);
        }
    }
}

