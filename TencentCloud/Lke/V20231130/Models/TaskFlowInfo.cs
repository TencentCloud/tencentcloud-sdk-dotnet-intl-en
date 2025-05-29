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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskFlowInfo : AbstractModel
    {
        
        /// <summary>
        /// Task flow ID.
        /// </summary>
        [JsonProperty("TaskFlowId")]
        public string TaskFlowId{ get; set; }

        /// <summary>
        /// Task flow name.
        /// </summary>
        [JsonProperty("TaskFlowName")]
        public string TaskFlowName{ get; set; }

        /// <summary>
        /// Rewrite results of query.
        /// </summary>
        [JsonProperty("QueryRewrite")]
        public string QueryRewrite{ get; set; }

        /// <summary>
        /// Hit intent.
        /// </summary>
        [JsonProperty("HitIntent")]
        public string HitIntent{ get; set; }

        /// <summary>
        /// Task flow response type.
        /// 0: Task flow response.
        /// 1: Silent task flow.
        /// 2: Pull back script of workflow.
        /// 3: Custom response of task flow.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskFlowId", this.TaskFlowId);
            this.SetParamSimple(map, prefix + "TaskFlowName", this.TaskFlowName);
            this.SetParamSimple(map, prefix + "QueryRewrite", this.QueryRewrite);
            this.SetParamSimple(map, prefix + "HitIntent", this.HitIntent);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

