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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// User ID.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Role ID list.
        /// </summary>
        [JsonProperty("RoleIdList")]
        public long?[] RoleIdList{ get; set; }

        /// <summary>
        /// Mailbox.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Mobile number.
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// Telephone country code.
        /// </summary>
        [JsonProperty("AreaCode")]
        public string AreaCode{ get; set; }

        /// <summary>
        /// WeCom user ID.
        /// </summary>
        [JsonProperty("AppUserId")]
        public string AppUserId{ get; set; }

        /// <summary>
        /// Whether to enable mobile phone verification code login (0: disabled, 1: enabled).
        /// </summary>
        [JsonProperty("LoginSecurityStatus")]
        public long? LoginSecurityStatus{ get; set; }

        /// <summary>
        /// Whether to enable password expiration reminder (0: disabled, 1: enabled).
        /// </summary>
        [JsonProperty("ResetPassWordTip")]
        public long? ResetPassWordTip{ get; set; }

        /// <summary>
        /// Force password reset (0: disabled, 1: enabled).
        /// </summary>
        [JsonProperty("ForceResetPassWord")]
        public long? ForceResetPassWord{ get; set; }

        /// <summary>
        /// Password expiration reminder period: 30, 60, 90 (default), or 180 days.
        /// </summary>
        [JsonProperty("PasswordExpired")]
        public long? PasswordExpired{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArraySimple(map, prefix + "RoleIdList.", this.RoleIdList);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "AreaCode", this.AreaCode);
            this.SetParamSimple(map, prefix + "AppUserId", this.AppUserId);
            this.SetParamSimple(map, prefix + "LoginSecurityStatus", this.LoginSecurityStatus);
            this.SetParamSimple(map, prefix + "ResetPassWordTip", this.ResetPassWordTip);
            this.SetParamSimple(map, prefix + "ForceResetPassWord", this.ForceResetPassWord);
            this.SetParamSimple(map, prefix + "PasswordExpired", this.PasswordExpired);
        }
    }
}

