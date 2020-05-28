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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainFilter : AbstractModel
    {
        
        /// <summary>
        /// Filter field name, which can be:
        /// - origin: primary origin server.
        /// - domain: domain name.
        /// - resourceId: domain name ID.
        /// - status: domain name status. Valid values: online, offline, processing.
        /// - disable: domain name blockage status. Valid values: normal, unlicensed.
        /// - projectId: project ID.
        /// - fullUrlCache: full path cache. Valid values: on, off.
        /// - https: whether to configure HTTPS. Valid values: on, off, processing.
        /// - originPullProtocol: origin-pull protocol type. Valid values: http, follow, https.
        /// - area: acceleration region. Valid values: mainland, overseas, global.
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
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
            this.SetParamSimple(map, prefix + "Fuzzy", this.Fuzzy);
        }
    }
}

