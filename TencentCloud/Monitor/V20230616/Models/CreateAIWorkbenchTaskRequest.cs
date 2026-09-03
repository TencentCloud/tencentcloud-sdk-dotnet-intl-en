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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAIWorkbenchTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Task Name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Task description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Associated Agent ID</p>
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>Prompt Template</p>
        /// </summary>
        [JsonProperty("PromptTemplate")]
        public string PromptTemplate{ get; set; }

        /// <summary>
        /// <p>Output format: markdown / json</p>
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// <p>Trigger type: manual / cron / webhook</p>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>Cron expression</p>
        /// </summary>
        [JsonProperty("CronExpr")]
        public string CronExpr{ get; set; }

        /// <summary>
        /// <p>Cron time zone</p>
        /// </summary>
        [JsonProperty("CronTimezone")]
        public string CronTimezone{ get; set; }

        /// <summary>
        /// <p>Associated resource map ID</p>
        /// </summary>
        [JsonProperty("ResourceMapId")]
        public string ResourceMapId{ get; set; }

        /// <summary>
        /// <p>Skill ID list</p>
        /// </summary>
        [JsonProperty("SkillIds")]
        public string[] SkillIds{ get; set; }

        /// <summary>
        /// <p>MCP endpoint ID list</p>
        /// </summary>
        [JsonProperty("McpEndpointIds")]
        public string[] McpEndpointIds{ get; set; }

        /// <summary>
        /// <p>Timeout (seconds)</p>
        /// </summary>
        [JsonProperty("TimeoutSec")]
        public long? TimeoutSec{ get; set; }

        /// <summary>
        /// <p>Retry count</p>
        /// </summary>
        [JsonProperty("RetryCount")]
        public long? RetryCount{ get; set; }

        /// <summary>
        /// <p>Whether to enable</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "PromptTemplate", this.PromptTemplate);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "CronExpr", this.CronExpr);
            this.SetParamSimple(map, prefix + "CronTimezone", this.CronTimezone);
            this.SetParamSimple(map, prefix + "ResourceMapId", this.ResourceMapId);
            this.SetParamArraySimple(map, prefix + "SkillIds.", this.SkillIds);
            this.SetParamArraySimple(map, prefix + "McpEndpointIds.", this.McpEndpointIds);
            this.SetParamSimple(map, prefix + "TimeoutSec", this.TimeoutSec);
            this.SetParamSimple(map, prefix + "RetryCount", this.RetryCount);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

