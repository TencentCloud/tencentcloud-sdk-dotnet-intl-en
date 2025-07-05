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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleCache : AbstractModel
    {
        
        /// <summary>
        /// Content for each `CacheType`:
        /// For `all`, enter a wildcard `*`.
        /// For `file`, enter the suffix, e.g., `jpg` or `txt`.
        /// For `directory`, enter the path, e.g., `/xxx/test/`.
        /// For `path`, enter the absolute path, e.g., `/xxx/test.html`.
        /// For `index`, enter a forward slash `/`.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// Rule types:
        /// `all`: effective for all files.
        /// `file`: effective for specified file suffixes.
        /// `directory`: effective for specified paths.
        /// `path`: effective for specified absolute paths.
        /// `index`: homepage.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Cache configuration
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CacheConfig")]
        public RuleCacheConfig CacheConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamObj(map, prefix + "CacheConfig.", this.CacheConfig);
        }
    }
}

