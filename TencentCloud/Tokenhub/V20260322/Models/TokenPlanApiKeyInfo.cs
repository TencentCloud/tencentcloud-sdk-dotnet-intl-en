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

    public class TokenPlanApiKeyInfo : AbstractModel
    {
        
        /// <summary>
        /// API Key ID.
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// API Key secret key value (masked).
        /// </summary>
        [JsonProperty("ApiKey")]
        public string ApiKey{ get; set; }

        /// <summary>
        /// API Key name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Bundle ID.
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// Account APP ID.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// Main account UIN.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// API Key available model list (JSON array string).
        /// </summary>
        [JsonProperty("AllowedModels")]
        public string AllowedModels{ get; set; }

        /// <summary>
        /// Whether the API Key is available. Values: enable (enable), disable (disable).
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Reason for disabling the API Key. Valid values: NORMAL (normal, default value), QUOTA_EXHAUSTED (API Key quota package exhausted), ABNORMAL (exception, human intervention required)
        /// </summary>
        [JsonProperty("StopReason")]
        public string StopReason{ get; set; }

        /// <summary>
        /// User-side switch. Valid values: enable, disable.
        /// </summary>
        [JsonProperty("UseStatus")]
        public string UseStatus{ get; set; }

        /// <summary>
        /// Key version.
        /// </summary>
        [JsonProperty("KeyVersion")]
        public long? KeyVersion{ get; set; }

        /// <summary>
        /// Last reset time (ISO 8601).
        /// </summary>
        [JsonProperty("LastRotatedAt")]
        public string LastRotatedAt{ get; set; }

        /// <summary>
        /// Creator. If it is created by a sub-account, this value is the sub-account UIN.
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// TPM limit (Tokens Per Minute).
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }

        /// <summary>
        /// Package type. Values: enterprise (Enterprise Professional package), enterprise-auto (Enterprise Light package)
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiKeyId", this.ApiKeyId);
            this.SetParamSimple(map, prefix + "ApiKey", this.ApiKey);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AllowedModels", this.AllowedModels);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "UseStatus", this.UseStatus);
            this.SetParamSimple(map, prefix + "KeyVersion", this.KeyVersion);
            this.SetParamSimple(map, prefix + "LastRotatedAt", this.LastRotatedAt);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
        }
    }
}

