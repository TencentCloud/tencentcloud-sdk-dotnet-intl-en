/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganizationServiceAssign : AbstractModel
    {
        
        /// <summary>
        /// Organization service ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceId")]
        public ulong? ServiceId{ get; set; }

        /// <summary>
        /// Organization service product name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Whether to support delegation. Valid values: 1 (yes), 2 (no).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsAssign")]
        public ulong? IsAssign{ get; set; }

        /// <summary>
        /// Organization service description.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Number of the current delegated admins.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemberNum")]
        public string MemberNum{ get; set; }

        /// <summary>
        /// Help documentation.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Document")]
        public string Document{ get; set; }

        /// <summary>
        /// Console path of the organization service product.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsoleUrl")]
        public string ConsoleUrl{ get; set; }

        /// <summary>
        /// Whether to access the usage status. Valid values: 1 (yes), 
        ///  2 (no).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsUsageStatus")]
        public ulong? IsUsageStatus{ get; set; }

        /// <summary>
        /// Limit for the number of delegated admins.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CanAssignCount")]
        public ulong? CanAssignCount{ get; set; }

        /// <summary>
        /// Organization service product identifier.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Whether to support organization service authorization. Valid values: 1 (yes), 2 (no).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceGrant")]
        public ulong? ServiceGrant{ get; set; }

        /// <summary>
        /// Enabling status of organization service authorization. This field is valid when ServiceGrant is 1. Valid values: Enabled, Disabled. 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GrantStatus")]
        public string GrantStatus{ get; set; }

        /// <summary>
        /// Whether to support setting the delegated management scope. Valid values: 1 (yes), 2 (no).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsSetManagementScope")]
        public ulong? IsSetManagementScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "IsAssign", this.IsAssign);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MemberNum", this.MemberNum);
            this.SetParamSimple(map, prefix + "Document", this.Document);
            this.SetParamSimple(map, prefix + "ConsoleUrl", this.ConsoleUrl);
            this.SetParamSimple(map, prefix + "IsUsageStatus", this.IsUsageStatus);
            this.SetParamSimple(map, prefix + "CanAssignCount", this.CanAssignCount);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "ServiceGrant", this.ServiceGrant);
            this.SetParamSimple(map, prefix + "GrantStatus", this.GrantStatus);
            this.SetParamSimple(map, prefix + "IsSetManagementScope", this.IsSetManagementScope);
        }
    }
}

