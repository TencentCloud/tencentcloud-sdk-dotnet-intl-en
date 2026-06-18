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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Explain : AbstractModel
    {
        
        /// <summary>
        /// <p>Identifier</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>Query type</p><p>Enumeration value:</p><ul><li>SIMPLE: A regular query with no subquery and UNION. Single table or ordinary JOIN is SIMPLE.</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SelectType")]
        public string SelectType{ get; set; }

        /// <summary>
        /// <p>Table name</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// <p>Partition</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Partitions")]
        public string Partitions{ get; set; }

        /// <summary>
        /// <p>Access type</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Possibly used indexes</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PossibleKeys")]
        public string PossibleKeys{ get; set; }

        /// <summary>
        /// <p>Used Indexes</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>Used Indexes length</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeyLen")]
        public string KeyLen{ get; set; }

        /// <summary>
        /// <p>Column or constant to compare with the index</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ref")]
        public string Ref{ get; set; }

        /// <summary>
        /// <p>Estimate the number of scanned rows</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Rows")]
        public string Rows{ get; set; }

        /// <summary>
        /// <p>Estimated percentage of remaining rows after conditional filtering</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Filtered")]
        public string Filtered{ get; set; }

        /// <summary>
        /// <p>Additional information, such as Using index, Using filesort</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
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

