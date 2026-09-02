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

    public class SeverityItem : AbstractModel
    {
        
        /// <summary>
        /// Risk level
        /// Enumeration values:
        /// critical: severe
        /// high: high risk
        /// Medium: medium risk
        /// low: low-risk
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }

        /// <summary>
        /// Risk level name in Chinese
        /// </summary>
        [JsonProperty("SeverityName")]
        public string SeverityName{ get; set; }

        /// <summary>
        /// Number of risks at this level
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// Points deducted per time.
        /// </summary>
        [JsonProperty("DeductPerItem")]
        public long? DeductPerItem{ get; set; }

        /// <summary>
        /// Severity deduction limit
        /// </summary>
        [JsonProperty("MaxDeductScore")]
        public long? MaxDeductScore{ get; set; }

        /// <summary>
        /// Actual point deduction
        /// </summary>
        [JsonProperty("DeductScore")]
        public long? DeductScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "SeverityName", this.SeverityName);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "DeductPerItem", this.DeductPerItem);
            this.SetParamSimple(map, prefix + "MaxDeductScore", this.MaxDeductScore);
            this.SetParamSimple(map, prefix + "DeductScore", this.DeductScore);
        }
    }
}

