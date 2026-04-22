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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserDetailResp : AbstractModel
    {
        
        /// <summary>
        /// User iD.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// User account
        /// </summary>
        [JsonProperty("UserAccount")]
        public string UserAccount{ get; set; }

        /// <summary>
        /// User account
        /// 1 - super admin 2 - platform admin 3 - ordinary member. not passing indicates all.
        /// </summary>
        [JsonProperty("AccountType")]
        public long? AccountType{ get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserAccount", this.UserAccount);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
        }
    }
}

