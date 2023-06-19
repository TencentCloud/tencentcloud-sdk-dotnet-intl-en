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

    public class HttpHeaderPathRule : AbstractModel
    {
        
        /// <summary>
        /// HTTP header setting methods: <li>set: sets a value for an existing header parameter, a new header parameter, or multiple header parameters. Multiple header parameters will be merged into one.</li> <li>del: deletes a header parameter.</li> <li>add: adds a header parameter. By default, you can repeat the same action to add the same header parameter, which may affect browser response. Please consider the set operation first.</li>
        /// </summary>
        [JsonProperty("HeaderMode")]
        public string HeaderMode{ get; set; }

        /// <summary>
        /// HTTP header name. Up to 100 characters can be set.
        /// </summary>
        [JsonProperty("HeaderName")]
        public string HeaderName{ get; set; }

        /// <summary>
        /// HTTP header value. Up to 1000 characters can be set.<li>Not required when Mode is del.</li> <li>Required when Mode is add/set.</li>
        /// </summary>
        [JsonProperty("HeaderValue")]
        public string HeaderValue{ get; set; }

        /// <summary>
        /// Rule types:<li>all: Apply to all files.</li> <li>file: Apply to files with the specified suffixes.</li> <li>directory: Apply to specified paths.</li> <li>path: Apply to specified absolute paths.</li>
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Content for each RuleType:<li>For all, enter a wildcard *.</li> <li>For file, enter a suffix, e.g., jpg or txt.</li> <li>For directory, enter a path, e.g., /xxx/test/.</li> <li>For path, enter an absolute path, e.g., /xxx/test.html.</li>
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HeaderMode", this.HeaderMode);
            this.SetParamSimple(map, prefix + "HeaderName", this.HeaderName);
            this.SetParamSimple(map, prefix + "HeaderValue", this.HeaderValue);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
        }
    }
}

