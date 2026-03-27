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
        /// Member account Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Member account name
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Department node name, department of account
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Asset Quantity
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// Risk Quantity
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// Attack Quantity
        /// </summary>
        [JsonProperty("AttackCount")]
        public long? AttackCount{ get; set; }

        /// <summary>
        /// Member/Admin/;Member or Administrator
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// Member account id
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// Member account Appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// account joining method,create/invite
        /// </summary>
        [JsonProperty("JoinType")]
        public string JoinType{ get; set; }

        /// <summary>
        /// If empty, it is not enabled; otherwise, different strings correspond to different versions, with 'common' being general and not version-specific.
        /// </summary>
        [JsonProperty("CFWProtect")]
        public string CFWProtect{ get; set; }

        /// <summary>
        /// If empty, it is not enabled; otherwise, different strings correspond to different versions, with 'common' being general and not version-specific.
        /// </summary>
        [JsonProperty("WAFProtect")]
        public string WAFProtect{ get; set; }

        /// <summary>
        /// If empty, it is not enabled; otherwise, different strings correspond to different versions, with 'common' being general and not version-specific.
        /// </summary>
        [JsonProperty("CWPProtect")]
        public string CWPProtect{ get; set; }

        /// <summary>
        /// 1 enable, 0 not enabled
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// "Free"      
        ///    //Free edition
        ///    "Advanced"   //Advanced edition "Enterprise" //Enterprise edition "Ultimate"  
        ///    //Ultimate edition
        /// </summary>
        [JsonProperty("CSIPProtect")]
        public string CSIPProtect{ get; set; }

        /// <summary>
        /// 1 indicates the quota consumer
        /// </summary>
        [JsonProperty("QuotaConsumer")]
        public long? QuotaConsumer{ get; set; }

        /// <summary>
        /// Account type: 0 for Tencent Cloud account, 1 for AWS account
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// 0 indicates the default value; 1 indicates 10 minutes; 2 indicates 1 hour; 3 indicates 24 hours
        /// </summary>
        [JsonProperty("SyncFrequency")]
        public long? SyncFrequency{ get; set; }

        /// <summary>
        /// Whether the multi-cloud account has expired
        /// </summary>
        [JsonProperty("IsExpired")]
        public bool? IsExpired{ get; set; }

        /// <summary>
        /// Multi-cloud account permissions list
        /// </summary>
        [JsonProperty("PermissionList")]
        public string[] PermissionList{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }

        /// <summary>
        /// 0 Tencent Cloud group account
        /// 1 Tencent Cloud access account
        /// 2 non-Tencent Cloud
        /// </summary>
        [JsonProperty("TcMemberType")]
        public long? TcMemberType{ get; set; }

        /// <summary>
        /// Sub-account count
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

