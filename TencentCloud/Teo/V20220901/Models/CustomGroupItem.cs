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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomGroupItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Entry content.</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>Entry type.</p><p>Valid values:</p><ul><li>JA3: JA3 fingerprint, available only when the GroupType of the group is TLSFingerprint</li><li>JA4: JA4 fingerprint, available only when the GroupType of the group is TLSFingerprint</li><li>UA: UA value, available only when the GroupType of the group is UA</li><li>Referer: Referer value, available only when the GroupType of the group is Referer</li></ul>
        /// </summary>
        [JsonProperty("ItemType")]
        public string ItemType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ItemType", this.ItemType);
        }
    }
}

