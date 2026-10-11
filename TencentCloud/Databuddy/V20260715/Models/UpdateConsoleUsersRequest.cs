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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateConsoleUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>User UIN list, up to 100 at a time</p>
        /// </summary>
        [JsonProperty("UserUins")]
        public string[] UserUins{ get; set; }

        /// <summary>
        /// <p>Role ID list</p><p>Enumeration values:</p><ul><li>2001: Console administrator</li><li>2002: Console member</li></ul><p>Can be obtained through the ListConsoleRoles API</p>
        /// </summary>
        [JsonProperty("RoleIds")]
        public string[] RoleIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "UserUins.", this.UserUins);
            this.SetParamArraySimple(map, prefix + "RoleIds.", this.RoleIds);
        }
    }
}

