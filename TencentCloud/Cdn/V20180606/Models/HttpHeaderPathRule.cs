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

    public class HttpHeaderPathRule : AbstractModel
    {
        
        /// <summary>
        /// HTTP header setting method
        /// add: add header. If a header exists, then there will be a duplicated header.
        /// set: only supports origin-pull header configuration. If a header exists, it will be overwritten. If one does not exist, then the header will be added.
        /// del: delete header
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HeaderMode")]
        public string HeaderMode{ get; set; }

        /// <summary>
        /// HTTP header name. Up to 100 characters can be set.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HeaderName")]
        public string HeaderName{ get; set; }

        /// <summary>
        /// HTTP header value. Up to 1000 characters can be set.
        /// Not required when Mode is del
        /// Required when Mode is add/set
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HeaderValue")]
        public string HeaderValue{ get; set; }

        /// <summary>
        /// Rule types:
        /// `all`: effective for all files
        /// `file`: effective for specified file suffixes
        /// `directory`: effective for specified paths
        /// `path`: effective for specified absolute paths
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Content for each RuleType:
        /// For `all`, enter an asterisk (*).
        /// For `file`, enter the suffix, such as jpg, txt.
        /// For `directory`, enter the path, such as /xxx/test/.
        /// For `path`, enter the corresponding absolute path, such as /xxx/test.html.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HeaderMode", this.HeaderMode);
            this.SetParamSimple(map, prefix + "HeaderName", this.HeaderName);
            this.SetParamSimple(map, prefix + "HeaderValue", this.HeaderValue);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
        }
    }
}

