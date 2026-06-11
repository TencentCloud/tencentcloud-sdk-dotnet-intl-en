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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompliancePolicyItemSummary : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of the customer check item
        /// </summary>
        [JsonProperty("CustomerPolicyItemId")]
        public ulong? CustomerPolicyItemId{ get; set; }

        /// <summary>
        /// Original ID of the check item
        /// </summary>
        [JsonProperty("BasePolicyItemId")]
        public ulong? BasePolicyItemId{ get; set; }

        /// <summary>
        /// Check item name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Category of the check item, which is an enumerated string.
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Compliance standard
        /// </summary>
        [JsonProperty("BenchmarkStandardName")]
        public string BenchmarkStandardName{ get; set; }

        /// <summary>
        /// Severity. Valid values: `RISK_CRITICAL`, `RISK_HIGH`, `RISK_MEDIUM`, `RISK_LOW`, `RISK_NOTICE`.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Asset type of the check item
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Last detection time
        /// </summary>
        [JsonProperty("LastCheckTime")]
        public string LastCheckTime{ get; set; }

        /// <summary>
        /// Check status
        /// 
        /// `CHECK_INIT`: To be checked.
        /// 
        /// `CHECK_RUNNING`: Checking.
        /// 
        /// `CHECK_FINISHED`: Checked.
        /// 
        /// `CHECK_FAILED`: Check failed.
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// Detection result. RESULT_PASSED: Passed.
        /// 
        /// RESULT_FAILED: failed
        /// </summary>
        [JsonProperty("CheckResult")]
        public string CheckResult{ get; set; }

        /// <summary>
        /// Number of assets passed detection
        /// </summary>
        [JsonProperty("PassedAssetCount")]
        public ulong? PassedAssetCount{ get; set; }

        /// <summary>
        /// Number of assets with detection failed
        /// </summary>
        [JsonProperty("FailedAssetCount")]
        public ulong? FailedAssetCount{ get; set; }

        /// <summary>
        /// ID of the allowlist item corresponding to the detection item. If it exists and is not 0, it means the detection item is ignored by the user.
        /// </summary>
        [JsonProperty("WhitelistId")]
        public ulong? WhitelistId{ get; set; }

        /// <summary>
        /// Handling suggestion
        /// </summary>
        [JsonProperty("FixSuggestion")]
        public string FixSuggestion{ get; set; }

        /// <summary>
        /// Compliance standard ID
        /// </summary>
        [JsonProperty("BenchmarkStandardId")]
        public ulong? BenchmarkStandardId{ get; set; }

        /// <summary>
        /// Applicable Version for Check Items
        /// </summary>
        [JsonProperty("ApplicableVersion")]
        public string ApplicableVersion{ get; set; }

        /// <summary>
        /// Check Item Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Check Item Audit Method
        /// </summary>
        [JsonProperty("AuditProcedure")]
        public string AuditProcedure{ get; set; }

        /// <summary>
        /// Whether enabled
        /// <li>0 Off</li>
        /// <li>1 Enable</li>
        /// </summary>
        [JsonProperty("IsEnable")]
        public ulong? IsEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerPolicyItemId", this.CustomerPolicyItemId);
            this.SetParamSimple(map, prefix + "BasePolicyItemId", this.BasePolicyItemId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "BenchmarkStandardName", this.BenchmarkStandardName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "LastCheckTime", this.LastCheckTime);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "CheckResult", this.CheckResult);
            this.SetParamSimple(map, prefix + "PassedAssetCount", this.PassedAssetCount);
            this.SetParamSimple(map, prefix + "FailedAssetCount", this.FailedAssetCount);
            this.SetParamSimple(map, prefix + "WhitelistId", this.WhitelistId);
            this.SetParamSimple(map, prefix + "FixSuggestion", this.FixSuggestion);
            this.SetParamSimple(map, prefix + "BenchmarkStandardId", this.BenchmarkStandardId);
            this.SetParamSimple(map, prefix + "ApplicableVersion", this.ApplicableVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AuditProcedure", this.AuditProcedure);
            this.SetParamSimple(map, prefix + "IsEnable", this.IsEnable);
        }
    }
}

