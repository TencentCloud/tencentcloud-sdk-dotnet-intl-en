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

    public class SimpleCacheRule : AbstractModel
    {
        
        /// <summary>
        /// Rule types:
        /// `all`: Apply to all files.
        /// `file`: Apply to files with the specified suffixes.
        /// `directory`: Apply to specified paths.
        /// `path`: Apply to specified absolute paths.
        /// index: home page
        /// </summary>
        [JsonProperty("CacheType")]
        public string CacheType{ get; set; }

        /// <summary>
        /// Content for each `CacheType`:
        /// For `all`, enter a wildcard `*`.
        /// For `file`, enter a suffix, e.g., `jpg` or `txt`.
        /// For `directory`, enter a path, e.g., `/xxx/test/`.
        /// For `path`, enter an absolute path, e.g., `/xxx/test.html`.
        /// For `index`, enter a forward slash `/`.
        /// </summary>
        [JsonProperty("CacheContents")]
        public string[] CacheContents{ get; set; }

        /// <summary>
        /// Cache expiration time settings
        /// Unit: second. The maximum value is 365 days.
        /// </summary>
        [JsonProperty("CacheTime")]
        public long? CacheTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CacheType", this.CacheType);
            this.SetParamArraySimple(map, prefix + "CacheContents.", this.CacheContents);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
        }
    }
}

