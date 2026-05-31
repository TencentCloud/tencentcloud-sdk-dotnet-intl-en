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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExplainRow : AbstractModel
    {
        
        /// <summary>
        /// <p>Serial number of the query</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>Query type. Common values: SIMPLE (simple query, excluding subqueries or UNION), PRIMARY (outermost query), SUBQUERY (first SELECT in a subquery), DERIVED (derivative table/subquery in FROM clause), UNION (second and subsequent SELECTs in UNION), UNION RESULT (result set of UNION).</p>
        /// </summary>
        [JsonProperty("SelectType")]
        public string SelectType{ get; set; }

        /// <summary>
        /// <p>Data table name</p>
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// <p>Query matching partition</p>
        /// </summary>
        [JsonProperty("Partitions")]
        public string Partitions{ get; set; }

        /// <summary>
        /// <p>Access type (very important, a key metric for measuring query efficiency), ranked from best to worst: system &gt; const &gt; eq_ref &gt; ref &gt; fulltext &gt; ref_or_null &gt; index_merge &gt; unique_subquery &gt; index_subquery &gt; range &gt; index &gt; ALL. Common value descriptions: • system: The table has only one row (system table). • const: Matches one row through primary key or unique index, commonly seen in WHERE pk = 1. • eq_ref: Uses primary key or unique index when connecting, each index value matches only one row. • ref: Uses non-unique index to search, may match multiple rows. • range: Index range scan, such as BETWEEN, &gt;, &lt;, IN. • index: Full index scan (traversal of the entire index tree). • ALL: Full-table scan (worst, requires optimization).</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Indexes that may be used in querying. NULL means no available index.</p>
        /// </summary>
        [JsonProperty("PossibleKeys")]
        public string PossibleKeys{ get; set; }

        /// <summary>
        /// <p>Indexes actually used. NULL means no index is used.</p>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>The length of the actual used index (number of bytes). It can be used to determine which columns are actually used in the composite index. A shorter value indicates fewer index columns are used.</p>
        /// </summary>
        [JsonProperty("KeyLen")]
        public string KeyLen{ get; set; }

        /// <summary>
        /// <p>Display which columns or constants are compared with indexes in the key column. Common values: const (constant), certain column name, func (function result).</p>
        /// </summary>
        [JsonProperty("Ref")]
        public string Ref{ get; set; }

        /// <summary>
        /// <p>Estimate the number of rows to scan</p>
        /// </summary>
        [JsonProperty("Rows")]
        public long? Rows{ get; set; }

        /// <summary>
        /// <p>Indicates the estimation of the percentage of rows remaining after table conditional filtering. 100% means no additional filtering. The higher the value, the better.</p>
        /// </summary>
        [JsonProperty("Filtered")]
        public float? Filtered{ get; set; }

        /// <summary>
        /// <p>Additional information (very important), common values: • Using index: covering index, no need to return to the table (good) • Using where: filter with WHERE after the storage engine returns rows • Using temporary: used a temporary table (commonly used in GROUP BY/ORDER BY, needs optimization) • Using filesort: used file sort instead of index sorting (needs optimization) • Using index condition: used pushdown of index (ICP)</p>
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SelectType", this.SelectType);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "Partitions", this.Partitions);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "PossibleKeys", this.PossibleKeys);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "KeyLen", this.KeyLen);
            this.SetParamSimple(map, prefix + "Ref", this.Ref);
            this.SetParamSimple(map, prefix + "Rows", this.Rows);
            this.SetParamSimple(map, prefix + "Filtered", this.Filtered);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

