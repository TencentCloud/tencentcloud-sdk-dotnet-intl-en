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

    public class DescribeModelListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Model scenario. 0-case-insensitive, 1-standard generation, 2-standard thinking, 3-Agent thinking, 4-multimodal understanding, 5-multimodal QA, 6-rewrite, 7-long-term memory, 8-natural language to SQL, 9-AI optimization, 10-real-time file parsing, 11-file parsing, 12-GraphRAG, 13-OpenClaw, 14-multimodal Embedding, 15-Rerank, 16-text Embedding, 17-Widget, 18-Claw mode, 19-workflow code generation, 20-workflow large model node, 21-dedicated vectorization for workflow node, 22-workflow parameter extraction, 23-workflow large model knowledge q&a, 24-workflow tag extraction, 25-workflow intent recognition, 26-workflow tab, 27-workflow logical judgment, 28-documentation generation QA, 29-knowledge base Schema</p><p>Enumeration values:</p><ul><li>0: case-insensitive</li><li>1: standard generation</li><li>2: standard thinking</li><li>3: Agent thinking</li><li>4: multimodal understanding</li><li>5: multimodal QA</li><li>6: rewrite</li><li>7: long-term memory</li><li>8: natural language to SQL</li><li>9: AI optimization</li><li>10: real-time file parsing</li><li>11: file parsing</li><li>12: GraphRAG</li><li>13: OpenClaw</li><li>14: multimodal Embedding</li><li>15: Rerank</li><li>16: text Embedding</li><li>17: Widget</li><li>18: Claw mode</li><li>19: workflow code generation</li><li>20: workflow large model node</li><li>21: dedicated vectorization for workflow node</li><li>22: workflow parameter extraction</li><li>23: workflow large model knowledge q&a</li><li>24: workflow tag extraction</li><li>25: workflow intent recognition</li><li>26: workflow tab</li><li>27: workflow logical judgment</li><li>28: documentation generation QA</li><li>29: knowledge base Schema</li></ul>
        /// </summary>
        [JsonProperty("ModelScene")]
        public long? ModelScene{ get; set; }

        /// <summary>
        /// <p>Filter conditions (multiple Filters are combined with AND, and multiple Values within the same Filter are combined with OR)<br>DeveloperName: model author name<br>ProviderName: model provider name<br>ProviderType: model provider type</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// <p>Page number. Starts from 0</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// <p>Number of items per page. Default: 20. Maximum: 100</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// <p>Fuzzy search by keyword</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>Space ID</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelScene", this.ModelScene);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
        }
    }
}

