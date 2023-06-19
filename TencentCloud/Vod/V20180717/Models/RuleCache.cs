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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleCache : AbstractModel
    {
        
        /// <summary>
        /// Rule types:<li>all: effective for all files.</li> <li>file: effective for specified file suffixes.</li> <li>directory: effective for specified paths.</li> <li>path: effective for specified absolute paths.</li>
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Content for each CacheType: <li>For all, enter a wildcard *.</li> <li>For file, enter the suffix, e.g., jpg or txt.</li> <li>For directory, enter the path, e.g., /xxx/test/.</li> <li>For path, enter the absolute path, e.g., /xxx/test.html.</li>
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// Cache configuration
        /// </summary>
        [JsonProperty("CacheConfig")]
        public RuleCacheConfig CacheConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamObj(map, prefix + "CacheConfig.", this.CacheConfig);
        }
    }
}

