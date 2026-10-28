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

    public class KnowledgeResult : AbstractModel
    {
        
        /// <summary>
        /// <p>Confidence degree</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// <p>Hit knowledge type: 1=QA, 2=document fragment, 3=database, 4=map<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>KNOWLEDGE_SOURCE_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>KNOWLEDGE_SOURCE_TYPE_QA</td><td>1</td><td>QA</td></tr><tr><td>KNOWLEDGE_SOURCE_TYPE_DOC</td><td>2</td><td>Document fragment</td></tr><tr><td>KNOWLEDGE_SOURCE_TYPE_DB</td><td>3</td><td>Database</td></tr><tr><td>KNOWLEDGE_SOURCE_TYPE_GRAPH</td><td>4</td><td>Map</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("KnowledgeType")]
        public long? KnowledgeType{ get; set; }

        /// <summary>
        /// <p>Recall type list</p>
        /// </summary>
        [JsonProperty("RecallTypeList")]
        public long?[] RecallTypeList{ get; set; }

        /// <summary>
        /// <p>Result payload</p>
        /// </summary>
        [JsonProperty("ResultPayload")]
        public SearchResultPayload ResultPayload{ get; set; }

        /// <summary>
        /// <p>Result type<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>SEARCH_RESULT_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>SEARCH_RESULT_TYPE_RETRIEVAL</td><td>1</td><td>Standard search result</td></tr><tr><td>SEARCH_RESULT_TYPE_TEXT_TO_SQL</td><td>2</td><td>text2sql result</td></tr><tr><td>SEARCH_RESULT_TYPE_IMAGE_SEARCH_IMAGE</td><td>3</td><td></td></tr><tr><td>SEARCH_RESULT_TYPE_TEXT_SEARCH_IMAGE</td><td>4</td><td></td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("ResultType")]
        public long? ResultType{ get; set; }

        /// <summary>
        /// <p>Additional information for similar questions.</p>
        /// </summary>
        [JsonProperty("SimilarQuestionExtra")]
        public SimilarQuestionExtra SimilarQuestionExtra{ get; set; }

        /// <summary>
        /// <p>Basic information of knowledge fragment</p>
        /// </summary>
        [JsonProperty("SnippetProfile")]
        public KnowledgeSnippetProfile SnippetProfile{ get; set; }

        /// <summary>
        /// <p>Knowledge source information</p>
        /// </summary>
        [JsonProperty("SourceInfo")]
        public KnowledgeSource SourceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "KnowledgeType", this.KnowledgeType);
            this.SetParamArraySimple(map, prefix + "RecallTypeList.", this.RecallTypeList);
            this.SetParamObj(map, prefix + "ResultPayload.", this.ResultPayload);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamObj(map, prefix + "SimilarQuestionExtra.", this.SimilarQuestionExtra);
            this.SetParamObj(map, prefix + "SnippetProfile.", this.SnippetProfile);
            this.SetParamObj(map, prefix + "SourceInfo.", this.SourceInfo);
        }
    }
}

