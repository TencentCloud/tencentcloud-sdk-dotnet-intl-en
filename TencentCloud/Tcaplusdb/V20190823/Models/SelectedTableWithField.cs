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

    public class SelectedTableWithField : AbstractModel
    {
        
        /// <summary>
        /// ID of the table group where the table resides
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Table ID
        /// </summary>
        [JsonProperty("TableInstanceId")]
        public string TableInstanceId{ get; set; }

        /// <summary>
        /// Table description language. Valid values: `PROTO`, `TDR`
        /// </summary>
        [JsonProperty("TableIdlType")]
        public string TableIdlType{ get; set; }

        /// <summary>
        /// Table data structure. Valid values: `GENERIC`, `LIST`
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// The list of fields on which indexes will be created, table caching enabled, or data subscription enabled
        /// </summary>
        [JsonProperty("SelectedFields")]
        public FieldInfo[] SelectedFields{ get; set; }

        /// <summary>
        /// The number of index shards
        /// </summary>
        [JsonProperty("ShardNum")]
        public ulong? ShardNum{ get; set; }

        /// <summary>
        /// CKafka instance information
        /// </summary>
        [JsonProperty("KafkaInfo")]
        public KafkaInfo KafkaInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableInstanceId", this.TableInstanceId);
            this.SetParamSimple(map, prefix + "TableIdlType", this.TableIdlType);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamArrayObj(map, prefix + "SelectedFields.", this.SelectedFields);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamObj(map, prefix + "KafkaInfo.", this.KafkaInfo);
        }
    }
}

