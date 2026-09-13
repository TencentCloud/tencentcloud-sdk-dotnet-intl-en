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

    public class User : AbstractModel
    {
        
        /// <summary>
        /// <p>The level of the user in your system</p>
        /// </summary>
        [JsonProperty("UserLevel")]
        public string UserLevel{ get; set; }

        /// <summary>
        /// <p>The point of the user in your system</p>
        /// </summary>
        [JsonProperty("UserPoint")]
        public CreditPoint UserPoint{ get; set; }

        /// <summary>
        /// <p>The type of the user in your system</p>
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserLevel", this.UserLevel);
            this.SetParamObj(map, prefix + "UserPoint.", this.UserPoint);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
        }
    }
}

