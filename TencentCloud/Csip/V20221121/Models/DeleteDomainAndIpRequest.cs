/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// u200c-
        /// </summary>
        [JsonProperty("Content")]
        public PublicIpDomainListKey[] Content{ get; set; }

        /// <summary>
        /// Whether to retain the path configuration. `1`: Retain; Others: Do not retain. It defaults to do not retain if not specified.
        /// </summary>
        [JsonProperty("RetainPath")]
        public long? RetainPath{ get; set; }

        /// <summary>
        /// Whether to ignore this asset in the future. `1`: Ignore; Others: Do not ignore. It defaults to ignore if not specified.
        /// </summary>
        [JsonProperty("IgnoreAsset")]
        public long? IgnoreAsset{ get; set; }

        /// <summary>
        /// Asset tags
        /// </summary>
        [JsonProperty("Tags")]
        public AssetTag[] Tags{ get; set; }

        /// <summary>
        /// Deletion mode. Values: `ALL` (delete all). If it's not specified, `Content` is required.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "RetainPath", this.RetainPath);
            this.SetParamSimple(map, prefix + "IgnoreAsset", this.IgnoreAsset);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

