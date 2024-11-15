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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class User : AbstractModel
    {
        
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Username
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Mobile number
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// Email address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Last login time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastSignOn")]
        public long? LastSignOn{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreatedDate")]
        public long? CreatedDate{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// User source
        /// </summary>
        [JsonProperty("UserDataSourceEnum")]
        public string UserDataSourceEnum{ get; set; }

        /// <summary>
        /// Nickname
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// Address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// Date of birth
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Birthdate")]
        public long? Birthdate{ get; set; }

        /// <summary>
        /// User group ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserGroups")]
        public string[] UserGroups{ get; set; }

        /// <summary>
        /// Last modified time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastModifiedDate")]
        public long? LastModifiedDate{ get; set; }

        /// <summary>
        /// Custom attribute
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomAttributes")]
        public MemberMap[] CustomAttributes{ get; set; }

        /// <summary>
        /// ID card number
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResidentIdentityCard")]
        public string ResidentIdentityCard{ get; set; }

        /// <summary>
        /// `OpenId` on QQ
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QqOpenId")]
        public string QqOpenId{ get; set; }

        /// <summary>
        /// `UnionId` on QQ
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QqUnionId")]
        public string QqUnionId{ get; set; }

        /// <summary>
        /// `WechatOpenId` on WeChat
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatOpenId")]
        public string WechatOpenId{ get; set; }

        /// <summary>
        /// `WechatUnionId` on WeChat
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WechatUnionId")]
        public string WechatUnionId{ get; set; }

        /// <summary>
        /// `AlipayUserId` on Alipay
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlipayUserId")]
        public string AlipayUserId{ get; set; }

        /// <summary>
        /// WeCom user ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WeComUserId")]
        public string WeComUserId{ get; set; }

        /// <summary>
        /// Description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Coordinate
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Locale")]
        public string Locale{ get; set; }

        /// <summary>
        /// Gender
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// Identity verification method
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdentityVerificationMethod")]
        public string IdentityVerificationMethod{ get; set; }

        /// <summary>
        /// Whether the identity is verified
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdentityVerified")]
        public bool? IdentityVerified{ get; set; }

        /// <summary>
        /// Job
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Job")]
        public string Job{ get; set; }

        /// <summary>
        /// Country/Region
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Whether the account is the primary account (after account merge, this parameter is `true` for primary accounts and `false` for secondary account).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }

        /// <summary>
        /// Time zone
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Whether the account has ever logged in.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AlreadyFirstLogin")]
        public bool? AlreadyFirstLogin{ get; set; }

        /// <summary>
        /// Tenant ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// User directory ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserStoreId")]
        public string UserStoreId{ get; set; }

        /// <summary>
        /// Version
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Version")]
        public long? Version{ get; set; }

        /// <summary>
        /// Lock type (locked by admin or locked by login policy)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LockType")]
        public string LockType{ get; set; }

        /// <summary>
        /// Lock time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LockTime")]
        public long? LockTime{ get; set; }

        /// <summary>
        /// Index field 1
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IndexedAttribute1")]
        public string IndexedAttribute1{ get; set; }

        /// <summary>
        /// Index field 2
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IndexedAttribute2")]
        public string IndexedAttribute2{ get; set; }

        /// <summary>
        /// Index field 3
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IndexedAttribute3")]
        public string IndexedAttribute3{ get; set; }

        /// <summary>
        /// Index field 4
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IndexedAttribute4")]
        public string IndexedAttribute4{ get; set; }

        /// <summary>
        /// Index field 5
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IndexedAttribute5")]
        public string IndexedAttribute5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "LastSignOn", this.LastSignOn);
            this.SetParamSimple(map, prefix + "CreatedDate", this.CreatedDate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UserDataSourceEnum", this.UserDataSourceEnum);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Birthdate", this.Birthdate);
            this.SetParamArraySimple(map, prefix + "UserGroups.", this.UserGroups);
            this.SetParamSimple(map, prefix + "LastModifiedDate", this.LastModifiedDate);
            this.SetParamArrayObj(map, prefix + "CustomAttributes.", this.CustomAttributes);
            this.SetParamSimple(map, prefix + "ResidentIdentityCard", this.ResidentIdentityCard);
            this.SetParamSimple(map, prefix + "QqOpenId", this.QqOpenId);
            this.SetParamSimple(map, prefix + "QqUnionId", this.QqUnionId);
            this.SetParamSimple(map, prefix + "WechatOpenId", this.WechatOpenId);
            this.SetParamSimple(map, prefix + "WechatUnionId", this.WechatUnionId);
            this.SetParamSimple(map, prefix + "AlipayUserId", this.AlipayUserId);
            this.SetParamSimple(map, prefix + "WeComUserId", this.WeComUserId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Locale", this.Locale);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "IdentityVerificationMethod", this.IdentityVerificationMethod);
            this.SetParamSimple(map, prefix + "IdentityVerified", this.IdentityVerified);
            this.SetParamSimple(map, prefix + "Job", this.Job);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "Primary", this.Primary);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "AlreadyFirstLogin", this.AlreadyFirstLogin);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "UserStoreId", this.UserStoreId);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LockType", this.LockType);
            this.SetParamSimple(map, prefix + "LockTime", this.LockTime);
            this.SetParamSimple(map, prefix + "IndexedAttribute1", this.IndexedAttribute1);
            this.SetParamSimple(map, prefix + "IndexedAttribute2", this.IndexedAttribute2);
            this.SetParamSimple(map, prefix + "IndexedAttribute3", this.IndexedAttribute3);
            this.SetParamSimple(map, prefix + "IndexedAttribute4", this.IndexedAttribute4);
            this.SetParamSimple(map, prefix + "IndexedAttribute5", this.IndexedAttribute5);
        }
    }
}

