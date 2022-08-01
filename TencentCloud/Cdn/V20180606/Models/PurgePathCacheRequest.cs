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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PurgePathCacheRequest : AbstractModel
    {
        
        /// <summary>
        /// List of directories. The protocol header such as "http://" or "https://" needs to be included.
        /// </summary>
        [JsonProperty("Paths")]
        public string[] Paths{ get; set; }

        /// <summary>
        /// Purge type:
        /// `flush`: purges updated resources
        /// `delete`: purges all resources
        /// </summary>
        [JsonProperty("FlushType")]
        public string FlushType{ get; set; }

        /// <summary>
        /// Whether to encode Chinese characters before purge.
        /// </summary>
        [JsonProperty("UrlEncode")]
        public bool? UrlEncode{ get; set; }

        /// <summary>
        /// Region to purge
        /// The acceleration region of the acceleration domain name will be purged if this parameter is not passed in.
        /// If `mainland` is passed in, only the content cached on nodes in the Chinese mainland will be purged.
        /// If `overseas` is passed in, only the content cached on nodes outside the Chinese mainland will be purged.
        /// The specified region to purge should match the domain name’s acceleration region.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Paths.", this.Paths);
            this.SetParamSimple(map, prefix + "FlushType", this.FlushType);
            this.SetParamSimple(map, prefix + "UrlEncode", this.UrlEncode);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

