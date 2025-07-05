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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaseTenant : AbstractModel
    {
        
        /// <summary>
        /// Tenant IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// Tenant ID
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TenantName")]
        public string TenantName{ get; set; }

        /// <summary>
        /// Tenant display name, usually the Chinese name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// RemarksNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Tenant Main Account
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OwnerUserId")]
        public string OwnerUserId{ get; set; }

        /// <summary>
        /// Tenant's additional configuration parameters, in JSON format string
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "TenantName", this.TenantName);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OwnerUserId", this.OwnerUserId);
            this.SetParamSimple(map, prefix + "Params", this.Params);
        }
    }
}

