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

    public class Content : AbstractModel
    {
        
        /// <summary>
        /// <p>Message content type<br>text: text<br>image: image<br>file: file<br>option_cards: tabs<br>custom_params: custom business parameters<br>sandbox: cloud desktop<br>custom_variables: custom input parameters<br>web_search: web search content<br>file_collection: file collection information<br>widget: widget info<br>widget_action: client-side widget action information</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Text content</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Reference info.</p>
        /// </summary>
        [JsonProperty("QuoteInfos")]
        public QuoteInfo[] QuoteInfos{ get; set; }

        /// <summary>
        /// <p>Reference information</p>
        /// </summary>
        [JsonProperty("References")]
        public ContentReference[] References{ get; set; }

        /// <summary>
        /// <p>Image information.</p>
        /// </summary>
        [JsonProperty("Image")]
        public ImageInfoContent Image{ get; set; }

        /// <summary>
        /// <p>File information</p>
        /// </summary>
        [JsonProperty("File")]
        public FileInfoContent File{ get; set; }

        /// <summary>
        /// <p>Tab info.</p>
        /// </summary>
        [JsonProperty("OptionCards")]
        public string[] OptionCards{ get; set; }

        /// <summary>
        /// <p>User-customized business parameter information.</p>
        /// </summary>
        [JsonProperty("CustomParams")]
        public string[] CustomParams{ get; set; }

        /// <summary>
        /// <p>Custom Variable</p>
        /// </summary>
        [JsonProperty("CustomVariables")]
        public string[] CustomVariables{ get; set; }

        /// <summary>
        /// <p>Sandbox information</p>
        /// </summary>
        [JsonProperty("Sandbox")]
        public SandboxContent Sandbox{ get; set; }

        /// <summary>
        /// <p>Web page search content</p>
        /// </summary>
        [JsonProperty("WebSearch")]
        public WebSearchContent WebSearch{ get; set; }

        /// <summary>
        /// <p>File information collection</p>
        /// </summary>
        [JsonProperty("FileCollection")]
        public FileCollection FileCollection{ get; set; }

        /// <summary>
        /// <p>Widget information.</p>
        /// </summary>
        [JsonProperty("Widget")]
        public Widget Widget{ get; set; }

        /// <summary>
        /// <p>Widget action information</p>
        /// </summary>
        [JsonProperty("WidgetAction")]
        public WidgetAction WidgetAction{ get; set; }

        /// <summary>
        /// <p>Task List</p>
        /// </summary>
        [JsonProperty("Tasks")]
        public AgentTask[] Tasks{ get; set; }

        /// <summary>
        /// <p>Questionnaire information</p>
        /// </summary>
        [JsonProperty("Questionnaire")]
        public Questionnaire Questionnaire{ get; set; }

        /// <summary>
        /// <p>Tab mode</p>
        /// </summary>
        [JsonProperty("OptionMode")]
        public long? OptionMode{ get; set; }

        /// <summary>
        /// <p>MCP APP information returned</p>
        /// </summary>
        [JsonProperty("McpApp")]
        public ConversationMcpApp McpApp{ get; set; }

        /// <summary>
        /// <p>Application or workflow resource product</p>
        /// </summary>
        [JsonProperty("Resource")]
        public ConversationResourceArtifact Resource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamArrayObj(map, prefix + "QuoteInfos.", this.QuoteInfos);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamObj(map, prefix + "File.", this.File);
            this.SetParamArraySimple(map, prefix + "OptionCards.", this.OptionCards);
            this.SetParamArraySimple(map, prefix + "CustomParams.", this.CustomParams);
            this.SetParamArraySimple(map, prefix + "CustomVariables.", this.CustomVariables);
            this.SetParamObj(map, prefix + "Sandbox.", this.Sandbox);
            this.SetParamObj(map, prefix + "WebSearch.", this.WebSearch);
            this.SetParamObj(map, prefix + "FileCollection.", this.FileCollection);
            this.SetParamObj(map, prefix + "Widget.", this.Widget);
            this.SetParamObj(map, prefix + "WidgetAction.", this.WidgetAction);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamObj(map, prefix + "Questionnaire.", this.Questionnaire);
            this.SetParamSimple(map, prefix + "OptionMode", this.OptionMode);
            this.SetParamObj(map, prefix + "McpApp.", this.McpApp);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
        }
    }
}

