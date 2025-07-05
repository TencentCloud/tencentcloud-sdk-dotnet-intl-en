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

    public class RuleExecResult : AbstractModel
    {
        
        /// <summary>
        /// Rule Execution ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleExecId")]
        public ulong? RuleExecId{ get; set; }

        /// <summary>
        /// Rule Group Execution ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleGroupExecId")]
        public ulong? RuleGroupExecId{ get; set; }

        /// <summary>
        /// Rule Group IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// Rule IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// Rule nameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule type 1.System Template, 2.Custom Definition Template, 3.Custom Definition SQLNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleType")]
        public ulong? RuleType{ get; set; }

        /// <summary>
        /// Source Field Detailed Type, int string
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceObjectDataTypeName")]
        public string SourceObjectDataTypeName{ get; set; }

        /// <summary>
        /// Source Field NameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SourceObjectValue")]
        public string SourceObjectValue{ get; set; }

        /// <summary>
        /// Conditional Scan WHERE Condition ExpressionNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ConditionExpression")]
        public string ConditionExpression{ get; set; }

        /// <summary>
        /// Test Results (1: Detection passed, 2: Trigger Rules, 3: Detection failed)
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExecResultStatus")]
        public ulong? ExecResultStatus{ get; set; }

        /// <summary>
        /// Trigger Result, Alert Sent Successfully, Block Task Successful
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TriggerResult")]
        public string TriggerResult{ get; set; }

        /// <summary>
        /// Comparison Result
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompareResult")]
        public CompareResult CompareResult{ get; set; }

        /// <summary>
        /// Template name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Quality Dimension
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }

        /// <summary>
        /// Target Table - Database Table Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetDBTableName")]
        public string TargetDBTableName{ get; set; }

        /// <summary>
        /// Target Table - Field Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetObjectValue")]
        public string TargetObjectValue{ get; set; }

        /// <summary>
        /// Target Table - Field Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TargetObjectDataType")]
        public string TargetObjectDataType{ get; set; }

        /// <summary>
        /// Custom Definition Template SQL Expression Parameters
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FieldConfig")]
        public RuleFieldConfig FieldConfig{ get; set; }

        /// <summary>
        /// Source Field and Target Field Association Condition ON ExpressionNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RelConditionExpr")]
        public string RelConditionExpr{ get; set; }

        /// <summary>
        /// Execution timeNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 1/2/3: Low/Medium/High
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleExecId", this.RuleExecId);
            this.SetParamSimple(map, prefix + "RuleGroupExecId", this.RuleGroupExecId);
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "SourceObjectDataTypeName", this.SourceObjectDataTypeName);
            this.SetParamSimple(map, prefix + "SourceObjectValue", this.SourceObjectValue);
            this.SetParamSimple(map, prefix + "ConditionExpression", this.ConditionExpression);
            this.SetParamSimple(map, prefix + "ExecResultStatus", this.ExecResultStatus);
            this.SetParamSimple(map, prefix + "TriggerResult", this.TriggerResult);
            this.SetParamObj(map, prefix + "CompareResult.", this.CompareResult);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "QualityDim", this.QualityDim);
            this.SetParamSimple(map, prefix + "TargetDBTableName", this.TargetDBTableName);
            this.SetParamSimple(map, prefix + "TargetObjectValue", this.TargetObjectValue);
            this.SetParamSimple(map, prefix + "TargetObjectDataType", this.TargetObjectDataType);
            this.SetParamObj(map, prefix + "FieldConfig.", this.FieldConfig);
            this.SetParamSimple(map, prefix + "RelConditionExpr", this.RelConditionExpr);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
        }
    }
}

