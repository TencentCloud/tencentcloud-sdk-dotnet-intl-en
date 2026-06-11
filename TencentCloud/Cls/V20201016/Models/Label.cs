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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Label : AbstractModel
    {
        
        /// <summary>
        /// The key of the tag. A valid tag key has two parts: an optional prefix and a name, separated by a slash (/). The name part is necessary and must be no more than 63 characters, starting and ending with alphanumeric characters ([a-z0-9A-Z]), with hyphens (-), underscores (_), dots (.), and alphanumerics in the middle. The prefix is optional. If specified, the prefix must be a DNS subdomain: a series of DNS labels separated by dots (.), with a total length not exceeding 253 characters, followed by a slash (/).
        /// 
        /// -Format of prefix `[a-z0-9]([-a-z0-9]*[a-z0-9])?(\.[a-z0-9]([-a-z0-9]*[a-z0-9])?)*`
        /// -Format of `name`: `([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]`
        /// -key must be unique
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// The comparison operator between tag key values. Different business scenarios support different comparison operators. See the API business description for supported ones.
        /// such as `in`, `notin`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// Tag value.
        /// -Supports up to 63 characters.
        /// -Format: `([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

