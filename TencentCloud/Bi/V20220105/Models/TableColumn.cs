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

    public class TableColumn : AbstractModel
    {
        
        /// <summary>
        /// Column name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// alias name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// Column type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// Segment type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FieldType")]
        public string FieldType{ get; set; }

        /// <summary>
        /// Remarks.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Mark")]
        public string Mark{ get; set; }

        /// <summary>
        /// excel name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExcelName")]
        public string ExcelName{ get; set; }

        /// <summary>
        /// Associated dictionary table Id
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DictId")]
        public long? DictId{ get; set; }

        /// <summary>
        /// Associated dictionary table name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DictName")]
        public string DictName{ get; set; }

        /// <summary>
        /// Join tables and add fields
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableNodeId")]
        public string TableNodeId{ get; set; }

        /// <summary>
        /// Table name to which the field belongs
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Complex format of the target set by the user
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FieldComplexType")]
        public string FieldComplexType{ get; set; }

        /// <summary>
        /// format rule
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FormatRule")]
        public string FormatRule{ get; set; }

        /// <summary>
        /// Whether to filter empty data fields
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsFilter")]
        public bool? IsFilter{ get; set; }

        /// <summary>
        /// Compute field type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CalcType")]
        public string CalcType{ get; set; }

        /// <summary>
        /// Formula content of the calculated field
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CalcFormula")]
        public string CalcFormula{ get; set; }

        /// <summary>
        /// Chinese formula content of the calculated field
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CalcDesc")]
        public string CalcDesc{ get; set; }

        /// <summary>
        /// Api data source json path name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JsonPathName")]
        public string JsonPathName{ get; set; }

        /// <summary>
        /// Geographic type identifier
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Granularity")]
        public string Granularity{ get; set; }

        /// <summary>
        /// Custom map Id
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GeoJsonId")]
        public ulong? GeoJsonId{ get; set; }

        /// <summary>
        /// Style configuration for null value display
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EmptyValueConfig")]
        public EmptyValueConfig EmptyValueConfig{ get; set; }

        /// <summary>
        /// Original column name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DbFieldName")]
        public string DbFieldName{ get; set; }

        /// <summary>
        /// Whether to copy field operation
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsCopyOperation")]
        public bool? IsCopyOperation{ get; set; }

        /// <summary>
        /// Whether to copy from common fields
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsCopyFromNormal")]
        public bool? IsCopyFromNormal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "FieldType", this.FieldType);
            this.SetParamSimple(map, prefix + "Mark", this.Mark);
            this.SetParamSimple(map, prefix + "ExcelName", this.ExcelName);
            this.SetParamSimple(map, prefix + "DictId", this.DictId);
            this.SetParamSimple(map, prefix + "DictName", this.DictName);
            this.SetParamSimple(map, prefix + "TableNodeId", this.TableNodeId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "FieldComplexType", this.FieldComplexType);
            this.SetParamSimple(map, prefix + "FormatRule", this.FormatRule);
            this.SetParamSimple(map, prefix + "IsFilter", this.IsFilter);
            this.SetParamSimple(map, prefix + "CalcType", this.CalcType);
            this.SetParamSimple(map, prefix + "CalcFormula", this.CalcFormula);
            this.SetParamSimple(map, prefix + "CalcDesc", this.CalcDesc);
            this.SetParamSimple(map, prefix + "JsonPathName", this.JsonPathName);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "GeoJsonId", this.GeoJsonId);
            this.SetParamObj(map, prefix + "EmptyValueConfig.", this.EmptyValueConfig);
            this.SetParamSimple(map, prefix + "DbFieldName", this.DbFieldName);
            this.SetParamSimple(map, prefix + "IsCopyOperation", this.IsCopyOperation);
            this.SetParamSimple(map, prefix + "IsCopyFromNormal", this.IsCopyFromNormal);
        }
    }
}

