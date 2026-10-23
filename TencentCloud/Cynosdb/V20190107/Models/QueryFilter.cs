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

    public class QueryFilter : AbstractModel
    {
        
        /// <summary>
        /// Field value list, one-to-one with Names. InstanceId/ClusterId use exact match, and InstanceName uses fuzzy match by default.
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// List of search field names. Only the following 3 fields are supported (case-insensitive, multiple values use OR relationship): ClusterId (filter by cluster ID, exact match), InstanceId (reverse-check the cluster by instance ID), InstanceName (reverse-check the cluster by instance name, default LIKE fuzzy matching, exact match when ExactMatch=true). When InstanceId and InstanceName are both imported, take the intersection (AND semantics).
        /// </summary>
        [JsonProperty("Names")]
        public string[] Names{ get; set; }

        /// <summary>
        /// Exact match. Only applicable to InstanceName: true for exact match, false (default) for LIKE fuzzy matching.
        /// </summary>
        [JsonProperty("ExactMatch")]
        public bool? ExactMatch{ get; set; }

        /// <summary>
        /// Search field name (single field mode; either this parameter or Names). Supported: ClusterId, InstanceId, InstanceName.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Operator (reserved field, currently disabled). Available values: >, >=, !=, =, <, <=
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamArraySimple(map, prefix + "Names.", this.Names);
            this.SetParamSimple(map, prefix + "ExactMatch", this.ExactMatch);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

