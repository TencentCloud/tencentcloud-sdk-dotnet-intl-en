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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Column : AbstractModel
    {
        
        /// <summary>
        /// Column name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Column type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Aggregation type: When the table is an aggregation model (AGG_KEY), the column with the aggregation type is set as the metric column, and other columns are dimension columns. Aggregation type: ●SUM: sum; the values of multiple rows are accumulated. ●REPLACE: replacement; the values in the next batch of data will replace the values in the previously imported rows. ●MAX: retain the maximum value.
        ///  ●MIN: retain the minimum value. ●REPLACE_IF_NOT_NULL: non-null values replacement. The difference from REPLACE is that null values are not replaced. ●HLL_UNION: aggregation method for HLL type columns, which is aggregated by HyperLogLog algorithm. ●BITMAP_UNION: aggregation method for BIMTAP type columns; bitmap union aggregation.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AggType")]
        public string AggType{ get; set; }

        /// <summary>
        /// Whether the column value is allowed to be Null
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsNull")]
        public bool? IsNull{ get; set; }

        /// <summary>
        /// Whether it is a Key column. The meaning of different data models:
        /// ●DUP_KEY: The column specified afterwards is the sorting column.
        /// ●AGG_KEY: The column specified afterwards is the dimension column.
        /// ●UNI_KEY: The column specified afterward is the primary key column.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsKey")]
        public bool? IsKey{ get; set; }

        /// <summary>
        /// Column's default value
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// Whether it is a partition column. The partition column must be a Key column.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsPartition")]
        public bool? IsPartition{ get; set; }

        /// <summary>
        /// Whether it is a bucket column. The bucket column of the aggregation model and primary key model must be Key columns, while the bucket column of the detail model can be any column.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsDistribution")]
        public bool? IsDistribution{ get; set; }

        /// <summary>
        /// Whether it is an auto-increment column. Supported by TCHouse-D 2.1 version and later.
        /// Limit:
        /// 1. Only DUP_KEY and UNI_KEY model tables can contain auto-increment columns.
        /// 2. A table can contain at most one auto-increment column.
        /// 3. The type of the auto-increment column must be BIGINT type and cannot be null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoInc")]
        public bool? AutoInc{ get; set; }

        /// <summary>
        /// Column description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AggType", this.AggType);
            this.SetParamSimple(map, prefix + "IsNull", this.IsNull);
            this.SetParamSimple(map, prefix + "IsKey", this.IsKey);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "IsPartition", this.IsPartition);
            this.SetParamSimple(map, prefix + "IsDistribution", this.IsDistribution);
            this.SetParamSimple(map, prefix + "AutoInc", this.AutoInc);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

