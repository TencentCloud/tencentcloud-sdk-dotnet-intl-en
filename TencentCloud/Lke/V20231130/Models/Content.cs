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
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QuoteInfos")]
        public QuoteInfo[] QuoteInfos{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("References")]
        public ContentReference[] References{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Image")]
        public ImageInfoContent Image{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("File")]
        public FileInfoContent File{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OptionCards")]
        public string[] OptionCards{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CustomParams")]
        public string[] CustomParams{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CustomVariables")]
        public string[] CustomVariables{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Sandbox")]
        public SandboxContent Sandbox{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WebSearch")]
        public WebSearchContent WebSearch{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FileCollection")]
        public FileCollection FileCollection{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Widget")]
        public Widget Widget{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WidgetAction")]
        public WidgetAction WidgetAction{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Tasks")]
        public AgentTask[] Tasks{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Questionnaire")]
        public Questionnaire Questionnaire{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OptionMode")]
        public long? OptionMode{ get; set; }


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
        }
    }
}

