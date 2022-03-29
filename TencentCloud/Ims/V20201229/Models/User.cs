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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class User : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the business user ID. After it is specified, the system can optimize the moderation result according to the violation history to facilitate determination when a suspicious violation risk exists.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// This field indicates the nickname of the business user's account.
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// This field indicates the account type of the business user ID.<br>
        /// This field can be used together with the ID parameter (UserId) to uniquely identify the account.
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// This field indicates the gender of the business user's account.<br>
        /// Valid values: **0** (default value): unknown; **1** (male); **2** (female).
        /// </summary>
        [JsonProperty("Gender")]
        public ulong? Gender{ get; set; }

        /// <summary>
        /// This field indicates the age of the business user's account.<br>
        /// Valid values: integers between **0** (default value, which indicates unknown) and **custom age limit**.
        /// </summary>
        [JsonProperty("Age")]
        public ulong? Age{ get; set; }

        /// <summary>
        /// This field indicates the level of the business user's account.<br>
        /// Valid values: **0** (default value): unknown; **1**: low level; **2**: medium level; **3**: high level. Currently, **the level is not customizable**.
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// This field indicates the mobile number of the business user's account. It supports recording mobile numbers across the world.<br>
        /// Note: you need to use a consistent mobile number format, such as area code format (086/+86).
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// This field indicates the profile of the business user. It can contain **up to 5,000 letters and special symbols**.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// This field indicates the access URL of the business user's profile photo in PNG, JPG, JPEG, BMP, GIF, or WEBP format.<br>Note: the profile photo **cannot exceed 5 MB in size**. **A resolution of 256x256 or higher** is recommended. The image download time should be limited to 3 seconds; otherwise, a download timeout will be returned.
        /// </summary>
        [JsonProperty("HeadUrl")]
        public string HeadUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "HeadUrl", this.HeadUrl);
        }
    }
}

