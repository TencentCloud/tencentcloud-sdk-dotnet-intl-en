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

    public class TokenPlanListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Package ID.</p>
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// <p>Package type. Values: enterprise (Enterprise Professional package), enterprise-auto (Enterprise Light package)</p>
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// <p>Package name. Maximum 128 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Account APP ID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Main account UIN.</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>Package status. Valid values: enable, disable.</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Reason for package disablement. Value: NORMAL, ISOLATED, FROZEN, EXHAUSTED, DESTROYED</p>
        /// </summary>
        [JsonProperty("StopReason")]
        public string StopReason{ get; set; }

        /// <summary>
        /// <p>Maximum number of API Keys that can be created.</p>
        /// </summary>
        [JsonProperty("ApiKeyMax")]
        public long? ApiKeyMax{ get; set; }

        /// <summary>
        /// <p>Number of API Keys currently created</p>
        /// </summary>
        [JsonProperty("ApiKeyCount")]
        public long? ApiKeyCount{ get; set; }

        /// <summary>
        /// <p>Cloud billing prepaid resource package ID.</p>
        /// </summary>
        [JsonProperty("PrepayResourceID")]
        public string PrepayResourceID{ get; set; }

        /// <summary>
        /// <p>Creator. If the package is created by a sub-account, this value is the sub-account UIN.</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// <p>Basic information of the package.</p>
        /// </summary>
        [JsonProperty("PackageInfo")]
        public TokenPlanPackageInfo PackageInfo{ get; set; }

        /// <summary>
        /// <p>Whether to enable auto-renewal. Value: 0 (not enabled), 1 (enabled)</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "ApiKeyMax", this.ApiKeyMax);
            this.SetParamSimple(map, prefix + "ApiKeyCount", this.ApiKeyCount);
            this.SetParamSimple(map, prefix + "PrepayResourceID", this.PrepayResourceID);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamObj(map, prefix + "PackageInfo.", this.PackageInfo);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
        }
    }
}

