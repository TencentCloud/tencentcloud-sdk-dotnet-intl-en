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

    public class ScoreRuleItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Rule type<br>Enumeration value:<br>dimension: dimensional rule<br>category: category-level rule<br>severity: severity-level rule</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// <p>Dimension ID</p>
        /// </summary>
        [JsonProperty("DimensionId")]
        public string DimensionId{ get; set; }

        /// <summary>
        /// <p>Dimension name</p>
        /// </summary>
        [JsonProperty("DimensionName")]
        public string DimensionName{ get; set; }

        /// <summary>
        /// <p>Sub-item ID.</p>
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// <p>Sub-item point deduction rule description</p>
        /// </summary>
        [JsonProperty("CategoryDesc")]
        public string CategoryDesc{ get; set; }

        /// <summary>
        /// <p>Sub-item name.</p>
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// <p>Severity<br>Enumeration values:<br>critical: Critical<br>high: High risk<br>medium: Medium risk<br>low: Low risk</p>
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }

        /// <summary>
        /// <p>Deduction limit</p>
        /// </summary>
        [JsonProperty("MaxDeductScore")]
        public long? MaxDeductScore{ get; set; }

        /// <summary>
        /// <p>Points deducted per time.</p>
        /// </summary>
        [JsonProperty("DeductPerItem")]
        public long? DeductPerItem{ get; set; }

        /// <summary>
        /// <p>Whether individual deduction is non-editable (true for sub-items under Protection Configuration Dimension)</p>
        /// </summary>
        [JsonProperty("DeductPerItemDisabled")]
        public bool? DeductPerItemDisabled{ get; set; }

        /// <summary>
        /// <p>Sorting serial number</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public long? SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "DimensionId", this.DimensionId);
            this.SetParamSimple(map, prefix + "DimensionName", this.DimensionName);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CategoryDesc", this.CategoryDesc);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "MaxDeductScore", this.MaxDeductScore);
            this.SetParamSimple(map, prefix + "DeductPerItem", this.DeductPerItem);
            this.SetParamSimple(map, prefix + "DeductPerItemDisabled", this.DeductPerItemDisabled);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}

