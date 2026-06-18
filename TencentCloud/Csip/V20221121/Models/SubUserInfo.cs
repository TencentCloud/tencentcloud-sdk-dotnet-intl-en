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

    public class SubUserInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Primary key ID, with no business significance, only serves as a unique key.</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>Sub-account Appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// <p>Sub-account UIn</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>Sub-account name</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>Root Account Appid</p>
        /// </summary>
        [JsonProperty("OwnerAppID")]
        public string OwnerAppID{ get; set; }

        /// <summary>
        /// <p>Root account Uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>Root account name</p>
        /// </summary>
        [JsonProperty("OwnerNickName")]
        public string OwnerNickName{ get; set; }

        /// <summary>
        /// <p>Member ID information belonging to main account</p>
        /// </summary>
        [JsonProperty("OwnerMemberID")]
        public string OwnerMemberID{ get; set; }

        /// <summary>
        /// <p>Account type. 0 indicates a Tencent Cloud account, and 1 indicates an AWS account.</p>
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// <p>Number of accessible services</p>
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// <p>Number of accessible APIs</p>
        /// </summary>
        [JsonProperty("InterfaceCount")]
        public long? InterfaceCount{ get; set; }

        /// <summary>
        /// <p>Number of accessible resources</p>
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// <p>Number of access/behavior logs</p>
        /// </summary>
        [JsonProperty("LogCount")]
        public long? LogCount{ get; set; }

        /// <summary>
        /// <p>Permission configuration risk</p>
        /// </summary>
        [JsonProperty("ConfigRiskCount")]
        public long? ConfigRiskCount{ get; set; }

        /// <summary>
        /// <p>Dangerous behavior alarm</p>
        /// </summary>
        [JsonProperty("ActionRiskCount")]
        public long? ActionRiskCount{ get; set; }

        /// <summary>
        /// <p>Whether to access operation audit log</p>
        /// </summary>
        [JsonProperty("IsAccessCloudAudit")]
        public bool? IsAccessCloudAudit{ get; set; }

        /// <summary>
        /// <p>Security check for configuration risk required or not</p>
        /// </summary>
        [JsonProperty("IsAccessCheck")]
        public bool? IsAccessCheck{ get; set; }

        /// <summary>
        /// <p>Whether configure user behavior management policy</p>
        /// </summary>
        [JsonProperty("IsAccessUeba")]
        public bool? IsAccessUeba{ get; set; }

        /// <summary>
        /// <p>Creation time (Unix timestamp).</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "OwnerAppID", this.OwnerAppID);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OwnerNickName", this.OwnerNickName);
            this.SetParamSimple(map, prefix + "OwnerMemberID", this.OwnerMemberID);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "InterfaceCount", this.InterfaceCount);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "LogCount", this.LogCount);
            this.SetParamSimple(map, prefix + "ConfigRiskCount", this.ConfigRiskCount);
            this.SetParamSimple(map, prefix + "ActionRiskCount", this.ActionRiskCount);
            this.SetParamSimple(map, prefix + "IsAccessCloudAudit", this.IsAccessCloudAudit);
            this.SetParamSimple(map, prefix + "IsAccessCheck", this.IsAccessCheck);
            this.SetParamSimple(map, prefix + "IsAccessUeba", this.IsAccessUeba);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

