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

    public class CacheKey : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable full-path cache
        /// on: enable full-path cache (i.e., disable parameter filter)
        /// off: disable full-path cache (i.e., enable parameter filter)
        /// </summary>
        [JsonProperty("FullUrlCache")]
        public string FullUrlCache{ get; set; }

        /// <summary>
        /// Whether the cache ignores letter case
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public string CaseSensitive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullUrlCache", this.FullUrlCache);
            this.SetParamSimple(map, prefix + "CaseSensitive", this.CaseSensitive);
        }
    }
}

