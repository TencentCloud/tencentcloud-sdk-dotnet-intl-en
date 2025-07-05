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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParsedTableInfoNew : AbstractModel
    {
        
        /// <summary>
        /// Table description language type. Valid values: PROTO, TDR
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableIdlType")]
        public string TableIdlType{ get; set; }

        /// <summary>
        /// Table instance ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableInstanceId")]
        public string TableInstanceId{ get; set; }

        /// <summary>
        /// Table name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Table data structure type. Valid values: GENERIC, LIST
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// Primary key field information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeyFields")]
        public string KeyFields{ get; set; }

        /// <summary>
        /// Old primary key field information, which is valid during verification of table modification
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OldKeyFields")]
        public string OldKeyFields{ get; set; }

        /// <summary>
        /// Non-primary key field information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValueFields")]
        public string ValueFields{ get; set; }

        /// <summary>
        /// Old non-primary key field information, which is valid during verification of table modification
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OldValueFields")]
        public string OldValueFields{ get; set; }

        /// <summary>
        /// Table group ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// Total size of primary key field
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SumKeyFieldSize")]
        public long? SumKeyFieldSize{ get; set; }

        /// <summary>
        /// Total size of non-primary key fields
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SumValueFieldSize")]
        public long? SumValueFieldSize{ get; set; }

        /// <summary>
        /// Index key set
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IndexKeySet")]
        public string IndexKeySet{ get; set; }

        /// <summary>
        /// Shardkey set
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShardingKeySet")]
        public string ShardingKeySet{ get; set; }

        /// <summary>
        /// TDR version number
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TdrVersion")]
        public long? TdrVersion{ get; set; }

        /// <summary>
        /// Error message
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Error")]
        public ErrorInfo Error{ get; set; }

        /// <summary>
        /// Number of LIST-type table elements
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ListElementNum")]
        public long? ListElementNum{ get; set; }

        /// <summary>
        /// Number of SORTLIST-type table sort fields
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SortFieldNum")]
        public long? SortFieldNum{ get; set; }

        /// <summary>
        /// Sort order of SORTLIST-type tables
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SortRule")]
        public long? SortRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableIdlType", this.TableIdlType);
            this.SetParamSimple(map, prefix + "TableInstanceId", this.TableInstanceId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "KeyFields", this.KeyFields);
            this.SetParamSimple(map, prefix + "OldKeyFields", this.OldKeyFields);
            this.SetParamSimple(map, prefix + "ValueFields", this.ValueFields);
            this.SetParamSimple(map, prefix + "OldValueFields", this.OldValueFields);
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "SumKeyFieldSize", this.SumKeyFieldSize);
            this.SetParamSimple(map, prefix + "SumValueFieldSize", this.SumValueFieldSize);
            this.SetParamSimple(map, prefix + "IndexKeySet", this.IndexKeySet);
            this.SetParamSimple(map, prefix + "ShardingKeySet", this.ShardingKeySet);
            this.SetParamSimple(map, prefix + "TdrVersion", this.TdrVersion);
            this.SetParamObj(map, prefix + "Error.", this.Error);
            this.SetParamSimple(map, prefix + "ListElementNum", this.ListElementNum);
            this.SetParamSimple(map, prefix + "SortFieldNum", this.SortFieldNum);
            this.SetParamSimple(map, prefix + "SortRule", this.SortRule);
        }
    }
}

