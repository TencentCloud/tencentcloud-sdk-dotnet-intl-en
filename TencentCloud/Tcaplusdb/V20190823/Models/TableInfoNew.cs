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

    public class TableInfoNew : AbstractModel
    {
        
        /// <summary>
        /// Table name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Table instance ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableInstanceId")]
        public string TableInstanceId{ get; set; }

        /// <summary>
        /// Table data structure type, such as `GENERIC` or `LIST`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// Table data interface description language (IDL) type, such as `PROTO` or `TDR`
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableIdlType")]
        public string TableIdlType{ get; set; }

        /// <summary>
        /// ID of the cluster where a table resides
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Name of the cluster where a table resides
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// ID of the table group where a table resides
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// Name of the table group where a table resides
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableGroupName")]
        public string TableGroupName{ get; set; }

        /// <summary>
        /// JSON string of table's primary key field structure
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeyStruct")]
        public string KeyStruct{ get; set; }

        /// <summary>
        /// JSON string of table non-primary key field structure
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValueStruct")]
        public string ValueStruct{ get; set; }

        /// <summary>
        /// Table shardkey set, which is valid for PROTO-type tables
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShardingKeySet")]
        public string ShardingKeySet{ get; set; }

        /// <summary>
        /// Table index key field set, which is valid for PROTO-type tables
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IndexStruct")]
        public string IndexStruct{ get; set; }

        /// <summary>
        /// Number of LIST-type table elements
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ListElementNum")]
        public ulong? ListElementNum{ get; set; }

        /// <summary>
        /// Information list of IDL files associated with table
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdlFiles")]
        public IdlFileInfo[] IdlFiles{ get; set; }

        /// <summary>
        /// Reserved table capacity in GB
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReservedVolume")]
        public long? ReservedVolume{ get; set; }

        /// <summary>
        /// Reserved table read QPS
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReservedReadQps")]
        public long? ReservedReadQps{ get; set; }

        /// <summary>
        /// Reserved table write QPS
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReservedWriteQps")]
        public long? ReservedWriteQps{ get; set; }

        /// <summary>
        /// Actual table data size in MB
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableSize")]
        public long? TableSize{ get; set; }

        /// <summary>
        /// Table status
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Table creation time
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Table's last modified time
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// Table remarks
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Memo")]
        public string Memo{ get; set; }

        /// <summary>
        /// Error message
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Error")]
        public ErrorInfo Error{ get; set; }

        /// <summary>
        /// TcaplusDB SDK data access ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApiAccessId")]
        public string ApiAccessId{ get; set; }

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
        /// Information about global indexes, table caching, or data subscription
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DbClusterInfoStruct")]
        public string DbClusterInfoStruct{ get; set; }

        /// <summary>
        /// The number of days after which the table Txh backup files will be expire and deleted.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TxhBackupExpireDay")]
        public ulong? TxhBackupExpireDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableInstanceId", this.TableInstanceId);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "TableIdlType", this.TableIdlType);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "TableGroupName", this.TableGroupName);
            this.SetParamSimple(map, prefix + "KeyStruct", this.KeyStruct);
            this.SetParamSimple(map, prefix + "ValueStruct", this.ValueStruct);
            this.SetParamSimple(map, prefix + "ShardingKeySet", this.ShardingKeySet);
            this.SetParamSimple(map, prefix + "IndexStruct", this.IndexStruct);
            this.SetParamSimple(map, prefix + "ListElementNum", this.ListElementNum);
            this.SetParamArrayObj(map, prefix + "IdlFiles.", this.IdlFiles);
            this.SetParamSimple(map, prefix + "ReservedVolume", this.ReservedVolume);
            this.SetParamSimple(map, prefix + "ReservedReadQps", this.ReservedReadQps);
            this.SetParamSimple(map, prefix + "ReservedWriteQps", this.ReservedWriteQps);
            this.SetParamSimple(map, prefix + "TableSize", this.TableSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "Memo", this.Memo);
            this.SetParamObj(map, prefix + "Error.", this.Error);
            this.SetParamSimple(map, prefix + "ApiAccessId", this.ApiAccessId);
            this.SetParamSimple(map, prefix + "SortFieldNum", this.SortFieldNum);
            this.SetParamSimple(map, prefix + "SortRule", this.SortRule);
            this.SetParamSimple(map, prefix + "DbClusterInfoStruct", this.DbClusterInfoStruct);
            this.SetParamSimple(map, prefix + "TxhBackupExpireDay", this.TxhBackupExpireDay);
        }
    }
}

