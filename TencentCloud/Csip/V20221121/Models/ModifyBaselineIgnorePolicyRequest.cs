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

    public class ModifyBaselineIgnorePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Detection item ID, identifying which detection item to set an ignore policy for.</p>
        /// </summary>
        [JsonProperty("ItemID")]
        public ulong? ItemID{ get; set; }

        /// <summary>
        /// <p>Ignorable range type.</p><p>Enumeration values:</p><ul><li>ALL: all assets</li><li>PICK: specified asset</li></ul>
        /// </summary>
        [JsonProperty("ScopeType")]
        public string ScopeType{ get; set; }

        /// <summary>
        /// <p>Remark information.</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Ignore policy record ID. Pass 0 when creating, and pass the corresponding record ID when updating.</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>Custom asset ID list. This parameter is valid only when PICK is selected. Import instance-id or cluster ID.</p>
        /// </summary>
        [JsonProperty("ScopeIncludeList")]
        public string[] ScopeIncludeList{ get; set; }

        /// <summary>
        /// <p>Remove asset ID list. This parameter is valid only when set to ALL. Input instance-id or cluster ID.</p>
        /// </summary>
        [JsonProperty("ScopeExcludeList")]
        public string[] ScopeExcludeList{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemID", this.ItemID);
            this.SetParamSimple(map, prefix + "ScopeType", this.ScopeType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamArraySimple(map, prefix + "ScopeIncludeList.", this.ScopeIncludeList);
            this.SetParamArraySimple(map, prefix + "ScopeExcludeList.", this.ScopeExcludeList);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

