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

    public class HttpHeaderPathRule : AbstractModel
    {
        
        /// <summary>
        /// http header setting method:
        /// <li>set: Set. Update the value of the specified header parameter to the configured value; if the specified header does not exist, it will be added; if multiple duplicate header parameters exist, all will be updated and merged into one header;</li>
        /// <li>del: delete. Delete specified HTTP header parameters;</li>
        /// <li>add: Add. Add the designated header parameter. Duplicate addition is allowed by default, meaning the same header can be repeatedly added (Note: Repeated addition may affect browser response. Please prioritize the set operation).</li>
        /// </summary>
        [JsonProperty("HeaderMode")]
        public string HeaderMode{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HeaderName")]
        public string HeaderName{ get; set; }

        /// <summary>
        /// http header value, up to 1000 characters;
        /// Optional when `Mode` is `del`.
        /// Required if Mode is add/set.
        /// </summary>
        [JsonProperty("HeaderValue")]
        public string HeaderValue{ get; set; }

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
            this.SetParamSimple(map, prefix + "HeaderMode", this.HeaderMode);
            this.SetParamSimple(map, prefix + "HeaderName", this.HeaderName);
            this.SetParamSimple(map, prefix + "HeaderValue", this.HeaderValue);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
        }
    }
}

