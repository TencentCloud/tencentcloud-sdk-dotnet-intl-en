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

    public class ModifyBaselineUserWeakPasswordConfRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Weak password dictionary plaintext, an empty string is allowed to clear the configuration.</p>
        /// </summary>
        [JsonProperty("UserConf")]
        public string UserConf{ get; set; }

        /// <summary>
        /// List of member account Appids in the group account scenario. Leave this empty for non-group accounts or when querying only the current account.
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserConf", this.UserConf);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

