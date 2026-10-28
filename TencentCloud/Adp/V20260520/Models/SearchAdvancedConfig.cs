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

    public class SearchAdvancedConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Final ReRank Configuration</p>
        /// </summary>
        [JsonProperty("FinalRerankConfig")]
        public FinalRerankConfig FinalRerankConfig{ get; set; }

        /// <summary>
        /// <p>Search configuration of each knowledge base</p>
        /// </summary>
        [JsonProperty("KbRetrievalList")]
        public KBRetrievalConfig[] KbRetrievalList{ get; set; }

        /// <summary>
        /// <p>Retrieve knowledge type: 1=document and QA, 2=rejected question<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>SEARCH_KNOWLEDGE_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>SEARCH_KNOWLEDGE_TYPE_DOC_QA</td><td>1</td><td>Document and QA</td></tr><tr><td>SEARCH_KNOWLEDGE_TYPE_REJECTED_QUESTION</td><td>2</td><td>Rejected question</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("KnowledgeType")]
        public long? KnowledgeType{ get; set; }

        /// <summary>
        /// <p>Number of final returned results</p>
        /// </summary>
        [JsonProperty("RecallCount")]
        public ulong? RecallCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FinalRerankConfig.", this.FinalRerankConfig);
            this.SetParamArrayObj(map, prefix + "KbRetrievalList.", this.KbRetrievalList);
            this.SetParamSimple(map, prefix + "KnowledgeType", this.KnowledgeType);
            this.SetParamSimple(map, prefix + "RecallCount", this.RecallCount);
        }
    }
}

