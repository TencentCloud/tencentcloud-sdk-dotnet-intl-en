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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginUserState : AbstractModel
    {
        
        /// <summary>
        /// Whether the plug-in has been bookmarked
        /// </summary>
        [JsonProperty("IsFavorite")]
        public bool? IsFavorite{ get; set; }

        /// <summary>
        /// Whether it is in the plug-in allowlist
        /// </summary>
        [JsonProperty("IsInWhiteList")]
        public bool? IsInWhiteList{ get; set; }

        /// <summary>
        /// <p>Allowlist type, used to represent whether the current user can use this plug-in directly.</p><p>Enumeration values:</p><ul><li>0: Not on the allowlist, fully available</li><li>1: Current user in allowlist</li><li>2: Current user not in allowlist, submit an application</li></ul>
        /// </summary>
        [JsonProperty("WhiteListType")]
        public long? WhiteListType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsFavorite", this.IsFavorite);
            this.SetParamSimple(map, prefix + "IsInWhiteList", this.IsInWhiteList);
            this.SetParamSimple(map, prefix + "WhiteListType", this.WhiteListType);
        }
    }
}

