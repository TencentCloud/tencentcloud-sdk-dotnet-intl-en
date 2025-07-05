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

    public class ModifyRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// Rule Group ID
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Data Table ID
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// Rule Template ID
        /// </summary>
        [JsonProperty("RuleTemplateId")]
        public ulong? RuleTemplateId{ get; set; }

        /// <summary>
        /// Rule type 1.System Template, 2.Custom Definition Template, 3.Custom Definition SQL
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Quality Dimension of Rule (1: Accuracy, 2: Uniqueness, 3: Integrity, 4: Consistency, 5: Timeliness, 6: Validity)
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }

        /// <summary>
        /// Source Field Detailed Type, int, string
        /// </summary>
        [JsonProperty("SourceObjectDataTypeName")]
        public string SourceObjectDataTypeName{ get; set; }

        /// <summary>
        /// Source Field Name
        /// </summary>
        [JsonProperty("SourceObjectValue")]
        public string SourceObjectValue{ get; set; }

        /// <summary>
        /// Detection Range 1.Whole Table 2.Conditional Scan
        /// </summary>
        [JsonProperty("ConditionType")]
        public ulong? ConditionType{ get; set; }

        /// <summary>
        /// Conditional Scan WHERE Condition Expression
        /// </summary>
        [JsonProperty("ConditionExpression")]
        public string ConditionExpression{ get; set; }

        /// <summary>
        /// Custom Definition SQL
        /// </summary>
        [JsonProperty("CustomSql")]
        public string CustomSql{ get; set; }

        /// <summary>
        /// Alert Trigger Condition
        /// </summary>
        [JsonProperty("CompareRule")]
        public CompareRule CompareRule{ get; set; }

        /// <summary>
        /// Alert Trigger Level 1.Low, 2.Medium, 3.High
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// Rule Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Target Database Id
        /// </summary>
        [JsonProperty("TargetDatabaseId")]
        public string TargetDatabaseId{ get; set; }

        /// <summary>
        /// Target Table Id
        /// </summary>
        [JsonProperty("TargetTableId")]
        public string TargetTableId{ get; set; }

        /// <summary>
        /// Target Filter Condition Expression
        /// </summary>
        [JsonProperty("TargetConditionExpr")]
        public string TargetConditionExpr{ get; set; }

        /// <summary>
        /// Source Field and Target Field Association Condition ON Expression
        /// </summary>
        [JsonProperty("RelConditionExpr")]
        public string RelConditionExpr{ get; set; }

        /// <summary>
        /// Custom Definition Template SQL Expression Field Replacement Parameter
        /// </summary>
        [JsonProperty("FieldConfig")]
        public RuleFieldConfig FieldConfig{ get; set; }

        /// <summary>
        /// Target Field Name CITY
        /// </summary>
        [JsonProperty("TargetObjectValue")]
        public string TargetObjectValue{ get; set; }

        /// <summary>
        /// Execution engine adapted to the rule
        /// </summary>
        [JsonProperty("SourceEngineTypes")]
        public ulong?[] SourceEngineTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "RuleTemplateId", this.RuleTemplateId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "QualityDim", this.QualityDim);
            this.SetParamSimple(map, prefix + "SourceObjectDataTypeName", this.SourceObjectDataTypeName);
            this.SetParamSimple(map, prefix + "SourceObjectValue", this.SourceObjectValue);
            this.SetParamSimple(map, prefix + "ConditionType", this.ConditionType);
            this.SetParamSimple(map, prefix + "ConditionExpression", this.ConditionExpression);
            this.SetParamSimple(map, prefix + "CustomSql", this.CustomSql);
            this.SetParamObj(map, prefix + "CompareRule.", this.CompareRule);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TargetDatabaseId", this.TargetDatabaseId);
            this.SetParamSimple(map, prefix + "TargetTableId", this.TargetTableId);
            this.SetParamSimple(map, prefix + "TargetConditionExpr", this.TargetConditionExpr);
            this.SetParamSimple(map, prefix + "RelConditionExpr", this.RelConditionExpr);
            this.SetParamObj(map, prefix + "FieldConfig.", this.FieldConfig);
            this.SetParamSimple(map, prefix + "TargetObjectValue", this.TargetObjectValue);
            this.SetParamArraySimple(map, prefix + "SourceEngineTypes.", this.SourceEngineTypes);
        }
    }
}

