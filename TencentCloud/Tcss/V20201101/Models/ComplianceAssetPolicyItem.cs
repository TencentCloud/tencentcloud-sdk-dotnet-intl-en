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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComplianceAssetPolicyItem : AbstractModel
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
        /// Category of the check item
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Compliance standard ID
        /// </summary>
        [JsonProperty("BenchmarkStandardId")]
        public ulong? BenchmarkStandardId{ get; set; }

        /// <summary>
        /// Compliance standard name
        /// </summary>
        [JsonProperty("BenchmarkStandardName")]
        public string BenchmarkStandardName{ get; set; }

        /// <summary>
        /// Severity
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Check status
        /// `CHECK_INIT`: To be checked.
        /// `CHECK_RUNNING`: Checking.
        /// `CHECK_FINISHED`: Checked.
        /// `CHECK_FAILED`: Check failed.
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// Check result
        /// `RESULT_PASSED`: Passed.
        /// `RESULT_FAILED`: Failed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckResult")]
        public string CheckResult{ get; set; }

        /// <summary>
        /// Allowed item ID of the check item. If it exists and is not `0`, the check item is ignored.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WhitelistId")]
        public ulong? WhitelistId{ get; set; }

        /// <summary>
        /// Handling suggestion
        /// </summary>
        [JsonProperty("FixSuggestion")]
        public string FixSuggestion{ get; set; }

        /// <summary>
        /// Last check time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastCheckTime")]
        public string LastCheckTime{ get; set; }

        /// <summary>
        /// Verification information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerifyInfo")]
        public string VerifyInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerPolicyItemId", this.CustomerPolicyItemId);
            this.SetParamSimple(map, prefix + "BasePolicyItemId", this.BasePolicyItemId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "BenchmarkStandardId", this.BenchmarkStandardId);
            this.SetParamSimple(map, prefix + "BenchmarkStandardName", this.BenchmarkStandardName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "CheckResult", this.CheckResult);
            this.SetParamSimple(map, prefix + "WhitelistId", this.WhitelistId);
            this.SetParamSimple(map, prefix + "FixSuggestion", this.FixSuggestion);
            this.SetParamSimple(map, prefix + "LastCheckTime", this.LastCheckTime);
            this.SetParamSimple(map, prefix + "VerifyInfo", this.VerifyInfo);
        }
    }
}

