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

    public class UserAgentFilterRule : AbstractModel
    {
        
        /// <summary>
        /// Effective access path type
        /// all: all access paths are effective
        /// file: effective by file extension
        /// directory: effective by directory
        /// path: effective by full access path
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Effective access paths
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// `UserAgent` list
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserAgents")]
        public string[] UserAgents{ get; set; }

        /// <summary>
        /// Blacklist or whitelist. Valid values: blacklist, whitelist
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamArraySimple(map, prefix + "UserAgents.", this.UserAgents);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
        }
    }
}

