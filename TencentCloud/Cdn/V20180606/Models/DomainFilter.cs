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
        /// Filter filter. Values:
        /// - `origin`: Primary origin server.
        /// - `domain`: Domain name.
        /// - `resourceId`: Domain name ID.
        /// - `status`: Domain name status. Values: `online`, `offline`, and `processing`.
        /// - `serviceType`: Service type. Values: `web`, `download`, `media`, `hybrid` and `dynamic`.
        /// - `projectId`: Project ID.
        /// - `domainType`: Primary origin type. Values: `cname` (customer origin), `COS` (COS origin), `third_party` (third-party object storage origin), and `igtm` (IGTM origin).
        /// - `fullUrlCache`: Whether to enable path cache. Values: `on`, `off`.
        /// - `https`: Whether to configure HTTPS. Values: `on`, `off` and `processing`.
        /// - `originPullProtocol`: Origin-pull protocol type. Value: `http`, `follow`, and `https`.
        /// - `tagKey`: Tag key.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Filter field value.
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

