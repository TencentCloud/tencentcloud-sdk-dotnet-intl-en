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
        /// Primary key ID, which has no business meaning and serves solely as a unique identifier
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// sub-account Appid
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// sub-account UIn
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Sub-account name
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// master account Appid
        /// </summary>
        [JsonProperty("OwnerAppID")]
        public string OwnerAppID{ get; set; }

        /// <summary>
        /// master account Uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// master account name
        /// </summary>
        [JsonProperty("OwnerNickName")]
        public string OwnerNickName{ get; set; }

        /// <summary>
        /// master account's memberId information
        /// </summary>
        [JsonProperty("OwnerMemberID")]
        public string OwnerMemberID{ get; set; }

        /// <summary>
        /// Account type: 0 for Tencent Cloud account, 1 for AWS account
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// Accessible services count
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// Accessible API count
        /// </summary>
        [JsonProperty("InterfaceCount")]
        public long? InterfaceCount{ get; set; }

        /// <summary>
        /// Accessible resources count
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// Access/Behavior Logs Count
        /// </summary>
        [JsonProperty("LogCount")]
        public long? LogCount{ get; set; }

        /// <summary>
        /// Permissions configuration risk
        /// </summary>
        [JsonProperty("ConfigRiskCount")]
        public long? ConfigRiskCount{ get; set; }

        /// <summary>
        /// Dangerous behavior alarm
        /// </summary>
        [JsonProperty("ActionRiskCount")]
        public long? ActionRiskCount{ get; set; }

        /// <summary>
        /// whether to enable CloudAudit logs
        /// </summary>
        [JsonProperty("IsAccessCloudAudit")]
        public bool? IsAccessCloudAudit{ get; set; }

        /// <summary>
        /// whether risk configuration security assessment
        /// </summary>
        [JsonProperty("IsAccessCheck")]
        public bool? IsAccessCheck{ get; set; }

        /// <summary>
        /// whether to configure user behavior management policies
        /// </summary>
        [JsonProperty("IsAccessUeba")]
        public bool? IsAccessUeba{ get; set; }


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
        }
    }
}

