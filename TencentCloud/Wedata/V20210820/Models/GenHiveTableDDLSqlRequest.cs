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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenHiveTableDDLSqlRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Target Database
        /// </summary>
        [JsonProperty("SinkDatabase")]
        public string SinkDatabase{ get; set; }

        /// <summary>
        /// Node ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Metadata Type (MYSQL,ORACLE)
        /// </summary>
        [JsonProperty("MsType")]
        public string MsType{ get; set; }

        /// <summary>
        /// Data source ID
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// Source Library Name
        /// </summary>
        [JsonProperty("SourceDatabase")]
        public string SourceDatabase{ get; set; }

        /// <summary>
        /// Source Table Name
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Target Table Metadata Type (HIVE,GBASE)
        /// </summary>
        [JsonProperty("SinkType")]
        public string SinkType{ get; set; }

        /// <summary>
        /// Source Schema Name
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// Field Information of Upstream Node
        /// </summary>
        [JsonProperty("SourceFieldInfoList")]
        public SourceFieldInfo[] SourceFieldInfoList{ get; set; }

        /// <summary>
        /// Partition Field
        /// </summary>
        [JsonProperty("Partitions")]
        public Partition[] Partitions{ get; set; }

        /// <summary>
        /// Table Creation Attributes
        /// </summary>
        [JsonProperty("Properties")]
        public Property[] Properties{ get; set; }

        /// <summary>
        /// Table Creation Mode,0: Wizard Mode,1: ddl
        /// </summary>
        [JsonProperty("TableMode")]
        public long? TableMode{ get; set; }

        /// <summary>
        /// DLC Table Version, v1/v2
        /// </summary>
        [JsonProperty("TableVersion")]
        public string TableVersion{ get; set; }

        /// <summary>
        /// Whether to Upsert Writes
        /// </summary>
        [JsonProperty("UpsertFlag")]
        public bool? UpsertFlag{ get; set; }

        /// <summary>
        /// Table Description Information
        /// </summary>
        [JsonProperty("TableComment")]
        public string TableComment{ get; set; }

        /// <summary>
        /// Threshold for Increased Number of Files, Exceeding Value Will Trigger Small File Merge
        /// </summary>
        [JsonProperty("AddDataFiles")]
        public long? AddDataFiles{ get; set; }

        /// <summary>
        /// Threshold for Increased Number of Equality Deletes, Exceeding Value Will Trigger Small File Merge
        /// </summary>
        [JsonProperty("AddEqualityDeletes")]
        public long? AddEqualityDeletes{ get; set; }

        /// <summary>
        /// Threshold for Increased Number of Position Deletes, Exceeding Value Will Trigger Small File Merge
        /// </summary>
        [JsonProperty("AddPositionDeletes")]
        public long? AddPositionDeletes{ get; set; }

        /// <summary>
        /// Threshold for Increased Number of Delete Files
        /// </summary>
        [JsonProperty("AddDeleteFiles")]
        public long? AddDeleteFiles{ get; set; }

        /// <summary>
        /// Downstream Node Data Source ID
        /// </summary>
        [JsonProperty("TargetDatasourceId")]
        public string TargetDatasourceId{ get; set; }

        /// <summary>
        /// DLC Upsert Primary Key
        /// </summary>
        [JsonProperty("UpsertKeys")]
        public string[] UpsertKeys{ get; set; }

        /// <summary>
        /// DLC Table Governance Information
        /// </summary>
        [JsonProperty("TableBaseInfo")]
        public TableBaseInfo TableBaseInfo{ get; set; }

        /// <summary>
        /// Target Schema Name
        /// </summary>
        [JsonProperty("SinkSchemaName")]
        public string SinkSchemaName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "SinkDatabase", this.SinkDatabase);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "MsType", this.MsType);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "SourceDatabase", this.SourceDatabase);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "SinkType", this.SinkType);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamArrayObj(map, prefix + "SourceFieldInfoList.", this.SourceFieldInfoList);
            this.SetParamArrayObj(map, prefix + "Partitions.", this.Partitions);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamSimple(map, prefix + "TableMode", this.TableMode);
            this.SetParamSimple(map, prefix + "TableVersion", this.TableVersion);
            this.SetParamSimple(map, prefix + "UpsertFlag", this.UpsertFlag);
            this.SetParamSimple(map, prefix + "TableComment", this.TableComment);
            this.SetParamSimple(map, prefix + "AddDataFiles", this.AddDataFiles);
            this.SetParamSimple(map, prefix + "AddEqualityDeletes", this.AddEqualityDeletes);
            this.SetParamSimple(map, prefix + "AddPositionDeletes", this.AddPositionDeletes);
            this.SetParamSimple(map, prefix + "AddDeleteFiles", this.AddDeleteFiles);
            this.SetParamSimple(map, prefix + "TargetDatasourceId", this.TargetDatasourceId);
            this.SetParamArraySimple(map, prefix + "UpsertKeys.", this.UpsertKeys);
            this.SetParamObj(map, prefix + "TableBaseInfo.", this.TableBaseInfo);
            this.SetParamSimple(map, prefix + "SinkSchemaName", this.SinkSchemaName);
        }
    }
}

