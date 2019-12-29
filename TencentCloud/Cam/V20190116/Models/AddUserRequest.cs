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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddUserRequest : AbstractModel
    {
        
        /// <summary>
        /// Sub-user username
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Sub-user remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Whether or not the sub-user is allowed to log in to the console. 0: No; 1: Yes.
        /// </summary>
        [JsonProperty("ConsoleLogin")]
        public ulong? ConsoleLogin{ get; set; }

        /// <summary>
        /// Whether or not to generate keys for sub-users. 0: No; 1: Yes.
        /// </summary>
        [JsonProperty("UseApi")]
        public ulong? UseApi{ get; set; }

        /// <summary>
        /// Sub-user’s console login password. If no password rules have been set, the default rules require the password to have at least 8 characters, at least one lowercase letter, one uppercase letter, one number, and one special character. This value is valid only when the sub-user is allowed to log in to the console. If no value is specified, and console login is allowed, the system will automatically generate a password. The automatically generated passwords are 32 characters long and contain letters (both upper and lower cases), numbers, and special characters. 
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// If the sub-user needs to reset their password when they next log in to the console. 0: No; 1: Yes.
        /// </summary>
        [JsonProperty("NeedResetPassword")]
        public ulong? NeedResetPassword{ get; set; }

        /// <summary>
        /// Mobile number
        /// </summary>
        [JsonProperty("PhoneNum")]
        public string PhoneNum{ get; set; }

        /// <summary>
        /// Country/Area Code
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode{ get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ConsoleLogin", this.ConsoleLogin);
            this.SetParamSimple(map, prefix + "UseApi", this.UseApi);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "NeedResetPassword", this.NeedResetPassword);
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "Email", this.Email);
        }
    }
}

