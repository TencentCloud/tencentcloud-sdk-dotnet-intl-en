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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PackInfo : AbstractModel
    {
        
        /// <summary>
        /// Package type. Valid values:
        /// `staticpack`: non-BGP package
        /// `insurance`: guarantee package
        /// ]
        /// </summary>
        [JsonProperty("PackType")]
        public string PackType{ get; set; }

        /// <summary>
        /// Package ID
        /// </summary>
        [JsonProperty("PackId")]
        public string PackId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackType", this.PackType);
            this.SetParamSimple(map, prefix + "PackId", this.PackId);
        }
    }
}

