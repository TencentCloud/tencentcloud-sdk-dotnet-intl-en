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

namespace TencentCloud.Eiam.V20210420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListApplicationAuthorizationsRequest : AbstractModel
    {
        
        /// <summary>
        /// Query type. Valid values: User: user; UserGroup: user group; OrgNode: organization.
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// Search criterion. You can combine multiple search criteria and search in multiple data ranges. In addition, multiple query methods such as full match, partial match, and range match are supported. Specifically, double quotation marks ("") indicate full match, an asterisk (*) at the end of the field indicates partial match, and an empty field indicates to query the full table by default.
        /// </summary>
        [JsonProperty("SearchCondition")]
        public AuthorizationInfoSearchCriteria SearchCondition{ get; set; }

        /// <summary>
        /// Set of sort criteria. You can sort the results by last modification time (lastModifiedDate). If this field is left empty, the results will be sorted in alphabetical order by application name.
        /// </summary>
        [JsonProperty("Sort")]
        public SortCondition Sort{ get; set; }

        /// <summary>
        /// Pagination offset. The `Offset` and `Limit` fields need to be used together; otherwise, the query results will not be paginated.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results read per page. The `Offset` and `Limit` fields need to be used together; otherwise, the query results will not be paginated.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EntityType", this.EntityType);
            this.SetParamObj(map, prefix + "SearchCondition.", this.SearchCondition);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

