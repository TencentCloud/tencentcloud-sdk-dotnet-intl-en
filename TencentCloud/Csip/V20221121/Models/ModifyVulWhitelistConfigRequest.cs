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

    public class ModifyVulWhitelistConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>id list</
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Remarks.</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Asset scope</p><p>Enumeration value:</p><ul><li>0: All assets</li><li>1: Custom assets</li><li>2: Select all remove asset</li></ul>
        /// </summary>
        [JsonProperty("AssetRange")]
        public ulong? AssetRange{ get; set; }

        /// <summary>
        /// <p>Asset list (Quuid list)</p>
        /// </summary>
        [JsonProperty("AssetList")]
        public string[] AssetList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
            this.SetParamArraySimple(map, prefix + "AssetList.", this.AssetList);
        }
    }
}

