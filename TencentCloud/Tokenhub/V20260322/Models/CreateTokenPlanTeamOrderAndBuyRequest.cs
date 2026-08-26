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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTokenPlanTeamOrderAndBuyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Package type. Value: enterprise (enterprise edition professional package), enterprise-auto (enterprise edition lite package).</p>
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// <p>Package name. It can only contain Chinese, letters, digits, underscores, and hyphens. It must start with a Chinese character or a letter and end with a Chinese character, letter, or digit. The length should be 2-50 characters.</p>
        /// </summary>
        [JsonProperty("TeamName")]
        public string TeamName{ get; set; }

        /// <summary>
        /// <p>Purchase duration. Unit: Month. It must be greater than 0, supporting 1 to 12 months.</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>Specification of the purchased package. If the package type is enterprise, the measurement unit is point; if the package type is enterprise-auto, the measurement unit is tokens.</p>
        /// </summary>
        [JsonProperty("CreditOrToken")]
        public long? CreditOrToken{ get; set; }

        /// <summary>
        /// <p>Whether to enable auto-renewal. Not enabled by default.</p>
        /// </summary>
        [JsonProperty("EnableAutoRenew")]
        public bool? EnableAutoRenew{ get; set; }

        /// <summary>
        /// <p>Existing package ID (if not empty, the renewal process is performed; if empty, a new purchase is performed)</p>
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "TeamName", this.TeamName);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "CreditOrToken", this.CreditOrToken);
            this.SetParamSimple(map, prefix + "EnableAutoRenew", this.EnableAutoRenew);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
        }
    }
}

