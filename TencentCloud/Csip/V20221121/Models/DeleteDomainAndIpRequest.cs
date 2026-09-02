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

    public class DeleteDomainAndIpRequest : AbstractModel
    {
        
        /// <summary>
        /// Group Account Member ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// Asset
        /// </summary>
        [JsonProperty("Content")]
        public PublicIpDomainListKey[] Content{ get; set; }

        /// <summary>
        /// Whether to retain path configuration. 1: Yes; Other: No. No if not specified by default.
        /// </summary>
        [JsonProperty("RetainPath")]
        public long? RetainPath{ get; set; }

        /// <summary>
        /// Whether to ignore this asset in the future. 1: Yes; Other: No. No if not specified by default.
        /// </summary>
        [JsonProperty("IgnoreAsset")]
        public long? IgnoreAsset{ get; set; }

        /// <summary>
        /// Asset tag
        /// </summary>
        [JsonProperty("Tags")]
        public AssetTag[] Tags{ get; set; }

        /// <summary>
        /// Delete type. ALL: deleting all, which will directly ignore the content of Content; Other value: not all, and Content is required. Other value by default.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "RetainPath", this.RetainPath);
            this.SetParamSimple(map, prefix + "IgnoreAsset", this.IgnoreAsset);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

