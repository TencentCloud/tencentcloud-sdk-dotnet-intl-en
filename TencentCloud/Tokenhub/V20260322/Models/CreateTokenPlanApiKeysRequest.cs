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

    public class CreateTokenPlanApiKeysRequest : AbstractModel
    {
        
        /// <summary>
        /// Package ID. You can obtain it through the DescribeTokenPlanList API.
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// API key name, up to 128 characters. If the number of API keys created exceeds 1, the actual name format is {ApiKeyName}-{serial number} (for example, mykey-1, mykey-2).
        /// </summary>
        [JsonProperty("ApiKeyName")]
        public string ApiKeyName{ get; set; }

        /// <summary>
        /// Number of creations. Value range: 1–10.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// List of available models. If the package type is the enterprise edition professional package, you can specify a model or pass in "all". "all" means all models supported by the package are available for use. To specify specific models, pass in Model IDs. "all" and specific Model IDs cannot be specified at the same time. If not provided, it indicates the API Key does not support any models, thereby impacting normal use of the API Key. If the package type is the enterprise edition lite package, this field will be force overwritten to ["auto"] regardless of whether it is provided and what value is passed in.
        /// </summary>
        [JsonProperty("AllowedModels")]
        public string[] AllowedModels{ get; set; }

        /// <summary>
        /// Exclusive reserved quota. If not passed in, the value is `0`, which means no exclusive reserved quota is assigned to the API Key. Measurement units are as follows:
        /// -Package type is professional, unit value is points;
        /// -Package type is lite package, and the measurement unit is token.
        /// </summary>
        [JsonProperty("ExclusiveQuota")]
        public long? ExclusiveQuota{ get; set; }

        /// <summary>
        /// Total credit limit. -1 means unlimited. It must be -1 or greater than or equal to the current ExclusiveQuota of the API Key. If not passed, no upper limit is set. The units are as follows:
        /// -Package type is professional, unit value is points;
        /// -Package type is lite package, and the measurement unit is token.
        /// </summary>
        [JsonProperty("TotalQuota")]
        public long? TotalQuota{ get; set; }

        /// <summary>
        /// TPM (Tokens Per Minute) limit. If not passed, the plan-level TPM is used. Must be >= 0 and <= the package TPM.
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "ApiKeyName", this.ApiKeyName);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamArraySimple(map, prefix + "AllowedModels.", this.AllowedModels);
            this.SetParamSimple(map, prefix + "ExclusiveQuota", this.ExclusiveQuota);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
        }
    }
}

