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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncTableInfo : AbstractModel
    {
        
        /// <summary>
        /// Sharded table quantity of the target cache table
        /// </summary>
        [JsonProperty("TargetTableSplitNum")]
        public ulong? TargetTableSplitNum{ get; set; }

        /// <summary>
        /// Prefix of the target cache table name
        /// </summary>
        [JsonProperty("TargetTableNamePrefix")]
        public string[] TargetTableNamePrefix{ get; set; }

        /// <summary>
        /// Instance ID of the cache database
        /// </summary>
        [JsonProperty("TargetSyncDBInstanceId")]
        public string TargetSyncDBInstanceId{ get; set; }

        /// <summary>
        /// Name of the database where the cache table resides
        /// </summary>
        [JsonProperty("TargetDatabaseName")]
        public string TargetDatabaseName{ get; set; }

        /// <summary>
        /// Caching status. Valid values: `0` (creating), `1` (caching), `2` (disabled), `-1` (deleted).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// ID of cluster where the table resides
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// The ID of the table group where the table resides
        /// </summary>
        [JsonProperty("TableGroupId")]
        public ulong? TableGroupId{ get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Table ID
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// Mapping from the primary key field of the TcaplusDB table to the field of the target cache table
        /// </summary>
        [JsonProperty("KeyFieldMapping")]
        public SyncTableField[] KeyFieldMapping{ get; set; }

        /// <summary>
        /// Mapping of TcaplusDB table field to target cache table field
        /// </summary>
        [JsonProperty("ValueFieldMapping")]
        public SyncTableField[] ValueFieldMapping{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetTableSplitNum", this.TargetTableSplitNum);
            this.SetParamArraySimple(map, prefix + "TargetTableNamePrefix.", this.TargetTableNamePrefix);
            this.SetParamSimple(map, prefix + "TargetSyncDBInstanceId", this.TargetSyncDBInstanceId);
            this.SetParamSimple(map, prefix + "TargetDatabaseName", this.TargetDatabaseName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamArrayObj(map, prefix + "KeyFieldMapping.", this.KeyFieldMapping);
            this.SetParamArrayObj(map, prefix + "ValueFieldMapping.", this.ValueFieldMapping);
        }
    }
}

