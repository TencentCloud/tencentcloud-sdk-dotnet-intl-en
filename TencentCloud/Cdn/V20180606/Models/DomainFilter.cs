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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainFilter : AbstractModel
    {
        
        /// <summary>
        /// Filter field name. supported list as follows:.
        /// -`Origin`: specifies the primary origin server.
        /// -Domain name. specifies the domain name.
        /// -resourceId: domain id.
        /// -Status: specifies the domain name status. valid values: online, offline, processing, deleted.
        /// -serviceType: specifies the business type. valid values: web, download, media, hybrid, dynamic.
        /// -projectId: specifies the project ID.
        /// -domainType: specifies the primary origin server type. valid values: cname (self-owned origin), cos (cloud object storage integration), third_party (third-party object storage), igtm (igtm multi-active origin).
        /// -fullUrlCache. specifies full path cache. valid values: on, off.
        /// -Specifies whether to configure https. valid values: on, off, processing.
        /// -originPullProtocol: specifies the origin-pull protocol. valid values: http, follow, https.
        /// -tagKey: specifies the Tag key.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Specifies the filter field value. the default maximum is 5. when Name is origin/domain and Fuzzy is true, the maximum is 1.
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }

        /// <summary>
        /// Whether to enable fuzzy query. Only `origin` or `domain` is supported for the filter field name.
        /// When fuzzy query is enabled, the maximum Value length is 1. When fuzzy query is disabled, the maximum Value length is 5.
        /// </summary>
        [JsonProperty("Fuzzy")]
        public bool? Fuzzy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
            this.SetParamSimple(map, prefix + "Fuzzy", this.Fuzzy);
        }
    }
}

