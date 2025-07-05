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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcedureDebugging : AbstractModel
    {
        
        /// <summary>
        /// Retrieve query.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// System prompt.
        /// </summary>
        [JsonProperty("System")]
        public string System{ get; set; }

        /// <summary>
        /// Multiple rounds of historical information.
        /// </summary>
        [JsonProperty("Histories")]
        public HistorySummary[] Histories{ get; set; }

        /// <summary>
        /// Retrieve knowledge.
        /// </summary>
        [JsonProperty("Knowledge")]
        public KnowledgeSummary[] Knowledge{ get; set; }

        /// <summary>
        /// Task process.
        /// </summary>
        [JsonProperty("TaskFlow")]
        public TaskFlowSummary TaskFlow{ get; set; }

        /// <summary>
        /// Workflow debugging information.
        /// </summary>
        [JsonProperty("WorkFlow")]
        public WorkFlowSummary WorkFlow{ get; set; }

        /// <summary>
        /// Agent debugging information.
        /// </summary>
        [JsonProperty("Agent")]
        public AgentDebugInfo Agent{ get; set; }

        /// <summary>
        /// Custom parameter.
        /// </summary>
        [JsonProperty("CustomVariables")]
        public string[] CustomVariables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "System", this.System);
            this.SetParamArrayObj(map, prefix + "Histories.", this.Histories);
            this.SetParamArrayObj(map, prefix + "Knowledge.", this.Knowledge);
            this.SetParamObj(map, prefix + "TaskFlow.", this.TaskFlow);
            this.SetParamObj(map, prefix + "WorkFlow.", this.WorkFlow);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "CustomVariables.", this.CustomVariables);
        }
    }
}

