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

    public class CategoryItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Sub-item ID<br>Enumeration values:<br>vulnerability: Vulnerability governance<br>cloud_config: Cloud product configuration governance<br>system_baseline: System baseline risk<br>intrusion_alert: Intrusion threat alarm<br>cloud_api_alert: Cloud API alarm<br>ai_agent_alert: AI Agent security alarm<br>object_storage_alert: Object storage exception alarm<br>database_alert: Database security alarm<br>protection_config: Recommended protection configuration not enabled<br>edition_coverage: Insufficient Pro/Ultimate edition coverage<br>product_expiry: Product expires within 7 days</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>Sub-item name</p>
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// <p>Subclass description</p>
        /// </summary>
        [JsonProperty("CategoryDesc")]
        public string CategoryDesc{ get; set; }

        /// <summary>
        /// <p>Sub-item deduction limit</p>
        /// </summary>
        [JsonProperty("MaxDeductScore")]
        public long? MaxDeductScore{ get; set; }

        /// <summary>
        /// <p>Actual point deduction for sub-items</p>
        /// </summary>
        [JsonProperty("DeductScore")]
        public long? DeductScore{ get; set; }

        /// <summary>
        /// <p>Total number of risks</p>
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// <p>Level details, sub-items of risk/threat type have values</p>
        /// </summary>
        [JsonProperty("SeverityItems")]
        public SeverityItem[] SeverityItems{ get; set; }

        /// <summary>
        /// <p>Reason for deduction description</p>
        /// </summary>
        [JsonProperty("DeductReason")]
        public string DeductReason{ get; set; }

        /// <summary>
        /// <p>Handling suggestion copywriting</p>
        /// </summary>
        [JsonProperty("ActionText")]
        public string ActionText{ get; set; }

        /// <summary>
        /// <p>Protection configuration detail, returned only for protection configuration dimension sub-items</p>
        /// </summary>
        [JsonProperty("ProtectionDetail")]
        public ProtectionDetail ProtectionDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "CategoryDesc", this.CategoryDesc);
            this.SetParamSimple(map, prefix + "MaxDeductScore", this.MaxDeductScore);
            this.SetParamSimple(map, prefix + "DeductScore", this.DeductScore);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamArrayObj(map, prefix + "SeverityItems.", this.SeverityItems);
            this.SetParamSimple(map, prefix + "DeductReason", this.DeductReason);
            this.SetParamSimple(map, prefix + "ActionText", this.ActionText);
            this.SetParamObj(map, prefix + "ProtectionDetail.", this.ProtectionDetail);
        }
    }
}

