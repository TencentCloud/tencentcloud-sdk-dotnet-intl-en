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

    public class Rule : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// Rule Group ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// Data Table ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// Rule nameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Rule Type 1. System Template, 2. Custom Definition Template, 3. Custom Definition SQL
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Rule Template ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleTemplateId")]
        public ulong? RuleTemplateId{ get; set; }

        /// <summary>
        /// Rule Template Overview
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleTemplateContent")]
        public string RuleTemplateContent{ get; set; }

        /// <summary>
        /// Quality Dimension of Rule 1: Accuracy, 2: Uniqueness, 3: Completeness, 4: Consistency, 5: Timeliness, 6: Validity
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }

        /// <summary>
        /// Applicable Source Data Object Type (1: Constant, 2: Offline Table Level, 3: Offline Field Level)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceObjectType")]
        public ulong? SourceObjectType{ get; set; }

        /// <summary>
        /// Applicable Source Data Object Type (1: Numeric, 2: String)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceObjectDataType")]
        public ulong? SourceObjectDataType{ get; set; }

        /// <summary>
        /// Source Field Detailed Type, INT, STRING
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceObjectDataTypeName")]
        public string SourceObjectDataTypeName{ get; set; }

        /// <summary>
        /// Source Field Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceObjectValue")]
        public string SourceObjectValue{ get; set; }

        /// <summary>
        /// Detection Range 1. Whole Table, 2. Conditional Scan
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ConditionType")]
        public ulong? ConditionType{ get; set; }

        /// <summary>
        /// Conditional Scan WHERE Condition Expression
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ConditionExpression")]
        public string ConditionExpression{ get; set; }

        /// <summary>
        /// Custom Template SQL Expression from Definition
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CustomSql")]
        public string CustomSql{ get; set; }

        /// <summary>
        /// Alert Trigger Condition
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompareRule")]
        public CompareRule CompareRule{ get; set; }

        /// <summary>
        /// Alert Trigger Level 1. Low, 2. Medium, 3. High
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// Rule DescriptionNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Rule Configurator
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Target Database Id
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetDatabaseId")]
        public string TargetDatabaseId{ get; set; }

        /// <summary>
        /// Target Database Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetDatabaseName")]
        public string TargetDatabaseName{ get; set; }

        /// <summary>
        /// Target Table Id
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetTableId")]
        public string TargetTableId{ get; set; }

        /// <summary>
        /// Target Table Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetTableName")]
        public string TargetTableName{ get; set; }

        /// <summary>
        /// Target Field Filter Condition Expression
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetConditionExpr")]
        public string TargetConditionExpr{ get; set; }

        /// <summary>
        /// Source and target field association conditions in ON expression
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RelConditionExpr")]
        public string RelConditionExpr{ get; set; }

        /// <summary>
        /// From Definition template SQL expression parameters
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FieldConfig")]
        public RuleFieldConfig FieldConfig{ get; set; }

        /// <summary>
        /// Whether to join multiple tables
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MultiSourceFlag")]
        public bool? MultiSourceFlag{ get; set; }

        /// <summary>
        /// Whether WHERE parameters exist
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("WhereFlag")]
        public bool? WhereFlag{ get; set; }

        /// <summary>
        /// Template original SQL
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TemplateSql")]
        public string TemplateSql{ get; set; }

        /// <summary>
        /// Template sub-dimensions: 0.Parent dimension type, 1.Consistency: Enum range consistency, 2.Consistency: Numeric range consistency, 3.Consistency: Field data correlation
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SubQualityDim")]
        public ulong? SubQualityDim{ get; set; }

        /// <summary>
        /// Rule applicable target data object types (1: Constant, 2: Offline table level, 3: Offline field level)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetObjectType")]
        public ulong? TargetObjectType{ get; set; }

        /// <summary>
        /// Rule applicable target data object types (1: Numeric, 2: String)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetObjectDataType")]
        public ulong? TargetObjectDataType{ get; set; }

        /// <summary>
        /// Target field detailed types, INT, STRING
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetObjectDataTypeName")]
        public string TargetObjectDataTypeName{ get; set; }

        /// <summary>
        /// Target field name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetObjectValue")]
        public string TargetObjectValue{ get; set; }

        /// <summary>
        /// Source engine type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceEngineTypes")]
        public ulong?[] SourceEngineTypes{ get; set; }

        /// <summary>
        /// Table name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Table manager name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TableOwnerName")]
        public string TableOwnerName{ get; set; }

        /// <summary>
        /// Execution strategy information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExecStrategy")]
        public RuleGroupExecStrategy ExecStrategy{ get; set; }

        /// <summary>
        /// Subscription information
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Subscription")]
        public RuleGroupSubscribe Subscription{ get; set; }

        /// <summary>
        /// Creation TimeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Data Source ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DatasourceId")]
        public ulong? DatasourceId{ get; set; }

        /// <summary>
        /// Database ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DatabaseId")]
        public string DatabaseId{ get; set; }

        /// <summary>
        /// Monitoring enabled. 0 false, 1 true
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public long? MonitorStatus{ get; set; }

        /// <summary>
        /// Trigger conditionNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TriggerCondition")]
        public string TriggerCondition{ get; set; }

        /// <summary>
        /// 0, or not returned, or null: Undefined, 1: Production, 2: Development
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DsEnvType")]
        public long? DsEnvType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RuleTemplateId", this.RuleTemplateId);
            this.SetParamSimple(map, prefix + "RuleTemplateContent", this.RuleTemplateContent);
            this.SetParamSimple(map, prefix + "QualityDim", this.QualityDim);
            this.SetParamSimple(map, prefix + "SourceObjectType", this.SourceObjectType);
            this.SetParamSimple(map, prefix + "SourceObjectDataType", this.SourceObjectDataType);
            this.SetParamSimple(map, prefix + "SourceObjectDataTypeName", this.SourceObjectDataTypeName);
            this.SetParamSimple(map, prefix + "SourceObjectValue", this.SourceObjectValue);
            this.SetParamSimple(map, prefix + "ConditionType", this.ConditionType);
            this.SetParamSimple(map, prefix + "ConditionExpression", this.ConditionExpression);
            this.SetParamSimple(map, prefix + "CustomSql", this.CustomSql);
            this.SetParamObj(map, prefix + "CompareRule.", this.CompareRule);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "TargetDatabaseId", this.TargetDatabaseId);
            this.SetParamSimple(map, prefix + "TargetDatabaseName", this.TargetDatabaseName);
            this.SetParamSimple(map, prefix + "TargetTableId", this.TargetTableId);
            this.SetParamSimple(map, prefix + "TargetTableName", this.TargetTableName);
            this.SetParamSimple(map, prefix + "TargetConditionExpr", this.TargetConditionExpr);
            this.SetParamSimple(map, prefix + "RelConditionExpr", this.RelConditionExpr);
            this.SetParamObj(map, prefix + "FieldConfig.", this.FieldConfig);
            this.SetParamSimple(map, prefix + "MultiSourceFlag", this.MultiSourceFlag);
            this.SetParamSimple(map, prefix + "WhereFlag", this.WhereFlag);
            this.SetParamSimple(map, prefix + "TemplateSql", this.TemplateSql);
            this.SetParamSimple(map, prefix + "SubQualityDim", this.SubQualityDim);
            this.SetParamSimple(map, prefix + "TargetObjectType", this.TargetObjectType);
            this.SetParamSimple(map, prefix + "TargetObjectDataType", this.TargetObjectDataType);
            this.SetParamSimple(map, prefix + "TargetObjectDataTypeName", this.TargetObjectDataTypeName);
            this.SetParamSimple(map, prefix + "TargetObjectValue", this.TargetObjectValue);
            this.SetParamArraySimple(map, prefix + "SourceEngineTypes.", this.SourceEngineTypes);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableOwnerName", this.TableOwnerName);
            this.SetParamObj(map, prefix + "ExecStrategy.", this.ExecStrategy);
            this.SetParamObj(map, prefix + "Subscription.", this.Subscription);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamSimple(map, prefix + "TriggerCondition", this.TriggerCondition);
            this.SetParamSimple(map, prefix + "DsEnvType", this.DsEnvType);
        }
    }
}

