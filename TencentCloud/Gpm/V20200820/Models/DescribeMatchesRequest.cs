/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMatchesRequest : AbstractModel
    {
        
        /// <summary>
        /// The current page number. If this parameter is left empty, all queried matches will be obtained.
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// Number of matchmaking lists per page. If this parameter is left empty, all queried matches will be obtained.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Query type (optional). Valid values: match (query by matchCode or matchName), rule (query by ruleCode or ruleName), and other types (not filtered)
        /// </summary>
        [JsonProperty("SearchType")]
        public string SearchType{ get; set; }

        /// <summary>
        /// Keyword. Enter a keyword about SearchType to query.
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// Tags. Enter a tag for querying.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SearchType", this.SearchType);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

