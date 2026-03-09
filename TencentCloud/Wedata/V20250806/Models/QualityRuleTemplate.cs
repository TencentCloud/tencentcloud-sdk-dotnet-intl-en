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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityRuleTemplate : AbstractModel
    {
        
        /// <summary>
        /// Rule template ID.
        /// </summary>
        [JsonProperty("RuleTemplateId")]
        public ulong? RuleTemplateId{ get; set; }

        /// <summary>
        /// Rule template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Rule template description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Template type (1: system template, 2: custom).
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Applicable source data object type for rule (1: constant, 2: offline table level, 3: offline field level).
        /// </summary>
        [JsonProperty("SourceObjectType")]
        public ulong? SourceObjectType{ get; set; }

        /// <summary>
        /// Applicable source data object type for rule (1: numeric value, 2: string).
        /// </summary>
        [JsonProperty("SourceObjectDataType")]
        public ulong? SourceObjectDataType{ get; set; }

        /// <summary>
        /// Rule template source side content, case-sensitive, JSON structure.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// Applicable source data type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SourceEngineTypes")]
        public ulong?[] SourceEngineTypes{ get; set; }

        /// <summary>
        /// Quality dimension of rule (1: accuracy, 2: uniqueness, 3: integrity, 4: consistency, 5: timeliness, 6: validity).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }

        /// <summary>
        /// Supported comparison types for rule (1: fixed value comparison, more than, less than, equal to or greater than; 2: fluctuation value comparison, absolute value, rise, drop).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CompareType")]
        public ulong? CompareType{ get; set; }

        /// <summary>
        /// Referenced times.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CitationCount")]
        public ulong? CitationCount{ get; set; }

        /// <summary>
        /// Creator ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserId")]
        public ulong? UserId{ get; set; }

        /// <summary>
        /// Creator nickname.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Last update time yyyy-MM-dd HH:MM:ss.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Whether to add where parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WhereFlag")]
        public bool? WhereFlag{ get; set; }

        /// <summary>
        /// Whether multiple database tables are associated.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MultiSourceFlag")]
        public bool? MultiSourceFlag{ get; set; }

        /// <summary>
        /// Custom template SQL expression.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SqlExpression")]
        public string SqlExpression{ get; set; }

        /// <summary>
        /// Template sub-dimension, 0. parent dimension type, 1. consistency: enumeration range consistency, 2. consistency: numeric range consistency, 3. consistency: field data correlation.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubQualityDim")]
        public ulong? SubQualityDim{ get; set; }

        /// <summary>
        /// sql expression parsing object.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResolvedSqlExpression")]
        public QualitySqlExpression ResolvedSqlExpression{ get; set; }

        /// <summary>
        /// Supported data source types.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatasourceTypes")]
        public long?[] DatasourceTypes{ get; set; }

        /// <summary>
        /// Created by user id str.
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

