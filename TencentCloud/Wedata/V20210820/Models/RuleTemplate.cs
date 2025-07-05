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

    public class RuleTemplate : AbstractModel
    {
        
        /// <summary>
        /// Rule Template ID
        /// </summary>
        [JsonProperty("RuleTemplateId")]
        public ulong? RuleTemplateId{ get; set; }

        /// <summary>
        /// Rule Template Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Rule Template Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Template Type (1: System Template, 2: Self Definition)
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Applicable Source Data Object Type (1: Constant, 2: Offline Table Level, 3: Offline Field Level)
        /// </summary>
        [JsonProperty("SourceObjectType")]
        public ulong? SourceObjectType{ get; set; }

        /// <summary>
        /// Applicable Source Data Object Type (1: Numeric, 2: String)
        /// </summary>
        [JsonProperty("SourceObjectDataType")]
        public ulong? SourceObjectDataType{ get; set; }

        /// <summary>
        /// Rule Template Source Side Content, distinguish engine, JSON Structure
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// Applicable Source Data Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceEngineTypes")]
        public ulong?[] SourceEngineTypes{ get; set; }

        /// <summary>
        /// Quality Dimension of Rule (1: Accuracy, 2: Uniqueness, 3: Completeness, 4: Consistency, 5: Timeliness, 6: Validity)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }

        /// <summary>
        /// Supported Comparison Types for Rule (1: Fixed Value Comparison, greater than, less than, greater than or equal, etc. 2: Fluctuation Value Comparison, absolute value, increase, decrease)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompareType")]
        public ulong? CompareType{ get; set; }

        /// <summary>
        /// Number of References
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CitationCount")]
        public ulong? CitationCount{ get; set; }

        /// <summary>
        /// Creator ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UserId")]
        public ulong? UserId{ get; set; }

        /// <summary>
        /// Creator Nickname
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Update Time yyyy-MM-dd HH:mm:ss
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Whether to add where parameter
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WhereFlag")]
        public bool? WhereFlag{ get; set; }

        /// <summary>
        /// Whether to Associate Multiple Tables
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MultiSourceFlag")]
        public bool? MultiSourceFlag{ get; set; }

        /// <summary>
        /// Custom Template SQL Expression from Definition
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SqlExpression")]
        public string SqlExpression{ get; set; }

        /// <summary>
        /// Template Sub-dimension,0. Parent Dimension Type,1. Consistency: Enumeration Range Consistency,2. Consistency: Numeric Range Consistency,3. Consistency: Field Data Correlation
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SubQualityDim")]
        public ulong? SubQualityDim{ get; set; }

        /// <summary>
        /// SQL Expression Parsing Object
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ResolvedSqlExpression")]
        public SqlExpression ResolvedSqlExpression{ get; set; }

        /// <summary>
        /// Supported Data Source Types
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DatasourceTypes")]
        public long?[] DatasourceTypes{ get; set; }

        /// <summary>
        /// Created by User ID Str
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UserIdStr")]
        public string UserIdStr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleTemplateId", this.RuleTemplateId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SourceObjectType", this.SourceObjectType);
            this.SetParamSimple(map, prefix + "SourceObjectDataType", this.SourceObjectDataType);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamArraySimple(map, prefix + "SourceEngineTypes.", this.SourceEngineTypes);
            this.SetParamSimple(map, prefix + "QualityDim", this.QualityDim);
            this.SetParamSimple(map, prefix + "CompareType", this.CompareType);
            this.SetParamSimple(map, prefix + "CitationCount", this.CitationCount);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "WhereFlag", this.WhereFlag);
            this.SetParamSimple(map, prefix + "MultiSourceFlag", this.MultiSourceFlag);
            this.SetParamSimple(map, prefix + "SqlExpression", this.SqlExpression);
            this.SetParamSimple(map, prefix + "SubQualityDim", this.SubQualityDim);
            this.SetParamObj(map, prefix + "ResolvedSqlExpression.", this.ResolvedSqlExpression);
            this.SetParamArraySimple(map, prefix + "DatasourceTypes.", this.DatasourceTypes);
            this.SetParamSimple(map, prefix + "UserIdStr", this.UserIdStr);
        }
    }
}

