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

    public class DomainFilter : AbstractModel
    {
        
        /// <summary>
        /// Filters field name, which includes:
        /// - `origin`: primary origin server.
        /// - `domain`: domain name.
        /// - `resourceId`: domain name ID.
        /// - `status`: domain name status. Valid values: `online`, `offline`, and `processing`.
        /// - `serviceType`: service type. Valid values: `web`, `download`, and `media`.
        /// - projectId: project ID.
        /// - `domainType`: primary origin server type. Valid values: `cname` (external origin), `COS` (COS origin), and `third_party` (3rd-party object storage origin).
        /// - `fullUrlCache`: whether to enable full-path cache, which can be `on` or `off`.
        /// - `https`: whether to configure HTTPS, which can be `on`, `off` or `processing`.
        /// - `originPullProtocol`: origin-pull protocol type, which can be `http`, `follow`, or `https`.
        /// - `tagKey`: tag key.
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

