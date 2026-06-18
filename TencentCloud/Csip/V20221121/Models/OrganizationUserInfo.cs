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

    public class OrganizationUserInfo : AbstractModel
    {
        
        /// <summary>
        /// Member Account UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// member account name
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Department Node Name, Account's Department
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Number of assets
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// Number of risks
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// Number of Attacks
        /// </summary>
        [JsonProperty("AttackCount")]
        public long? AttackCount{ get; set; }

        /// <summary>
        /// Member/Admin/; Member or Administrator
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// Member Account ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// Member Account AppID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// Account Joining Method: Create/Invite.
        /// </summary>
        [JsonProperty("JoinType")]
        public string JoinType{ get; set; }

        /// <summary>
        /// Not enabled if empty. Otherwise, different strings correspond to different versions. Common for General, regardless of version.
        /// </summary>
        [JsonProperty("CFWProtect")]
        public string CFWProtect{ get; set; }

        /// <summary>
        /// Not enabled if empty. Otherwise, different strings correspond to different versions. Common for General, regardless of version.
        /// </summary>
        [JsonProperty("WAFProtect")]
        public string WAFProtect{ get; set; }

        /// <summary>
        /// Not enabled if empty. Otherwise, different strings correspond to different versions. Common for General, regardless of version.
        /// </summary>
        [JsonProperty("CWPProtect")]
        public string CWPProtect{ get; set; }

        /// <summary>
        /// 1-Enabled; 0-Not Enabled.
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// Free       // Free Edition  Advanced   //Advanced Edition Enterprise //Enterprise Edition Ultimate   //Premium Edition
        /// </summary>
        [JsonProperty("CSIPProtect")]
        public string CSIPProtect{ get; set; }

        /// <summary>
        /// 1 for quota consumer.
        /// </summary>
        [JsonProperty("QuotaConsumer")]
        public long? QuotaConsumer{ get; set; }

        /// <summary>
        /// Account Type. 0 for Tencent Cloud account; 1 for AWS account.
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// 0 for default value, 1 for 10 minutes, 2 for 1 hour, 3 for 24 hours.
        /// </summary>
        [JsonProperty("SyncFrequency")]
        public long? SyncFrequency{ get; set; }

        /// <summary>
        /// Whether the multi-cloud account is expired.
        /// </summary>
        [JsonProperty("IsExpired")]
        public bool? IsExpired{ get; set; }

        /// <summary>
        /// Multi-Cloud Account Permission List
        /// </summary>
        [JsonProperty("PermissionList")]
        public string[] PermissionList{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }

        /// <summary>
        /// Tencent Cloud Group Account
        /// Tencent Cloud access account
        /// 2: non-Tencent Cloud
        /// </summary>
        [JsonProperty("TcMemberType")]
        public long? TcMemberType{ get; set; }

        /// <summary>
        /// Number of sub-accounts.
        /// </summary>
        [JsonProperty("SubUserCount")]
        public long? SubUserCount{ get; set; }

        /// <summary>
        /// Joining method details
        /// </summary>
        [JsonProperty("JoinTypeInfo")]
        public string JoinTypeInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "AttackCount", this.AttackCount);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "JoinType", this.JoinType);
            this.SetParamSimple(map, prefix + "CFWProtect", this.CFWProtect);
            this.SetParamSimple(map, prefix + "WAFProtect", this.WAFProtect);
            this.SetParamSimple(map, prefix + "CWPProtect", this.CWPProtect);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "CSIPProtect", this.CSIPProtect);
            this.SetParamSimple(map, prefix + "QuotaConsumer", this.QuotaConsumer);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "SyncFrequency", this.SyncFrequency);
            this.SetParamSimple(map, prefix + "IsExpired", this.IsExpired);
            this.SetParamArraySimple(map, prefix + "PermissionList.", this.PermissionList);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "TcMemberType", this.TcMemberType);
            this.SetParamSimple(map, prefix + "SubUserCount", this.SubUserCount);
            this.SetParamSimple(map, prefix + "JoinTypeInfo", this.JoinTypeInfo);
        }
    }
}

