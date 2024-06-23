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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ColumnLineageInfo : AbstractModel
    {
        
        /// <summary>
        /// Lineage ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Data Source ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// Field NameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ColumnName")]
        public string ColumnName{ get; set; }

        /// <summary>
        /// Field Chinese Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ColumnNameCn")]
        public string ColumnNameCn{ get; set; }

        /// <summary>
        /// Field TypeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ColumnType")]
        public string ColumnType{ get; set; }

        /// <summary>
        /// Relationship Parameters
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RelationParams")]
        public string RelationParams{ get; set; }

        /// <summary>
        /// ParameterNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// Parent ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ParentId")]
        public string ParentId{ get; set; }

        /// <summary>
        /// Metadata Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MetastoreType")]
        public string MetastoreType{ get; set; }

        /// <summary>
        /// Metadata Type Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MetastoreTypeName")]
        public string MetastoreTypeName{ get; set; }

        /// <summary>
        /// Table Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Full Field Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QualifiedName")]
        public string QualifiedName{ get; set; }

        /// <summary>
        /// Number of Downstream Nodes
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DownStreamCount")]
        public long? DownStreamCount{ get; set; }

        /// <summary>
        /// Number of Upstream Nodes
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UpStreamCount")]
        public long? UpStreamCount{ get; set; }

        /// <summary>
        /// DescriptionNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Path Information Starting from the Central Node
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PrefixPath")]
        public string PrefixPath{ get; set; }

        /// <summary>
        /// Creation TimeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update timeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Task ID list
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Tasks")]
        public string[] Tasks{ get; set; }

        /// <summary>
        /// Parent Node List String
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ParentSet")]
        public string ParentSet{ get; set; }

        /// <summary>
        /// Child Node List String
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ChildSet")]
        public string ChildSet{ get; set; }

        /// <summary>
        /// Additional parameters
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExtParams")]
        public LineageParamRecord[] ExtParams{ get; set; }

        /// <summary>
        /// Table IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "ColumnName", this.ColumnName);
            this.SetParamSimple(map, prefix + "ColumnNameCn", this.ColumnNameCn);
            this.SetParamSimple(map, prefix + "ColumnType", this.ColumnType);
            this.SetParamSimple(map, prefix + "RelationParams", this.RelationParams);
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "MetastoreType", this.MetastoreType);
            this.SetParamSimple(map, prefix + "MetastoreTypeName", this.MetastoreTypeName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "QualifiedName", this.QualifiedName);
            this.SetParamSimple(map, prefix + "DownStreamCount", this.DownStreamCount);
            this.SetParamSimple(map, prefix + "UpStreamCount", this.UpStreamCount);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PrefixPath", this.PrefixPath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamArraySimple(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "ParentSet", this.ParentSet);
            this.SetParamSimple(map, prefix + "ChildSet", this.ChildSet);
            this.SetParamArrayObj(map, prefix + "ExtParams.", this.ExtParams);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
        }
    }
}

