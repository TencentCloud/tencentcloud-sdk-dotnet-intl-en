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

    public class KeyRule : AbstractModel
    {
        
        /// <summary>
        /// Content for each CacheType:
        /// For `file`, enter a suffix, e.g., `jpg` or `txt`.
        /// For `directory`, enter the path, such as /xxx/test/.
        /// For `path`, enter an absolute path, e.g., `/xxx/test.html`.
        /// For `index`, enter a backslash (/).
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// Rule types:
        /// `file`: Apply to files with the specified suffixes.
        /// `directory`: Apply to specified paths.
        /// `path`: Apply to specified absolute paths.
        /// `index`: home page
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Whether to enable full-path cache
        /// `on`: Enable full-path cache (i.e., disable Ignore Query String).
        /// `off`: Disable full-path cache (i.e., enable Ignore Query String).
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FullUrlCache")]
        public string FullUrlCache{ get; set; }

        /// <summary>
        /// Whether caches are case insensitive
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public string IgnoreCase{ get; set; }

        /// <summary>
        /// Request parameter contained in `CacheKey`
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QueryString")]
        public RuleQueryString QueryString{ get; set; }

        /// <summary>
        /// Path cache key tag, the value "user" is passed.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleTag")]
        public string RuleTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "FullUrlCache", this.FullUrlCache);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
            this.SetParamSimple(map, prefix + "RuleTag", this.RuleTag);
        }
    }
}

