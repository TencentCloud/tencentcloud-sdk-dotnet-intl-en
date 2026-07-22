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

namespace TencentCloud.Es.V20250101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunRerankRequest : AbstractModel
    {
        
        /// <summary>
        /// Model name, selectable model list: bge-reranker-large, bge-reranker-v2-m3.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Query text.
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// List of candidate docs to sort.
        /// </summary>
        [JsonProperty("Documents")]
        public string[] Documents{ get; set; }

        /// <summary>
        /// Number of top documents returned in sorting order. If not specified, return all candidate docs. If the specified top_n value is larger than the number of input candidate docs, return all docs.
        /// </summary>
        [JsonProperty("TopN")]
        public long? TopN{ get; set; }

        /// <summary>
        /// Whether to return the original document for each sorting result inside the result list. Default value: False.
        /// </summary>
        [JsonProperty("ReturnDocuments")]
        public bool? ReturnDocuments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamArraySimple(map, prefix + "Documents.", this.Documents);
            this.SetParamSimple(map, prefix + "TopN", this.TopN);
            this.SetParamSimple(map, prefix + "ReturnDocuments", this.ReturnDocuments);
        }
    }
}

