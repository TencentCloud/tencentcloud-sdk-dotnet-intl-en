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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleCondition : AbstractModel
    {
        
        /// <summary>
        /// Operator. Valid values:
        /// <li>equal: Equal to.</li>
        /// <li>notequal: Not equal to.</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Match type. Valid values:
        /// <li>`host`: All</li>
        /// <li>`filename`: File name</li>
        /// <li>`extension`: File extension</li>
        /// <li>`host`: HOST: .</li>
        /// <li>`full_url`: The full URL of the current site. It must contain the HTTP protocol, host, and path.</li>
        /// <li>`url`: The URL path of the current site.</li>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// Parameter values of the match type. Each match type has the following valid values:
        /// <li>`Target=extension`:  The extension of the file, such as `jpg` and `txt`.</li>
        /// <li>`Target=filename`: The file name without the extension.</li>
        /// <li>`Target=host`: Values can be `all` 
        /// or a host, such as `www.maxx55.com`.</li>
        /// <li>`Target=url`: A URL request path under the current site, such as `/example`.</li>
        /// <li>`Target=full_url`: A complete URL request under the current site. It must contain the protocol, host, and path, such as `https://www.maxx55.cn/example`.</li>
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

