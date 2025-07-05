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

    public class KnowledgeQaOutput : AbstractModel
    {
        
        /// <summary>
        /// Output method, 1: streaming 2: non-streaming.
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }

        /// <summary>
        /// General model response.
        /// </summary>
        [JsonProperty("UseGeneralKnowledge")]
        public bool? UseGeneralKnowledge{ get; set; }

        /// <summary>
        /// Unknown response, within 300 characters.
        /// </summary>
        [JsonProperty("BareAnswer")]
        public string BareAnswer{ get; set; }

        /// <summary>
        /// Whether to display the question clarification switch.
        /// </summary>
        [JsonProperty("ShowQuestionClarify")]
        public bool? ShowQuestionClarify{ get; set; }

        /// <summary>
        /// Whether to enable question clarification.
        /// </summary>
        [JsonProperty("UseQuestionClarify")]
        public bool? UseQuestionClarify{ get; set; }

        /// <summary>
        /// List of keywords for question clarification.
        /// </summary>
        [JsonProperty("QuestionClarifyKeywords")]
        public string[] QuestionClarifyKeywords{ get; set; }

        /// <summary>
        /// Whether to enable recommended questions.
        /// </summary>
        [JsonProperty("UseRecommended")]
        public bool? UseRecommended{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "UseGeneralKnowledge", this.UseGeneralKnowledge);
            this.SetParamSimple(map, prefix + "BareAnswer", this.BareAnswer);
            this.SetParamSimple(map, prefix + "ShowQuestionClarify", this.ShowQuestionClarify);
            this.SetParamSimple(map, prefix + "UseQuestionClarify", this.UseQuestionClarify);
            this.SetParamArraySimple(map, prefix + "QuestionClarifyKeywords.", this.QuestionClarifyKeywords);
            this.SetParamSimple(map, prefix + "UseRecommended", this.UseRecommended);
        }
    }
}

