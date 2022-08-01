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

    public class RefererRule : AbstractModel
    {
        
        /// <summary>
        /// Rule types:
        /// `all`: Apply to all files.
        /// `file`: Apply to files with the specified suffixes.
        /// `directory`: Apply to specified paths.
        /// `path`: Apply to specified absolute paths.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Content for each `RuleType`:
        /// For `all`, enter a wildcard `*`.
        /// For `file`, enter a suffix, e.g., `jpg` or `txt`.
        /// For `directory`, enter a path, e.g., `/xxx/test/`.
        /// For `path`, enter an absolute path, e.g., `/xxx/test.html`.
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// Referer configuration types
        /// `whitelist`: Allowlist
        /// `blacklist`: Blocklist
        /// </summary>
        [JsonProperty("RefererType")]
        public string RefererType{ get; set; }

        /// <summary>
        /// Referer content list
        /// </summary>
        [JsonProperty("Referers")]
        public string[] Referers{ get; set; }

        /// <summary>
        /// Whether to allow empty referer
        /// `true`: Allow empty referer when `RefererType = whitelist`.
        /// `false`: Reject empty refer when `RefererType = blacklist`.
        /// </summary>
        [JsonProperty("AllowEmpty")]
        public bool? AllowEmpty{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamSimple(map, prefix + "RefererType", this.RefererType);
            this.SetParamArraySimple(map, prefix + "Referers.", this.Referers);
            this.SetParamSimple(map, prefix + "AllowEmpty", this.AllowEmpty);
        }
    }
}

