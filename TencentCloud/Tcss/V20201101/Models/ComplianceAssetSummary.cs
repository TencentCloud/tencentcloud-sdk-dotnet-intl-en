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

    public class ComplianceAssetSummary : AbstractModel
    {
        
        /// <summary>
        /// Asset type
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Whether it is the first check. This parameter is used together with `CheckStatus`.
        /// </summary>
        [JsonProperty("IsCustomerFirstCheck")]
        public bool? IsCustomerFirstCheck{ get; set; }

        /// <summary>
        /// Check status
        /// 
        /// `CHECK_UNINIT`: Feature not enabled.
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
        /// Check progress. Value range: 0-100. This field is valid only if the check is running.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckProgress")]
        public float? CheckProgress{ get; set; }

        /// <summary>
        /// Number of check items that the asset passed
        /// </summary>
        [JsonProperty("PassedPolicyItemCount")]
        public ulong? PassedPolicyItemCount{ get; set; }

        /// <summary>
        /// Number of check items that the asset failed
        /// </summary>
        [JsonProperty("FailedPolicyItemCount")]
        public ulong? FailedPolicyItemCount{ get; set; }

        /// <summary>
        /// Number of critical check items that the asset failed
        /// </summary>
        [JsonProperty("FailedCriticalPolicyItemCount")]
        public ulong? FailedCriticalPolicyItemCount{ get; set; }

        /// <summary>
        /// Number of high-risk check items that the asset failed
        /// </summary>
        [JsonProperty("FailedHighRiskPolicyItemCount")]
        public ulong? FailedHighRiskPolicyItemCount{ get; set; }

        /// <summary>
        /// Number of medium-risk check items that the asset failed
        /// </summary>
        [JsonProperty("FailedMediumRiskPolicyItemCount")]
        public ulong? FailedMediumRiskPolicyItemCount{ get; set; }

        /// <summary>
        /// Number of low-risk check items that the asset failed
        /// </summary>
        [JsonProperty("FailedLowRiskPolicyItemCount")]
        public ulong? FailedLowRiskPolicyItemCount{ get; set; }

        /// <summary>
        /// Number of prompt check items of the asset
        /// </summary>
        [JsonProperty("NoticePolicyItemCount")]
        public ulong? NoticePolicyItemCount{ get; set; }

        /// <summary>
        /// Number of assets that passed the check
        /// </summary>
        [JsonProperty("PassedAssetCount")]
        public ulong? PassedAssetCount{ get; set; }

        /// <summary>
        /// Number of assets that failed the check
        /// </summary>
        [JsonProperty("FailedAssetCount")]
        public ulong? FailedAssetCount{ get; set; }

        /// <summary>
        /// Asset compliance rate. Value range: 0-100.
        /// </summary>
        [JsonProperty("AssetPassedRate")]
        public float? AssetPassedRate{ get; set; }

        /// <summary>
        /// Number of assets that failed the check
        /// </summary>
        [JsonProperty("ScanFailedAssetCount")]
        public ulong? ScanFailedAssetCount{ get; set; }

        /// <summary>
        /// Last check duration in seconds
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckCostTime")]
        public float? CheckCostTime{ get; set; }

        /// <summary>
        /// Last check time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastCheckTime")]
        public string LastCheckTime{ get; set; }

        /// <summary>
        /// Scheduled check rule
        /// </summary>
        [JsonProperty("PeriodRule")]
        public CompliancePeriodTaskRule PeriodRule{ get; set; }

        /// <summary>
        /// Total number of enabled check items
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OpenPolicyItemCount")]
        public ulong? OpenPolicyItemCount{ get; set; }

        /// <summary>
        /// Total number of ignored check items
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IgnoredPolicyItemCount")]
        public ulong? IgnoredPolicyItemCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "IsCustomerFirstCheck", this.IsCustomerFirstCheck);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "CheckProgress", this.CheckProgress);
            this.SetParamSimple(map, prefix + "PassedPolicyItemCount", this.PassedPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedPolicyItemCount", this.FailedPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedCriticalPolicyItemCount", this.FailedCriticalPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedHighRiskPolicyItemCount", this.FailedHighRiskPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedMediumRiskPolicyItemCount", this.FailedMediumRiskPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedLowRiskPolicyItemCount", this.FailedLowRiskPolicyItemCount);
            this.SetParamSimple(map, prefix + "NoticePolicyItemCount", this.NoticePolicyItemCount);
            this.SetParamSimple(map, prefix + "PassedAssetCount", this.PassedAssetCount);
            this.SetParamSimple(map, prefix + "FailedAssetCount", this.FailedAssetCount);
            this.SetParamSimple(map, prefix + "AssetPassedRate", this.AssetPassedRate);
            this.SetParamSimple(map, prefix + "ScanFailedAssetCount", this.ScanFailedAssetCount);
            this.SetParamSimple(map, prefix + "CheckCostTime", this.CheckCostTime);
            this.SetParamSimple(map, prefix + "LastCheckTime", this.LastCheckTime);
            this.SetParamObj(map, prefix + "PeriodRule.", this.PeriodRule);
            this.SetParamSimple(map, prefix + "OpenPolicyItemCount", this.OpenPolicyItemCount);
            this.SetParamSimple(map, prefix + "IgnoredPolicyItemCount", this.IgnoredPolicyItemCount);
        }
    }
}

