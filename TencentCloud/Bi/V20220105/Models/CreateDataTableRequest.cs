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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDataTableRequest : AbstractModel
    {
        
        /// <summary>
        /// The backend provides a dictionary: table type, 1. database table creation, 2. SQL table creation, 3. Excel upload, 4. API connection, 5. Tencent documentation, 6. cloud database, 7. manually enter, 8. join query.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Data table name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// None.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// folder
        /// </summary>
        [JsonProperty("FoldId")]
        public ulong? FoldId{ get; set; }

        /// <summary>
        /// data source Id
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// physical table name
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// sql statement
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// excel address
        /// </summary>
        [JsonProperty("ExcelUrl")]
        public string ExcelUrl{ get; set; }

        /// <summary>
        /// configure field
        /// </summary>
        [JsonProperty("Fields")]
        public TableField[] Fields{ get; set; }

        /// <summary>
        /// Multi-table join usage: 1: Data source original table, 2: Local table, 3: Excel table, 4: API table
        /// </summary>
        [JsonProperty("TableNodeType")]
        public ulong? TableNodeType{ get; set; }

        /// <summary>
        /// Original table information for multi-table join
        /// </summary>
        [JsonProperty("Tables")]
        public JoinSourceTable[] Tables{ get; set; }

        /// <summary>
        /// Multi-table join association information
        /// </summary>
        [JsonProperty("Joins")]
        public JoinRelation[] Joins{ get; set; }

        /// <summary>
        /// Additional info, such as api data source info and Tencent document access info
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// whether
        /// </summary>
        [JsonProperty("AsyncRequest")]
        public bool? AsyncRequest{ get; set; }

        /// <summary>
        /// dependent async transaction id
        /// </summary>
        [JsonProperty("ParentTranId")]
        public string ParentTranId{ get; set; }

        /// <summary>
        /// API data source configuration
        /// </summary>
        [JsonProperty("ApiDatasourceConfig")]
        public ApiDatasourceConfig ApiDatasourceConfig{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("ParamList")]
        public ParamCreateDTO[] ParamList{ get; set; }

        /// <summary>
        /// dlc advanced parameter
        /// </summary>
        [JsonProperty("DlcExtInfo")]
        public string DlcExtInfo{ get; set; }

        /// <summary>
        /// Query database required or not
        /// </summary>
        [JsonProperty("QueryDbData")]
        public string QueryDbData{ get; set; }

        /// <summary>
        /// Table remark
        /// </summary>
        [JsonProperty("TableComment")]
        public string TableComment{ get; set; }

        /// <summary>
        /// Whether to query field remarks
        /// </summary>
        [JsonProperty("QueryFieldRemark")]
        public long? QueryFieldRemark{ get; set; }

        /// <summary>
        /// Field remarks list
        /// </summary>
        [JsonProperty("FieldRemarkList")]
        public FieldRemarkDTO[] FieldRemarkList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "FoldId", this.FoldId);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "ExcelUrl", this.ExcelUrl);
            this.SetParamArrayObj(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "TableNodeType", this.TableNodeType);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamArrayObj(map, prefix + "Joins.", this.Joins);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "AsyncRequest", this.AsyncRequest);
            this.SetParamSimple(map, prefix + "ParentTranId", this.ParentTranId);
            this.SetParamObj(map, prefix + "ApiDatasourceConfig.", this.ApiDatasourceConfig);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "DlcExtInfo", this.DlcExtInfo);
            this.SetParamSimple(map, prefix + "QueryDbData", this.QueryDbData);
            this.SetParamSimple(map, prefix + "TableComment", this.TableComment);
            this.SetParamSimple(map, prefix + "QueryFieldRemark", this.QueryFieldRemark);
            this.SetParamArrayObj(map, prefix + "FieldRemarkList.", this.FieldRemarkList);
        }
    }
}

