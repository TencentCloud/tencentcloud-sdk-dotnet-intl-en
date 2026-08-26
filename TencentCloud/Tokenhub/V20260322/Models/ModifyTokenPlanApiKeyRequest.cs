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

    public class ModifyTokenPlanApiKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// API Key ID.
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// Available model list. If this parameter is not specified, no modification is made.
        /// 
        /// - If the package type is enterprise professional:
        /// 1) Input "all": use all models supported by the package
        /// 2) Import Model ID: specify a specific model. "all" and a specific Model ID cannot be specified at the same time.
        /// 
        /// -If the package type is enterprise lightweight edition, do not pass in this parameter.
        /// </summary>
        [JsonProperty("AllowedModels")]
        public string[] AllowedModels{ get; set; }

        /// <summary>
        /// Dedicated limit. If this parameter is not specified, no modification will be made. Unit:
        /// 
        /// -Package type: professional. Measurement unit: point.
        /// - Package type is lite package, and the measurement unit is token.
        /// </summary>
        [JsonProperty("ExclusiveQuota")]
        public long? ExclusiveQuota{ get; set; }

        /// <summary>
        /// Total credit limit. -1 means unlimited. It must be -1 or greater than or equal to the current ExclusiveQuota of the API Key. If not passed, no modification is made. Measurement units are as follows:
        /// -Package type: professional. Measurement unit: point.
        /// - Package type is lite package, and the measurement unit is token.
        /// </summary>
        [JsonProperty("TotalQuota")]
        public long? TotalQuota{ get; set; }

        /// <summary>
        /// Whether to enable the API Key. Values: enable (enable), disable (disable). If not passed, no modification is made.
        /// </summary>
        [JsonProperty("UseStatus")]
        public string UseStatus{ get; set; }

        /// <summary>
        /// TPM (Tokens Per Minute) limit. If not passed, no modification will be made. Must be >= 0 and <= the package TPM.
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiKeyId", this.ApiKeyId);
            this.SetParamArraySimple(map, prefix + "AllowedModels.", this.AllowedModels);
            this.SetParamSimple(map, prefix + "ExclusiveQuota", this.ExclusiveQuota);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "UseStatus", this.UseStatus);
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
        }
    }
}

