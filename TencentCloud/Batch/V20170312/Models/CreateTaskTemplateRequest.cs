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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTaskTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Task template name
        /// </summary>
        [JsonProperty("TaskTemplateName")]
        public string TaskTemplateName{ get; set; }

        /// <summary>
        /// Task template content with the same parameter requirements as the task
        /// </summary>
        [JsonProperty("TaskTemplateInfo")]
        public Task TaskTemplateInfo{ get; set; }

        /// <summary>
        /// Task template description
        /// </summary>
        [JsonProperty("TaskTemplateDescription")]
        public string TaskTemplateDescription{ get; set; }

        /// <summary>
        /// Tag list. By setting this parameter, you can bind tags to a task template. Each task template supports up to 10 tags.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskTemplateName", this.TaskTemplateName);
            this.SetParamObj(map, prefix + "TaskTemplateInfo.", this.TaskTemplateInfo);
            this.SetParamSimple(map, prefix + "TaskTemplateDescription", this.TaskTemplateDescription);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

