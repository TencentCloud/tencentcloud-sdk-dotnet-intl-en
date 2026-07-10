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

    public class ApiKeyDetail : AbstractModel
    {
        
        /// <summary>
        /// API Key ID.
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// API key value. The API response contains the masking value.
        /// </summary>
        [JsonProperty("ApiKey")]
        public string ApiKey{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Platform type. Currently supported values: maas.
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// Root account.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Sub-account.
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// Status. Valid values: enable, disable.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Binding type. Value: all (all models and services), model_all_endpoint_custom (all models + custom service), model_custom_endpoint_all (custom model + all services), model_custom_endpoint_custom (custom model + custom service).
        /// </summary>
        [JsonProperty("BindType")]
        public string BindType{ get; set; }

        /// <summary>
        /// Creation time. Format: YYYY-MM-DD HH:mm:ss.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last update time. Format: YYYY-MM-DD HH:mm:ss.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// App ID.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// Whether it is editable. true means editable, false means non-editable.
        /// </summary>
        [JsonProperty("Editable")]
        public bool? Editable{ get; set; }

        /// <summary>
        /// List of bound resources, case-sensitive for endpoint and model kind.
        /// </summary>
        [JsonProperty("BindingItems")]
        public BindingItem[] BindingItems{ get; set; }

        /// <summary>
        /// IP allowlist. Supports IPv4 and CIDR format. Empty array indicates no restriction.
        /// </summary>
        [JsonProperty("IpWhitelist")]
        public string[] IpWhitelist{ get; set; }

        /// <summary>
        /// This field is empty when Platform is maas.
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// Multi-dimensional list of Token quota information. This field is not returned when unconfigured.
        /// </summary>
        [JsonProperty("QuotaSet")]
        public QuotaInfo[] QuotaSet{ get; set; }

        /// <summary>
        /// Token quota status. An empty string means no configuration. active means configured with current availability. inactive means configured but quota exhausted.
        /// </summary>
        [JsonProperty("QuotaStatus")]
        public string QuotaStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiKeyId", this.ApiKeyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ApiKey", this.ApiKey);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Editable", this.Editable);
            this.SetParamArrayObj(map, prefix + "BindingItems.", this.BindingItems);
            this.SetParamArraySimple(map, prefix + "IpWhitelist.", this.IpWhitelist);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamArrayObj(map, prefix + "QuotaSet.", this.QuotaSet);
            this.SetParamSimple(map, prefix + "QuotaStatus", this.QuotaStatus);
        }
    }
}

