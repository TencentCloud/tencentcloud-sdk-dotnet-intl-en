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

    public class AgentProcedure : AbstractModel
    {
        
        /// <summary>
        /// Index.
        /// </summary>
        [JsonProperty("Index")]
        public ulong? Index{ get; set; }

        /// <summary>
        /// English name of the execution process.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Chinese name for display.
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// Status constant: processing; success; failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Icon.
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// Agent debugging information.
        /// </summary>
        [JsonProperty("Debugging")]
        public AgentProcedureDebugging Debugging{ get; set; }

        /// <summary>
        /// Whether to switch to Agent. The value can be "main" or "workflow". Leave it blank for no switch.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Workflow name.
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// Current request execution time, in milliseconds.
        /// </summary>
        [JsonProperty("Elapsed")]
        public ulong? Elapsed{ get; set; }

        /// <summary>
        /// Workflow node name.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Used to display in which reply bubble the thoughts are placed.
        /// </summary>
        [JsonProperty("ReplyIndex")]
        public ulong? ReplyIndex{ get; set; }

        /// <summary>
        /// Main agent.
        /// </summary>
        [JsonProperty("SourceAgentName")]
        public string SourceAgentName{ get; set; }

        /// <summary>
        /// Registration agent.
        /// </summary>
        [JsonProperty("TargetAgentName")]
        public string TargetAgentName{ get; set; }

        /// <summary>
        /// Icon of Agent.
        /// </summary>
        [JsonProperty("AgentIcon")]
        public string AgentIcon{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamObj(map, prefix + "Debugging.", this.Debugging);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "Elapsed", this.Elapsed);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "ReplyIndex", this.ReplyIndex);
            this.SetParamSimple(map, prefix + "SourceAgentName", this.SourceAgentName);
            this.SetParamSimple(map, prefix + "TargetAgentName", this.TargetAgentName);
            this.SetParamSimple(map, prefix + "AgentIcon", this.AgentIcon);
        }
    }
}

