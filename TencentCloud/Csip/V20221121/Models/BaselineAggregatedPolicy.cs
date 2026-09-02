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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineAggregatedPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>Parent category ID of the system policy (only for aggregation when PolicyType=SYSTEM; 0 for custom policy).</p>
        /// </summary>
        [JsonProperty("ParentCategoryID")]
        public ulong? ParentCategoryID{ get; set; }

        /// <summary>
        /// <p>List of baseline policy IDs involved in this aggregation.</p>
        /// </summary>
        [JsonProperty("PolicyID")]
        public ulong?[] PolicyID{ get; set; }

        /// <summary>
        /// <p>Policy Name (custom policy is user input, and system policy is a built-in classification name).</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Policy description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Number of detection items configured in the policy.</p>
        /// </summary>
        [JsonProperty("ConfItemCount")]
        public ulong? ConfItemCount{ get; set; }

        /// <summary>
        /// <p>Number of detection items with a result of PASS under this policy.</p>
        /// </summary>
        [JsonProperty("PassItemCount")]
        public ulong? PassItemCount{ get; set; }

        /// <summary>
        /// <p>Number of detection items with result NOT_PASS under this policy.</p>
        /// </summary>
        [JsonProperty("NotPassItemCount")]
        public ulong? NotPassItemCount{ get; set; }

        /// <summary>
        /// <p>Distribution statistics of detection failed items by risk level (LOW/MEDIUM/HIGH/CRITICAL).</p>
        /// </summary>
        [JsonProperty("NotPassItemRiskLevelStatistic")]
        public BaselineRiskLevelStatistic[] NotPassItemRiskLevelStatistic{ get; set; }

        /// <summary>
        /// <p>Passing rate of the last scan of this policy, unit: percentage (0-100), rounded to two decimal places.</p>
        /// </summary>
        [JsonProperty("PassRate")]
        public float? PassRate{ get; set; }

        /// <summary>
        /// <p>Scanning result statistics details of each subcategory under this policy.</p>
        /// </summary>
        [JsonProperty("CategoryStatistic")]
        public BaselineAggregatedCategory[] CategoryStatistic{ get; set; }

        /// <summary>
        /// <p>Baseline policy type. Values:</p><ul><li>SYSTEM: system policy (CSIP built-in)</li><li>SELF: user-defined policy</li></ul>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// <p>Detect asset major category, case-sensitive host baseline and container cluster baseline. Parameter values:</p><ul><li>HOST: Host</li><li>CLUSTER: Container cluster</li></ul>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string CheckAssetType{ get; set; }

        /// <summary>
        /// <p>Whether the baseline category has been scanned</p>
        /// </summary>
        [JsonProperty("Scanned")]
        public bool? Scanned{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParentCategoryID", this.ParentCategoryID);
            this.SetParamArraySimple(map, prefix + "PolicyID.", this.PolicyID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConfItemCount", this.ConfItemCount);
            this.SetParamSimple(map, prefix + "PassItemCount", this.PassItemCount);
            this.SetParamSimple(map, prefix + "NotPassItemCount", this.NotPassItemCount);
            this.SetParamArrayObj(map, prefix + "NotPassItemRiskLevelStatistic.", this.NotPassItemRiskLevelStatistic);
            this.SetParamSimple(map, prefix + "PassRate", this.PassRate);
            this.SetParamArrayObj(map, prefix + "CategoryStatistic.", this.CategoryStatistic);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "CheckAssetType", this.CheckAssetType);
            this.SetParamSimple(map, prefix + "Scanned", this.Scanned);
        }
    }
}

