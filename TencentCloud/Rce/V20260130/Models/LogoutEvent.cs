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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogoutEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>The detail information of the user</p>
        /// </summary>
        [JsonProperty("UserInfo")]
        public User UserInfo{ get; set; }

        /// <summary>
        /// <p>The user name entered when the user logged in</p>
        /// </summary>
        [JsonProperty("UserLoginName")]
        public string UserLoginName{ get; set; }

        /// <summary>
        /// <p>The custom parameters agreed with RCE. An array of objects in K:V format. e.g.[{"Key": "ApproverName", "Value": "bob"},{"Key":"ApproverPhone","Value": "+86131****5678"}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "UserLoginName", this.UserLoginName);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

