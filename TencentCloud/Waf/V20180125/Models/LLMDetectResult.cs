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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LLMDetectResult : AbstractModel
    {
        
        /// <summary>
        /// <p>Output only: Sensitive information</p>
        /// </summary>
        [JsonProperty("SensitiveResult")]
        public LLMSensitiveValueLevel[] SensitiveResult{ get; set; }

        /// <summary>
        /// <p>Both input and output: Keyword library hit information</p>
        /// </summary>
        [JsonProperty("KeyWordsResult")]
        public KeyWordInfo[] KeyWordsResult{ get; set; }

        /// <summary>
        /// <p>Both input and output: Data classification and grading result</p>
        /// </summary>
        [JsonProperty("DataCategoryResult")]
        public string[] DataCategoryResult{ get; set; }

        /// <summary>
        /// <p>Input only: prompt injection detection result</p>
        /// </summary>
        [JsonProperty("PromptInjectionResult")]
        public PromptDetectResult PromptInjectionResult{ get; set; }

        /// <summary>
        /// <p>ID of the hit rule</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>Name of the hit rule</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>Rule action</p>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>Attack payload</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// <p>Masked content. Returned when Action is mask. If no masked evidence is generated, the original text is returned.</p>
        /// </summary>
        [JsonProperty("Desensitization")]
        public string Desensitization{ get; set; }

        /// <summary>
        /// <p>Image detection result</p>
        /// </summary>
        [JsonProperty("ImageResult")]
        public ImageResult[] ImageResult{ get; set; }

        /// <summary>
        /// <p>id of the message to be answered on behalf. This message id is used as an input parameter of the GenerateLLMSecAnswer API.</p>
        /// </summary>
        [JsonProperty("MsgID")]
        public string MsgID{ get; set; }

        /// <summary>
        /// <p>Tool call detection result</p>
        /// </summary>
        [JsonProperty("ToolCallResult")]
        public ToolCallResult ToolCallResult{ get; set; }

        /// <summary>
        /// <p>Intent detection result</p>
        /// </summary>
        [JsonProperty("IntentDetectResult")]
        public IntentDetectResult IntentDetectResult{ get; set; }

        /// <summary>
        /// <p>Malicious URL detection result</p>
        /// </summary>
        [JsonProperty("UrlDetectResult")]
        public UrlDetectResult UrlDetectResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SensitiveResult.", this.SensitiveResult);
            this.SetParamArrayObj(map, prefix + "KeyWordsResult.", this.KeyWordsResult);
            this.SetParamArraySimple(map, prefix + "DataCategoryResult.", this.DataCategoryResult);
            this.SetParamObj(map, prefix + "PromptInjectionResult.", this.PromptInjectionResult);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "Desensitization", this.Desensitization);
            this.SetParamArrayObj(map, prefix + "ImageResult.", this.ImageResult);
            this.SetParamSimple(map, prefix + "MsgID", this.MsgID);
            this.SetParamObj(map, prefix + "ToolCallResult.", this.ToolCallResult);
            this.SetParamObj(map, prefix + "IntentDetectResult.", this.IntentDetectResult);
            this.SetParamObj(map, prefix + "UrlDetectResult.", this.UrlDetectResult);
        }
    }
}

