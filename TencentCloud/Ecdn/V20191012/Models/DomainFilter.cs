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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainFilter : AbstractModel
    {
        
        /// <summary>
        /// Filters by the field name, which includes:
        /// - `origin`: Primary origin server.
        /// - `domain`: Domain name.
        /// - `resourceId`: Domain name ID.
        /// - `status`: Domain name status. Valid values: `online`, `offline`, and `processing`.
        /// - `disable`: Whether the domain name is blocked. Valid values: `normal`, `unlicensed`.
        /// - `projectId`: Project ID.
        /// - `fullUrlCache`: Whether to enable full-path cache, which can be `on` or `off`.
        /// - `https`: Whether to configure HTTPS, which can be `on`, `off` or `processing`.
        /// - `originPullProtocol`: Origin-pull protocol type, which can be `http`, `follow`, or `https`.
        /// - `area`: Acceleration region, which can be `mainland`，`overseas` or `global`.
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
        /// Whether to enable fuzzy query, which is supported only for filter fields `origin` and `domain`.
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

