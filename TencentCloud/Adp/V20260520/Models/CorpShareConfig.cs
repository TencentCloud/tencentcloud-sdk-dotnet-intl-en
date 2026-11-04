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

    public class CorpShareConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Business shared switch</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>Share scope type. 1: all business staff, 2: designated account, 3: designated space</p>
        /// </summary>
        [JsonProperty("ShareScope")]
        public long? ShareScope{ get; set; }

        /// <summary>
        /// <p>Business shared application tag</p>
        /// </summary>
        [JsonProperty("TagIdList")]
        public string[] TagIdList{ get; set; }

        /// <summary>
        /// <p>Shared range information (for users, StrId is uin and Name is username; for spaces, StrId is space ID and Name is space Name)</p>
        /// </summary>
        [JsonProperty("ShareScopeList")]
        public Identity[] ShareScopeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "ShareScope", this.ShareScope);
            this.SetParamArraySimple(map, prefix + "TagIdList.", this.TagIdList);
            this.SetParamArrayObj(map, prefix + "ShareScopeList.", this.ShareScopeList);
        }
    }
}

