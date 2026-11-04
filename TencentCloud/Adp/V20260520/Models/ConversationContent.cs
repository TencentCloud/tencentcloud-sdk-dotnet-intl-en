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

    public class ConversationContent : AbstractModel
    {
        
        /// <summary>
        /// <p>Text content</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Content type. text: text, image: image, file: file, custom_variables: custom input parameter information, widget_action: widget action information</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Custom parameter data</p>
        /// </summary>
        [JsonProperty("CustomParamList")]
        public string[] CustomParamList{ get; set; }

        /// <summary>
        /// <p>Custom parameter data</p>
        /// </summary>
        [JsonProperty("CustomParams")]
        public string[] CustomParams{ get; set; }

        /// <summary>
        /// <p>Custom variable data</p>
        /// </summary>
        [JsonProperty("CustomVariablesData")]
        public string CustomVariablesData{ get; set; }

        /// <summary>
        /// <p>Business form</p>
        /// </summary>
        [JsonProperty("EnterpriseCharts")]
        public string EnterpriseCharts{ get; set; }

        /// <summary>
        /// <p>Tab List</p>
        /// </summary>
        [JsonProperty("OptionCardList")]
        public string[] OptionCardList{ get; set; }

        /// <summary>
        /// <p>Tab list.</p>
        /// </summary>
        [JsonProperty("OptionCards")]
        public string[] OptionCards{ get; set; }

        /// <summary>
        /// <p>Tab mode. Enumeration values: 0-OPTION_MODE_SINGLE (single selection), 1-OPTION_MODE_MULTI (multiple selection)</p>
        /// </summary>
        [JsonProperty("OptionMode")]
        public long? OptionMode{ get; set; }

        /// <summary>
        /// <p>Reference marker information list</p>
        /// </summary>
        [JsonProperty("QuoteInfoList")]
        public ConversationQuoteInfo[] QuoteInfoList{ get; set; }

        /// <summary>
        /// <p>List of reference superscript information</p>
        /// </summary>
        [JsonProperty("QuoteInfos")]
        public ConversationQuoteInfo[] QuoteInfos{ get; set; }

        /// <summary>
        /// <p>Reference source list</p>
        /// </summary>
        [JsonProperty("ReferenceList")]
        public ConversationReference[] ReferenceList{ get; set; }

        /// <summary>
        /// <p>Reference list</p>
        /// </summary>
        [JsonProperty("References")]
        public ConversationReference[] References{ get; set; }

        /// <summary>
        /// <p>Associated record ID</p>
        /// </summary>
        [JsonProperty("RelatedRecordId")]
        public string RelatedRecordId{ get; set; }

        /// <summary>
        /// <p>Intelligent Agent Task List</p>
        /// </summary>
        [JsonProperty("TaskList")]
        public ConversationAgentTask[] TaskList{ get; set; }

        /// <summary>
        /// <p>Intelligent Agent Task List</p>
        /// </summary>
        [JsonProperty("Tasks")]
        public ConversationAgentTask[] Tasks{ get; set; }

        /// <summary>
        /// <p>Workflow input parameter</p>
        /// </summary>
        [JsonProperty("WorkflowInput")]
        public string WorkflowInput{ get; set; }

        /// <summary>
        /// <p>MCP-APP call information</p>
        /// </summary>
        [JsonProperty("McpApp")]
        public ConversationMcpApp McpApp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "CustomParamList.", this.CustomParamList);
            this.SetParamArraySimple(map, prefix + "CustomParams.", this.CustomParams);
            this.SetParamSimple(map, prefix + "CustomVariablesData", this.CustomVariablesData);
            this.SetParamSimple(map, prefix + "EnterpriseCharts", this.EnterpriseCharts);
            this.SetParamArraySimple(map, prefix + "OptionCardList.", this.OptionCardList);
            this.SetParamArraySimple(map, prefix + "OptionCards.", this.OptionCards);
            this.SetParamSimple(map, prefix + "OptionMode", this.OptionMode);
            this.SetParamArrayObj(map, prefix + "QuoteInfoList.", this.QuoteInfoList);
            this.SetParamArrayObj(map, prefix + "QuoteInfos.", this.QuoteInfos);
            this.SetParamArrayObj(map, prefix + "ReferenceList.", this.ReferenceList);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamSimple(map, prefix + "RelatedRecordId", this.RelatedRecordId);
            this.SetParamArrayObj(map, prefix + "TaskList.", this.TaskList);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "WorkflowInput", this.WorkflowInput);
            this.SetParamObj(map, prefix + "McpApp.", this.McpApp);
        }
    }
}

