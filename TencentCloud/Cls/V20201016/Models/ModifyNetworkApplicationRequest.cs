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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetworkApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Web application id</p>
        /// </summary>
        [JsonProperty("NetworkAppId")]
        public string NetworkAppId{ get; set; }

        /// <summary>
        /// <p>Network application name: Length not exceeding 64 characters, name must be unique.</p><ul><li>Can only contain the following characters:<ul><li>Letters (a-z and A-Z)</li><li>Numbers</li><li>Underscore</li><li>Hyphen (minus sign)</li><li>Chinese characters</li></ul></li><li>At least one character</li><li>Cannot contain spaces</li><li>Cannot contain other special characters (such as @, #, $, % etc.)</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkAppId", this.NetworkAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

