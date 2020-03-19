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

    public class CappingRule : AbstractModel
    {
        
        /// <summary>
        /// Rule types:
        /// `all`: effective for all files
        /// `file`: effective for specified file suffixes
        /// `directory`: effective for specified paths
        /// `path`: effective for specified absolute paths
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Content for each RuleType: 
        /// For `all`, enter an asterisk (*).
        /// For `file`, enter the suffix, such as jpg, txt.
        /// For `directory`, enter the path, such as /xxx/test/.
        /// For `path`, enter the corresponding absolute path, such as /xxx/test.html.
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// Downstream speed value settings (in KB/s)
        /// </summary>
        [JsonProperty("KBpsThreshold")]
        public long? KBpsThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamSimple(map, prefix + "KBpsThreshold", this.KBpsThreshold);
        }
    }
}

