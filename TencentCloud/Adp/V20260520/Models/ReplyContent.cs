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

    public class ReplyContent : AbstractModel
    {
        
        /// <summary>
        /// <p>Message content type<br>text: text<br>image: image<br>file: file<br>option_cards: tab<br>custom_params: user-customized business parameter<br>sandbox: cloud desktop<br>custom_variables: custom input parameter<br>web_search: web search content<br>file_collection: file collection info<br>widget: widget info<br>widget_action: client-side widget action information</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Text content</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Tab information</p>
        /// </summary>
        [JsonProperty("OptionCardList")]
        public string[] OptionCardList{ get; set; }

        /// <summary>
        /// <p>File collection info</p>
        /// </summary>
        [JsonProperty("FileCollection")]
        public ConversationFileCollection FileCollection{ get; set; }

        /// <summary>
        /// <p>Widget information.</p>
        /// </summary>
        [JsonProperty("Widget")]
        public ConversationWidget Widget{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamArraySimple(map, prefix + "OptionCardList.", this.OptionCardList);
            this.SetParamObj(map, prefix + "FileCollection.", this.FileCollection);
            this.SetParamObj(map, prefix + "Widget.", this.Widget);
        }
    }
}

