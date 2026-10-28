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

    public class KBRetrievalConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Database search configuration</p>
        /// </summary>
        [JsonProperty("DbRetrievalConfig")]
        public DBRetrievalConfig DbRetrievalConfig{ get; set; }

        /// <summary>
        /// <p>Document retrieval configuration.</p>
        /// </summary>
        [JsonProperty("DocRetrievalConfig")]
        public DocRetrievalConfig DocRetrievalConfig{ get; set; }

        /// <summary>
        /// <p>Knowledge base ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>Retrieval optional configuration</p>
        /// </summary>
        [JsonProperty("OptionConfig")]
        public RetrievalOption OptionConfig{ get; set; }

        /// <summary>
        /// <p>QA search configuration</p>
        /// </summary>
        [JsonProperty("QaRetrievalConfig")]
        public QARetrievalConfig QaRetrievalConfig{ get; set; }

        /// <summary>
        /// <p>ReRank configuration</p>
        /// </summary>
        [JsonProperty("RerankConfig")]
        public RerankConfig RerankConfig{ get; set; }

        /// <summary>
        /// <p>Search filter configuration</p>
        /// </summary>
        [JsonProperty("SearchFilterConfig")]
        public SearchFilterConfig SearchFilterConfig{ get; set; }

        /// <summary>
        /// <p>Retrieval strategy: 1=hybrid, 2=semantic, 3=keyword, 4=none<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>SEARCH_STRATEGY_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>SEARCH_STRATEGY_TYPE_MIXING</td><td>1</td><td>Hybrid retrieval</td></tr><tr><td>SEARCH_STRATEGY_TYPE_SEMANTIC</td><td>2</td><td>Semantic retrieval</td></tr><tr><td>SEARCH_STRATEGY_TYPE_KEYWORD</td><td>3</td><td>Keyword retrieval</td></tr><tr><td>SEARCH_STRATEGY_TYPE_NONE</td><td>4</td><td>No semantic/vector retrieval</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// <p>Text2SQL model</p>
        /// </summary>
        [JsonProperty("TextToSqlModel")]
        public ModelDetailInfo TextToSqlModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DbRetrievalConfig.", this.DbRetrievalConfig);
            this.SetParamObj(map, prefix + "DocRetrievalConfig.", this.DocRetrievalConfig);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamObj(map, prefix + "OptionConfig.", this.OptionConfig);
            this.SetParamObj(map, prefix + "QaRetrievalConfig.", this.QaRetrievalConfig);
            this.SetParamObj(map, prefix + "RerankConfig.", this.RerankConfig);
            this.SetParamObj(map, prefix + "SearchFilterConfig.", this.SearchFilterConfig);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamObj(map, prefix + "TextToSqlModel.", this.TextToSqlModel);
        }
    }
}

