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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserAgentFilterRule : AbstractModel
    {
        
        /// <summary>
        /// UA allowlist/blocklist type: <li>whitelist: allowlist;</li> <li>blacklist: blocklist.</li>	
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("UserAgents")]
        public string[] UserAgents{ get; set; }

        /// <summary>
        /// Rule type:
        /// <li>all: take effect for all files;</li>
        /// <li>file: The specified file suffix takes effect;</li>
        /// <li>directory: specify the path to take effect;</li>
        /// <li>path: The absolute path takes effect.</li>
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Matching content under the corresponding type of RuleType:
        /// <li>Fill with * when set to all;</li>
        /// <li>For file, fill in the extension, such as jpg or txt;</li>
        /// <li>For directory, fill in the path, such as /xxx/test/;</li>
        /// <li>For path, fill in the absolute path, such as /xxx/test.html.</li>
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamArraySimple(map, prefix + "UserAgents.", this.UserAgents);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
        }
    }
}

