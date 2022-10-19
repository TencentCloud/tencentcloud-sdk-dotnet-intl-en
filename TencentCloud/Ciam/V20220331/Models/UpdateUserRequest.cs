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

    public class UpdateUserRequest : AbstractModel
    {
        
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// User directory ID
        /// </summary>
        [JsonProperty("UserStoreId")]
        public string UserStoreId{ get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Mobile number
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Nickname
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// User group
        /// </summary>
        [JsonProperty("UserGroup")]
        public string[] UserGroup{ get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonProperty("Birthdate")]
        public long? Birthdate{ get; set; }

        /// <summary>
        /// Custom attribute
        /// </summary>
        [JsonProperty("CustomizationAttributes")]
        public MemberMap[] CustomizationAttributes{ get; set; }

        /// <summary>
        /// Index field 1
        /// </summary>
        [JsonProperty("IndexedAttribute1")]
        public string IndexedAttribute1{ get; set; }

        /// <summary>
        /// Index field 2
        /// </summary>
        [JsonProperty("IndexedAttribute2")]
        public string IndexedAttribute2{ get; set; }

        /// <summary>
        /// Index field 3
        /// </summary>
        [JsonProperty("IndexedAttribute3")]
        public string IndexedAttribute3{ get; set; }

        /// <summary>
        /// Index field 4
        /// </summary>
        [JsonProperty("IndexedAttribute4")]
        public string IndexedAttribute4{ get; set; }

        /// <summary>
        /// Index field 5
        /// </summary>
        [JsonProperty("IndexedAttribute5")]
        public string IndexedAttribute5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserStoreId", this.UserStoreId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamArraySimple(map, prefix + "UserGroup.", this.UserGroup);
            this.SetParamSimple(map, prefix + "Birthdate", this.Birthdate);
            this.SetParamArrayObj(map, prefix + "CustomizationAttributes.", this.CustomizationAttributes);
            this.SetParamSimple(map, prefix + "IndexedAttribute1", this.IndexedAttribute1);
            this.SetParamSimple(map, prefix + "IndexedAttribute2", this.IndexedAttribute2);
            this.SetParamSimple(map, prefix + "IndexedAttribute3", this.IndexedAttribute3);
            this.SetParamSimple(map, prefix + "IndexedAttribute4", this.IndexedAttribute4);
            this.SetParamSimple(map, prefix + "IndexedAttribute5", this.IndexedAttribute5);
        }
    }
}

