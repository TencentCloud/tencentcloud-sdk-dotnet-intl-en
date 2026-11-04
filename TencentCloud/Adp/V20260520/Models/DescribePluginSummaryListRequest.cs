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

    public class DescribePluginSummaryListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Space ID, used when querying the plug-in list in the space</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>Filter criteria list, supporting PluginKind, CategoryKey, PluginSource, PluginId, PluginClass, BillingType, AuthType, IsShared, IsCreatedByMe</p>
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// <p>Whether to only return favorite plug-ins. If set to true, only plug-ins favorited by the current user are returned. If set to false or not specified, no filtering by favorite status is applied.</p>
        /// </summary>
        [JsonProperty("IsFavoriteOnly")]
        public bool? IsFavoriteOnly{ get; set; }

        /// <summary>
        /// <p>Plug-in display scenario. If not passed or set to 0, the scenario is not limited.</p><p>Enumeration values:</p><ul><li>0: Not limited</li><li>1: Agent Mode</li><li>2: Workflow</li><li>3: Intelligent workbench</li></ul>
        /// </summary>
        [JsonProperty("Module")]
        public long? Module{ get; set; }

        /// <summary>
        /// <p>Page number. Starts from 0</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>Size per page.</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>Query content fuzzy matching: plugin name/plugin description/tool name/tool description</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>Sorting method.</p><p>Enumeration values:</p><ul><li>0: not specified, default sorting</li><li>1: relevance ranking</li><li>2: sort by update time</li><li>3: default sorting</li><li>4: sort by popularity</li></ul>
        /// </summary>
        [JsonProperty("SortType")]
        public long? SortType{ get; set; }

        /// <summary>
        /// <p>Filter plug-ins shared by the current space/business</p><p>Value range: [0, 2]</p>
        /// </summary>
        [JsonProperty("PluginSpaceRelation")]
        public long? PluginSpaceRelation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "IsFavoriteOnly", this.IsFavoriteOnly);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "PluginSpaceRelation", this.PluginSpaceRelation);
        }
    }
}

