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

    public class QACreateSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>Query</p>
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// <p>Answer</p>
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// <p>Category ID</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>Associated document ID</p>
        /// </summary>
        [JsonProperty("DocId")]
        public string DocId{ get; set; }

        /// <summary>
        /// <p>Knowledge effective scope<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_UNKNOWN</td><td>0</td><td></td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_NONE</td><td>1</td><td>Disabled</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_DEV</td><td>2</td><td>Development domain only</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_RELEASE</td><td>3</td><td>Release domain only</td></tr><tr><td>KNOWLEDGE_EFFECTIVE_DOMAIN_ALL</td><td>4</td><td>Global</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("EffectiveDomain")]
        public long? EffectiveDomain{ get; set; }

        /// <summary>
        /// <p>Expiration policy (validity time and behavior after the validity period expires)</p>
        /// </summary>
        [JsonProperty("ExpirationPolicy")]
        public ExpirationPolicy ExpirationPolicy{ get; set; }

        /// <summary>
        /// <p>Applicable scope (tag condition)</p>
        /// </summary>
        [JsonProperty("LabelRefList")]
        public LabelRefIdentity[] LabelRefList{ get; set; }

        /// <summary>
        /// <p>Issue description</p>
        /// </summary>
        [JsonProperty("QuestionDescription")]
        public string QuestionDescription{ get; set; }

        /// <summary>
        /// <p>Similar question list</p>
        /// </summary>
        [JsonProperty("SimilarQuestionList")]
        public string[] SimilarQuestionList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "DocId", this.DocId);
            this.SetParamSimple(map, prefix + "EffectiveDomain", this.EffectiveDomain);
            this.SetParamObj(map, prefix + "ExpirationPolicy.", this.ExpirationPolicy);
            this.SetParamArrayObj(map, prefix + "LabelRefList.", this.LabelRefList);
            this.SetParamSimple(map, prefix + "QuestionDescription", this.QuestionDescription);
            this.SetParamArraySimple(map, prefix + "SimilarQuestionList.", this.SimilarQuestionList);
        }
    }
}

